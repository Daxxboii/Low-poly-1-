using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager_obstaclespawner : MonoBehaviour
{
    //obstacles
    public GameObject obstacle;
    public float z_offset;
    private float x_offset;
    private Vector3 pos;
    private GameObject obstacles;
    private Vector3 scale;


    //coins
    public GameObject coin;
    public float coin_y_offset;



    void Start()
    {
        Spawn_obstacle();
        Spawn_coin();
    }



    void Randomize()
    {
        x_offset = Random.Range(-0.8f, 0.8f);
    }

    void Scaling()
    {
        scale.y = Random.Range(0.5f, 1f);
        scale.x = 0.15f;
        scale.z = transform.localScale.z;
    }

    void Spawn_obstacle()
    {
        Randomize();
        pos = transform.position;
        pos.x = x_offset;
        pos.y = z_offset;
        obstacles = Instantiate(obstacle, pos, transform.rotation);

        Scaling();
        obstacles.transform.SetParent(this.gameObject.transform);
        obstacles.transform.localScale = scale;
    }

    void Spawn_coin()
    {
        Randomize_coins();
    }

    void Randomize_coins()
    {
        if(Random.Range(0,1) < 0.3)
        {
            x_offset = Random.Range(-0.5f, 0.5f);
            pos.x = x_offset;
            pos.y = coin_y_offset;
            pos.z = transform.position.z + 0.5f;
           var coins =  Instantiate(coin,pos, transform.rotation);
            coins.transform.SetParent(this.gameObject.transform);
        }
    }

}
