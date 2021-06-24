using UnityEngine;

namespace ProjectKritskiy
{
    public sealed class MoveController : IExecute
    {
        private readonly Rigidbody _unitBody;
        private readonly Transform _unitLocation;
        private readonly IUnit _unitData;
        
        
        private float _horizontal;
        private float _vertical;
        private Vector3 _move;
        private IUserInputProxy _horizontalInputProxy;
        private float _yAxis;
        private IUserInputProxy _verticalInputProxy;

        public MoveController((IUserInputProxy inputHorizontal, float yAxis, IUserInputProxy inputVertical) input,
            Transform unitLocation, IUnit unitData)
        {
            _unitBody = GameObject.Find("Player").GetComponent<Rigidbody>();
            _unitLocation = unitLocation;
            _unitData = unitData;
            _horizontalInputProxy = input.inputHorizontal;
            _yAxis = input.yAxis;
            _verticalInputProxy = input.inputVertical;

            _horizontalInputProxy.AxisOnChange += HorizontalOnAxisOnChange;
            _verticalInputProxy.AxisOnChange += VerticalOnAxisOnChange;
        }

        private void HorizontalOnAxisOnChange(float value)
        {
            _horizontal = value;
        }

        private void VerticalOnAxisOnChange(float value)
        {
            _vertical = value;
        }

        public void Execute(float deltaTime)
        {
            _move.Set(_horizontal, _yAxis, _vertical);
            _unitBody.AddForce(_unitData.Speed * _unitLocation.TransformDirection(_move));
        }
    }
}