﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR.Extras;

public class SceneHandler : MonoBehaviour
{
   public SteamVR_LaserPointer laserPointer;
   
       void Awake()
       {
           laserPointer.PointerIn += PointerInside;
           laserPointer.PointerOut += PointerOutside;
           laserPointer.PointerClick += PointerClick;
       }
   
       public void PointerClick(object sender, PointerEventArgs e)
       {
           if (e.target.name == "Cube")
           {
               Debug.Log("Cube was clicked");
           } else if (e.target.name == "PlayButton")
           {
               Debug.Log("Play Button was clicked");
               SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
           }
           else if (e.target.name == "QuitButton")
           {
               Debug.Log("Quit Button was clicked");
               Application.Quit();
           }
       }
   
       public void PointerInside(object sender, PointerEventArgs e)
       {
           if (e.target.name == "Cube")
           {
               Debug.Log("Cube was entered");
           }
           else if (e.target.name == "Button")
           {
               Debug.Log("Button was entered");
           }
       }
   
       public void PointerOutside(object sender, PointerEventArgs e)
       {
           if (e.target.name == "Cube")
           {
               Debug.Log("Cube was exited");
           }
           else if (e.target.name == "Button")
           {
               Debug.Log("Button was exited");
           }
       }
}
