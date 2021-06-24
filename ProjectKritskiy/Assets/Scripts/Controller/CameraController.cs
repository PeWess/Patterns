using UnityEngine;

namespace ProjectKritskiy
{
    internal sealed class CameraController : IExecute, ILateExecute
    {
        private readonly Rigidbody _playerBody;
        private readonly Transform _mainCamera;
        private readonly Vector3 _offset;
        
        private float _rotationSpeed = 20f;
        private float _angleX;
        private float _angleY;
        private float _cameraAngleX;
        private float _cameraAngleY;
        private IUserInputProxy _InputAngleX;
        private IUserInputProxy _InputAngleY;

        public CameraController((IUserInputProxy mouseHorizontal, IUserInputProxy mouseVertical) input,
            Transform mainCamera)
        {
            _mainCamera = mainCamera;
            _playerBody = GameObject.Find("Player").GetComponent<Rigidbody>();
            _offset = new Vector3(0f, 3f, 0f);

            _InputAngleX = input.mouseHorizontal;
            _InputAngleY = input.mouseVertical;
            
            _InputAngleX.AxisOnChange += HorizontalMouseOnChange;
            _InputAngleY.AxisOnChange += VerticalMouseOnChange;
        }

        private void HorizontalMouseOnChange(float value)
        {
            _angleX = value;
        }
        
        private void VerticalMouseOnChange(float value)
        {
            _angleY = value;
        }

        public void Execute(float deltaTime)
        {
            _cameraAngleX += _angleX;
            _cameraAngleY += _angleY;
        }

        public void LateExecute(float deltaTime)
        {
            _playerBody.MoveRotation(Quaternion.Euler(-_cameraAngleY * _rotationSpeed * deltaTime,
                _cameraAngleX * _rotationSpeed * Time.fixedDeltaTime, 0f));
            _mainCamera.position = _playerBody.transform.position + _offset;
            _mainCamera.rotation = _playerBody.rotation;
        }
    }
}