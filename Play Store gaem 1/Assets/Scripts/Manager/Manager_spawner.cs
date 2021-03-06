﻿using UnityEngine;
using System.Collections;
public class Manager_spawner : MonoBehaviour
{
    private float offset = 2f;
    private float _offset;
    public float Render_distance = 100f;
    public Transform scene_base;
    public GameObject base_model;

    private GameObject player;
    private Vector3 playerpos;
    private Vector3 basepos;
    private float dist;

    private Vector3 spawn_location;

    private void Awake()
    {
        _offset = offset;
        player = GameObject.FindWithTag("Player");
      
    }
    void Update()
    {

        playerpos = player.transform.position;


        spawn_location = new Vector3(0f, 0f, offset);
        if (Render_distance != 0f)
        {
            var Base = Instantiate(base_model,spawn_location,base_model.transform.rotation);
            StartCoroutine(wait());
            basepos = Base.transform.position;
            Base.transform.SetParent(scene_base);
            offset += _offset;
            Render_distance--;
        }
        dist = Vector3.Distance(playerpos, basepos);

        if (dist < 10f)
        {
            Render_distance = 100f;
        }
    }

IEnumerator wait()
    {
        yield return new WaitForSeconds(10);
    }
}
