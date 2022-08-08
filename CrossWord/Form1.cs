using System.Collections;
namespace CrossWord
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        ArrayList splitWord = new ArrayList();
        ArrayList word = new ArrayList();
        ArrayList locationX = new ArrayList();
        ArrayList locationY = new ArrayList();

        int mistakes = 0;
        string[] words = { "car", "bike", "motorcycle", "plane", "helicopter", "submarine" };

        public Form1()
        {
            InitializeComponent();
            //Input button
            txtInput.MaxLength = 1;
            txtInput.Location = new Point((this.Width - 100) / 2, 300);
            btnSub.Location = new Point(this.Width / 2 + 10, 300);

            NewGame();
        }
        void NewGame()
        {
            int random = rnd.Next(0, words.Length);

            //Generate Lines
            for (int i = 0; i < words[random].Length; i++)
            {
                var pictureBox = new PictureBox
                {
                    Size = new Size(30, 7),
                    BackColor = Color.Black,
                    Location = new Point(this.Width / (words[random].Length + 2) * (i + 1), this.Height / 2 - 50),//Left; Top
                };
                this.Controls.Add(pictureBox);

                locationX.Add(pictureBox.Location.X);
                locationY.Add(pictureBox.Location.Y);

                splitWord.Add(pictureBox);//UnderLines

                word.Add(words[random][i]);//Letters of the correct word
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            Logic();
        }
        void GameStatus()
        {
            int win = 0;
            for (int i = 0; i < word.Count; i++)
            {
                if (splitWord[i].ToString() == word[i].ToString())       
                {
                    win++;
                }
            }
            if(win == word.Count)
            {
                Label winLbl = new Label
                {
                    Text = "You Won!",
                    Location = new Point(txtInput.Location.X, this.Height / 2),
                };
                btnSub.Enabled = false;
                txtInput.Enabled = false;

                this.Controls.Add(winLbl);
            }
        }

        void Logic()
        {
            //Input Checking
            int check = 0;
            string input = txtInput.Text.ToLower();

            if (input.Length != 0)
            {
                for (int i = 0; i < word.Count; i++)
                {
                    if (input == Convert.ToString(word[i]))
                    {

                        var label = new Label
                        {
                            Text = Convert.ToString(word[i]),
                            Location = new Point((int)locationX[i] + 4, (int)locationY[i] - 20),
                        };
                        this.Controls.Add(label);
                        splitWord[i] = label.Text;
                        check++;
                    }
                }
                //Mistakes
                if (check == 0)
                {
                    mistakes++;
                    lblMiss.Text = "Mistakes: " + mistakes;
                }
                else
                {
                    GameStatus();
                }
                txtInput.Text = "";
            }
        }

        private void txtInput_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Logic();
            }
        }
    }
}