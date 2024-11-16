using UnityEngine;

namespace HBM.Scriptable
{
    [CreateAssetMenu(menuName = "HBM/Variables/Int")]
    public class IntVariable : Variable<int>
    {
        public void Change(int by)
        {
            value += by;
        }
    }
}