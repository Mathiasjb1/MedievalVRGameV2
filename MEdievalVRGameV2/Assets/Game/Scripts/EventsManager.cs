using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventsManager : MonoBehaviour
{
    [SerializeField]
    private Animator myAnimationController;

    [SerializeField]
    private Animator SwordKnightController;

    [SerializeField]
    private Animator CannonKnightController;

    // När eventet "GateOpenEvent" kallas så sätts animator Boolen "GateOpen" till true.
    public void GateOpenEvent()
    {
        myAnimationController.SetBool("GateOpen", true);
        Debug.Log("The Gate Opens for the Worthy");
    }

    public void GateCloseEvent()
    {
        myAnimationController.SetBool("GateOpen", false);
    }

    public void SwordQDone()
    {
        SwordKnightController.SetBool("QuestDone", true);
    }

    public void CannonQDone()
    {
        CannonKnightController.SetBool("QuestDone", true);
    }
 
}
