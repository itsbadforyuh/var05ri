using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject arrow;
    public float shootSpeed = 10.0f;

    private bool isShooting = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isShooting)
        {
            isShooting = true;

            Vector3 direction = -arrow.transform.forward;
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.velocity = direction * shootSpeed;
        }
    }
}
