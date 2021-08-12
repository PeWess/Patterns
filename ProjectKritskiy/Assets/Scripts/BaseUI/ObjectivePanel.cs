using UnityEngine;
using UnityEngine.UI;

namespace ProjectKritskiy
{
    internal sealed class ObjectivePanel : BaseUi
    {
        [SerializeField] private Text _objective;
        
        public override void Execute()
        {
            gameObject.SetActive(true);
        }

        public override void Cancel()
        {
            gameObject.SetActive(false);
        }

        public void UpdateObjective(string newObjective)
        {
            _objective.text = newObjective;
        }
    }
}