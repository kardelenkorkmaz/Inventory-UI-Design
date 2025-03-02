using UnityEngine;

namespace Assets.Scripts
{
    public class StateManager : MonoBehaviour
    {
        [SerializeField] private Animator parentAnimator;
        
        // Sight
        private string _currentSightSelection;
        private string _sightSelectionClick;
        // Mag
        private string _currentMagSelection;
        private string _magSelectionClick;
        
        private string _lastSelection;

        public void ChangeSightSelection(string sightSelection)
        {
            _sightSelectionClick = sightSelection;
            parentAnimator.Play(sightSelection);
        }
        
        public void ChangeMagSelection(string magSelection)
        {
            _magSelectionClick = magSelection;
            parentAnimator.Play(magSelection);
        }

        public void OnClickedEquipButton()
        {
            _currentSightSelection = _sightSelectionClick;
            _currentMagSelection = _magSelectionClick;
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
                
            }

            if (_lastSelection == "Stock")
            {
                
            }

            if (_lastSelection == "Tactical")
            {
                
            }
            
            _lastSelection = newSelection;
            
        }
    }

}