using Asteroids.Interfaces;
using UnityEngine;


namespace Asteroids.Player
{
    internal class PlayerMove : IMove
    {
        #region PrivateFields

        private readonly Transform _transform;

        #endregion
        
        
        #region Properties

        public float Speed { get; }

        #endregion
        
        
        #region ClassLifeCycle

        public PlayerMove(float speed, Transform transform)
        {
            Speed = speed;
            _transform = transform;
        }

        #endregion


        #region IMove
        
        public void Move(Vector3 moveInput, float deltaTime)
        {
            _transform.localPosition += Speed * deltaTime * moveInput;
        }

        #endregion

    }
}