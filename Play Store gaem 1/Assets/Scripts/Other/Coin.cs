using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float speed = 10f;
    public ParticleSystem destroy_particle;
    private Manager_saveload coin_manager;
   
  
    // Start is called before the first frame update
    void Start()
    {
      
        coin_manager = GameObject.FindWithTag("Manager").transform.GetComponent<Manager_saveload>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * speed); 
    }


    private void OnTriggerEnter(Collider other)
    
        {
            if(other.gameObject.tag == "Player")
            {
            coin_manager.coins++;
            Instantiate(destroy_particle, transform.position, transform.rotation);
            Destroy(gameObject);
            }
        }
    

}
