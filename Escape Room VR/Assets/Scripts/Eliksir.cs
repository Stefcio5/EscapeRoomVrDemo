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
    // Start is called before the first frame update
    void Start()
    {
        PotionAnimator = GameObject.Find("eliksiry animacja").GetComponent<Animator>();
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
