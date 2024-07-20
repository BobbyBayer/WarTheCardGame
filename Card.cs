using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WarTheCardGame
{
    internal class Card
    {
        public Image cardPic;
        public int height;
        public int width;
        public Point position = new Point();
        public bool active = false;
        public bool inDropBox = false;
        public Rectangle rect;

        public int cardValue;

        public Card(string imageLocation)
        {
            cardPic = Image.FromFile(imageLocation);
            height = 200;
            width = 100;
            rect = new Rectangle(position.X, position.Y, width, height);
            cardValue = GetCardValue(imageLocation);
        }

        private int GetCardValue(string imageLocation)
        {
            var index = imageLocation.IndexOf('_') + 1;
            var value = imageLocation.Substring(index, 1);

            switch (value)
            {
                case "1":
                    return 10;
                case "J":
                    return 11;
                case "Q":
                    return 12;
                case "K":
                    return 13;
                case "A":
                    return 14;
                default:
                    return int.Parse(value);
            }
        }
    }
}
