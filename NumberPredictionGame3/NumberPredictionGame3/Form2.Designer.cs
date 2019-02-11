namespace NumberPredictionGame3
{
  partial class Form2
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(32, 18);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(216, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "Rules of the game to win";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(36, 52);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(194, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "- We\'re gonna keep a four-digit number.";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(36, 75);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(228, 13);
      this.label3.TabIndex = 1;
      this.label3.Text = "- The numbers of this number must be different.";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(36, 97);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(309, 13);
      this.label4.TabIndex = 1;
      this.label4.Text = "- If you want to beat me, you have to find the number before me.";
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.Teal;
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
      this.button1.Location = new System.Drawing.Point(233, 206);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(229, 43);
      this.button1.TabIndex = 2;
      this.button1.Text = "I got it and accept";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
      this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.button2.Location = new System.Drawing.Point(12, 219);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 30);
      this.button2.TabIndex = 3;
      this.button2.Text = "Back";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(36, 119);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(385, 13);
      this.label5.TabIndex = 1;
      this.label5.Text = "- if you know the numbers and the digits are correct, you will give a positive cl" +
    "ue.";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(36, 142);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(408, 13);
      this.label6.TabIndex = 1;
      this.label6.Text = "- If I know the numbers, but the digits are wrong, you\'re going to give a negativ" +
    "e clue.";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(36, 165);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(227, 13);
      this.label7.TabIndex = 1;
      this.label7.Text = "- In the same way I\'ll give you a hint. (ex: +1,-2)";
      this.label7.Click += new System.EventHandler(this.label7_Click);
      // 
      // Form2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(474, 261);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "Form2";
      this.Text = "Form2";
      this.Load += new System.EventHandler(this.Form2_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
  }
}