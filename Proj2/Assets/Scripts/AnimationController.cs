using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField]private Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        if(Input.anyKey)
        {
            anim.SetBool("IsRunning", true);
        }
        else anim.SetBool("IsRunning", false);
    }
}
