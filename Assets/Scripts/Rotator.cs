using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour
{
	public Vector3 theAxis;
	public float speed;


	// Update is called once per frame
	void Update ()
	{
		transform.Rotate(theAxis, Time.deltaTime * speed);
		//transform.Rotate = ((Time.time, 45.0f,  45.0f), Space.Self);
	}
}
