using HBM.Scriptable;
using UnityEngine;

public class SetY : MonoBehaviour
{
    [SerializeField] private Vector3Variable _variable;

    public void Set(float val)
    {
        _variable.value = new Vector3(_variable.value.x, val, _variable.value.z);
    }
}
