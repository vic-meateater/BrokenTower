using BrokenTower.Interfaces;
using UnityEngine;

namespace BrokenTower
{
    public class ObjectsHandler : MonoBehaviour
    {
        private Camera _camera;
        private const float EXPLOSION_RADIUS = 2f;
        private Unit _unit;
        private ParticleSystem _particleSystem;
        private ExplosionView _explosionView;
        
    
        void Start()
        {
            _camera = Camera.main;
            _particleSystem = FindObjectOfType<ParticleSystem>();
            _explosionView = new ExplosionView(_particleSystem);
        }

        private void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Shoot();
            }
        }

        
        private void Shoot()
        {
            var ray = _camera.ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(ray, out var hitInfo);
            _explosionView.Explosion(hitInfo.transform);
            var surroundingObjects = Physics.OverlapSphere(hitInfo.transform.position, EXPLOSION_RADIUS);
            if (surroundingObjects == null) return;
            foreach (var o in surroundingObjects)
            {
                if (o.TryGetComponent(out IDestroyable unit))
                {
                    unit.DisableKinematic();
                }
            }
        }
    }
}

