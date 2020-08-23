using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Touch_pos : MonoBehaviour
{
    public TextMeshProUGUI txt;
    private Rigidbody player_rb;

    private Vector2 finalpos;
    private Vector2 initpos;
    private float dist;

   
 

    private Vector3 playerpos;

    private void Awake()
    {
        player_rb = this.gameObject.transform.GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        GetTouch();
      

        // Debug.Log(Screen.width);

    }
    void GetTouch()
    {
       
          
            if (Input.GetMouseButtonDown(0))
            {
             
           

            }
            if (Input.GetMouseButton(0))
            {
               finalpos = Input.mousePosition;
              
            }
            if (Input.GetMouseButtonUp(0))
            {
               
             
               
            }
          
            dist = finalpos.x - initpos.x;
            Move();
            

 
    }

    void Move()
    {
     
   
            txt.text = finalpos.x.ToString();
      
    }

}

