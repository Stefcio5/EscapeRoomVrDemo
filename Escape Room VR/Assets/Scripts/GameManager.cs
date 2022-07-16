using System.Collections;
using TMPro;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public GameObject Drawer;

    public GameObject Spells;

    public GameObject Spell1Page;

    public GameObject Spell2Page;

    public GameObject Spell3Page;

    public GameObject EndScreen;

    public GameObject EndScreenTime;
    public GameObject EndGameDoors;
    public GameObject EndGameTeleport;
    public GameObject BookLight;

    public float time = 0f;

    public bool isGameFinished = false;
    public static GameManager Instance;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    // Disable drawer animator after picking up wand
    public void DisableAnimator()
    {
        var animator = Drawer.GetComponent<Animator>();
        animator.enabled = false;

    }

    public void SpellEnabler()
    {
        var spells = Spells.GetComponent<Sample_OneHanded>();
        spells.enabled = true;
    }

    public void SpellDisabler()
    {
        var spells = Spells.GetComponent<Sample_OneHanded>();
        spells.enabled = false;
    }

    public IEnumerator ShowSpellPage(GameObject spellPage)
    {
        spellPage.gameObject.SetActive(true);
        BookLight.SetActive(true);
        yield return new WaitForSeconds(5);
        BookLight.SetActive(false);
    }
    public void ShowFirstSpellPage()
    {
        if (!Spell1Page.gameObject.activeSelf)
        {
            StartCoroutine(ShowSpellPage(Spell1Page));
        }
    }

    void Update()
    {
        if (!isGameFinished)
        {
            time += Time.deltaTime;
        }
    }

    public void EndGame()
    {
        isGameFinished = true;
        EndGameDoors.GetComponent<Animator>().Play("EndGameDoorAnimation");
        EndScreen.SetActive(true);
        EndGameTeleport.gameObject.SetActive(true);
        EndScreenTime.GetComponent<TextMeshProUGUI>().SetText("Your time: " + (time).ToString("0"));
    }
}
