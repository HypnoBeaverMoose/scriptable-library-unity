using UnityEngine;

namespace HBM.Scriptable
{
    [System.Serializable]
    public class VariableReference<T>
    {
        [SerializeField] private bool _useConstant;
        [SerializeField] private T _constant;
        [SerializeField] private Variable<T> _variable;

        public T value => _useConstant ? _constant : _variable.value;
    }
}