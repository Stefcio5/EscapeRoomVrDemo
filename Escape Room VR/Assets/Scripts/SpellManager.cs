using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class SpellManager : MonoBehaviour
{
    [Header("Levitation")]
    // Levitation
    public float minimum = 0F;
    public float maximum = 2.0F;
    public float speed = 0.5f;
    public bool isLevitating = false;
    static float t = 0.0f;
    public float startingx, startingy, startingz;
    public float endingx, endingy, endingz;
    

    //
    [Header("MoveSpell")] 
    public bool ActivateMoveSpell = false;

    public bool MoveSpellUnlocked = false;
    public bool hasMoved = false;

    [Header("Lights")] 
    public GameObject lights;

    public bool lightSpellUnlocked = false;

    void Start()
    {
        startingx = transform.localPosition.x;
        startingy = transform.localPosition.y;
        startingz = transform.localPosition.z;
        endingy = startingy + 2F;
        //
        
        


    }

    public void Levitation()
    {
        //var LaserPointerWrapper = GetComponent<LaserPointerWrapper>();
        //targetObject = LaserPointerWrapper.GetTargetObject();

        // animate the position of the game object...
        //transform.position = new Vector3(0, Mathf.Lerp(minimum, maximum, t), 0);
        transform.position = new Vector3(startingx, Mathf.Lerp(startingy,endingy, t), startingz);
        

        // .. and increase the t interpolater
        t += speed * Time.deltaTime;

        // now check if the interpolator has reached 1.0
        // and swap maximum and minimum so game object moves
        // in the opposite direction.
        if (t > 1.0f)
        {
            float temp = endingy;
            endingy = startingy;
            startingy = temp;
            t = 0.0f;
        }
        
    }

    public void TurnLights()
    {
        if (lights.activeSelf)
        {
            lights.SetActive(false);
        }
        else
        {
            lights.SetActive(true);
        }
        
    }

    public int MoveSpell()
    {
        if (MoveSpellUnlocked)
        {
            // has moved nie potrzebne
            if (!hasMoved)
            {
                transform.localPosition = new Vector3(Mathf.Lerp(startingx,endingx, t), startingy, startingz);
                t += speed * Time.deltaTime;
                if (t > 1.0f)
                {
                    hasMoved = true;
                    float temp = endingx;
                    endingx = startingx;
                    startingx = temp;
                    ActivateMoveSpell = false;
                    t = 0f;
                    return 0;
                }
            }
            else
            {
                transform.localPosition = new Vector3(Mathf.Lerp(startingx,endingx, t), startingy, startingz);
                t += speed * Time.deltaTime;
                if (t > 1.0f)
                {
                    hasMoved = false;
                    hasMoved = true;
                    float temp = endingx;
                    endingx = startingx;
                    startingx = temp;
                    ActivateMoveSpell = false;
                    t = 0f;
                    return 0;
                }
            }
        
        

            
        }
        return 1;
    }

    // Update is called once per frame
        void Update()
        {

            if (isLevitating)
            {
                Levitation();
                
            }

            if (ActivateMoveSpell)
            {
                MoveSpell();
            }

        }
    }

