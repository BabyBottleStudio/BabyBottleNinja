using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffAfterSec : MonoBehaviour
{
    public float time;

    // Start is called before the first frame update

    private void OnEnable()
    {
        StartCoroutine(TurnOff());
    }

    void Start()
    {
        StartCoroutine(TurnOff());
    }


    IEnumerator TurnOff()
    {
        yield return new WaitForSeconds(time);
        gameObject.SetActive(false);

     
    }
}
