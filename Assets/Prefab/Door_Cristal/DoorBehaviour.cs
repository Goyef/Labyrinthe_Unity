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
        if (DoorManager.ManageDoor.doorAlreadyOpened == false && isOpen == false)
        {
            isOpen = !isOpen;
            animator.SetBool("IsOpen", isOpen);
            DoorManager.ManageDoor.doorAlreadyOpened = true;
        }

    }

}
