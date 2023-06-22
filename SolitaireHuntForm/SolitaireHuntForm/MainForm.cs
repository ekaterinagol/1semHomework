using System;
using CardsLibrary;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolitaireHuntForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            GameStart();

        }

        public Card PreviousCard = null;
        public Card crd = new Card(SuitType.S, 6);
        public Stack<Card>[] stack = new Stack<Card>[9];


        void GameStart()
        {
            var crd = new Card(SuitType.S, 6);

            Stack<Card>[] stack = new Stack<Card>[9];
            for (int j = 0; j < 9; j++)
            {
                stack[j] = new Stack<Card>();
                for (int i = 0; i < 4; i++)
                {
                    Card card = crd.GenerateCard();
                    for (int k = 0; k < j + 1; k++)
                    {
                        if (stack[k].Contains(card))
                            i--;
                        else
                            stack[j].Push(card);
                    }
                }
            }
            //Stack<Card>[] stack = { new Stack<Card>() };
            //for (int j = 0; j < 10; j++)
            //{
            //    Stack<Card> GenerateStack()
            //{
            //    var stack = new Stack<Card>();
            //    for (int i = 0; i < 4; i++)
            //    {
            //        var card = crd.GenerateCard();
            //        if (stack.Contains(card))
            //            i--;
            //        else
            //            stack.Push(card);
            //    }
            //    return stack;

            //}
            //    }
            //}

            //crd = GenerateStack().Peek();
            //position11.Image = Image.FromFile(System.IO.Path.GetFullPath($@"CardImages\{crd.Suit}{crd.Value}.png"));
            crd = stack[0].Peek();
            position11.Image = Image.FromFile(System.IO.Path.GetFullPath($@"CardImages\{crd.Suit}{crd.Value}.png"));
            crd = stack[1].Peek();
            position12.Image = Image.FromFile(System.IO.Path.GetFullPath($@"CardImages\{crd.Suit}{crd.Value}.png"));
            crd = stack[2].Peek();
            position13.Image = Image.FromFile(System.IO.Path.GetFullPath($@"CardImages\{crd.Suit}{crd.Value}.png"));
            crd = stack[3].Peek();
            position21.Image = Image.FromFile(System.IO.Path.GetFullPath($@"CardImages\{crd.Suit}{crd.Value}.png"));
            crd = stack[4].Peek();
            position22.Image = Image.FromFile(System.IO.Path.GetFullPath($@"CardImages\{crd.Suit}{crd.Value}.png"));
            crd = stack[5].Peek();
            position23.Image = Image.FromFile(System.IO.Path.GetFullPath($@"CardImages\{crd.Suit}{crd.Value}.png"));
            crd = stack[6].Peek();
            position31.Image = Image.FromFile(System.IO.Path.GetFullPath($@"CardImages\{crd.Suit}{crd.Value}.png"));
            crd = stack[7].Peek();
            position32.Image = Image.FromFile(System.IO.Path.GetFullPath($@"CardImages\{crd.Suit}{crd.Value}.png"));
            crd = stack[8].Peek();
            position33.Image = Image.FromFile(System.IO.Path.GetFullPath($@"CardImages\{crd.Suit}{crd.Value}.png"));


        }

        void Position11_MouseClick(object sender, MouseEventArgs e)
        {
            var crd = new Card(SuitType.S, 6);
            if (crd.IsCardTheSameValue(stack[0].Peek(), PreviousCard)){
                stack[0].Pop();
                for (int i = 0; i < 9; i++)
                {
                    if (crd.IsCardTheSameValue(PreviousCard, stack[i].Peek()))
                    {
                        stack[i].Pop();
                        PreviousCard = null;
                    }
                }
            }
            else
                PreviousCard = stack[0].Peek();


        }

        public void Position22_Click(object sender, EventArgs e)
        {
            var crd = new Card(SuitType.S, 6);
            if (crd.IsCardTheSameValue(stack[4].Peek(), PreviousCard))
            {
                stack[4].Pop();
                for (int i = 0; i < 9; i++)
                {
                    if (crd.IsCardTheSameValue(PreviousCard, stack[i].Peek()))
                    {
                        stack[i].Pop();
                        PreviousCard = null;
                    }
                }
            }
            else
                PreviousCard = stack[4].Peek();
        }


        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rulesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            RulesForm rulesForm = new RulesForm();
            rulesForm.ShowDialog();
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameStart();

        }
    }
}
