using UnityEngine;

namespace HBM.Scriptable
{
    public abstract class SetRegistarBase<T> : MonoBehaviour
    {
        [SerializeField] private RuntimeSet<T> _set;

        protected abstract T _object {  get; }

        private void OnEnable()
        {
            _set.Add(_object);
        }

        private void OnDisable()
        {
            _set.Remove(_object);
        }
    }
}