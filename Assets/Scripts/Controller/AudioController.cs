using UnityEngine;
using System.Collections;

public class AudioController : EntityBehaviour<GameEntity>
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
            source.Stop();
        }
        else if (source.clip != clip)
        {
            source.Stop();
            source.clip = clip;
            source.Play();
        }
    }

    public void PlayEffect(AudioClip clip)
    {
        source.PlayOneShot(clip);
    }
    private void Update()
    {
        if(PlayClip)
        {
            source.PlayOneShot(PlayClip);
            PlayClip = null;
        }
    }
}
