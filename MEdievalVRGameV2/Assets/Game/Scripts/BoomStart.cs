using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomStart : MonoBehaviour
{
    [SerializeField]
    private Animator myAnimationController;
    [SerializeField]
    private Animator myAnimationControllerr;
    [SerializeField]
    private Animator questDoneControll;
    [SerializeField]
    GameObject _ThankMenu;
    public bool QuestCDone;

    private void Start()
    {
        QuestCDone = false;
    }
    // Om en collider med taggen "ObjectTrigger" kommmer i kontakt med detta objekt så kommer Boolen "FuseLIT" att ändras till true.
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ObjectTrigger"))
        {
            myAnimationController.SetBool("FuseLIT", true);
            myAnimationControllerr.SetBool("WallGone", true);
            questDoneControll.SetBool("QuestDone", true);
            _ThankMenu.SetActive(true);
            QuestCDone = true;

        }

    }
}
