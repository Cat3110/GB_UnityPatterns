namespace Asteroids.Enemy
{
    public sealed class EnemiesController
    {
        #region ClassLifeCycles

        public EnemiesController(GameController gameController, EnemyAsteroidData enemyAsteroidData, EnemyShipData enemyShipData, EnemyAsteroidFactory enemyAsteroidFactory, EnemyShipFactory enemyShipFactory)
        {
            enemyAsteroidFactory.Create();
            enemyShipFactory.Create();
        }

        #endregion

    }

}