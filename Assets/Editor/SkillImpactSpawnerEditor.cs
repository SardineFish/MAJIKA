using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;

namespace Assets.Editor
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(SkillImpactSpawner))]
    class SkillImpactSpawnerEditor : UnityEditor.Editor
    {
        bool editOffset = false;
        bool editSpawnDir = false;
        public override void OnInspectorGUI()
        {
            var spawner = target as SkillImpactSpawner;
            base.OnInspectorGUI();

            if(spawner.SpawnType == ImpactSpawnType.Barrage)
            {
                if (spawner.SpawnDirections.Length != spawner.SpawnAmount)
                {
                    Array.Resize(ref spawner.SpawnDirections, spawner.SpawnAmount);
                }
                if (spawner.SpawnAmount <= 0)
                    return;
                spawner.SpawnDirections[0] = MathUtility.Rotate(spawner.SpawnSectorDirection, -spawner.SpawnAngle / 2 * Mathf.Deg2Rad);
                if (spawner.SpawnAmount == 1)
                    spawner.SpawnDirections[0] = spawner.SpawnSectorDirection;
                var delta = spawner.SpawnAngle / (spawner.SpawnAmount - 1);
                for (var i = 1; i < spawner.SpawnAmount; i++)
                {
                    spawner.SpawnDirections[i] = MathUtility.Rotate(spawner.SpawnDirections[i - 1], delta * Mathf.Deg2Rad);
                }
                editSpawnDir = GUILayout.Toggle(editSpawnDir, "Edit Spawn Direction", "Button");
            }

            EditorUtilities.DrawList("Additional Effects", spawner.AdditionalEffect, (effect) =>
            {
                EditorGUILayout.BeginHorizontal(GUILayout.Height(EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing));
                effect.Effect = EditorGUILayout.ObjectField(effect.Effect, typeof(Effect), true) as Effect;
                EditorGUILayout.LabelField("x", GUILayout.Width(EditorGUIUtility.singleLineHeight));
                effect.Strength = EditorGUILayout.FloatField(effect.Strength);
                EditorGUILayout.EndHorizontal();
                return effect;
            });
            Undo.RecordObject(target, "Edit Impact Spawner");
            EditorGUILayout.Space();
            editOffset = GUILayout.Toggle(editOffset, "Edit Offset", "Button");
        }
        

        private void OnSceneGUI()
        {
            var spawner = target as SkillImpactSpawner;
            if (editOffset)
            {
                Tools.current = Tool.None;

                var pos = Handles.PositionHandle(spawner.transform.position + spawner.SpawnOffset.ToVector3(), Quaternion.identity);
                var n = GridSystem.Instance.GridPerPixel;
                pos = new Vector3(Mathf.Round(pos.x / n) * n, Mathf.Round(pos.y / n) * n, pos.z);
                spawner.SpawnOffset = pos - spawner.transform.position;
            }

            if(editSpawnDir)
            {
                Tools.current = Tool.None;
                var spawnPos = spawner.transform.position + spawner.SpawnOffset.ToVector3();
                var rotation = Handles.RotationHandle(Quaternion.FromToRotation(Vector2.right, spawner.SpawnSectorDirection), spawnPos);
                spawner.SpawnSectorDirection = rotation * Vector2.right;
                EditorUtility.SetDirty(spawner);
            }
            
            if(spawner.SpawnType == ImpactSpawnType.Barrage)
            {
                var color = Color.yellow;
                color.a = .2f;
                var sectorFrom = MathUtility.Rotate(spawner.SpawnSectorDirection, -spawner.SpawnAngle / 2 * Mathf.Deg2Rad);
                var spawnPos = spawner.transform.position + spawner.SpawnOffset.ToVector3();
                Handles.color = color;
                Handles.DrawSolidArc(spawnPos, Vector3.forward, sectorFrom, spawner.SpawnAngle, 1);
                Handles.color = Color.red;
                foreach (var dir in spawner.SpawnDirections)
                {
                    Handles.DrawLine(spawnPos, spawnPos + dir.ToVector3() * 2);
                }
            }
        }
    }
}
