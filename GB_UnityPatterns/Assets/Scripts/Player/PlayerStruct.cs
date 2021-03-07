using System;
using UnityEngine;

namespace Asteroids.Player
{
    [Serializable]
    public struct PlayerStruct
    {
        public float speed;
        public float hp;
        public float shootForce;
        public GameObject bulletPrefab;
    }
}
