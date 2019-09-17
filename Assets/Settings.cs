using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Settings : MonoBehaviour
{
    GameObject panelSetting;
    public AudioMixer audioMixer;
    public Slider sliderBGM;
    public Dropdown resolution;
    Resolution[] resolutions;
    // Start is called before the first frame update
    void Start()
    {
        panelSetting = this.gameObject;
        resolutions = Screen.resolutions;
        resolution.ClearOptions();

        List<string> options = new List<string>();
        int curentResolutionIndex = 0;
        for(int i=0;i<resolutions.Length;i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);

            if(resolutions[i].width==Screen.currentResolution.width && 
                resolutions[i].height==Screen.currentResolution.height)
            {
                curentResolutionIndex = i;
            }
        }
        resolution.AddOptions(options);
        resolution.value = curentResolutionIndex;
        resolution.RefreshShownValue();
    }
    
    public void SetVolumeBGM(float volume)
    {
        audioMixer.SetFloat("BGM",volume);
    }
    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
