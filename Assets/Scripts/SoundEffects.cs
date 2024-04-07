using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    public void PlaySoundEffect(AudioClip clip)
    {
        if (SoundEffectController.Instance != null)
        {
            SoundEffectController.Instance.PlayEffect(clip);
        }
        else
        {
            Debug.LogWarning("You need sound effect controller");
        }
    }
}
