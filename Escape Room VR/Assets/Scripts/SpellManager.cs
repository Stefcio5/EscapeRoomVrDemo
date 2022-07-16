using UnityEngine;

public class SpellManager : MonoBehaviour
{
    static float t = 0.0f;

    [Header("Levitation")]

    public float minimum = 0F;

    public float maximum = 2.0F;
    public float speed = 0.5f;
    public bool isLevitating = false;
    public float startingx, startingy, startingz;
    public float endingx, endingy, endingz;


    [Header("MoveSpell")]
    public bool ActivateMoveSpell = false;
    public bool MoveSpellUnlocked = false;
    public bool hasMoved = false;

    [Header("Lights")] public GameObject lights;

    public GameObject potionReceipt;

    public bool lightSpellUnlocked = false;

    void Start()
    {
        startingx = transform.localPosition.x;
        startingy = transform.localPosition.y;
        startingz = transform.localPosition.z;
        endingy = startingy + 2F;


    }

    void FixedUpdate()
    {
        if (isLevitating)
        {
            Levitation();
        }

        if (MoveSpellUnlocked && ActivateMoveSpell)
        {
            MoveSpell();
        }
    }

    public void Levitation()
    {
        transform.position = new Vector3(startingx, Mathf.Lerp(startingy, endingy, t), startingz);
        t += speed * Time.deltaTime;
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
            potionReceipt.gameObject.SetActive(true);
        }
        else
        {
            lights.SetActive(true);
            potionReceipt.gameObject.SetActive(false);
        }
    }

    public void MoveSpell()
    {
        transform.localPosition = new Vector3(Mathf.Lerp(startingx, endingx, t), startingy, startingz);
        t += speed * Time.deltaTime;
        if (t > 1.0f)
        {
            hasMoved = true;
            float temp = endingx;
            endingx = startingx;
            startingx = temp;
            ActivateMoveSpell = false;
            t = 0f;

        }
    }
}