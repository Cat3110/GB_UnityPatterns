using UnityEngine;

namespace Asteroids.Interfaces
{
    public interface IMove
    {
        float Speed { get;  }
        void Move(Vector3 moveData, float deltaTime);
    }
}