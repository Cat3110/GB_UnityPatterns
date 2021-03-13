using Asteroids.Interfaces;
using UnityEngine;


namespace Asteroids.Player
{
    internal class PlayerMove : IMove
    {
        #region PrivateFields

        private readonly Rigidbody _rigidbody;

        #endregion
        
        
        #region Properties

        public float Speed { get; }

        #endregion
        
        
        #region ClassLifeCycle

        public PlayerMove(float speed, Rigidbody rigidbody)
        {
            Speed = speed;
            _rigidbody = rigidbody;
        }

        #endregion


        #region IMove
        
        public void Move(Vector3 moveInput, float deltaTime)
        {
            _rigidbody.AddForce(moveInput);
        }

        #endregion

    }
}