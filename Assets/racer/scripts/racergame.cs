using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class racergame : MonoBehaviour
{
    public float speed;
    public GameObject player1;
    public GameObject player2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    if (transform.localPosition.x <= 48.64f) 
       { transform.Translate(1 * speed * Time.deltaTime, 0, 0);
            Debug.Log(transform.localPosition.x);
        }

           
    }

 
}



