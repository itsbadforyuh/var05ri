using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawGrabManager : MonoBehaviour
{

    public Transform clawGrab;

    bool isGrab = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {

        Debug.Log("clicked");

        if (transform.name == "Forward_b")
        {
            Debug.Log("f");
            //if (clowGrab.position.z >= 10) return;
            clawGrab.Translate(new Vector3(0, 0, 0.05f));
        }
        if (transform.name == "Backward_b")
        {
            Debug.Log("f");
            clawGrab.Translate(new Vector3(0, 0, -0.05f));
        }
        if (transform.name == "Up_b")
        {
            Debug.Log("f");
            clawGrab.Translate(new Vector3(0, 0.05f, 0));
        }
        if (transform.name == "Right_b")
        {
            Debug.Log("f");
            clawGrab.Translate(new Vector3(0.05f, 0, 0));
        }
        if (transform.name == "Left_b")
        {
            Debug.Log("f");
            clawGrab.Translate(new Vector3(-0.05f, 0, 0));
        
      
        }

        if (transform.name == "Down")
        {
            Debug.Log(transform.name);
            clawGrab.Translate(new Vector3(0, -0.05f, 0));
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(transform.name == "clawgrab")
        {

            // grab 
            if(other.transform.name == "Sphere"  && !isGrab)
            {
                isGrab = true;
                other.transform.parent = transform;
                other.GetComponent<Rigidbody>().isKinematic = true;
                StartCoroutine(ControlBall(other.transform));
            }

        }
    }


    IEnumerator ControlBall(Transform ball)
    {
        yield return new WaitForSeconds(7f);
        ball.transform.parent = null;
        ball.GetComponent<Rigidbody>().isKinematic = false;
        yield return new WaitForSeconds(5f);
        isGrab = false;
    }

}
