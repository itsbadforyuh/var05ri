using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class racergame : MonoBehaviour
{
    public float speed;
    public GameObject player1;
    public GameObject player2;
    public GameObject win;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(new Vector3(speed * 0.01f, 0, 0), Space.World);
   
             // foreach 
           // list of strings 
           // bool isgrass = tile.name == "grass"
           //public float percentchancetomove = 0.25f
           // make a list that have a name and a chance to moveforward 
    }


    public void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.transform.name);
      

        if (other.transform.name == "finishline")
        {
            speed = 0;
            GetComponent<Animator>().SetBool("walk", false);
            win.SetActive(true);
            win.GetComponent<Text>().text =transform.name +  "  Win!";
            Time.timeScale = 0;

        }
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.transform.tag == "1")
        {
            //public float percentchancetomove = 12.5f;
            int i = Random.Range(1, 5);
            if(i == 3)
            {
                speed = 7;
                GetComponent<Animator>().SetBool("walk", true);
            }
            else
            {
                speed = 0;
                GetComponent<Animator>().SetBool("walk", false);
            }

        }

        if (other.transform.tag == "2")
        {
            //public float percentchancetomove = 12.5f;
            int i = Random.Range(1, 9);
            if (i == 4)
            {
                speed = 7;
                GetComponent<Animator>().SetBool("walk", true);
            }
            else
            {
                speed = 0;
                GetComponent<Animator>().SetBool("walk", false);
            }
        }
    }


}



