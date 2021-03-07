using UnityEngine;


namespace Asteroids.Player
{
    public static class PlayerGetInput
    {
        #region Methods

        public static Vector3 GetMoveInput()
        {
            return new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
        }
        
        public static Vector3 GetRotationInput()
        {
            return Input.mousePosition;
        }

        public static bool GetShootInput()
        {
            return Input.GetButtonDown("Fire1");
        }

        #endregion
    }
}

