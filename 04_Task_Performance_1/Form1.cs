using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Task_Performance_1
{
    public partial class form1 : Form
    {
        private string wordToGuess = "programming";//word na kailangan hulaan
       
        private StringBuilder RevealWord;//revealing the word
        
        private ArrayList wrongGuesses;//para ma display mga wrong guess

        public form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            //by doing this magagawa yung guessing word sa label 
            RevealWord = new StringBuilder();

            
            for (int i = 0; i < wordToGuess.Length; i++)
            {
                if (wordToGuess[i] == 'p' || wordToGuess[i] == 'r' || wordToGuess[i] == 'n')//char ginamit pang lagay sa mga specific letter
                {
                    RevealWord.Append(wordToGuess[i]); 
                }
                else
                {
                    RevealWord.Append('-'); //para sa mga ltter na 'di revealed
                }
            }

            wrongGuesses = new ArrayList();           
            labelWord.Text = RevealWord.ToString(); 
            listBoxGuess.Items.Clear();               
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string guessedWord = GuessText.Text.ToLower().Trim(); // Getting the word from the GuessText(TextBox)

if (guessedWord == wordToGuess)
{
    // If na guess na lalabas to
    MessageBox.Show("Congratulations! You guessed the word!");
    labelWord.Text = wordToGuess; //Lalabas buong correct word

    //Para di na mag tuloy yung program mag guess
    GuessText.Enabled = false;   // Disable
    GuessWord.Enabled = false;   // Disable

    // Optional: Show a game-over message
    MessageBox.Show("Game won! You have guessed the word.");
}
else
{
    // mappunta sa list box pag mali
    if (!wrongGuesses.Contains(guessedWord))
    {
        wrongGuesses.Add(guessedWord);
        listBoxGuess.Items.Add(guessedWord);
    }
    MessageBox.Show("Incorrect guess! Try again.");//it will show pag mali ang guess
}

GuessText.Clear();  // Clear the TextBox for the next guess
GuessText.Focus(); 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void labelWord_Click(object sender, EventArgs e)
        {

        }
    }
}
