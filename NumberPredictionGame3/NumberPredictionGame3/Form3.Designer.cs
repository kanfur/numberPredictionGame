﻿namespace NumberPredictionGame3
{
  partial class Form3
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
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(52, 75);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(325, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "Keep a 4-digit number from your mind now";
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.Teal;
      this.button1.Font = new System.Drawing.Font("Open Sans Light", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
      this.button1.Location = new System.Drawing.Point(143, 132);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(141, 39);
      this.button1.TabIndex = 1;
      this.button1.Text = "I kept";
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
      this.button2.TabIndex = 4;
      this.button2.Text = "Back";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // Form3
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
      this.ClientSize = new System.Drawing.Size(428, 261);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label1);
      this.Name = "Form3";
      this.Text = "Form3";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
  }
}