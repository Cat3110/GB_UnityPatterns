using Asteroids.Interfaces;
using UnityEngine;

namespace Asteroids.Player
{
    public class PlayerRotate : IRotation
    {
        #region PrivateField

        private readonly Transform _transform;
        private readonly Camera _camera;

        #endregion
        
        
        #region ClassLifeCycles

        public PlayerRotate(Transform transform, Camera camera)
        {
            _transform = transform;
            _camera = camera;
        }

        #endregion

        
        #region IRotate

        public void Rotate(Vector3 input)
        {
            var direction = input - _camera.WorldToScreenPoint(_transform.position);
            var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            _transform.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }

        #endregion
    }
}