using UnityEngine;
using UnityEngine.Events;

namespace HBM.Scriptable
{
    public abstract class TypedEventResponder<T, E> : MonoBehaviour where E : TypedEvent<T>
    {
        [SerializeField] private E _event;
        [SerializeField] private UnityEvent<T> _response;

        private void Awake()
        {
            _event.AddListener(OnEventRaised);
        }

        private void OnDestroy()
        {
            _event.RemoveListener(OnEventRaised);
        }

        public virtual void OnEventRaised(T payload)
        {
            _response.Invoke(payload);
        }
    }
}
