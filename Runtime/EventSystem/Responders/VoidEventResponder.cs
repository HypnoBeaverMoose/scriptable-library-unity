using UnityEngine;
using UnityEngine.Events;

namespace HBM.Scriptable
{
    public class VoidEventResponder : MonoBehaviour
    {
        [SerializeField] private VoidEvent _event;

        [SerializeField] private UnityEvent _response;

        private void OnEnable()
        {
            _event.AddListener(OnEventRaised);
        }

        private void OnDisable()
        {
            _event.RemoveListener(OnEventRaised);
        }

        public void OnEventRaised()
        {
            _response.Invoke();
        }
    }
}