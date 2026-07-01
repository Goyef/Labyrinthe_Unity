using UnityEngine;

public class BehaviourDoor : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private bool isOpen = false;

    private void Reset()
    {
        // Pratique : récupère automatiquement l'Animator si présent sur le même objet
        animator = GetComponent<Animator>();
    }

    public void OpenDoor()
    {
        if (isOpen) return;

        isOpen = true;
        animator.SetTrigger("Open"); // ou SetBool("IsOpen", true);
    }

    public void CloseDoor()
    {
        if (!isOpen) return;

        isOpen = false;
        animator.SetTrigger("Close"); // ou SetBool("IsOpen", false);
    }
}