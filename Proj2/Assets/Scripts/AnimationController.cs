using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public AudioClip FootstepsSound;
    [SerializeField]private Animator anim;
    [SerializeField]private AudioSource _ad;
    private void Start()
    {
        _ad = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        if(Input.anyKey)
        {
            anim.SetBool("IsRunning", true);
            if (!_ad.isPlaying)
            { //проигрываем новый звук, только если сейчас никакой звук не играет

                _ad.clip = FootstepsSound;

                _ad.Play();

            }
        }
        else anim.SetBool("IsRunning", false);
    }
}
