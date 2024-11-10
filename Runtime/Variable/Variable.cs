using UnityEngine;

namespace HBM.Scriptable
{
    public class Variable<T> : ScriptableObject
    {
        public T value { get => realValue; set => realValue = value; }

        [System.NonSerialized] private T realValue;
        [SerializeField] private T _value;

        private void OnEnable()
        {
            this.hideFlags = HideFlags.DontUnloadUnusedAsset;
            realValue = _value;
        }

        private void OnValidate()
        {
            realValue = _value;
        }

        public override string ToString()
        {
            return realValue?.ToString() ?? "";
        }
    }
}