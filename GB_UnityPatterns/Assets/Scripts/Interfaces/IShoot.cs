using UnityEngine;

namespace Asteroids.Interfaces
{
    public interface IShoot
    {
        void Shoot(GameObject bulletPrefab, Vector3 direction);
    }
}