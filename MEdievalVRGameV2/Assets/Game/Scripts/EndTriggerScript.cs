using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTriggerScript : MonoBehaviour
{
    public SceneLoader EndTrigger;

    // N�r spelaren triggar detta objekt s� k�rs "EndScene" metoden i "SceneLoader" scriptet.
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            EndTrigger.EndScene();
        }

    }
}
