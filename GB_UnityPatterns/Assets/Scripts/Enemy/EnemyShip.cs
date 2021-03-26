using Asteroids.Interfaces;
using UnityEngine;

namespace Asteroids.Enemy
{
    public class EnemyShip : Enemy, IRotation, IShoot
    {
        #region ClassLifeCycles

        public EnemyShip(EnemyShipData enemyShipData)
        {
            Debug.Log("Enemy ship has created");
        }

        #endregion


        #region IRotation

        public void Rotate(Vector3 direction)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        #region IShoot

        public void Shoot(GameObject bulletPrefab, Vector3 direction)
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}