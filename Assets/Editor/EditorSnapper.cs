using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;

namespace Assets.Editor
{
    [CustomEditor(typeof(GridSnapper))]
    [CanEditMultipleObjects]
    public class EditorSnapper : UnityEditor.Editor
    {
        bool moving = false;
        private void OnSceneGUI()
        {
            var snapper = target as GridSnapper;
            if (Application.isPlaying)
                return;
            if (Tools.current == Tool.Move)
                moving = true;
            else if(Tools.current != Tool.None)
                moving = false;
            if (moving)
            {
                Tools.current = Tool.None;
                if(snapper.transform is RectTransform )
                {
                    var n = GridSystem.Instance.ScreenPixelPerUnit;
                    var center = (snapper.transform as RectTransform).rect.size / 2;
                    snapper.OriginOffset = center - new Vector2(Mathf.FloorToInt(center.x / n) * n, Mathf.FloorToInt(center.y / n) * n);
                    var pos = Handles.PositionHandle(snapper.transform.position + snapper.OriginOffset /*+ new Vector3(0.5f, 0.5f, 0)*/, Quaternion.identity) /*- new Vector3(0.5f, 0.5f, 0)*/;
                    pos = new Vector3(Mathf.Floor(pos.x / n) * n, Mathf.Floor(pos.y / n) * n, pos.z);
                    pos -= snapper.OriginOffset;
                    pos.x = Mathf.CeilToInt(pos.x);
                    pos.y = Mathf.CeilToInt(pos.y);
                    snapper.transform.position = pos;
                }
                else
                {
                    var n = GridSystem.Instance.GridPerPixel;
                    var pos = Handles.PositionHandle(snapper.transform.position + snapper.OriginOffset * n, Quaternion.identity);
                    switch (snapper.SnapMode)
                    {
                        case SnapMode.SnapToGrid:
                            pos = new Vector3(Mathf.Floor(pos.x), Mathf.Floor(pos.y), pos.z);
                            break;
                        case SnapMode.SnapToPixel:
                            pos = new Vector3(Mathf.Floor(pos.x / n) * n, Mathf.Floor(pos.y / n) * n, pos.z);
                            break;
                    }
                    pos -= snapper.OriginOffset * n;
                    snapper.transform.position = pos;
                }
            }
        }
    }
}
