using UnityEngine;
using HBM.Scriptable;

namespace HBM.HBMEditor.Scriptable
{
    public abstract class EventEditorBase<T> : EditorExtension<TypedEvent<T>>
    {
        private T _payload;

        protected virtual T _initialPayload => default;

        private void OnEnable()
        {
            _payload = _initialPayload;
        }

        public override void OnInspectorGUI(TypedEvent<T> target)
        {
            _payload = PayloadField("Payload", _payload);

            if (GUILayout.Button("Invoke"))
            {
                target.Invoke(_payload);
            }
        }

        protected virtual T PayloadField(string label, T payload)
        {
            return EditorGUILayoutUtils.GenericField(label, payload);
        }
    }
}
