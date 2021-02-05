using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Audio;




/**
* Wird bei dem GameObject "MusicManager" aufgerufen. Hierbei werden die 
* die Musiktracks gemanaged, die abgespielt werden sollen (gilt nur für Level 1)
*/

public class MusicManager : MonoBehaviour
{
    public Sound[] sounds;
    /**
	* Wird aufgerufen, um für jede sounddatei im array die jeweiligen sachen bei der source datei mit zu initialisieren.
	*/
    void Awake()
    {
        
        //DontDestroyOnLoad(gameObject);
        
        foreach (Sound s in sounds)
        {
            s.source=gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.panStereo = s.stereoPan;
            s.source.loop = s.loop;
        }   
    }

	/**
	* Wird aufgerufen, um die Musikstücke in den passenden Stellen abzuspielen.
	* dabei ist es so, dass zuerst build up gespielt wird und sobald es vorbei ist
	* soll dann der eigentliche Loop abgespielt werden.
	*/
    void Start()
    {

        String name = "Build";
        Sound s=Array.Find(sounds,sound => sound.name==name);
        if (s == null)
        {
            Debug.LogWarning("Sound" + name + "wasn't found");
            return;
        }
       


            String name2 = "Loop";
            Sound s2=Array.Find(sounds,sound => sound.name==name2);
            if (s2 == null)
            {
                Debug.LogWarning("Sound" + name2 + "wasn't found");
                return;
            }

            

            s.source.PlayScheduled(AudioSettings.dspTime);
            double clipLength = s.source.clip.samples / s.source.clip.frequency;
            s2.source.PlayScheduled(AudioSettings.dspTime + clipLength+0.15f);
    }


    
    
}
