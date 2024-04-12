using UnityEngine;

namespace DefaultNamespace
{
    public class ResolutionManager: MonoBehaviour
    {
        public void ChangeResolution(int width, int height, bool fullscreen)
        {
            Screen.SetResolution(width, height, fullscreen);
        }
        
        public Resolution[] GetAvailableResolutions()
        {
            return Screen.resolutions;
        }

        public Resolution GetCurrentResolution()
        {
            return Screen.currentResolution;
        }
    }
}