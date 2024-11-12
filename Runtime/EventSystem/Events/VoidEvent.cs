using System.Collections.Generic;
using UnityEngine;

namespace HBM.Scriptable
{
    [CreateAssetMenu(menuName = "HBM/Events/Void")]
    public class VoidEvent : ScriptableObject
    {
        private event System.Action _action;

        public void AddListener(System.Action listener)
        {
            _action += listener;
        }

        public void RemoveListener(System.Action listener)
        {
            _action -= listener;
        }

        public void Invoke()
        {
            _action?.Invoke();
        }
    }
}