using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    //int findFastestToThis = 0;
    private static int MinimumDistance(int[] distance, bool[] shortestPathTreeSet, int verticesCount)
      {
        int min = int.MaxValue;
        int minIndex = 0;

        for (int v = 0; v < verticesCount; ++v)
        {
          if (shortestPathTreeSet[v] == false && distance[v] <= min)
          {
            min = distance[v];
            minIndex = v;
          }
        }

        return minIndex;
      }


    private static void Print(int[] distance, int verticesCount)
    {
      var mc = new Form1();
      for (int i = 0; i < verticesCount; ++i)
        MessageBox.Show("Вершина: " + (i + 1).ToString() + " Расстояние: " + distance[i].ToString());
    }
    public static void DijkstraAlgo(int[,] graph, int source, int verticesCount)
      {
        int[] distance = new int[verticesCount];
        bool[] shortestPathTreeSet = new bool[verticesCount];

        for (int i = 0; i < verticesCount; ++i)
        {
          distance[i] = int.MaxValue;
          shortestPathTreeSet[i] = false;
        }

        distance[source] = 0;

        for (int count = 0; count < verticesCount - 1; ++count)
        {
          int u = MinimumDistance(distance, shortestPathTreeSet, verticesCount);
          shortestPathTreeSet[u] = true;

          for (int v = 0; v < verticesCount; ++v)
            if (!shortestPathTreeSet[v] && Convert.ToBoolean(graph[u, v]) && distance[u] != int.MaxValue && distance[u] + graph[u, v] < distance[v])
              distance[v] = distance[u] + graph[u, v];
        }

      Print(distance, verticesCount);
      }

      List<List<int>> linksInLinks = new List<List<int>>();
    List<int> links = new List<int>();
    Button first, second;
    bool seted = false;
    int choosedAll = 0;
    Random rn = new Random();
    int buttonsCount = 0;
    List<Button> buttons = new List<Button>();
    private void button1_Click(object sender, EventArgs e)
    {
      buttonsCount++;
      Button btn = new Button();
      btn.Size = new Size(20, 20);
      btn.Location = new Point(this.Width / 2, this.Height/2);
      btn.Text = buttonsCount.ToString();
      btn.Name = buttonsCount.ToString();
      pictureBox1.Controls.Add(btn);
      btn.BringToFront();
      ControlExtension.Draggable(btn, true);
      btn.Click += ButtonOnClick;
      buttons.Add(btn);
      string someString = btn.Name;
      linksInLinks.Add(new List<int>());
      for (int i = 0; i < buttonsCount; i++)
      {
        int j = 0;
        if (buttonsCount != 0)
        {
          j = linksInLinks[i].Count;
        }
        else
        {
          j = 1;
        }
        do {
          linksInLinks[i].Add(0);
          j++;
        } while (j < buttonsCount);
      }
    }
    private void Form1_Load(object sender, EventArgs e)
    {
    }

    private void ButtonOnClick(object sender, EventArgs eventArgs)
    {
      for (int i = 0; i < buttons.Count; i++)
      {
        string someString = sender.ToString();
        if (sender.ToString() == "System.Windows.Forms.Button, Text: " + buttons[i].Text)
        {
          var button = (Button)sender;
          if (button != null)
          {
            if (seted)
            {
              second = buttons[i];
              seted = false;
              choosedAll++;
            }
            else
            {
              first = buttons[i];
              seted = true;
              choosedAll++;
            }
            /*MessageBox.Show("Прощай " + button.Name);
            button.Dispose();
            buttonsCount--;*/
            /*return button.Location;*/
          }
        }
      }
    }

    private void button3_Click(object sender, EventArgs e)
    {
      if (buttonsCount > 1)
      {
        //findFastestToThis = int.Parse(textBox1.Text);
        int[,] graph = new int[buttonsCount, buttonsCount];
        for (int i = 0; i < buttonsCount; i++)
        {
          for (int j = 0; j < buttonsCount; j++)
          {
            graph[i, j] = linksInLinks[i][j];
          }
        }
        DijkstraAlgo(graph, 0, linksInLinks.Count);
      }
      else
      {
        MessageBox.Show("Add some more vertexs");
      }
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (buttonsCount > 1)
      {
        int Weight = 0;
        int biggestY = 0, biggestX = 0;
        int Width = buttons[0].Width / 2;
        int Height = buttons[0].Height / 2;
        Pen myPen = new Pen(Color.Red);
        //if (choosedAll == 2) {
        using (Graphics g = pictureBox1.CreateGraphics())
        {
          //g.Clear(Color.White);
          g.DrawLine(myPen, first.Location.X + Width, first.Location.Y + Height, second.Location.X + Width, second.Location.Y + Height);
          Font myFont = new Font("Arial", 14);
          if (first.Location.X > second.Location.X)
          {
            biggestX = second.Location.X + (first.Location.X - second.Location.X) / 2;
          }
          else
          {
            biggestX = second.Location.X + (first.Location.Y - second.Location.X) / 2;
          }
          if (first.Location.Y > second.Location.Y)
          {
            biggestY = second.Location.Y + (first.Location.Y - second.Location.Y) / 2;
          }
          else
          {
            biggestY = first.Location.Y + (second.Location.Y - first.Location.Y) / 2;
          }
          Point point = new Point(biggestX, biggestY);
          g.DrawString(textBox1.Text.ToString(), myFont, Brushes.Green, point);
          try
          {
            Weight = int.Parse(textBox1.Text);
          }
          catch
          {
            Weight = 0;
          }
          linksInLinks[int.Parse(first.Text) - 1][int.Parse(second.Text) - 1] = Weight;
          linksInLinks[int.Parse(second.Text) - 1][int.Parse(first.Text) - 1] = Weight;
          choosedAll = 0;
        }
        //}
      }
      else
      {
        MessageBox.Show("Add some more vertexs");
      }
    }

  }
}
