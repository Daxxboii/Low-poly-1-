using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Player_movement : MonoBehaviour
{
    public float units_per_second;
    private Rigidbody player_rb;
    public float y_offset;

    public float sensitivity = 1f;
    private Touch touch;
    private Vector3 correction;
    //test
   // public TextMeshProUGUI tmp;
 

    private void Awake()
    {
        player_rb = this.gameObject.transform.GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        GetTouch();
        Move();
        Testing();
       
       // Debug.Log(Screen.width);
       
    }
    void GetTouch()
    {
        
        if (Input.touchCount > 0)
        {
             touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * sensitivity,transform.position.y,transform.position.z);

                correction = transform.position;
                correction.x = Mathf.Clamp(transform.position.x, -0.8f, 0.8f);

                transform.position = correction;
            }

        }
    }

      void Move()
    {
        //forward
        player_rb.velocity = new Vector3(0f, 0f, units_per_second);

    }

    void Testing()
    {
       // tmp.text = touch.deltaPosition.x.ToString();
    }
}

