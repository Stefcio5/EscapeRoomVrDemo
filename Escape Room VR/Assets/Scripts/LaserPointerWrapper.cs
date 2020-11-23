using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR.Extras;

public class LaserPointerWrapper : MonoBehaviour
{
   public SteamVR_LaserPointer laserPointer;
   public GameObject spellManager;

   public GameObject targetObject;
   public string levitateTag = "Levitate";

   public GameObject GetTargetObject()
   {
       return targetObject;
   }
   
       void Awake()
       {
           laserPointer.PointerIn += PointerInside;
           laserPointer.PointerOut += PointerOutside;
           laserPointer.PointerClick += PointerClick;
       }
   
       public void PointerClick(object sender, PointerEventArgs e)
       {
           if (e.target.tag == "Levitate")
           {
               Debug.Log("Levitate object clicked");
               targetObject = e.target.gameObject;

               //SpellManager sp = targetObject.GetComponent<SpellManager>();
               /*if (sp.isLevitating)
               {
                   sp.isLevitating = false;
               }
               else
               {
                   sp.isLevitating = true;
               }*/
               
               

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

           if (e.target.gameObject.tag == "Levitate" || e.target.gameObject.tag == "Movable" || e.target.gameObject.tag == "Planet")
           {
               Debug.Log("Levitate object Inside");
               targetObject = e.target.gameObject;
               
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
