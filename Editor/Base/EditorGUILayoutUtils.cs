using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace HBM.HBMEditor
{
    public static class EditorGUILayoutUtils
    {
        public static T ObjectField<T>(string label, T obj, params GUILayoutOption[] options) where T : Object
        {
            return ObjectField<T>(label, obj, true, options);
        }

        public static T ObjectField<T>(string label, T obj, bool allowSceneObjects, params GUILayoutOption[] options) where T : Object
        {
            return (T)EditorGUILayout.ObjectField(label, obj, typeof(T), allowSceneObjects, options);
        }

        public static T GenericField<T>(string label, T value)
        {
            return value switch
            {
                int i => (T)(object)EditorGUILayout.IntField(label, i),
                float f => (T)(object)EditorGUILayout.FloatField(label, f),
                bool b => (T)(object)EditorGUILayout.Toggle(label, b),
                string s => (T)(object)EditorGUILayout.TextField(label, s),
                Vector3 v => (T)(object)EditorGUILayout.Vector3Field(label, v),
                Vector2 v => (T)(object)EditorGUILayout.Vector2Field(label, v),
                System.Enum en => (T)(object)EditorGUILayout.EnumPopup(label, en),
                _ => throw new System.NotImplementedException($"Type {typeof(T)} not supported!"),
            };
        }

        public static IEnumerable<T> Separate<T>(IEnumerable<T> elements)
        {
            var enumerator = elements.GetEnumerator();
            if (enumerator.MoveNext())
            {
                yield return enumerator.Current;
            }
            while (enumerator.MoveNext())
            {
                EditorGUILayout.Separator();
                yield return enumerator.Current;
            }
        }
    }

}