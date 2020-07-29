using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour
{
    Animator animation;
    public Anim(Animator animation)
    {
        this.animation = animation;
    }
    public void Walk()
    {
        animation.SetBool("IsWalk", true);
    }
    public void StopWalk()
    {
        animation.SetBool("IsWalk", false);
    }
    public void Attack()
    {
        animation.SetBool("IsAttack", true);

    }
    public void StopAttack()
    {
        animation.SetBool("IsAttack", false);

    }
}
