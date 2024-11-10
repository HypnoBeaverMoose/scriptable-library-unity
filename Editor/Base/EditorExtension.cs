using UnityEditor;
using UnityEngine;

namespace HBM.HBMEditor
{
    public abstract class EditorExtension<T> : Editor where T : Object
    {
        public sealed override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            EditorGUILayout.Separator();

            using (new EditorLayout(EditorLayout.Type.Vertical))
            {
                OnInspectorGUI((T)target);
            }
        }

        public abstract void OnInspectorGUI(T target);
    }
}