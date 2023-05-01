using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator animator;
    public CharacterController controller;

    private void Start()
    {
        // Set the initial state of the isAnimating parameter to false
        animator.SetBool("isAnimating", false);
    }

    public void OnAnimationStart()
    {
        // Lock the controller when the animation starts
        controller.enabled = false;
        animator.SetBool("isAnimating", true);
    }

    public void OnAnimationEnd()
    {
        // Unlock the controller when the animation ends
        controller.enabled = true;
        animator.SetBool("isAnimating", false);
    }
}
