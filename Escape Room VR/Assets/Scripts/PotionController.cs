using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionController : MonoBehaviour
{

    public GameObject[] potions;
    public bool PotionPuzzleFinished = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void CheckPotions()
    {
        foreach (var potion in potions)
        {
            if (potion.GetComponent<Potion>().InCorrectSlot)
            {
                PotionPuzzleFinished = true;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
