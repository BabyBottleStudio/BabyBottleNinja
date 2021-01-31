using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TranslateFixed : MonoBehaviour
{
   // public float _moveSpeed = 2f;
    private float randomSpeed;
    public float[] randomSpeedMinMax;
    private void Start()
    {
       randomSpeed =  Random.Range(randomSpeedMinMax[0], randomSpeedMinMax[1]);
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * randomSpeed * Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Edges")
        {
           //  Debug.Log("jeeej");
           // transform.localScale = new Vector3 (transform.localScale.x *-1, transform.localScale.y, transform.localScale.z);
        
        }
    }
}
