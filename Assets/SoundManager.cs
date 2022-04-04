using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager: MonoBehaviour
{
    public static SoundManager instance;
    [SerializeField] private AudioSource _musicSource, _effectsSource;
   
    //Private void Awake and the code within create the possibility of making a singleton out of our SoundManager
    //a singleton is a common design pattern in programming which enforces that only a single instance of this class will be running at a time
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlaySound(AudioClip clip)
    {
        //this line of code create the possibility 
        _effectsSource.PlayOneShot(clip);
    }
    public void ChangeMasterVolume(float value)
    {
        //this line of code create the possibility of creating a changemastervolume by making an audiolistener thats connected to the volume by value
        AudioListener.volume = value;
    }

    public void ToggleEffects()
    {
        //this line of code create the possibility of toggling your effects by muting
        _effectsSource.mute = !_effectsSource.mute;
    }

    public void ToggleMusic()
    {
        //this line of code create the possibility of toggling your music by muting
        _musicSource.mute = !_musicSource.mute;
    }


}
