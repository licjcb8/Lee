using UnityEngine;
using System.Collections;

public class DynmicAxis : MonoBehaviour
{
    public float m_fSpeed = 10.0F;
    public float m_fRotSpeed = 100.0F;

    void Update()
    {
        float fVertical = Input.GetAxis("Vertical");
        float fHorizontal = Input.GetAxis("Horizontal");

        if (Mathf.Abs(fVertical) > 0 || Mathf.Abs(fHorizontal) > 0)
        {
            float fTranslation = fVertical * m_fSpeed;
            float fRotation = fHorizontal * m_fRotSpeed;
            fTranslation *= Time.deltaTime;
            fRotation *= Time.deltaTime;
            transform.Translate(0, 0, fTranslation);
            transform.Rotate(0, fRotation, 0);
        }

        GUI.Box(new Rect(0, 0, 300, 100),
                "Vertical:" + fVertical +
                "\nHorizontal:" + fHorizontal);
        //float translation = Input.GetAxis("Vertical") * speed;
        //float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        //translation *= Time.deltaTime;
        //rotation *= Time.deltaTime;
        //transform.Translate(0, 0, translation);
        //transform.Rotate(0, rotation, 0);
    }

    private void OnGUI()
    {
        
    }
}