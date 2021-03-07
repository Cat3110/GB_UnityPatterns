using System.Collections;
using System.Collections.Generic;
using Asteroids.Interfaces;
using UnityEngine;


namespace Asteroids.Player
{
    public sealed class PlayerController : IUpdatable
    {
        #region PrivateFields

        private PlayerMove _playerMove;
        private PlayerRotate _playerRotate;
        private PlayerShoot _playerShoot;

        #endregion
        
        
        #region ClassLifeCycle

        public PlayerController(PlayerModel playerModel, GameObject playerView)
        {
            _playerMove = new PlayerMove(playerModel.PlayerStruct.speed, playerView.transform);
            _playerRotate = new PlayerRotate(playerView.transform, Camera.main);
            _playerShoot = new PlayerShoot(playerModel.PlayerStruct.bulletPrefab, playerModel.PlayerStruct.shootForce, playerView.transform);
        }

        #endregion


        #region IUpdatable

        public void UpdateTick()
        {
            _playerMove.Move(PlayerGetInput.GetMoveInput(), Time.deltaTime);
            _playerRotate.Rotate(PlayerGetInput.GetRotationInput());
            if (PlayerGetInput.GetShootInput())
            {
                _playerShoot.Shoot();
            }

        }

        #endregion
    }
}
