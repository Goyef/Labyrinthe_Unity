using UnityEngine;

public class GestionGrimoire : MonoBehaviour
{
    [SerializeField] private bool estOuvert;
    public GameObject grimoirePanel; // Ton Canvas en World Space au-dessus du pupitre

    void Start()
    {
        estOuvert = false;
        if (grimoirePanel != null)
        {
            grimoirePanel.SetActive(estOuvert);
        }
    }

    // C'est cette fonction que tu vas lier à ton système de Grab VR
    public void TriggerGrimoire()
    {
        Debug.Log("Le porte-grimoire à été déclenché");

        if (grimoirePanel != null)
        {
            estOuvert = !estOuvert; // Alterne entre ouvert et fermé
            grimoirePanel.SetActive(estOuvert); // Active ou désactive le Canvas
        }
    }
}