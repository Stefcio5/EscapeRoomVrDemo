using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    [Header("Orbit")]
    public float xSpread;
    public float zSpread;
    public float yOffset;
    public Transform centerPoint;

    public float rotSpeed;
    public bool rotateClockwise;
    public bool orbit = false;

    private float timer = 0;
    
    [Header("Moving")] 
    public Transform[] positions;

    public float PlanetMovingSpeed;

    private int NextPosIndex;
    private Transform NextPos;
    public bool PlanetMoving = false;

    [Header("Shrinking")] 
    public Vector3 minScale;

    public float speed = 0.05f;
    public bool Shrinking;
    public float ShrinkingTime = 0f;
    
    
    
    // Start is called before the first frame update
    void Start()
    {

        NextPos = positions[0];
        minScale = (transform.localScale / 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlanetMoving)
        {
            MovePlanet();
        }
        rotSpeed = 0.5f / xSpread;
        if (orbit)
        {
            timer += Time.deltaTime * rotSpeed;
            if (timer >= 360f)
            {
                timer = 0;
            }
            Rotate();
            //transform.LookAt(centerPoint);
        }

        if (Shrinking)
        {
            ShrinkPlanet();
        }
    }

    void Rotate()
    {
        if (rotateClockwise)
        {
            float x = -Mathf.Cos(timer) * xSpread;
            float z = Mathf.Sin(timer) * zSpread;
            Vector3 pos = new Vector3(x, yOffset, z);
            transform.position = pos + centerPoint.position;
        }
        else
        {
            float x = Mathf.Cos(timer) * xSpread;
            float z = Mathf.Sin(timer) * zSpread;
            Vector3 pos = new Vector3(x, yOffset, z);
            transform.position = pos + centerPoint.position;
        }
    }

    public void MovePlanet()
    {
        if (transform.position == NextPos.position)
        {
            NextPosIndex++;
            if (NextPosIndex >= positions.Length)
            {
                // stop moving
                PlanetMoving = false;
            }
            NextPos = positions[NextPosIndex];
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, NextPos.position, PlanetMovingSpeed * Time.deltaTime);
        }
    }

    public void ShrinkPlanet()
    {
        ShrinkingTime += speed * Time.deltaTime;

        if (transform.localScale != minScale)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, minScale, ShrinkingTime);
        }
        else
        {
            Shrinking = false;
        }
    }
}
