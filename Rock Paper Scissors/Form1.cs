namespace Rock_Paper_Scissors
{
    public partial class Form1 : Form
    {

        string pChoice;
        string cChoice;
        string[] Options = { "R", "P", "S", "P", "S", "R", "S", "R", "P" };
        Random rand = new Random();

        int cScore;
        int pScore;
        string draw;

        public Form1()
        {
            InitializeComponent();
        }

        private void MakeChoiceEvent(object sender, EventArgs e)
        {
            Button tempBtn = sender as Button;
            pChoice = (string)tempBtn.Tag;

            int i = rand.Next(0, 1000) % Options.Length;
            cChoice = Options[i];

            UpdateTextAndImage(pChoice, PLAYERPIC);
            lblcpu.Text = "CPU is : " + UpdateTextAndImage(cChoice, CPUPIC);
            CheckGame();
        }

        private string UpdateTextAndImage(string text, PictureBox pic)
        {
            string word = null;

            switch (text)
            {
                case "R":
                    word = "Rock";
                    pic.Image = Properties.Resources.p1r;
                    break;
                case "P":
                    word = "Paper";
                    pic.Image = Properties.Resources.p1p;
                    break;
                case "S":
                    word = "Scissors";
                    pic.Image = Properties.Resources.p1s;
                    break;
            }

            return word;
        }

        private void CheckGame()
        {
            draw = null;

            if (cChoice == pChoice)
            {
                draw = "Draw!";
            }
            else if (cChoice == "R" && pChoice == "S")
                cScore++;
            else if (cChoice == "R" && pChoice == "P")
                pScore++;
            else if (cChoice == "P" && pChoice == "R")
                cScore++;
            else if (cChoice == "P" && pChoice == "S")
                pScore++;
            else if (cChoice == "S" && pChoice == "P")
                cScore++;
            else if (cChoice == "S" && pChoice == "R")
                pScore++;

            lblcs.Text = "CPU Score: " + cScore + Environment.NewLine + draw;
            lblps.Text = "Player Score: " + pScore + Environment.NewLine + draw;
        }
    }
}