using UnityEngine;

public class RotationController : MonoBehaviour
{

    public int xrotation, yrotation, zrotation;
    public bool isRotating = true;

    void Update()
    {
        if (isRotating)
        {
            transform.Rotate(new Vector3(xrotation, yrotation, zrotation) * Time.deltaTime);
        }
    }
}
