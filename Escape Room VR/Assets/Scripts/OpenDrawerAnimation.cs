using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class OpenDrawerAnimation : MonoBehaviour
{
    
    public HoverButton hoverButton;

    private Animator drawerAnimator;
    

    private string currentState;
    
    //Animation States
    private const string DRAWER_ANIMATION = "Otwieranie";
    
    // Start is called before the first frame update
    void Start()
    {
        //hoverButton.onButtonDown.AddListener(OnButtonDown);
        drawerAnimator = GetComponent<Animator>();
    }

    public void StartAnimation()
    {
        //drawerAnimator.SetBool("ButtonClicked", true);
        //ChangeAnimationState(DRAWER_ANIMATION);
        drawerAnimator.enabled = true;
    }
    private void OnButtonDown(Hand hand)
    {
        drawerAnimator.SetBool("ButtonClicked", true);
    }
    void ChangeAnimationState(string newState)
    {
        if (currentState == newState) return;
        
        drawerAnimator.Play(newState);

        currentState = newState;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
