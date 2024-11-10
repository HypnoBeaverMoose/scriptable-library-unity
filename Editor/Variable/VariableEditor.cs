using UnityEditor;
using UnityEngine;
using HBM.Scriptable;

namespace HBM.HBMEditor
{
    [CustomEditor(typeof(Variable<>), editorForChildClasses: true)]
    public class VariableEditor : EditorExtension<ScriptableObject>
    {
        public override void OnInspectorGUI(ScriptableObject target)
        {
            EditorGUILayout.LabelField("Real Value: " + target.ToString());

        }
    }
}