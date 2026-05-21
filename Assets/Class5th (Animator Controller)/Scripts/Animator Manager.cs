using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    public Animator animator;

    public void Die()
    {
        animator.SetTrigger("Die");
    }

        public void Attack()
        {
        animator.SetBool("Attack", true);
        }
    
        public void Walk()
        {
        animator.SetBool("Walk", true);
        }
    
    public void Idle()
    {
        animator.SetBool("Walk", false);
        animator.SetBool("Attack", false);
    }
}
