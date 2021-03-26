using UnityEngine;


namespace Asteroids.Player
{
    public sealed class PlayerInitializator
    {
        #region ClassLifeCycles

        public PlayerInitializator(GameController gameController, PlayerData playerData)
        {
            var playerView = Object.Instantiate(playerData.playerPrefab, playerData.startPosition, Quaternion.identity);

            var playerModel = new PlayerModel(playerData.playerStruct);
            
            gameController.AddUpdatable(new PlayerController(playerModel, playerView));
        }

        #endregion

    }
}

