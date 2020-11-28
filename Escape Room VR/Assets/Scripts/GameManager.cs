using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class GameManager : MonoBehaviour
{
    public GameObject Drawer;

    public GameObject Spells;
    // Start is called before the first frame update
    void Start()
    {
        
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

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EndGame()
    {
        // ekran koncowy
        Debug.Log("Ekran koncowy");
    }
}
