namespace Asteroids.Enemy
{
    public sealed class EnemiesInitializator
    {
        #region Fields

        private EnemyAsteroidFactory _enemyAsteroidFactory;
        private EnemyShipFactory _enemyShipFactory;

        #endregion
        
        #region ClassLifeCycles

        public EnemiesInitializator(GameController gameController, EnemyAsteroidData enemyAsteroidData, EnemyShipData enemyShipData)
        {
            _enemyAsteroidFactory = new EnemyAsteroidFactory(enemyAsteroidData);
            _enemyShipFactory = new EnemyShipFactory(enemyShipData);
            new EnemiesController(gameController, enemyAsteroidData, enemyShipData, _enemyAsteroidFactory, _enemyShipFactory);
        }

        #endregion
    }
}