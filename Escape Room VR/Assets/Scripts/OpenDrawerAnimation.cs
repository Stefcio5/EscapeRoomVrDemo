using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class OpenDrawerAnimation : MonoBehaviour
{
    
    public HoverButton hoverButton;

    public Animator drawerAnimator;
    // Start is called before the first frame update
    void Start()
    {
        //hoverButton.onButtonDown.AddListener(OnButtonDown);
    }

    public void StartAnimation()
    {
        drawerAnimator.SetBool("ButtonClicked", true);
    }
    private void OnButtonDown(Hand hand)
    {
        drawerAnimator.SetBool("ButtonClicked", true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
