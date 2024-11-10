using UnityEngine;

[RequireComponent(typeof(TMPro.TextMeshProUGUI))]
public class VariableToText : MonoBehaviour
{
    [SerializeField] private ScriptableObject _variable;

    private TMPro.TextMeshProUGUI _label;

    private void Awake()
    {
        _label = GetComponent<TMPro.TextMeshProUGUI>();
    }

    private void Update()
    {
        _label.text = _variable.ToString();
    }
}
