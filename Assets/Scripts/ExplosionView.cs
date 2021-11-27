using UnityEngine;

namespace BrokenTower
{
    public class ExplosionView
    {
        private ParticleSystem _particleSystem;

        public ExplosionView(ParticleSystem particleSystem)
        {
            _particleSystem = particleSystem;
        }
        
        public void Explosion(Transform transform)
        {
            _particleSystem.transform.position = transform.position;
            _particleSystem.Play();
        }
    }
}