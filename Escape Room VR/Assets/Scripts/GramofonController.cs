using UnityEngine;

public class GramofonController : MonoBehaviour
{
    private Animator Animator;

    private string currentState;
    public GameObject Drawer;


    //Animation States
    private const string GRAMOFON_BROKEN = "Gramophone Broken";
    private const string GRAMOFON_NEEDLE = "Gramophone Needle";
    private const string GRAMOFON_WORKING_START = "Gramophone Working Start";
    private const string GRAMOFON_WORKING_LOOP = "Gramophone Working Loop";

    public AudioSource WorkingSound;
    public AudioSource BrokenSound;

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

    void Update()
    {
        if (Animator.GetCurrentAnimatorStateInfo(0).IsName(GRAMOFON_WORKING_START))
        {
            WorkingSound.enabled = true;
            Drawer.GetComponent<OpenDrawerAnimation>().StartAnimation();
        }
    }
}
