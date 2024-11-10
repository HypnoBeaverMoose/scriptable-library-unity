using UnityEngine;

namespace HBM.Scriptable
{
    public class BoolEventResponder : TypedEventResponder<bool, BoolEvent>
    {
        [SerializeField] private bool _invert;

        public override void OnEventRaised(bool payload)
        {
            base.OnEventRaised(_invert ? !payload : payload);
        }
    }
}