using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class PlayerControlls : MonoBehaviour
{

	public float speed;
	public float jump;
	private Rigidbody rb;

	void Start()
	{

		  rb = GetComponent<Rigidbody>();


	}

	void Update()
	{
		float xMov = Input.GetAxisRaw("Horizontal");

		transform.position += new Vector3(xMov, 0f, 0f).normalized * speed * Time.deltaTime;
	}


    private void FixedUpdate()
    {
		if (Input.GetKey(KeyCode.Space)) {

			rb.AddForce(0f, jump, 0f);

		}



	}
}
