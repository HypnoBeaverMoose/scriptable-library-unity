using UnityEngine;

namespace HBM.Scriptable
{
    public class SetRegistar<T> : SetRegistarBase<T>
    {
        [SerializeField] private T _toRegister;

        protected override T _object { get => _toRegister; }
    }
}