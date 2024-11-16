using HBM.Scriptable;
using UnityEditor;

namespace HBM.HBMEditor.Scriptable
{
    [CustomEditor(typeof(RuntimeSet<>), editorForChildClasses: true)]
    public class SetEditorBase : EditorExtension<RuntimeSetBase>
    {
        public override void OnInspectorGUI(RuntimeSetBase target)
        {
            foreach (var item in target.GetValues())
            {
                EditorGUILayout.LabelField(item.ToString());
            }
        }
    }
}
