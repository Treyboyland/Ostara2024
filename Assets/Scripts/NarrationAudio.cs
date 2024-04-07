using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarrationAudio : MonoBehaviour
{
    [SerializeField]
    AudioSource source;

    static NarrationAudio _instance;

    public static NarrationAudio Instance { get => _instance; }

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        if (_instance != null && this != _instance)
        {
            Destroy(gameObject);
            return;
        }

        _instance = this;
    }
    
    public void PlayAudio(AudioClip clip)
    {
        source.clip = clip;
        source.Play();
    }
}
