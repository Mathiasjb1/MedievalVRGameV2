using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampfireTrigger : MonoBehaviour
{
    [SerializeField]
    private Animator myAnimationController;
    public string newTag;
    public GameObject Torch;

    // Om en collider med taggen "TorchFire" kommer i kontakt med denna trigger så ändras animator Boolen "Fire" till true.
    // Och Objektets tag ändras till den nya taggen.
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TorchFire"))
        {
            myAnimationController.SetBool("Fire", true);
            Torch.tag = newTag;

        }

    }
}
