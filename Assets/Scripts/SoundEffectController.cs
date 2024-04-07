using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectController : MonoBehaviour
{
    [SerializeField]
    AudioSource source;

    static SoundEffectController _instance;

    public static SoundEffectController Instance { get => _instance; }

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


    public void PlayEffect(AudioClip clip)
    {
        source.PlayOneShot(clip);
    }
}
