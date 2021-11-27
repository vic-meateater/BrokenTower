using UnityEngine;

namespace BrokenTower
{
    public sealed class Pillar:Unit
    {
        private Rigidbody _rigidbody;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        public override void DisableKinematic()
        {
            _rigidbody.isKinematic = false;
        }
    }
}