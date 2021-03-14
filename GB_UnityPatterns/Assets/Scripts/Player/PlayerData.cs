using UnityEngine;


namespace Asteroids.Player
{
    [CreateAssetMenu(fileName = "PlayerData", menuName = "Data/PlayerData")]
    public sealed class PlayerData : ScriptableObject
    {
        #region Fiels

        public GameObject playerPrefab;
        public Vector3 startPosition;
        
        public PlayerStruct playerStruct;

        #endregion
    } 
}

