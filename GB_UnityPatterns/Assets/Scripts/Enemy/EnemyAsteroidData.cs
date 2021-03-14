using UnityEngine;

namespace Asteroids.Enemy
{
    [CreateAssetMenu(fileName = "PlayerData", menuName = "Data/EnemyAsteroidData")]
    public sealed class EnemyAsteroidData : ScriptableObject
    {
        #region Fields

        public GameObject[] enemyAsteroidPrefabArray;

        public EnemyAsteroidStruct enemyAsteroidStruct;

        #endregion
    }
}