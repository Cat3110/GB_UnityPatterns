using UnityEngine;

namespace Asteroids.Player
{
    public class PlayerShoot
    {
        #region PrivateFields

        private readonly Transform _transform;
        private readonly GameObject _bulletPrefab;
        private readonly float _force;

        #endregion
        
        

        #region ClassLyfeCycles

        public PlayerShoot(GameObject bulletPrefab, float force, Transform transform)
        {
            _transform = transform;
            _force = force;
            _bulletPrefab = bulletPrefab;
        }

        #endregion


        #region Methods

        public void Shoot()
        {
            Vector3 bulletOffset = new Vector3(1, 0, 0);
            var bullet = Object.Instantiate(_bulletPrefab, _transform.position + bulletOffset, _transform.rotation);
            bullet.GetComponent<Rigidbody>().AddForce(_transform.up * _force);
        }

        #endregion
    }
}