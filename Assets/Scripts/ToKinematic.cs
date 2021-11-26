using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BrokenTower
{
    public class ToKinematic : MonoBehaviour
    {
        void Start()
        {
            var rbs = transform.GetComponentsInChildren<Rigidbody>();
            foreach (var rb in rbs)
            {
                rb.isKinematic = true;
            } 
        }
    }
}

