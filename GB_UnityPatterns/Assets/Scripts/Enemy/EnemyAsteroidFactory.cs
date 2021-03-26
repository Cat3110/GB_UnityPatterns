using Asteroids.Interfaces;
using UnityEngine;

namespace Asteroids.Enemy
{
    public class EnemyAsteroidFactory : IEnemyFactory
    {
        #region Fields

        private EnemyAsteroidData _enemyAsteroidData;
        
        #endregion


        #region ClassLifeCycles

        public EnemyAsteroidFactory(EnemyAsteroidData enemyAsteroidData)
        {
            _enemyAsteroidData = enemyAsteroidData;
        }

        #endregion


        #region IEnemyFactory

        public Enemy Create()
        {
            return new EnemyAsteroid(_enemyAsteroidData);
        }

        #endregion
    }
}