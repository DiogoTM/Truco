﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trucoApp.Properties;

namespace trucoApp.BLL
{
    class Deck
    {
        private List<Card> myDeck;
        private Card vira;
       

        public Deck()
        {
            this.MyDeck = createDeck();
            this.Vira = drawCard();
        }

  
        internal List<Card> MyDeck { get => myDeck; set => myDeck = value; }
        internal Card Vira { get => vira; set => vira = value; }

        private List<Card> createDeck()
        {
            List<Card> myDeck = new List<Card>();
            //Card structer values go from 1 (Ace) to 13(King), kind follows the structure :1=♦,2=♠, 3=♥, 4=♣

            for (int i = 1; i < 14; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    if (!(i > 7 && i<=10))
                    {
                        string cardName = i + "_of_" + j+".png";
                        Image cardPicture = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName+@"\pictures\" +cardName);
                        Card myCard = new Card(i, j, cardPicture, false);
                        myDeck.Add(myCard);   
                    }             
                }        
            }
            return myDeck;
        }
        Random rand = new Random();
        
        public Card drawCard()
        {
            int drawCard = rand.Next(myDeck.Count);
            Card card = new Card(myDeck[drawCard].Value, myDeck[drawCard].Kind, myDeck[drawCard].Picture, myDeck[drawCard].IsZap);
            myDeck.RemoveAt(drawCard);          
            return card;       
        }


    }
    

}
