using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseScript : MonoBehaviour
{
    [SerializeField]
    private Animator SwordKnightController;

    [SerializeField]
    private Animator CannonKnightController;

    [SerializeField]
    GameObject _TableGlow;

    [SerializeField]
    GameObject _Menu1;

    [SerializeField]
    GameObject _Menu2;

    [SerializeField]
    GameObject _DeathSound;

    [SerializeField]
    GameObject _DeathSound1;

    
    public void PYesSword()
    {
        SwordKnightController.SetBool("PlayerYES", true);
        SwordKnightController.SetBool("FirstContact", false);
        _TableGlow.SetActive(true);
        _Menu1.SetActive(false);

    }

    public void PNoSword()
    {
        SwordKnightController.SetBool("PlayerNo", true);
        _DeathSound.SetActive(true);
        _Menu1.SetActive(false);
    }

    public void PYesCannon()
    {
        CannonKnightController.SetBool("PlayerYES", true);
        CannonKnightController.SetBool("FirstContact", false);
        _Menu2.SetActive(false);
    }

    public void PNoCannon()
    {
        CannonKnightController.SetBool("PlayerNo", true);
        _DeathSound1.SetActive(true);
        _Menu2.SetActive(false);
    }

}
