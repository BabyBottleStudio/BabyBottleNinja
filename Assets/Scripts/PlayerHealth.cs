using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    public int lives = 3;
    public bool gameOver = false;
    public Text livesTXT;

    public GameObject gameOverCanvas;

    public GameObject GameOverFade;

    public bool gameWon = false;

    public GameObject playerMesh;
    public GameObject deathParticles;

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
        if (other.gameObject.tag == "Enemy")
        {
            if (lives >= 0)
            {
                lives = lives - 1;
                livesTXT.text = lives.ToString();


            }
      
            if (lives == 0 && gameWon == false)
            {

                gameOver = true;
                playerMesh.SetActive(false);
                deathParticles.SetActive(true);
                StartCoroutine(GameOverScreen());
            }
        
        
        }
    }


    IEnumerator GameOverScreen()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("GameOverScene");
    }

    IEnumerator GameWonScreen()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("GameWonScene");
    }

}
