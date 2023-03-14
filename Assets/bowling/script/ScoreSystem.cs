using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
   
    public int pointsPerHit = 1;
    public TextMeshProUGUI ScoreText;
    private int score = 0;
    private bool _done = false;
    void Start()
    {
        ScoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.CompareTag("pin") || collision.collider.CompareTag("ball")) && !_done)
        {
            score += pointsPerHit;
            ScoreText.text = "Score: " + score;
            _done = true;
            
        }
    }

   
}
        


    
 
