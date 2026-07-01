using UnityEngine;

public class DoorBehaviour : MonoBehaviour
{
    [SerializeField] private bool isOpen;
    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isOpen = false;
        animator.SetBool("IsOpen", isOpen);
    }

    public void TriggerDoor()
    {
        Debug.Log("Le bouton à été déclenché");
        isOpen = !isOpen;
        animator.SetBool("IsOpen", isOpen);
    }

}
