using Asteroids.Interfaces;
using UnityEngine;

namespace Asteroids.Enemy
{
    public class EnemyAsteroid : Enemy, IRotation
    {
        #region ClassLifeCycles

        public EnemyAsteroid(EnemyAsteroidData enemyAsteroidData)
        {
            Debug.Log("Asteroid has created");
        }

        #endregion


        #region IRotation

        public void Rotate(Vector3 direction)
        {
            throw new System.NotImplementedException();
        }

        #endregion

    }
}