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

        public static ListDrawer<T> DrawList<T>(List<T> list)
            => new ListDrawer<T>(list);

        public static T[] DrawArray<T>(T[] array, Action headerRenderer, Func<T, T> renderCallback)
        {
            return DrawList(array.ToList())
                .Header(headerRenderer)
                .Item(renderCallback)
                .Render()
                .ToArray();
        }

        public static T[] DrawArray<T>(string lable, T[] array, Func<T,T> renderCallback)
        {
            return DrawList(array.ToList())
                .Header(lable)
                .Item(renderCallback)
                .Render()
                .ToArray();
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
            DrawList(dict.Keys)
                .Header(lable)
                .Fold(true)
                .Item((key, i) =>
                {
                    EditorGUILayout.BeginHorizontal();
                    dict.Keys[i] = keyEditCallback(dict.Keys[i]);
                    dict.Values[i] = valueEditCallback(dict.Values[i]);
                    return key;
                })
                .OnRemove((key, i) =>
                {
                    // dict.keys[i] will be remove internally.
                    dict.Values.RemoveAt(i);
                    return true;
                })
                .OnAdd(() =>
                {
                    dict.Add(default(TKey), default(TValue));
                    return default(TKey);
                })
                .Render();
        }

        public static void EditWeightedList(string label, bool show,WeightedList list)
        {
            DrawList(list.ToList())
                .Header(label)
                .Fold(show)
                .Item((item) =>
                {
                    item.Object = EditorGUILayout.ObjectField(item.Object, typeof(UnityEngine.Object), true);
                    item.Weight = EditorGUILayout.FloatField(item.Weight);
                    return item;
                })
                .Render();
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

        public class ListDrawer<T>
        {
            bool fold = true;
            List<T> list = null;
            Func<T> onCreate = null;
            Func<T, int, bool> onRemove = null;
            Action headerRenderer = null;
            Func<T, int, T> itemRenderer = null;

            public ListDrawer(List<T> list)
            {
                this.list = list;
            }

            public ListDrawer<T> Fold(bool extend)
            {
                this.fold = extend;
                return this;
            }

            public ListDrawer<T> Header(string label)
            {
                this.headerRenderer = () => EditorGUILayout.LabelField(label);
                return this;
            }

            public ListDrawer<T> Header(Action renderer)
            {
                this.headerRenderer = renderer;
                return this;
            }

            public ListDrawer<T> Item(Func<T, int, T> itemRenderer)
            {
                this.itemRenderer = itemRenderer;
                return this;
            }

            public ListDrawer<T> Item(Func<T, T> itemRenderer)
                => this.Item((t, i) => itemRenderer(t));

            public ListDrawer<T> OnAdd(Func<T> callback)
            {
                this.onCreate = callback;
                return this;
            }

            public ListDrawer<T> OnRemove(Func<T, int, bool> callback)
            {
                this.onRemove = callback;
                return this;
            }

            public List<T> Render()
            {
                if (itemRenderer == null)
                    return list;

                onCreate = onCreate ?? AddItem;

                Verticle(() =>
                {
                    Horizontal(() =>
                    {
                        headerRenderer?.Invoke();
                        if (GUILayout.Button(Styles.PlusIconContent, GUIStyle.none, GUILayout.Width(EditorGUIUtility.singleLineHeight)))
                        {
                            list.Add(onCreate());
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
                                    if(onRemove != null && !onRemove(list[i], i))
                                    {
                                        // do nothing;
                                    }
                                    else
                                    {
                                        list.RemoveAt(i--);
                                        if (i >= list.Count)
                                            return;
                                        return;
                                    }
                                }

                                Verticle(() =>
                                {
                                    list[i] = itemRenderer.Invoke(list[i], i);
                                });
                            });
                        }
                    });
                });
                return list;
            }

            T AddItem()
            {
                if(typeof(T).IsClass)
                {
                    try
                    {
                        var instance = Activator.CreateInstance<T>();
                        return instance;
                    }
                    catch
                    {
                        Debug.LogWarning($"Failed to create instance of {typeof(T).Name}");
                    }
                }
                return default(T);
            }

        }

    }
}
