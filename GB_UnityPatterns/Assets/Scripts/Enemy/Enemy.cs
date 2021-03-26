using Asteroids.Interfaces;
using UnityEngine;

namespace Asteroids.Enemy
{
    public abstract class Enemy : IMove, IUpdatable
    {
        #region IMove

        public float Speed { get; }
        
        public void Move(Vector3 moveData, float deltaTime)
        {
            throw new System.NotImplementedException();
        }

        #endregion


        #region IUpdatable

        public void UpdateTick()
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}