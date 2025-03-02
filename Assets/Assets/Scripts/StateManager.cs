using UnityEngine;

namespace Assets.Scripts
{
    public class StateManager : MonoBehaviour
    {
        [SerializeField] private Animator parentAnimator;
        
        // Sight
        private string _currentSightSelection;
        private string _sightSelection;
        // Mag
        private string _currentMagSelection;
        private string _magSelection;
        // Barrel
        private string _currentBarrelSelection;
        private string _barrelSelection;
        //Stock
        private string _currentStockSelection;
        private string _stockSelection;
        //Tactical
        private string _currentTacticalSelection;
        private string _tacticalSelection;
        
        
        private string _lastSelection;

        public void ChangeSightSelection(string sightSelection)
        {
            _sightSelection = sightSelection;
            parentAnimator.Play(sightSelection);
        }
        
        public void ChangeMagSelection(string magSelection)
        {
            _magSelection = magSelection;
            parentAnimator.Play(magSelection);
        }

        public void ChangeBarrelSelection(string barrelSelection)
        {
            _barrelSelection = barrelSelection;
            parentAnimator.Play(barrelSelection);
        }

        public void ChangeStockSelection(string stockSelection)
        {
            _stockSelection = stockSelection;
            parentAnimator.Play(stockSelection);
        }

        public void ChangeTacticalSelection(string tacticalSelection)
        {
            _tacticalSelection = tacticalSelection;
            parentAnimator.Play(tacticalSelection);
        }

        public void OnClickedEquipButton()
        {
            if (_lastSelection == "Sight")
            {
                _currentSightSelection = _sightSelection;
            }

            if (_lastSelection == "Mag")
            {
                _currentMagSelection = _magSelection;
            }

            if (_lastSelection == "Barrel")
            {
                _currentBarrelSelection = _barrelSelection;
            }

            if (_lastSelection == "Stock")
            {
                _currentStockSelection = _stockSelection;
            }

            if (_lastSelection == "Tactical")
            {
                _currentTacticalSelection = _tacticalSelection;
            }
        }

        public void OnDifferentSectionSelected(string newSelection)
        {
            if (_lastSelection == "Sight")
            {
                parentAnimator.Play(_currentSightSelection);
            }

            if (_lastSelection == "Mag")
            {
                parentAnimator.Play(_currentMagSelection);
            }

            if (_lastSelection == "Barrel")
            {
                parentAnimator.Play(_currentBarrelSelection);
            }

            if (_lastSelection == "Stock")
            {
                parentAnimator.Play(_currentStockSelection);
            }

            if (_lastSelection == "Tactical")
            {
                parentAnimator.Play(_currentTacticalSelection);
            }
            
            _lastSelection = newSelection;
        }
    }

}