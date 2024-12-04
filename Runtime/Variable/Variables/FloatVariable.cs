using UnityEngine;

namespace HBM.Scriptable
{
    [CreateAssetMenu(menuName = "HBM/Variables/Float")]
    public class FloatVariable : Variable<float>
    {
        public void Change(float by)
        {
            value += by;
        }
    }
}