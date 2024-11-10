using UnityEditor;

namespace HBM.HBMEditor
{
    public class EditorLayout : System.IDisposable
    {
        public enum Type { Vertical, Horizontal }
        private readonly Type _layoutType;

        public EditorLayout(Type type)
        {
            _layoutType = type;

            switch (_layoutType)
            {
                case Type.Horizontal:
                    EditorGUILayout.BeginHorizontal();
                    break;
                case Type.Vertical:
                    EditorGUILayout.BeginVertical();
                    break;
            }

        }

        public void Dispose()
        {
            switch (_layoutType)
            {
                case Type.Horizontal:
                    EditorGUILayout.EndHorizontal();
                    break;
                case Type.Vertical:
                    EditorGUILayout.EndVertical();
                    break;
            }
        }
    }
}