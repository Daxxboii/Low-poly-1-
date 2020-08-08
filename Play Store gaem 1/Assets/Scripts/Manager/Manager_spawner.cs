using UnityEngine;

public class Manager_spawner : MonoBehaviour
{
    private float offset = 2f;
    private float _offset;
    public float Render_distance = 100f;
    public Transform scene_base;
    public GameObject base_model;

    private Vector3 spawn_location;

    private void Awake()
    {
        _offset = offset;
      
    }
    void Update()
    {
        spawn_location = new Vector3(0f, 0f, offset);
        if (Render_distance != 0f)
        {
            var Base = Instantiate(base_model,spawn_location,base_model.transform.rotation);
            Base.transform.SetParent(scene_base);
            offset += _offset;
            Render_distance++;
        }
    }
}
