using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class claw : MonoBehaviour
{
    public float speed;
    public float verticalRange;
    public float horizontalRange;

    private Rigidbody rb;
    private float horizontalMovement;
    private float verticalMovement;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalMovement * horizontalRange, 0f, verticalMovement * verticalRange);
        rb.MovePosition(transform.position + movement * speed * Time.fixedDeltaTime);
    }
}