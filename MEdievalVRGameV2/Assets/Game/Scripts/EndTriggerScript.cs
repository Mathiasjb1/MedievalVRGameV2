using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTriggerScript : MonoBehaviour
{
    public SceneLoader EndTrigger;

    // När spelaren triggar detta objekt så körs "EndScene" metoden i "SceneLoader" scriptet.
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            EndTrigger.EndScene();
        }

    }
}
