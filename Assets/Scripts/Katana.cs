using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Katana : MonoBehaviour
{


    public GameObject katana;
    public float speed = 0.35f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
            
            
            //Debug.Log ("A key was pressed");
        }

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.localScale = new Vector3(1f, 1f, 1f);

            //Debug.Log("D key was pressed");
        }


        if (Input.GetButton("Fire1") && katana.activeSelf == false)
        {
            katana.SetActive(true);

            StartCoroutine(KillKatana());
        }
    }

    IEnumerator KillKatana()
    {
        yield return new WaitForSeconds(speed);
        katana.SetActive(false);
    }




}
