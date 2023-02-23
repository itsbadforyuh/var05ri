using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JokerManager : MonoBehaviour
{

    public List<Sprite> decks = new List<Sprite>();
    public Transform PC;
    public Transform Player;

    bool isStand = false;
    int playerScore = 0;
    int PCScore = 0;

    public Text PCText;
    public Text PlayerText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    string CardNumer(string cardname)
    {
        string[] c = cardname.Split("_");
        string number = c[0];
        if(number == "ace")
        {
            number = "1";
        }
        if(number == "jack" || number == "king" || number == "queen" )
        {
            number = "10";
        }
        Debug.Log(number);
        return number;
    }
    public void PlayerDeal()
    {
       

        if (isStand) return;

        CreatCard(Player.GetChild(0));
        CreatCard(Player.GetChild(1));


        Player.GetChild(0).Find("cardinfo").gameObject.SetActive(false);

    }

    // generate deck
    void CreatCard(Transform c)
    {
        int index = Random.Range(0, decks.Count);
        c.gameObject.SetActive(true);
        c.Find("cardinfo").GetComponent<Image>().sprite = decks[index];
        c.name = CardNumer(decks[index].name);
        decks.RemoveAt(index);
    }

    public void PlayerHit()
    {
        if (isStand) return;
        foreach(Transform t in Player)
        {
            if(!t.gameObject.activeSelf)
            {
                t.gameObject.SetActive(true);
                CreatCard(t);
                break;
            }
        }
    }

    public void PlayerStand()
    {
        isStand = true;
        foreach(Transform t in Player)
        {
            if(t.gameObject.activeSelf)
            {
                playerScore += int.Parse(t.name);
            }
        }
        Debug.Log("playerScore: " + playerScore);
        StartCoroutine(PCStand());
    }

    public void ReStart()
    {
        SceneManager.LoadScene("blackjack");
    }

    IEnumerator PCStand()
    {
        yield return new WaitForSeconds(1f);
        CreatCard(PC.GetChild(0));
        CreatCard(PC.GetChild(1));

        PC.GetChild(0).Find("cardinfo").gameObject.SetActive(false);

        yield return new WaitForSeconds(1f);
        bool isPCStand = false;
        while(!isPCStand)
        {
            var a = Random.Range(0, 2);
            if(a == 0)
            {
                foreach (Transform t in PC)
                {
                    if (!t.gameObject.activeSelf)
                    {
                        t.gameObject.SetActive(true);
                        CreatCard(t);
                        break;
                    }
                }
            }
            else
            {
                isPCStand = true;
            }
        }
        yield return new WaitForSeconds(1f);
        foreach (Transform t in PC)
        {
            if (t.gameObject.activeSelf)
            {
                PCScore += int.Parse(t.name);
            }
        }
        Debug.Log("PCScore: " + PCScore);

        PC.GetChild(0).Find("cardinfo").gameObject.SetActive(true);
        Player.GetChild(0).Find("cardinfo").gameObject.SetActive(true);

      
        int pcs = PCScore - 21;
        int players = playerScore - 21;

        if (pcs > 0)
        {
            PCText.text = "busted！";
        }

        if (players > 0)
        {
            PlayerText.text = "busted！";
        }
        if(pcs < 0 && players > 0)
        {
            PCText.text = "Win!";
        }
        if (pcs > 0 && players < 0)
        {
            PlayerText.text = "Win!";
        }

        if(pcs<= 0 && players <= 0)
        {
            if(pcs > players)
            {
                PCText.text = "Win!";
                PlayerText.text = "lose!";
            }
            if (pcs < players)
            {
                PCText.text = "lose!";
                PlayerText.text = "win!";
            }
            if (pcs == players)
            {
                PCText.text = "tie dealrer wins";
                PlayerText.text = "tie dealer wins";
            }
        }


    }
}
