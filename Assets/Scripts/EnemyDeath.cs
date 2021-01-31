using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public float time = 3f;
    public GameObject deathParticles;
    public GameObject pirate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    // Umrite neprijatelji

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Katana") 
        {
            //Destroy(gameObject);
            pirate.SetActive(false);
            deathParticles.SetActive(true);
            gameObject.GetComponent<Collider>().enabled = false;
        }
    }

    IEnumerator TurnOff()
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);


    }
}
