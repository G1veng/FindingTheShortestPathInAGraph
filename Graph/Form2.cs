using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph
{
  public partial class Form2 : Form
  {
    public Form2()
    {
      InitializeComponent();
    }

    public void Clear()
    {
      Graphics clear = pictureBox1.CreateGraphics();
      clear.Clear(Color.White);
      if (countOfVertexes != 0 && texts.Count() != 0)
      {
        int count = 0;
        for (int i = 0; i < countOfVertexes; i++)
        {
          for (int j = 0; j < countOfVertexes; j++)
          {
            texts[count].Dispose();
          }
        }
        countOfVertexes = 0;
        texts.Clear();
      }
    }

    int countOfVertexes = 0;
    int sizeX = 0, sizeY = 0;
    List<TextBox> texts = new List<TextBox>();
    List<List<int>> array = new List<List<int>>();
    private void button1_Click(object sender, EventArgs e)
    {
      if (texts.Count() != 0)
      {
        if (MessageBox.Show("Удалить текущий граф?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
          array.Clear();
          Clear();
        }
      }
      Form1 mainForm = (Form1)this.Owner;
      if (countOfVertexes == 0 && (mainForm.GetArray().Count() == 0 || !textBox1.Text.Equals("")))
      {
        countOfVertexes = Int32.Parse(textBox1.Text);
        sizeX = (this.Size.Width - 170) / countOfVertexes;
        sizeY = (this.Size.Height - 50) / countOfVertexes;
        int countOfTextBoxes = 1;
        for (int i = 0; i < countOfVertexes; i++)
        {
          for (int j = 0; j < countOfVertexes; j++)
          {
            TextBox textBox = new TextBox();
            textBox.Multiline = true;
            textBox.Size = new Size(sizeX, sizeY);
            textBox.Location = new Point((140 + sizeX * j), (sizeY * i));
            textBox.Text = "0";
            textBox.Name = countOfTextBoxes.ToString();
            pictureBox1.Controls.Add(textBox);
            textBox.BringToFront();
            textBox.Click += textOnClick;
            texts.Add(textBox);
            textBox.TextAlign = HorizontalAlignment.Center;
          }
        }
      }
      if (mainForm.GetArray().Count() != 0 && countOfVertexes == 0 && array != mainForm.GetArray())
      {
        array.Clear();
        array = mainForm.GetArray();
        countOfVertexes = array.Count();
        sizeX = (this.Size.Width - 170) / countOfVertexes;
        sizeY = (this.Size.Height - 50) / countOfVertexes;
        int countOfTextBoxes = 1;
        for (int i = 0; i < countOfVertexes; i++)
        {
          for (int j = 0; j < countOfVertexes; j++)
          {
            TextBox textBox = new TextBox();
            textBox.Multiline = true;
            textBox.Size = new Size(sizeX, sizeY);
            textBox.Location = new Point((140 + sizeX * j), (sizeY * i));
            if (array[i][j] != 0)
            {
              textBox.Text = array[i][j].ToString();
            }
            else
            {
              textBox.Text = "0";
            }
            textBox.Name = countOfTextBoxes.ToString();
            pictureBox1.Controls.Add(textBox);
            textBox.BringToFront();
            textBox.Click += textOnClick;
            texts.Add(textBox);
            textBox.TextAlign = HorizontalAlignment.Center;
          }
        }
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      int counter = 0;
      array.Clear();
      for(int i = 0; i < countOfVertexes; i++)
      {
        array.Add(new List<int>());
        for(int j = 0; j < countOfVertexes; j++)
        {
          array[i].Add(Int32.Parse(texts[counter].Text));
          counter++;
        }
      }
      Form1 mainForm = (Form1)this.Owner;
      if (array != mainForm.GetArray())
      {
        mainForm.Sinchronise(array, countOfVertexes);
        array.Clear();
      }
      this.Close();
    }

    void textOnClick(object sender, EventArgs e)
    {
    }
  }
}
