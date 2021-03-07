namespace Asteroids.Player
{
    public sealed class PlayerModel
    {
        #region PrivateData

        private readonly PlayerStruct _playerStruct;

        #endregion


        #region Properties

        public PlayerStruct PlayerStruct => _playerStruct;

        #endregion


        #region ClassLifeCycles

        public PlayerModel(PlayerStruct playerStruct)
        {
            _playerStruct = playerStruct;
        }

        #endregion
    }
}