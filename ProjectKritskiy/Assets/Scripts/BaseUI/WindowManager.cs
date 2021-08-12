using System.Collections.Generic;
using UnityEngine;

namespace ProjectKritskiy
{
    internal sealed class WindowManager : MonoBehaviour
    {
        [SerializeField] private StatusPanel _statusPanel;
        [SerializeField] private ObjectivePanel _objectivePanel;
        private readonly Stack<StateUI> _stateUi = new Stack<StateUI>();
        private BaseUi _currentWindow;

        private void Start()
        {
            _statusPanel.Cancel();
            _objectivePanel.Cancel();
        }

        private void Execute(StateUI stateUI, bool isSave = true)
        {
            if (_currentWindow != null)
            {
                _currentWindow.Cancel();
            }

            switch (stateUI)
            {
                case StateUI.StatusPanel:
                    _currentWindow = _statusPanel;
                    break;

                case StateUI.ObjectivePanel:
                    _currentWindow = _objectivePanel;
                    break;

                default:
                    break;
            }

            _currentWindow.Execute();
            if (isSave)
            {
                _stateUi.Push(stateUI);
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                Execute(StateUI.StatusPanel);
            }

            if (Input.GetKeyDown(KeyCode.O))
            {
                Execute(StateUI.ObjectivePanel);
            }

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (_stateUi.Count > 0)
                {
                    Execute(_stateUi.Pop(), false);
                }
            }
        }
    }
}