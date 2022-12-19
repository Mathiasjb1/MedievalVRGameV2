using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateTrigger : MonoBehaviour
{
    public EventsManager GateEvent;

    // N�r en collider med taggen "Player" kommer kontakt med denna trigger s� kallas "GateOpenEvent" eventet fr�n "EventsManager".
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
