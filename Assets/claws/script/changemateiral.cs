using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changemateiral : MonoBehaviour
{
    public Material transparent;
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
       if (transform.name == "material")
        {
            GetComponent<Renderer>().material = transparent;
        }
         
    }
}
