using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnStart : MonoBehaviour
{
    [SerializeField] private AudioClip _clip;
    void Start()
    {
        //this line of code create the possibility of playing the soundclip 
        SoundManager.instance.PlaySound(_clip);
    }
}
