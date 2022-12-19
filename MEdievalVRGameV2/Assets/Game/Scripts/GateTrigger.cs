using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateTrigger : MonoBehaviour
{
    public EventsManager GateEvent;

    // När en collider med taggen "Player" kommer kontakt med denna trigger så kallas "GateOpenEvent" eventet från "EventsManager".
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GateEvent.GateOpenEvent();
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GateEvent.GateCloseEvent();
        }

    }
}
