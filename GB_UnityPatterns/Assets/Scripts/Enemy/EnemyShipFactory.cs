using Asteroids.Interfaces;
using UnityEngine;

namespace Asteroids.Enemy
{
    public class EnemyShipFactory : IEnemyFactory
    {
        #region Fields

        private EnemyShipData _enemyShipData;

        #endregion


        #region ClassLifeCycles

        public EnemyShipFactory(EnemyShipData enemyShipData)
        {
            _enemyShipData = enemyShipData;
        }

        #endregion


        #region IEnemyFactory

        public Enemy Create()
        {
            return new EnemyShip(_enemyShipData);
        }

        #endregion
    }
}