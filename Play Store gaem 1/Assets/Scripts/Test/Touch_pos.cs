using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Touch_pos : MonoBehaviour
{
    public TextMeshProUGUI tmp;
    Vector2 position;
    Touch touch;
    Vector2 initpos;
    Vector2 dist;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {

                initpos = touch.position;

            }
            if (touch.phase == TouchPhase.Moved)
            {
                position = touch.position;
                tmp.text = "Touch Position : " + position;

            }
            if (touch.phase == TouchPhase.Ended)
            {
                position = touch.position;
                tmp.text = "Touch Position : " + position;

            }
            dist = position - initpos;
            touch = new Touch();

        }
        
    }
}
