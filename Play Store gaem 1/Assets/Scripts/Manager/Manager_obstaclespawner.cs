using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager_obstaclespawner : MonoBehaviour
{
    public GameObject obstacle;
   

    public float z_offset;
    private float x_offset;
    private Vector3 pos;
    private GameObject obstacles;
    private Vector3 scale;




    void Start()
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
}
