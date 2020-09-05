using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager_script : MonoBehaviour
{
    public Material emission;
    private Color color;
    public float speed = 1f;
    private float limiter;

    private void Awake()
    {
        limiter = 0f;
        color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }
    void Update()
    {

       if (limiter <= 1)
       {
               emission.color = Color.Lerp(emission.color, color, limiter);
               //  emission.SetColor("_EmissionColor", Color.Lerp(emission.color, color, timer * Time.deltaTime));
               limiter += Time.deltaTime /speed;
       }
       else
       {
             color = Random.ColorHSV(0f, 1f, 1f, 1f, 1f, 1f);
               limiter = 0;
       }
       
    }
}
