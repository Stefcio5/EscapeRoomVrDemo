using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eliksir : MonoBehaviour
{
    public GameObject CorrectPotion;
    public GameObject PotionTrigger;

    public GameObject PotionHolder;

    public static int PotionNumber = 0;

    private Animator PotionAnimator;

    private GameManager gamemanager;
    // Start is called before the first frame update
    void Start()
    {
        PotionAnimator = GameObject.Find("eliksiry animacja").GetComponent<Animator>();
        gamemanager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == PotionTrigger.name)
        {
            Debug.Log("Correct Potion");
            Destroy(CorrectPotion);
            PotionHolder.SetActive(true);
            PotionNumber++;
            Debug.Log(PotionNumber);
            if (PotionNumber == 5)
            {
                PlayAnimation();
                gamemanager.ShowSpellPage(gamemanager.Spell3Page);
            }

            if (PotionNumber == 6)
            {
                GameObject.Find("ptak").GetComponent<Animator>().enabled = true;
                
            }
            
            

        }
    }

    private void PlayAnimation()
    {
        //Play Anim
        PotionAnimator.enabled = true;
        
        
        // aktywyje zaklecie przeuswania
        GameObject.Find("Clock").GetComponent<SpellManager>().MoveSpellUnlocked = true;
    }
}
