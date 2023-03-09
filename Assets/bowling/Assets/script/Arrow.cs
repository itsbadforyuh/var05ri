using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float swingSpeed = 2f;
    public float swingAngle = 120f;

    private float timeOffset;

   
    // Start is called before the first frame update
    void Start()
    {
        timeOffset = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float angle = Mathf.Sin((Time.time - timeOffset) * swingSpeed) * swingAngle;

        transform.rotation = Quaternion.Euler(0f, angle, 0f);
    }
}
