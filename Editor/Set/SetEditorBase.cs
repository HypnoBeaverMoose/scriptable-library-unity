using HBM.Scriptable;
using UnityEditor;

namespace HBM.HBMEditor.Scriptable
{
    [CustomEditor(typeof(RuntimeSet<>), editorForChildClasses: true)]
    public class RuntimeSetEditor : EditorExtension<RuntimeSetBase>
    {
        public override void OnInspectorGUI(RuntimeSetBase target)
        {
            int count = 0;
            foreach (var item in target.GetValues())
            {
                count++;
                EditorGUILayout.LabelField($"{count} {item.ToString()}");
            }

            EditorGUILayout.LabelField($"{count} Elements.");
        }
    }
}
