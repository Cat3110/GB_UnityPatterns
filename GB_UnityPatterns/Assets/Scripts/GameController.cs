using System;
using System.Collections.Generic;
using System.Xml;
using Asteroids.Enemy;
using UnityEngine;
using Asteroids.Interfaces;
using Asteroids.Player;


namespace Asteroids
{
    public sealed class GameController : MonoBehaviour
    {
        #region PrivateData
        
        [SerializeField] private PlayerData _playerData;
        [SerializeField] private EnemyAsteroidData _enemyAsteroidData;
        [SerializeField] private EnemyShipData _enemyShipData;

        private List<IUpdatable> _iUpdatables = new List<IUpdatable>();

        #endregion
        
        
        #region UnityMethods

        private void Start()
        {
            new GameInitializator(this, _playerData, _enemyAsteroidData, _enemyShipData);
        }

        private void Update()
        {
            for (int i = 0; i < _iUpdatables.Count; i++)
            {
                _iUpdatables[i].UpdateTick();
            }
        }

        #endregion


        #region Methods

        public void AddUpdatable(IUpdatable iUpdatable)
        {
            _iUpdatables.Add(iUpdatable);
        }

        #endregion

    }
}

