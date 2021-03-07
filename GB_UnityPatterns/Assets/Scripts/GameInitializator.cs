using UnityEngine;
using Asteroids.Player;


namespace Asteroids
{
    public class GameInitializator
    {
        #region ClassLifeCycles

        public GameInitializator(GameController gameController, PlayerData playerData)
        {
            new PlayerInitializator(gameController, playerData);
        }

        #endregion
    }
}

