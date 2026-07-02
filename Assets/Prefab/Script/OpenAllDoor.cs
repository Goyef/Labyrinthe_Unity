using UnityEngine;

public class OpenAlldDoor : MonoBehaviour
{
    [SerializeField] private bool isOpen;
    public Animator animator;
    public BoxCollider doorCollider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isOpen = false;
        animator.SetBool("IsOpen", isOpen);
    }

    public void TriggerDoor()
    {
        Debug.Log("Le bouton à été déclenché");
        if (isOpen == false)
        {
            isOpen = !isOpen;
            animator.SetBool("IsOpen", isOpen);
            doorCollider.enabled = false;
        }

    }

}
