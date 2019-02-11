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
  public partial class Form3 : Form
  {
    Form2 form2;
    public Form3(Form2 form2)
    {
      InitializeComponent();
      this.form2 = form2;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      StartGameForm startGame = new StartGameForm(this);
      startGame.Show();
      this.Hide();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      form2.Show();
      this.Hide();
    }
  }
}
