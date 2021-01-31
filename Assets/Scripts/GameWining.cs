using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWining : MonoBehaviour
{

    public GameObject honourReceivedParticle;
    public GameObject star;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Gotova igra");
            other.GetComponent<PlayerHealth>().gameWon = true;
            StartCoroutine(GameWonScreen());
            honourReceivedParticle.SetActive(true);
            //other.gameObject.GetComponent<Collider>().enabled = false;
            star.SetActive(false);

        }
    }



    IEnumerator GameWonScreen()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("WinGameScene");
    }
}
