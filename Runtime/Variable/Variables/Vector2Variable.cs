using UnityEngine;

namespace HBM.Scriptable
{
    [CreateAssetMenu(menuName = "HBM/Variables/Vector2")]
    public class Vector2Variable : Variable<Vector2>
    {
        public void Change(Vector2 by)
        {
            value += by;
        }
    }
}