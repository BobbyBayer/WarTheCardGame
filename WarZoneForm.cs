using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarTheCardGame
{
    public partial class WarZoneForm : Form
    {
        private const int handLimit = 3;

        Card? selectedCard = null;

        List<Card> opponentDeck = new();
        List<Card> yourDeck = new();
        List<Card> opponentDiscard = new List<Card>();
        List<Card> yourDiscard = new List<Card>();
        List<Card> cardsInHand = new();

        private Random rng = new();

        public WarZoneForm()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void FormMouseDown(object sender, MouseEventArgs e)
        {
            Point mousePosition = new(e.X, e.Y);

            foreach (Card card in cardsInHand)
            {
                if (selectedCard == null)
                {
                    if (card.rect.Contains(mousePosition))
                    {
                        selectedCard = card;
                        card.active = true;
                    }
                }
            }
        }

        private void FormMouseMove(object sender, MouseEventArgs e)
        {
            if (selectedCard != null)
            {
                selectedCard.position.X = e.X - (selectedCard.width / 2);
                selectedCard.position.Y = e.Y - (selectedCard.height / 2);
            }
        }

        private void FormMouseUp(object sender, MouseEventArgs e)
        {
            foreach (Card card in cardsInHand)
            {
                card.active = false;
            }
            selectedCard = null;
        }

        private void FormPaint(object sender, PaintEventArgs e)
        {
            foreach (Card card in cardsInHand)
            {
                e.Graphics.DrawImage(card.cardPic, card.position.X, card.position.Y, card.width, card.height);

                Pen outline;
                if (card.active && !card.inDropBox)
                {
                    outline = new Pen(Color.Red, 10);
                }
                else if (card.active && card.inDropBox)
                {
                    outline = new Pen(Color.Blue, 10);
                }
                else
                {
                    outline = new Pen(Color.Transparent, 0);
                }

                e.Graphics.DrawRectangle(outline, card.rect);
            }

            if (selectedCard != null)
            {
                e.Graphics.DrawImage(selectedCard.cardPic, selectedCard.position.X, selectedCard.position.Y, selectedCard.width, selectedCard.height);
            }
        }

        private void FormTimer(object sender, EventArgs e)
        {
            foreach (Card card in cardsInHand)
            {
                card.rect.X = card.position.X;
                card.rect.Y = card.position.Y;
            }

            this.Invalidate();
        }

        private void SetUpGame()
        {
            CreateDecks();

            DrawCard();
            DrawCard();
            DrawCard();
        }

        private void DrawCard()
        {
            if (yourDeck.Count > 0)
            {
                cardsInHand.Add(yourDeck.Last());
                yourDeck.RemoveAt(yourDeck.Count - 1);
            }
            else
            {
                SuffleDiscardPile();
                DrawCard();
            }
            UpdateCountLabels();
            ShowCardsInHand();
        }

        private void SuffleDiscardPile()
        {
            yourDeck = yourDiscard;
            yourDeck = yourDeck.OrderBy(_ => rng.Next()).ToList();
            yourDiscard.Clear();
        }

        private void ShowCardsInHand()
        {
            var xposition = 5;
            foreach (Card card in cardsInHand)
            {
                card.position.X = (xposition += 55);
                card.position.Y = 300;
                card.rect.X = card.position.X;
                card.rect.Y = card.position.Y;
            }
        }

        private void UpdateCountLabels()
        {
            yourDeckCountLabel.Text = yourDeck.Count.ToString();
            opponentDeckCountLabel.Text = opponentDeck.Count.ToString();
            yourDiscardPileLabel.Text = "Discard pile: " + yourDiscard.Count.ToString();
            opponentDiscardPileLabel.Text = "Discard pile: " + opponentDiscard.Count.ToString();
        }

        private void CreateDecks()
        {
            var suffeldCardLocation = Directory.GetFiles("PlayingCardsImages", "*.png").OrderBy(_ => rng.Next()).ToList();

            for (int i = 0; i < suffeldCardLocation.Count; i++)
            {
                if (i % 2 == 0)
                {
                    yourDeck.Add(new Card(suffeldCardLocation[i]));
                }
                else
                {
                    opponentDeck.Add(new Card(suffeldCardLocation[i]));
                }
            }
        }

        private void drawCardButton_Click(object sender, EventArgs e)
        {
            if (cardsInHand.Count < handLimit)
            {
                DrawCard();
            }
        }
    }
}
