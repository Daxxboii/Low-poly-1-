using UnityEngine;

public class Manager_spawner : MonoBehaviour
{
    public float offset = 2f;
    public float Render_distance = 100f;
    public GameObject scene_base;
    public GameObject base_model;

    private Vector3 spawn_location;

    private void Awake()
    {
        
      
    }
    void Update()
    {
        if (Render_distance == 0f)
        {
            spawn_location = new Vector3(0f, 0f, offset);
        }
    }
}
