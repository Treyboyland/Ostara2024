using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayNarration : MonoBehaviour
{
    public static void PlayAudio(AudioClip clip)
    {
        if (NarrationAudio.Instance != null)
        {
            NarrationAudio.Instance.PlayAudio(clip);
        }
        else
        {
            Debug.LogWarning("You need Narration Audio manager in scene");
        }
    }
}
