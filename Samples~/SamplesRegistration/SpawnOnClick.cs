using HBM.Scriptable;
using UnityEngine;

public class SpawnOnClick : MonoBehaviour
{
    [SerializeField] private GameObjectVariable _variable;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit info))
            {
                _variable.value = info.collider.gameObject;
            }
            else if(_variable.value)
            {
                var position = Camera.main.ScreenToWorldPoint(Input.mousePosition + Vector3.forward * 10);
                Instantiate(_variable.value, position, Quaternion.identity);
            }

        }
    }
}
