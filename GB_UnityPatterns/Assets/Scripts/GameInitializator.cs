using Asteroids.Enemy;
using UnityEngine;
using Asteroids.Player;


namespace Asteroids
{
    public class GameInitializator
    {
        #region ClassLifeCycles

        public GameInitializator(GameController gameController, PlayerData playerData, EnemyAsteroidData enemyAsteroidData, EnemyShipData enemyShipData)
        {
            new PlayerInitializator(gameController, playerData);
            new EnemiesInitializator(gameController, enemyAsteroidData, enemyShipData);
        }

        #endregion
    }
}

