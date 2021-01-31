using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonsToggle : MonoBehaviour
{
    public GameObject cage;
    public GameObject[] buttons;

    public GameObject BtnAParticle1;
    public GameObject BtnAParticle2;

    public GameObject BtnBParticle1;
    public GameObject BtnBParticle2;

    public GameObject cageParticle;
    public GameObject honourReady;


    public Material matB;
    public Material matA;


    public GameObject player;
    private bool moveCage;
    private int score;

    public Slider slider;
    //private int slidervalue;

    public Collider honour;
    public bool gameWon = false;


    public GameObject leftHand;
    public GameObject rightHand;
    public GameObject freeHonourText;


    // Start is called before the first frame update
    void Start()
    {
        matA.color = Color.red;
        matB.color = Color.green;
        StartCoroutine(TurnOnRightHand());
    }

    // Update is called once per frame
    void Update()
    {
        if (moveCage == true)
        {
            cage.transform.position = new Vector3(0f, cage.transform.position.y - 2, 4f);
            score = score + 1;
            cageParticle.SetActive(false);
            cageParticle.SetActive(true);
            slider.GetComponent<Slider>().value = score;

            if (score == 6)
            {
                honour.enabled = true;
                honourReady.SetActive(true);
               // gameWon = true;
                transform.GetComponent<PlayerHealth>().gameWon = true;
                buttons[0].GetComponent<ButtonReady>().ready = false;
                matA.color = Color.red;
                buttons[1].GetComponent<ButtonReady>().ready = false;
                matB.color = Color.red;

                freeHonourText.SetActive(true);

            }
        }

        moveCage = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Button")
        {
            if (other.gameObject.name == "ButtonA" && other.gameObject.GetComponent<ButtonReady>().ready == true)
            {
                buttons[0].GetComponent<ButtonReady>().ready = false;
                matA.color = Color.red;
                buttons[1].GetComponent<ButtonReady>().ready = true;
                matB.color = Color.green;
                BtnAParticle1.SetActive(false);
                BtnAParticle2.SetActive(true);
                BtnBParticle1.SetActive(true);
                BtnBParticle2.SetActive(false);

  
                rightHand.SetActive(true);

                moveCage = true;
               // cage.transform.position = new Vector3(0f, Mathf.Lerp(cage.transform.position.y, cage.transform.position.y - 1, 0f), 0f); 


            }


            if (other.gameObject.name == "ButtonB" && other.gameObject.GetComponent<ButtonReady>().ready == true)
            {

                buttons[0].GetComponent<ButtonReady>().ready = true;
                matA.color = Color.green;
                buttons[1].GetComponent<ButtonReady>().ready = false;
                matB.color = Color.red;

                BtnBParticle1.SetActive(false);
                BtnBParticle2.SetActive(true);
                BtnAParticle1.SetActive(true);
                BtnAParticle2.SetActive(false);

                leftHand.SetActive(true);

                moveCage = true;
                // cage.transform.position = new Vector3(0f, Mathf.Lerp(cage.transform.position.y, cage.transform.position.y - 1, 0f), 0f);
            }

        }
    }

    IEnumerator TurnOnRightHand()
    {
        yield return new WaitForSeconds(0.5f);
        rightHand.SetActive(true);


    }


}
