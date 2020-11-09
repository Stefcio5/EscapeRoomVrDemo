using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.Extras;
using Valve.VR.InteractionSystem;


public class test : MonoBehaviour
{
    private SteamVR_LaserPointer pointer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnPointerIn(PointerEventArgs e)
    {
        Debug.Log("Pointer in");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
