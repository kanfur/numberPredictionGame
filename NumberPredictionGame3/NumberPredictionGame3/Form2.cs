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
  public partial class Form2 : Form
  {
    Form1 form1;
    public Form2(Form1 form1)
    {
      InitializeComponent();
      this.form1 = form1;
    }

    private void Form2_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      Form3 form3 = new Form3(this);
      this.Hide();
      form3.Show();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.Hide();
      form1.Show();
    }

    private void label7_Click(object sender, EventArgs e)
    {

    }
  }
}
