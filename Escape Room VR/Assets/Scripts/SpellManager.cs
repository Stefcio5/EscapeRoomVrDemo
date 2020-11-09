using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class SpellManager : MonoBehaviour
{
    // Levitation
    public float minimum = 0F;
    public float maximum = 2.0F;
    public float speed = 0.5f;
    public bool isLevitating = false;
    static float t = 0.0f;
    public float startingx, startingy, startingz;
    public float endingy;

    //

    void Start()
    {
        startingx = transform.position.x;
        startingy = transform.position.y;
        startingz = transform.position.z;
        endingy = startingy + 2F;


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

    // Update is called once per frame
        void Update()
        {

            if (isLevitating)
            {
                Levitation();
            }

        }
    }

