using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GramofonController : MonoBehaviour
{
    private Animator Animator;

    private string currentState;
    public GameObject Szafka;
    
    
    //Animation States
    private const string GRAMOFON_BROKEN = "Gramofon zepsuty";
    private const string GRAMOFON_NEEDLE = "Gramofon igla";
    private const string GRAMOFON_WORKING_START = "Gramofon dzialajacy start";
    private const string GRAMOFON_WORKING_LOOP = "Gramofon dzialajacy loop";

    public AudioSource WorkingSound;
    public AudioSource BrokenSound;

    // Start is called before the first frame update
    void Start()
    {
        Animator = GetComponent<Animator>();
    }

    void ChangeAnimationState(string newState)
    {
        if (currentState == newState) return;
        
        Animator.Play(newState);

        currentState = newState;


    }

    public void OnNeedleHover()
    {
        ChangeAnimationState(GRAMOFON_NEEDLE);
        BrokenSound.enabled = false;
        
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Animator.GetCurrentAnimatorStateInfo(0).IsName(GRAMOFON_WORKING_START))
        {
            
            //Debug.Log("Muzyka");
            WorkingSound.enabled = true;
            Szafka.GetComponent<OpenDrawerAnimation>().StartAnimation();
        }
    }
}
