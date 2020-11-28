using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
 

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

    public bool isGameFinished;
    // Start is called before the first frame update
    void Start()
    {
        isGameFinished = false;
        
    }
// Wyłącza Animator szafki po podniesieniu różdzki
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

    public void ShowSpellPage(GameObject spellPage)
    {
        spellPage.gameObject.SetActive(true);
        BookLight.SetActive(true);
    }

    // Update is called once per frame
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
        // ekran koncowy
        Debug.Log("Ekran koncowy");
        EndScreen.SetActive(true);
        EndGameTeleport.gameObject.SetActive(true);
        EndScreenTime.GetComponent<TextMeshPro>().SetText("Your time: " + (time).ToString("0"));
    }
}
