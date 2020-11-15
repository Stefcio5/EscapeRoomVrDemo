using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class PotionSlot : MonoBehaviour
{

    public GameObject CorrectPotion;
    public bool isInCorrectSlot = false;
    public bool isPuzzleFinished = false;
    
    public PotionSlot[] potionSlots;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == CorrectPotion)
        {
            Debug.Log("Triggered");
            //other.GetComponent<Rigidbody>().isKinematic = true;
            //other.GetComponent<Interactable>().enabled = false;
            //other.transform.position = potionPosition;
            isInCorrectSlot = true;
            CheckPotions();
        }
    }
    public int CheckPotions()
    {

        foreach (var potionSlot in potionSlots)
        {
            if (potionSlot.isInCorrectSlot == false)
            {
                return 0;

            }
        }

        isPuzzleFinished = true;
        if (isPuzzleFinished)
        {
            Debug.Log("Puzzle Finnished");
        }
        return 1;
    }
    

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


