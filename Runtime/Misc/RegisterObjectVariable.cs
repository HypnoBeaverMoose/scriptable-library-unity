using UnityEngine;

namespace HBM.Scriptable
{
    public class RegisterObjectVariable : MonoBehaviour
    {
        [SerializeField] private Object _toRegister;
        [SerializeField] private ObjectVariable _variable;
        [SerializeField] private bool _override;
        [SerializeField] private bool _registerOnAwake;

        private void Awake()
        {
            if (_registerOnAwake)
            {
                Register();
            }
        }

        public void Register()
        {
            if (!_override && _variable.value != null)
            {
                Debug.LogError("Attempting to override an existing variable");
                return;
            }
            _variable.value = _toRegister;
        }
    }
}