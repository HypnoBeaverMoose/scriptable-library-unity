using UnityEngine;

namespace HBM.Scriptable
{
    public abstract class TypedEvent<T> : ScriptableObject
    {
        private event System.Action<T> _action;

        public void AddListener(System.Action<T> listener)
        {
            _action += listener;
        }

        public void RemoveListener(System.Action<T> listener)
        {
            _action -= listener;
        }

        public void Invoke(T arg)
        {
            _action?.Invoke(arg);
        }
    }
}