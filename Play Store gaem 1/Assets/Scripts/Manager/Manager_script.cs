using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager_script : MonoBehaviour
{
    public Material emission;
  
   
    public void Update()
    {
        emission.SetColor("_EmissionColor", Random.ColorHSV(0f, 360f,98f,100f,98f,100f));
  
    }
}
