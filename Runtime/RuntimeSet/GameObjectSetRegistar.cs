using UnityEngine;

namespace HBM.Scriptable
{
    public class GameObjectSetRegistar : SetRegistarBase<GameObject>
    {
        protected override GameObject _object { get => gameObject; }
    }
}