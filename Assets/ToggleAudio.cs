using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleAudio : MonoBehaviour
{
    [SerializeField] private bool _toggleMusic, _toggleEffects;

    public void Toggle()
    {
        //this line of code create the possibility of toggling effects
        if (_toggleEffects) SoundManager.instance.ToggleEffects();
        //this line of code create the possibility of toggling music
        if (_toggleMusic) SoundManager.instance.ToggleMusic();
    }
}
