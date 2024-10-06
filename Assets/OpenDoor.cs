using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Animator animator;
    public Animator animator2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseUp()
    {
        if (CompareTag("P1"))
        {
            animator.SetTrigger("open");
            animator2.SetTrigger("open");
        }
        else if (CompareTag("P2"))
        {
            animator.SetTrigger("open2");
            animator2.SetTrigger("open");
        }
    }
    
}
