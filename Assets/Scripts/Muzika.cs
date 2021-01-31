using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muzika : MonoBehaviour
{

    private static Muzika theMusic = null;

    private void Awake()
    {
        if (theMusic != null)
        {
            Destroy(gameObject);

        }
        else
        {
            theMusic = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
