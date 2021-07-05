using System;
using UnityEngine;

namespace ProjectKritskiy
{
    public sealed class PCMouseHorizontal : IUserInputProxy
    {
        public event Action<float> AxisOnChange = delegate(float f) { };

        public void GetAxis()
        {
            AxisOnChange.Invoke(Input.GetAxis(AxisManager.MOUSEHORIZONTAL));
        }
    }
}