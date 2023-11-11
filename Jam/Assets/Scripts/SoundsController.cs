using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SoundsController : MonoBehaviour
{
    static public SoundsController Instance { get; private set; }
    private float mVolume = 1, sVolume = 1;
    [SerializeField] private AudioSource musicSource, soundsSource;
    [SerializeField] private AudioClip[] soundsClips;
    public enum AudioClips { ShakeSound, HitSound, ButtonClickSound, DeathSound, OpenDoorSound}
    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
        mVolume = PlayerPrefs.GetFloat("mVolume", 1);
        sVolume = PlayerPrefs.GetFloat("sVolume", 1);
    }

    public void PlaySound(AudioClips clip) 
    {
        soundsSource.pitch = Random.Range(0.9f, 1.1f);
        soundsSource.PlayOneShot(soundsClips[(int)clip]);
    }
    public void PlayButtonClickSound()
    {
        PlaySound(AudioClips.ButtonClickSound);
    }
    public void ChangeVolume(float volume, bool music)
    {
        if(music)
        {
            mVolume = volume;
            PlayerPrefs.SetFloat("mVolume", volume);
        }
        else
        {
            sVolume = volume;
            PlayerPrefs.SetFloat("sVolume", volume);
        }
    }
}
