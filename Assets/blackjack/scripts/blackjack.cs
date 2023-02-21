using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackjack : MonoBehaviour
{
    public static string[] suits = new string[] { "C", "D", "H", "S" };// c meihua d fangkuai h hongtao s heitao
    public static int[] value = new int[] { 1, 2, 3, 4, 5, 6, 7,8, 9, 10, 11, 12, 13 };


    public class Card
    {
        public string suit = "";
        public int value = 0;
    }
    public List<string> deck;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayCards()
    {
        deck = GenerateDeck();
        //test cards
        foreach (string card in deck)
        {
            print(card);
        }
    }
    public static List<string> GenerateDeck()
    {
        List<string> newdeck = new List<string>();
        //foreach (string s in suits)
        //{
        //    foreach (string v in value)
        //    {
        //        newdeck.Add(s + v);
        //    }
        //}

        return newdeck;
    }
}


