using UnityEngine;

namespace Assets.Scripts
{
    public class StateManager : MonoBehaviour
    {
        [SerializeField] private Animator parentAnimator;
        
        // Sight
        private string _currentSightSelection = "Sight1Selected";
        private string _sightSelection;
        // Mag
        private string _currentMagSelection = "Mag1Selected";
        private string _magSelection;
        // Barrel
        private string _currentBarrelSelection = "Barrel1Selected";
        private string _barrelSelection;
        // Stock
        private string _currentStockSelection = "Stock1Selected";
        private string _stockSelection;
        // Tactical
        private string _currentTacticalSelection = "Tactical1Selected";
        private string _tacticalSelection;
        
        [SerializeField] private GameObject equipButton;
        [SerializeField] private GameObject equippedButton;
        
        private string _lastSelection;

        public void ChangeSightSelection(string sightSelection)
        {
            if (sightSelection == _currentSightSelection)
            {
                EnableEquippedButton();
            }
            else
            {
                EnableEquipButton();
            }
            _sightSelection = sightSelection;
            parentAnimator.Play(sightSelection);
        }
        
        public void ChangeMagSelection(string magSelection)
        {
            if (magSelection == _currentMagSelection)
            {
                EnableEquippedButton();
            }
            else
            {
                EnableEquipButton();
            }
            _magSelection = magSelection;
            parentAnimator.Play(magSelection);
        }

        public void ChangeBarrelSelection(string barrelSelection)
        {
            if (barrelSelection == _currentBarrelSelection)
            {
                EnableEquippedButton();
            }
            else
            {
                EnableEquipButton();
            }
            _barrelSelection = barrelSelection;
            parentAnimator.Play(barrelSelection);
        }

        public void ChangeStockSelection(string stockSelection)
        {
            if (stockSelection == _currentStockSelection)
            {
                EnableEquippedButton();
            }
            else
            {
                EnableEquipButton();
            }
            _stockSelection = stockSelection;
            parentAnimator.Play(stockSelection);
        }

        public void ChangeTacticalSelection(string tacticalSelection)
        {
            if (tacticalSelection == _currentTacticalSelection)
            {
                EnableEquippedButton();
            }
            else
            {
                EnableEquipButton();
            }
            _tacticalSelection = tacticalSelection;
            parentAnimator.Play(tacticalSelection);
        }

        public void OnClickedEquipButton()
        {
            if (_lastSelection == "Sight")
            {
                _currentSightSelection = _sightSelection;
                EnableEquippedButton();
            }

            if (_lastSelection == "Mag")
            {
                _currentMagSelection = _magSelection;
                EnableEquippedButton();
            }

            if (_lastSelection == "Barrel")
            {
                _currentBarrelSelection = _barrelSelection;
                EnableEquippedButton();
            }

            if (_lastSelection == "Stock")
            {
                _currentStockSelection = _stockSelection;
                EnableEquippedButton();
            }

            if (_lastSelection == "Tactical")
            {
                _currentTacticalSelection = _tacticalSelection;
                EnableEquippedButton();
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

            EnableEquippedButton();
            _lastSelection = newSelection;
        }

        private void EnableEquipButton()
        {
            equipButton.SetActive(true);
            equippedButton.SetActive(false);
        }

        private void EnableEquippedButton()
        {
            equippedButton.SetActive(true);
            equipButton.SetActive(false);
        }
    }

}