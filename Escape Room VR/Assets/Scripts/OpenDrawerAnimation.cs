using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class OpenDrawerAnimation : MonoBehaviour
{
    
    public HoverButton hoverButton;

    public Animator drawerAnimation;
    // Start is called before the first frame update
    void Start()
    {
        hoverButton.onButtonDown.AddListener(OnButtonDown);
    }

    private void OnButtonDown(Hand hand)
    {
        throw new System.NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
