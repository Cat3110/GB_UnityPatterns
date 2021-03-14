using UnityEngine;

namespace Asteroids.Enemy
{
    [CreateAssetMenu(fileName = "PlayerData", menuName = "Data/EnemyShipData")]
    public sealed class EnemyShipData : ScriptableObject
    {
        #region Fields

        public GameObject enemyShipPrefab;

        public EnemyAsteroidStruct enemyAsteroidStruct;
        
        #endregion
    }
}