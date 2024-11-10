using UnityEditor;
using UnityEngine;

namespace HBM.Scriptable.Editor
{
    [CustomPropertyDrawer(typeof(VariableReference<>))]
    public class VariableReferenceDrawer : PropertyDrawer
    {
        private const int toggleWidth = 100;

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var useConstant = property.FindPropertyRelative("_useConstant");
            var constant = property.FindPropertyRelative("_constant");
            var variable = property.FindPropertyRelative("_variable");
            var rect = EditorGUI.PrefixLabel(position, label);

            var toggleRect = rect;
            toggleRect.width = toggleWidth;
            useConstant.boolValue = EditorGUI.ToggleLeft(toggleRect, "Use Constant", useConstant.boolValue);

            rect.x += toggleWidth;
            rect.width -= toggleWidth;
            if (useConstant.boolValue)
            {
                EditorGUI.PropertyField(rect, constant, new GUIContent());
            }
            else
            {
                EditorGUI.PropertyField(rect, variable, new GUIContent());
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUIUtility.singleLineHeight;
        }
    }
}