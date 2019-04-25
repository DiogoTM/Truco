using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trucoApp.BLL
{
    class Card
    {
        private int value, kind;
        private Image picture;
        private bool isZap;

        //Card structer values go from 1 (Ace) to 13(King), kind follows the structure :1=♦,2=♠, 3=♥, 4=♣

        public Card(int value, int kind, Image picture, bool isZap)
        {
            if (value > 3)
            {
                this.value = value;
            }
            else
            {
                this.value = value + 12;        //Case card is an Ace, 2 or 3. They are more powerful.
            }
           
            this.kind = kind;
            this.picture = picture;
            this.isZap = isZap;
        }

        public int Value { get => value; set => this.value = value; }
        public int Kind { get => kind; set => kind = value; }
        public Image Picture { get => picture; set => picture = value; }
        public bool IsZap { get => isZap; set => isZap = value; }

        public override string ToString()
        {
            return "Value= "+this.value+" Kind= "+this.kind+". ";
        }
    }
}
