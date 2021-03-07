using System.Collections.Generic;
using UnityEngine;
using Asteroids.Interfaces;
using Asteroids.Player;


namespace Asteroids
{
    public sealed class GameController : MonoBehaviour
    {
        #region PrivateData

        [SerializeField] private PlayerData _playerData;

        private List<IUpdatable> _iUpdatables = new List<IUpdatable>();

        #endregion
        
        
        #region UnityMethods

        private void Start()
        {
            new GameInitializator(this, _playerData);
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

