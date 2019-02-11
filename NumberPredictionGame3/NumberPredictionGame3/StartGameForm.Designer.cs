namespace NumberPredictionGame3
{
  partial class StartGameForm
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
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.positiveBox = new System.Windows.Forms.TextBox();
      this.negativeBox = new System.Windows.Forms.TextBox();
      this.guessBtn = new System.Windows.Forms.Button();
      this.guessBox = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.button2 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // richTextBox1
      // 
      this.richTextBox1.Location = new System.Drawing.Point(193, 29);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.Size = new System.Drawing.Size(332, 201);
      this.richTextBox1.TabIndex = 8;
      this.richTextBox1.Text = "";
      this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
      // 
      // positiveBox
      // 
      this.positiveBox.Location = new System.Drawing.Point(44, 63);
      this.positiveBox.Name = "positiveBox";
      this.positiveBox.Size = new System.Drawing.Size(47, 20);
      this.positiveBox.TabIndex = 1;
      // 
      // negativeBox
      // 
      this.negativeBox.Location = new System.Drawing.Point(108, 63);
      this.negativeBox.Name = "negativeBox";
      this.negativeBox.Size = new System.Drawing.Size(47, 20);
      this.negativeBox.TabIndex = 2;
      // 
      // guessBtn
      // 
      this.guessBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.guessBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.guessBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.guessBtn.Location = new System.Drawing.Point(52, 148);
      this.guessBtn.Name = "guessBtn";
      this.guessBtn.Size = new System.Drawing.Size(94, 35);
      this.guessBtn.TabIndex = 4;
      this.guessBtn.Text = "Guess";
      this.guessBtn.UseVisualStyleBackColor = false;
      this.guessBtn.Click += new System.EventHandler(this.guessBtn_Click);
      // 
      // guessBox
      // 
      this.guessBox.Location = new System.Drawing.Point(52, 113);
      this.guessBox.Name = "guessBox";
      this.guessBox.Size = new System.Drawing.Size(94, 20);
      this.guessBox.TabIndex = 3;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(41, 47);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(55, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "+1,2,3,4,0";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(105, 47);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(52, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "-1,2,3,4,0";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(68, 97);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(62, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Your Guess";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(80, 29);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(33, 13);
      this.label4.TabIndex = 4;
      this.label4.Text = "Clues";
      this.label4.Click += new System.EventHandler(this.label1_Click);
      // 
      // button2
      // 
      this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
      this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.button2.Location = new System.Drawing.Point(12, 219);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 30);
      this.button2.TabIndex = 9;
      this.button2.Text = "Back";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // StartGameForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      this.ClientSize = new System.Drawing.Size(560, 261);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.guessBox);
      this.Controls.Add(this.guessBtn);
      this.Controls.Add(this.negativeBox);
      this.Controls.Add(this.positiveBox);
      this.Controls.Add(this.richTextBox1);
      this.Name = "StartGameForm";
      this.Text = "StartGameForm";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.RichTextBox richTextBox1;
    private System.Windows.Forms.TextBox positiveBox;
    private System.Windows.Forms.TextBox negativeBox;
    private System.Windows.Forms.Button guessBtn;
    private System.Windows.Forms.TextBox guessBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button button2;
  }
}