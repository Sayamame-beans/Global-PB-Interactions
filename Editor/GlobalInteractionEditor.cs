using UnityEditor;
using Sayabeans.GlobalPBInteraction;
using UnityEngine;

namespace Sayabeans.GlobalPBInteraction
{
    [CustomEditor(typeof(GlobalInteraction))]
    internal class GlobalInteractionEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            SerializedProperty diversionPoint = serializedObject.FindProperty(nameof(GlobalInteraction.diversionPoint));
            SerializedProperty rootTransform = serializedObject.FindProperty(nameof(GlobalInteraction.rootTransform));
            SerializedProperty radius = serializedObject.FindProperty(nameof(GlobalInteraction.radius));
            SerializedProperty height = serializedObject.FindProperty(nameof(GlobalInteraction.height));

            EditorGUILayout.PropertyField(diversionPoint, new GUIContent("Diversion Point"));
            EditorGUILayout.PropertyField(rootTransform, new GUIContent("Root Transform"));
            EditorGUILayout.PropertyField(radius, new GUIContent("Radius"));
            EditorGUILayout.PropertyField(height, new GUIContent("Height"));

            EditorGUILayout.HelpBox("Message Here", MessageType.Info);

            serializedObject.ApplyModifiedProperties();
        }
    }
}
