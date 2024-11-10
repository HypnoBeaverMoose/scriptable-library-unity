using HBM.Scriptable;
using UnityEngine;

public class SetX : MonoBehaviour
{
    [SerializeField] private Vector3Variable _variable;

    public void Set(float val)
    {
        _variable.value = new Vector3(val, _variable.value.y, _variable.value.z);
    }
}
