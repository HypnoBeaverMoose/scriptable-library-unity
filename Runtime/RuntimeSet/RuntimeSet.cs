using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEngine;

namespace HBM.Scriptable
{
    public abstract class RuntimeSetBase : ScriptableObject
    {
        public abstract IEnumerable<object> GetValues();
    }

    public class RuntimeSet<T> : RuntimeSetBase, IEnumerable<T>
    {
        [System.NonSerialized] private readonly HashSet<T> _values = new();

        public void Add(T value)
        {
            _values.Add(value);
        }

        public void Remove(T value)
        {
            _values.Remove(value);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _values.GetEnumerator();
        }

        public override IEnumerable<object> GetValues()
        {
            foreach (var item in _values)
            {
                yield return item;
            }
        }
    }
}