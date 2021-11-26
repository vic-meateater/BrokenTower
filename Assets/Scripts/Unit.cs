using System.Collections.Generic;
using Interfaces;
using UnityEngine;

namespace BrokenTower
{
    [RequireComponent(typeof(Rigidbody))]
    public class Unit: IDestroyable
    {
        public void DisableKinematic(IEnumerable<Collider> colliders)
        {
            throw new System.NotImplementedException();
        }
    }
}