using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonKnightTrigger : MonoBehaviour
{
    [SerializeField]
    private Animator myAnimationController;

    [SerializeField]
    GameObject _TextMenu;

    // Om spelaren kommer med kontakt med denna trigger s� s�tts Boolen "PlayerTrigger" till true.
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimationController.SetBool("PlayerTrigger", true);
            _TextMenu.SetActive(true);
        }

    }

    // Om spelaren l�mnar triggern s� blir v�rdet false.
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimationController.SetBool("PlayerTrigger", false);
            myAnimationController.SetBool("FirstContact", false);
        }

    }

}
