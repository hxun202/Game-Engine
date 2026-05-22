using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    public Animator animator;
    public AnimatorStateInfo animatorStateInfo;

    public void Die()
    {
        animatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);

        if (animatorStateInfo.IsName("Die") || animator.IsInTransition(0))
        {
            return;
        }

        animator.SetTrigger("Die");
    }

        public void Attack()
        {
        animatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);

        if (animatorStateInfo.IsName("Idle"))
        {
            animator.SetBool("Attack", true);
            animator.SetBool("Idle", false);
        }
        else if (animatorStateInfo.IsName("Walk"))
        {
            animator.SetBool("Walk", false);
            animator.SetBool("Idle", true);
        }
        }
    
    public void Walk()
    {
        animatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);

        if (animatorStateInfo.IsName("Attack"))
        {
            animator.SetBool("Walk", true);
            animator.SetBool("Attack", false);
        }
        else if(animatorStateInfo.IsName("Idle"))
        {
            animator.SetBool("Walk", true);
            animator.SetBool("Idle", false);
        }

    }
    
    public void Idle()
    {
        animatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);

        if (animatorStateInfo.IsName("Walk"))
        {
            animator.SetBool("Walk",false);
            animator.SetBool("Idle", true);
        }
        else if (animatorStateInfo.IsName("Attack"))
        {
            animator.SetBool("Idle", true);
            animator.SetBool("Attack", false);
        }
    }
}
