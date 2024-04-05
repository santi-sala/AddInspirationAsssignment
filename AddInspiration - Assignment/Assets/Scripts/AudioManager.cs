using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : Singleton<AudioManager>
{

    private AudioSource _audioSourceBackgroundMusic;
    [SerializeField] private AudioSource _audioSourceSfx;
    [SerializeField] private AudioSource _audioSourceSfxFlying;
    [SerializeField] private List<AudioClip> _sfxs;

    // Start is called before the first frame update
    void Start()
    {
        _audioSourceBackgroundMusic = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySFX(int index)
    {
        _audioSourceSfx.PlayOneShot(_sfxs[index]);
    }

    public void PlayJetStart()
    {
        _audioSourceSfxFlying.mute = false;
        _audioSourceSfxFlying.Play();
    }
    public void PlayJetMute()
    {
        _audioSourceSfxFlying.mute = true;
    }
}
