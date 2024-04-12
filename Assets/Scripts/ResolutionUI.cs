using System.Collections.Generic;
using DefaultNamespace;
using TMPro;
using UnityEngine;

public class ResolutionUI : MonoBehaviour
{
    public ResolutionManager resolutionManager;
    
    [SerializeField] 
    private TMP_Dropdown resolutionDropdown;
    
    private Resolution[] resolutions;
    private Resolution resolutionCurrent;
   
    private void Start()
    {
        resolutions = resolutionManager.GetAvailableResolutions(); 
        resolutionDropdown.ClearOptions();
           
       List<string> options = new List<string>();
       
       foreach (Resolution res in resolutions)
       {
           options.Add($"{res.width} x {res.height}");
       }
       resolutionDropdown.AddOptions(options);
    }
    
    public void OnResolutionChanged()
    {
        int index = resolutionDropdown.value;
        Resolution selectedResolution = resolutions[index];
        resolutionManager.ChangeResolution(selectedResolution.width, selectedResolution.height, true);
    }
}
