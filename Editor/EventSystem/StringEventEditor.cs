using UnityEditor;
using HBM.Scriptable;

namespace HBM.HBMEditor.Scriptable
{
    [CustomEditor(typeof(StringEvent))]
    public class StringEventEditor : EventEditorBase<string>
    {
        protected override string _initialPayload => "";
    }
}
