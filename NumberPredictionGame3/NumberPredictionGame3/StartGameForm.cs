using NumberPredictionGame3.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberPredictionGame3
{
  public partial class StartGameForm : Form
  {
    Form3 form3;
    private int[] pcSayi;
    public int tahminAdedi = 0;
    int userTahmin;//userdan alınıyor
    int pcPositive,userPositive; //pcPositive pc tarafından ipucu
    int pcNegative,userNegative;
    const int ANSWER_SIZE = 4;
    List<string> answers = PcGuess.answers(ANSWER_SIZE);
    public StartGameForm(Form3 form3)
    {
      InitializeComponent();
      this.form3 = form3;
      //user tahmin etme
      int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
      int[] randomNum = new int[4]; //pcSayi
      UserGuess.sayilariKar(ref nums);//binler basamağı 0 olamaz
      Array.Copy(nums, randomNum, 4);
      pcSayi = randomNum;
      richTextBox1.Text = String.Format("My guess is {0}. If it is wrong, can you give me a few clue ?",PcGuess.guess(answers));
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void guessBtn_Click(object sender, EventArgs e)
    { 
      if (!String.IsNullOrEmpty(positiveBox.Text) && !String.IsNullOrEmpty(negativeBox.Text) && !String.IsNullOrEmpty(guessBox.Text))
      { 
        if((int.Parse(positiveBox.Text)< 0 || int.Parse(positiveBox.Text)>4) || (int.Parse(negativeBox.Text) < 0 || int.Parse(negativeBox.Text) > 4))
        {
          MessageBox.Show("Clues can not be greater than 4 and smaller than 0 !");
        }else
        {
          if (int.Parse(guessBox.Text) > 999 && int.Parse(guessBox.Text) < 10000)
          {
            userTahmin = int.Parse(guessBox.Text);
            pcNegative = 0;
            pcPositive = 0;
            var isfound = UserGuess.tahminDogruMu(pcSayi, userTahmin, ref pcPositive, ref pcNegative); //tahmin doğruysa
            richTextBox1.Text += "\nYour Guess:"+guessBox.Text+", Your Clues:+"+positiveBox.Text+",-"+negativeBox.Text+"\n";
            if (!isfound)
            {
              tahminAdedi++;
            }
            if (isfound)
            {
              richTextBox1.Text += "You Won! Congratulations :)";
              MessageBox.Show( "You Won! Congratulations :>");
              richTextBox1.Text += tahminAdedi + ". Step";
            }
            else if (pcPositive > 0)
            {
              StringBuilder sb = new StringBuilder();
              sb.AppendLine("+" + pcPositive + "");
              if (pcNegative > 0)
                sb.AppendLine("-" + pcNegative + "");
              richTextBox1.Text += ("===========\nMy Clues:\n" + sb.ToString());
              pcguess();
            }
            else if (pcNegative > 0)
            {
              StringBuilder sb = new StringBuilder();
              sb.AppendLine("-" + pcNegative + "");
              richTextBox1.Text += ("===========\nMy Clues:\n" + sb.ToString());
              pcguess();
            }
            else
            {
              richTextBox1.Text += ("===========\nYou didn't find any number, please try again !\nClues: 0,0");
              pcguess();
            }

          }
          else
          {
            MessageBox.Show("Please enter a 4-digit estimate!");
          }
        }
      }
      else
      {
        MessageBox.Show("You must fill in all fields!");
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      form3.Show();
      this.Hide();
    }

    private void richTextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    private void pcguess()
    {
      richTextBox1.Text += "\n===========";
      PcGuess.pcGuess(int.Parse(positiveBox.Text), int.Parse(negativeBox.Text),ref answers, PcGuess.guess(answers), ANSWER_SIZE);
      if (answers.Count > 1)
        richTextBox1.Text += String.Format("\nMy guess is {0}. If it is wrong, can you give me clue ?", PcGuess.guess(answers));
      else if (answers.Count == 1)
      {
        richTextBox1.Text += String.Format("\nOleyyy! I Won. The number in your mind is {0}!", answers[0]);
        MessageBox.Show("I WON ! hahahhah :)))");
      }
      else if (answers.Count < 1)
        richTextBox1.Text += "\nImpossible answer for the clues you gave.";
    }
  }
}
