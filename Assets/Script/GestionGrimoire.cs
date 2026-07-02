using UnityEngine;
using UnityEngine.InputSystem; // OBLIGATOIRE pour le nouveau système d'Input

public class GestionGrimoire : MonoBehaviour
{
    [Header("Éléments d'UI")]
    public GameObject grimoirePanel;

    private bool estOuvert = false;

    void Start()
    {
        if (grimoirePanel != null)
            grimoirePanel.SetActive(false);
    }

    void Update()
    {
        // Vérifie si le clavier est connecté et si la touche G vient d'être pressée
        if (Keyboard.current != null && Keyboard.current.gKey.wasPressedThisFrame)
        {
            if (!estOuvert)
            {
                OuvrirGrimoire();
            }
            else
            {
                FermerGrimoire();
            }
        }

        // Permet aussi de fermer avec la touche Échap (Escape)
        if (estOuvert && Keyboard.current != null && Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            FermerGrimoire();
        }
    }

    public void OuvrirGrimoire()
    {
        estOuvert = true;

        if (grimoirePanel != null)
        {
            grimoirePanel.SetActive(true);
        }

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void FermerGrimoire()
    {
        estOuvert = false;

        if (grimoirePanel != null)
        {
            grimoirePanel.SetActive(false);
        }

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}