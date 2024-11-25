using System.Linq;
using UnityEngine;

namespace HBM.Scriptable
{
    [CreateAssetMenu(menuName = "HBM/Sets/GameObject")]
    public class GameObjectSet : RuntimeSet<GameObject>
    {
        public GameObject GetClosest(Vector3 position, out float distance)
        {
            GameObject closest = this.First();
            distance = Vector3.Distance(position, closest.transform.position);
            foreach (var item in this)
            {
                var newDistance = Vector3.Distance(item.transform.position, position);
                if (newDistance < distance)
                {
                    distance = newDistance;
                    closest = item;
                }
            }

            return closest;
        }
    }
}