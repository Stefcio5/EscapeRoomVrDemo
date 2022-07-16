using UnityEngine;

public class Elixir : MonoBehaviour
{
    public static int PotionNumber = 0;
    public GameObject CorrectPotion;
    public GameObject PotionTrigger;

    public GameObject PotionHolder;


    private Animator PotionAnimator;

    void Start()
    {
        PotionAnimator = GameObject.Find("Potion Animator").GetComponent<Animator>();
        
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
                GameObject.Find("Clock").GetComponent<SpellManager>().MoveSpellUnlocked = true;
                StartCoroutine(GameManager.Instance.ShowSpellPage(GameManager.Instance.Spell3Page));
                
            }

            if (PotionNumber == 6)
            {
                GameObject.Find("Bird").GetComponent<Animator>().enabled = true;
            }
        }
    }
    

    private void PlayAnimation()
    {

        PotionAnimator.enabled = true;
    }
}