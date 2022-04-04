using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    void Start()
    {
        //this line of code create the possibility of making the slider being the same spot as it when i begins, so you dont have to move it before it should be used.
        SoundManager.instance.ChangeMasterVolume(_slider.value);
        //this line of code create the possibility of creating a slider by using listener that listens to the slider being used
        _slider.onValueChanged.AddListener(val => SoundManager.instance.ChangeMasterVolume(val));   
    }

    
}
