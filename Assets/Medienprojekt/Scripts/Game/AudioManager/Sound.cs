using UnityEngine.Audio;
using UnityEngine;
[System.Serializable]

/**
 *  Neue Klasse für die einzelnen Sound soucres mit den Variablen
 * als deren Eigenschaften (oberbegriff/name, volume, pitch,
 * loop, ob mono oder nicht und die jeweilige source Datei)
 */
public class Sound
{
    public string name;
    public AudioClip clip;

    [Range(0f,1f)]
    public float volume;
    
    [Range(1f,3f)]
    public float pitch;

    public bool loop;

    [Range(-1f, 1f)] public float stereoPan;
    [HideInInspector] public AudioSource source;
}
