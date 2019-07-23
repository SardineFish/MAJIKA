using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class AudioController : MonoBehaviour
{
    AudioSource source;
    public AudioClip PlayClip;
    private void Awake()
    {
        source = GetComponentInChildren<AudioSource>();
        source.loop = true;
    }

    public void PlayAudio(AudioClip clip)
    {
        if (!clip)
        {
            source.clip = null;
        }
        else if (source.clip != clip)
        {
            source.clip = clip;
            source.Play();
        }
    }

    public void PlayEffect(AudioClip clip, float volumn = 1)
    {
        if (clip)
            source.PlayOneShot(clip, volumn);
    }
    
    public IEnumerator Enter(AudioClip clip, float volumn, float time, bool loop = true)
    {
        source.clip = clip;
        source.volume = 0;
        source.loop = loop;
        foreach(var t in Utility.TimerNormalized(time))
        {
            source.volume = volumn * t;
            yield return null;
        }
    }

    public IEnumerator Exit(float time)
    {
        var v = source.volume;
        foreach (var t in Utility.TimerNormalized(time))
        {
            source.volume = v * (1 - t);
            yield return null;
        }
        source.clip = null;
    }
}
