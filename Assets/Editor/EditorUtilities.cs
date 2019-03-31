using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEditor;

namespace Assets.Editor
{
    public static class EditorUtilities
    {
        public static class Styles
        {
            public static GUIContent PlusIconContent = EditorGUIUtility.IconContent("Toolbar Plus");
            public static GUIContent MinusIconContent = EditorGUIUtility.IconContent("Toolbar Minus");
            public static GUIStyle Indent = new GUIStyle();

            static Styles()
            {
                Indent.margin.left = (int)EditorGUIUtility.singleLineHeight;
            }
        }
        public static AngularRange DrawAngularRangeField(string lable, AngularRange value)
        {
            var rect = EditorGUILayout.BeginHorizontal(GUILayout.Height(22));
            rect.height = 20;
            EditorGUILayout.Space();
            var values = new float[] { value.low, value.high };
            EditorGUI.MultiFloatField(rect,new GUIContent(lable), new GUIContent[] { new GUIContent(" "), new GUIContent("~") }, values);
            EditorGUILayout.EndHorizontal();

            return new AngularRange(values[0], values[1]);
        }

        public static bool DrawFoldList(string lable, bool show, Func<bool> itemRenderingCallback)
        {
            show = EditorGUILayout.Foldout(show, lable);
            if (show)
            {
                GUIStyle style = new GUIStyle();
                style.margin.left = 40;
                EditorGUILayout.BeginVertical(style);
                while (itemRenderingCallback()) ;
                EditorGUILayout.EndVertical();
            }
            return show;
        }

        public static bool DrawFoldList(string lable, bool show,int count, Action<int> itemRenderingCallback)
        {
            //EditorGUILayout.BeginHorizontal();
            show = EditorGUILayout.Foldout(show, lable);
                
            if (show)
            {
                GUIStyle style = new GUIStyle();
                style.margin.left = 24;
                EditorGUILayout.BeginVertical(style);
                for (var i = 0; i < count; i++)
                {
                    itemRenderingCallback(i);
                }
                EditorGUILayout.EndVertical();
            }
            return show;
        }

        public static List<T> DrawList<T>(List<T> list, Action headerRenderer, Func<T, T> renderCallback)
        {
            Verticle(() =>
            {
                Horizontal(() =>
                {
                    headerRenderer?.Invoke();
                    if (GUILayout.Button(Styles.PlusIconContent, GUIStyle.none, GUILayout.Width(EditorGUIUtility.singleLineHeight)))
                    {
                        list.Add(default(T));
                    }
                });
                EditorGUILayout.Space();
                Verticle(Styles.Indent, () =>
                {
                    for (var i = 0; i < list.Count; i++)
                    {
                        Horizontal(() =>
                        {
                            if (GUILayout.Button(Styles.MinusIconContent, GUIStyle.none, GUILayout.Width(EditorGUIUtility.singleLineHeight)))
                            {
                                list.RemoveAt(i--);
                                if (i >= list.Count)
                                    return;
                                return;
                            }

                            Verticle(() =>
                            {
                                if (renderCallback != null)
                                    list[i] = renderCallback(list[i]);
                            });
                        });
                    }
                });
            });
            return list;
        }
        

        public static List<T> DrawList<T>(string lable, List<T> list, Func<T,T> renderCallback)
        {
            return DrawList(list, () => EditorGUILayout.Foldout(true, lable), renderCallback);
        }

        public static T[] DrawArray<T>(T[] array, Action headerRenderer, Func<T, T> renderCallback)
        {
            return DrawList(array.ToList(), headerRenderer, renderCallback).ToArray();
        }

        public static T[] DrawArray<T>(string lable, T[] array, Func<T,T> renderCallback)
        {
            return DrawList(
                array.ToList(),
                () => EditorGUILayout.Foldout(true, lable),
                renderCallback
            ).ToArray();
        }



        public static bool DrawFoldList(string lable, bool show, int count, Action<int> itemRenderingCallback,Action addCallback, Action removeCallback=null)
        {
            EditorGUILayout.BeginHorizontal();
            show = EditorGUILayout.Foldout(show, lable);
            var plusIconContext = EditorGUIUtility.IconContent("Toolbar Plus");
            if (GUILayout.Button(plusIconContext, GUIStyle.none, GUILayout.Width(EditorGUIUtility.singleLineHeight)))
                addCallback();
            EditorGUILayout.EndHorizontal();

            if (show)
            {
                GUIStyle style = new GUIStyle();
                style.margin.left = 24;
                EditorGUILayout.BeginVertical(style);
                for (var i = 0; i < count; i++)
                {
                    EditorGUILayout.BeginHorizontal();
                    var minusIconContext = EditorGUIUtility.IconContent("Toolbar Minus");
                    if (GUILayout.Button(minusIconContext, GUIStyle.none, GUILayout.Width(EditorGUIUtility.singleLineHeight)))
                        removeCallback?.Invoke();
                    EditorGUILayout.BeginVertical();
                    itemRenderingCallback(i);
                    EditorGUILayout.EndVertical();
                    EditorGUILayout.EndHorizontal();
                }
                EditorGUILayout.EndVertical();
            }
            return show;
        }

        public static Color HTMLColor(string color)
        {
            Color c;
            ColorUtility.TryParseHtmlString(color, out c);
            return c;
        }
        
        public static T ObjectField<T>(string label,T obj) where T:UnityEngine.Object
        {
            return EditorGUILayout.ObjectField(label, obj, typeof(T), true) as T;
        }
        public static T ObjectField<T>(T obj) where T : UnityEngine.Object
        {
            return EditorGUILayout.ObjectField(obj, typeof(T), true) as T;
        }

        public static void EditSerializableDictionary<TKey, TValue>(string lable, SerializableDictionary<TKey, TValue> dict)
        {
            EditSerializableDictionary(
                lable,
                dict,
                (key) => (TKey)(object)EditorGUILayout.TextField((string)(object)key),
                (value) => (TValue)(object)EditorGUILayout.ObjectField((UnityEngine.Object)(object)value, typeof(TValue), true)
                );
        }

        public static void EditSerializableDictionary<TKey, TValue>(string lable, SerializableDictionary<TKey, TValue> dict,Func<TKey,TKey> keyEditCallback,Func<TValue,TValue> valueEditCallback)
        {
            var style = new GUIStyle();
            style.margin.left = 60;
            //EditorGUILayout.BeginVertical(style);
            var removeIdx = -1;
            DrawFoldList(lable, true, dict.Count, (i) =>
            {
                EditorGUILayout.BeginHorizontal();
                dict.Keys[i] = keyEditCallback(dict.Keys[i]);
                dict.Values[i] = valueEditCallback(dict.Values[i]);
                if (GUILayout.Button("-"))
                    removeIdx = i;
                EditorGUILayout.EndHorizontal();
            });
            if (removeIdx >= 0)
            {
                dict.Keys.RemoveAt(removeIdx);
                dict.Values.RemoveAt(removeIdx);
            }
            EditorGUILayout.Space();
            EditorGUILayout.BeginHorizontal();
            var valueDrag = valueEditCallback((TValue)(object)null);
            if (valueDrag != null)
                dict.Add(default(TKey), valueDrag);
            if (GUILayout.Button("Add"))
            {
                dict.Add(default(TKey), default(TValue));
            }
            EditorGUILayout.EndHorizontal();
        }
        /*
        public static void EditAssetObject<TAssetsLib,TAsset>(TAssetsLib assetsLib,TAssetsLib)
        {
            
        }*/
        public static void EditWeightedList(string label, bool show,WeightedList list)
        {
            DrawFoldList(label, show, list.Count, (i) =>
               {
                   EditorGUILayout.BeginHorizontal();
                   list[i].Object = EditorGUILayout.ObjectField(list[i].Object, typeof(UnityEngine.Object), true);
                   list[i].Weight = EditorGUILayout.FloatField(list[i].Weight);
                   if (GUILayout.Button("-"))
                       list.RemoveAt(i);
                   EditorGUILayout.EndHorizontal();
               }, () =>
               {
                   list.Add(new WeightedItem(null, 1));
               });
        }

        public static void Verticle(GUIStyle style, Action renderContent)
        {
            if (style == null)
                EditorGUILayout.BeginVertical();
            else
                EditorGUILayout.BeginVertical(style);
            renderContent?.Invoke();
            EditorGUILayout.EndVertical();
        }

        public static void Verticle(Action renderContent)
        {
            Verticle(null, renderContent);
        }

        public static void Horizontal(GUIStyle style,Action renderContent)
        {
            if (style == null)
                EditorGUILayout.BeginHorizontal();
            else
                EditorGUILayout.BeginHorizontal(style);
            renderContent?.Invoke();
            EditorGUILayout.EndHorizontal();
        }

        public static void Horizontal(Action renderContent)
        {
            Horizontal(null, renderContent);
        }
    }
}
