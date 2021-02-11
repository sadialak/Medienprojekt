using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Audio;


/**
* Wird bei dem GameObject "AudioManager" aufgerufen. Hierbei werden die 
* die Geräusche gemanaged, die abgespielt werden sollen (gilt für Level 1 und 2)
*/

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
	/**
	* Wird aufgerufen, um für jede sounddatei im array die jeweiligen sachen bei der source datei mit zu initialisieren.
	*/
    void Awake()
    {

        foreach (Sound s in sounds)
        {
            s.source=gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.panStereo = s.stereoPan;
        }   
    }


/**
* Eine Funktion, welche von anderen Funktionen abgerufen werden kann. dabei
* wird genau die AudioDatei abgespielt, welche den gleichen String Namen hat 
* wie der String Name bei Sound.
*/

    public void Play(string name)
    {
        Sound s=Array.Find(sounds,sound => sound.name==name);
        s.source.PlayOneShot(s.source.clip);
    }
}
