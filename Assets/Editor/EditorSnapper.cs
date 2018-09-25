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
                var pos = Handles.PositionHandle(snapper.transform.position + snapper.OriginOffset + new Vector3(0.5f, 0.5f, 0), Quaternion.identity) - new Vector3(0.5f, 0.5f, 0);
                var n = GridSystem.Instance.GridPerPixel;
                switch (snapper.SnapMode)
                {
                    case SnapMode.SnapToGrid:
                        pos = new Vector3(Mathf.Round(pos.x), Mathf.Round(pos.y), pos.z);
                        break;
                    case SnapMode.SnapToPixel:
                        pos = new Vector3(Mathf.Round(pos.x / n) * n, Mathf.Round(pos.y / n) * n, pos.z);
                        break;
                }
                pos -= snapper.OriginOffset;
                snapper.transform.position = pos;
            }
        }
    }
}
