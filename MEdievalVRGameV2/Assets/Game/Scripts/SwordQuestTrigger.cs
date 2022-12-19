using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordQuestTrigger : MonoBehaviour
{

    [SerializeField]
    GameObject _ThankMenu;
    public bool QuestSDone;
    [SerializeField]
    private Animator questDoneControll;

    private void Start()
    {
        QuestSDone = false;
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("SwordTrigger"))
        {
            _ThankMenu.SetActive(true);
            QuestSDone = true;
            questDoneControll.SetBool("QuestDone", true);
        }
    }
}
