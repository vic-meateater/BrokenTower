using UnityEngine;

namespace BrokenTower
{
    public sealed class Floor: Unit
    {
        private Rigidbody _rigidbody;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

       
        private void OnCollisionExit(Collision other)
        {
            DisableKinematic();
        }

        public override void DisableKinematic()
        {
            _rigidbody.isKinematic = false;
        }
    }
}