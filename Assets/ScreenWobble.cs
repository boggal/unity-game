using UnityEngine;

public class ScreenWobble : MonoBehaviour
{
    public Animator animator;
    

    private void Start()
    {
        animator.enabled = false;  
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)) 
        {
            animator.enabled = true;
        }

        if(Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D)) 
        {
            animator.enabled = false;
        }
    }
}