using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportToScene : MonoBehaviour
{
    [Tooltip("Le nom exact de la scène à charger")]
    public string nomDeLaScene;

    [Tooltip("Le tag de l'objet qui doit déclencher la TP (généralement 'Player')")]
    public string tagDuJoueur = "Player";

    // Cette fonction de Unity se déclenche dès qu'un objet entre dans le Trigger
    private void OnTriggerEnter(Collider other)
    {
        // On vérifie si c'est bien le joueur qui est entré dans la zone
        if (other.CompareTag(tagDuJoueur))
        {
            Debug.Log("salut");
            ChangerDeScene();
        }
    }

    private void ChangerDeScene()
    {
        if (!string.IsNullOrEmpty(nomDeLaScene))
        {
            SceneManager.LoadScene(nomDeLaScene);
        }
        else
        {
            Debug.LogError("Le nom de la scène n'est pas configuré !");
        }
    }
}

