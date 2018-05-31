using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour {

    private Animator anim;
    public string triggerToSet;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void SetTrigger()
    {
        anim.SetTrigger(triggerToSet);
    }
}
