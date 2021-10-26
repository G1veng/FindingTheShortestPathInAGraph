
namespace Graph
{
  partial class Form1
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
      this.button1 = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.button2 = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.button3 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.AllowDrop = true;
      this.button1.Location = new System.Drawing.Point(41, 22);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(109, 42);
      this.button1.TabIndex = 0;
      this.button1.Text = "Создать врешину";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pictureBox1.Location = new System.Drawing.Point(0, 0);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(800, 450);
      this.pictureBox1.TabIndex = 1;
      this.pictureBox1.TabStop = false;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(41, 363);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(129, 57);
      this.button2.TabIndex = 2;
      this.button2.Text = "Связать вершины";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(688, 42);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(100, 22);
      this.textBox1.TabIndex = 3;
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(41, 290);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(140, 67);
      this.button3.TabIndex = 4;
      this.button3.Text = "Найти кратчайшее расстояние";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(695, 22);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(93, 17);
      this.label1.TabIndex = 5;
      this.label1.Text = "Weight of link";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.pictureBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Label label1;
  }
}

