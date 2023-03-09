using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject ball;
    public float followSpeed = 10.0f;
    public float height = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 ballPos = ball.transform.position;

        Vector3 cameraPos = new Vector3(ballPos.x, ballPos.y + height, ballPos.z - 10.0f);


        transform.position = Vector3.Lerp(transform.position, ballPos, Time.deltaTime * followSpeed);

        transform.LookAt(ball.transform);
    }
}
