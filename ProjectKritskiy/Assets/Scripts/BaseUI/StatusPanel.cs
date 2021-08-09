using UnityEngine;
using UnityEngine.UI;

namespace ProjectKritskiy
{
    internal sealed class StatusPanel : BaseUi
    {
        [SerializeField] private Image _imageHP;
        [SerializeField] private Text _textAmmo;
        [SerializeField] private Text _textPoints;

        private PointsInterpreter _interpreter = new PointsInterpreter();

        private float _hpScaleSizeX;
        private float _hpScaleSizeY = 0.2f;
        private float _hpScaleSizeZ = 0.1f;

        private int _currentAmmo;
        private int _maxAmmo;

        public override void Execute()
        {
            gameObject.SetActive(true);
        }

        public override void Cancel()
        {
            gameObject.SetActive(false);
        }

        public void SetHPInfo(float playerHP, float playerMaxHP)
        {
            _hpScaleSizeX = playerHP / playerMaxHP;
            _imageHP.transform.localScale = new Vector3(_hpScaleSizeX, _hpScaleSizeY, _hpScaleSizeZ);
        }

        public void SetAmmoInfo(int currentAmmo, int maxAmmo)
        {
            _currentAmmo = currentAmmo;
            _maxAmmo = maxAmmo;
            _textAmmo.text = $"{_currentAmmo} / {_maxAmmo}";
        }
        
        public void SetPointsInfo(long points)
        {
            _textPoints.text = _interpreter.CalculatePoints(points);
        }
    }
}