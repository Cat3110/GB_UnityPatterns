using System;
using UnityEngine;


namespace Asteroids.Player
{
    [CreateAssetMenu(fileName = "PlayerData", menuName = "Data/PlayerData")]
    public sealed class PlayerData : ScriptableObject
    {
        #region Fiels

        public GameObject _playerPrefab;
        public Vector3 _startPosition;
        
        public PlayerStruct playerStruct;

        #endregion
    } 
}

