using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour
{
    public float units_per_second;
    private Rigidbody player_rb;


    private void Awake()
    {
        player_rb = this.gameObject.transform.GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        player_rb.velocity = new Vector3(0f, 0f, units_per_second);
       // Debug.Log(Screen.width);

    }
}
