using UnityEngine;
using System.Collections.Generic;

public class CrystalEnigma : MonoBehaviour
{
    [Header("Configuration des Portes")]
    public List<DoorBehaviourSimple> toutesLesPortes; // Glissez vos 3 portes ici

    [Header("Configuration de l'Ordre (ID des Cristaux)")]
    [Tooltip("Exemple : 1, puis 2, puis 3")]
    public List<int> ordreCorrect; // Définissez l'ordre ici dans l'inspecteur (ex: 1, 2, 3)

    private List<int> ordreActuel = new List<int>();

    // Cette fonction sera appelée par chaque cristal
    public void CristalActive(int idCristal)
    {
        Debug.Log("Cristal activé : " + idCristal);

        // Ajouter le cristal à la liste du joueur
        ordreActuel.Add(idCristal);

        // Vérifier si le dernier cristal activé est le bon
        int indexActuel = ordreActuel.Count - 1;

        if (ordreActuel[indexActuel] != ordreCorrect[indexActuel])
        {
            // ERREUR : Le joueur s'est trompé d'ordre
            Debug.LogWarning("Mauvais ordre ! Réinitialisation de l'énigme.");
            ResetEnigme();
            return;
        }

        // Si le joueur a activé tous les cristaux dans le bon ordre
        if (ordreActuel.Count == ordreCorrect.Count)
        {
            Debug.Log("Énigme réussie ! Ouverture des portes.");
            OuvrirToutesLesPortes();
        }
    }

    private void OuvrirToutesLesPortes()
    {
        foreach (DoorBehaviourSimple porte in toutesLesPortes)
        {
            porte.TriggerDoor(); // Appelle votre fonction existante
        }
    }

    private void ResetEnigme()
    {
        ordreActuel.Clear();
        // Optionnel : Vous pouvez ajouter ici un son d'erreur ou faire clignoter les cristaux
    }
}