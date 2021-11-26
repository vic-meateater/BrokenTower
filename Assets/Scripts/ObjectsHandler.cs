using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BrokenTower
{
    public class ObjectsHandler : MonoBehaviour
    {
        private Camera _camera;
        private const float EXPLOSION_RADIUS = 3f;
        private const float EXPLOSION_FORCE = 500f;
    
        void Start()
        {
            _camera = Camera.main;
        }
    
        void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Shoot();
            }
        }
    
        private void DisableKinematic(IEnumerable<Collider> colliders)
        {
            foreach (var c in colliders)
            {
                if (c.TryGetComponent(out Rigidbody rb))
                {
                    rb.isKinematic = false; 
                }
            }
        }
    
        private void Shoot()
        {
            var ray = _camera.ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(ray, out var hitInfo);
            Debug.Log(hitInfo.transform.name);
    
            var surroundingObjects = Physics.OverlapSphere(hitInfo.transform.position, EXPLOSION_RADIUS);
            if (surroundingObjects != null)
            {
                DisableKinematic(surroundingObjects);
            }
            foreach (var surroundingObject in surroundingObjects)
            {
                if (surroundingObject.TryGetComponent(out Rigidbody rb))
                {
                    rb.AddExplosionForce(EXPLOSION_FORCE, hitInfo.transform.position, EXPLOSION_RADIUS);
                }
            }
        }
    }
}

