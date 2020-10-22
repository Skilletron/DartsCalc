using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class animation_options : MonoBehaviour
{
   public Animator animator;

    private void Update()
    {
    }
    public void PlayerClickOptions()
    {
        animator.SetBool("PlayerClickOptions", true);
        animator.SetBool("PlayerClickOptionsClose", false);
    }
    public void PlayerClickOptionsClose()
    {
        animator.SetBool("PlayerClickOptions", false);
        animator.SetBool("PlayerClickOptionsClose",true);
    }
   
}
