using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;
using Valve.VR.InteractionSystem.Sample;

public class MoveObject : MonoBehaviour
{

    [SerializeField] private Animator animator;
    
    public bool objectMoved;

    private Interactable interactable;

    void Awake()
    {
        objectMoved = false;
        interactable = this.GetComponent<Interactable>();
    }
    

    private void OnHandHoverBegin(Hand hand)
    {
        if (objectMoved == false)
        {
            animator.SetBool("PlayMovingAnimation", true);
            objectMoved = true;
            animator.SetBool("PlayReverseMovingAnimation", false);
        }
        else
        {
            animator.SetBool("PlayReverseMovingAnimation", true);
            animator.SetBool("PlayMovingAnimation", false);
            objectMoved = false;
        }
        
    }
    private void OnHandHoverEnd(Hand hand)
    {
        //animator.SetBool("PlayMovingAnimation", false);
    }
    private void HandHoverUpdate(Hand hand )
    {
        
    }
}
