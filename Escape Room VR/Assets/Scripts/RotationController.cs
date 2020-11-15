using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour {

    public int xrotation, yrotation, zrotation;
    public bool isRotating = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (isRotating)
        {
            transform.Rotate(new Vector3(xrotation, yrotation, zrotation)*Time.deltaTime);

        }
		
	}
}
