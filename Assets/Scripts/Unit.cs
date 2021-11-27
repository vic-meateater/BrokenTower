using System;
using BrokenTower.Interfaces;
using UnityEngine;

namespace BrokenTower
{
    [RequireComponent(typeof(Rigidbody))]
    public abstract class Unit: MonoBehaviour, IDestroyable
    {
        public abstract void DisableKinematic();
    }
}