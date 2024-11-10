using UnityEditor;
using UnityEngine;
using HBM.Scriptable;

namespace HBM.HBMEditor.Scriptable
{
    [CustomEditor(typeof(VoidEvent))]
    public class VoidEventEditor : EditorExtension<VoidEvent>
    {
        public override void OnInspectorGUI(VoidEvent target)
        {
            if (GUILayout.Button("Invoke"))
            {
                target.Invoke();
            }
        }
    }
}
