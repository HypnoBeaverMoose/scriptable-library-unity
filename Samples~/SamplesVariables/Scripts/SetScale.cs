using HBM.Scriptable;
using UnityEngine;

public class SetScale : MonoBehaviour
{
    [SerializeField] private VariableReference<Vector3> _variable;

    private void Update()
    {
        transform.localScale = _variable.value;
    }
}
