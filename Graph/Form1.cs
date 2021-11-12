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

    public class Vertex
    {
    public int first;
    public int second;
    public int value;
    }

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

    public void UpdatePicture()
    {
      Graphics clear = pictureBox1.CreateGraphics();
      clear.Clear(Color.White);
      pictureBox1.BackColor = Color.White;
      int theBiggestY = 0, theBiggestX = 0;
      for (int i = 0; i < buttonsCount; i++)
      {
        for (int j = 0; j < buttonsCount; j++)
        {
          if (linksInLinks[i][j] != 0)
          {
            using (Graphics g = pictureBox1.CreateGraphics())
            {
              Pen myPen = new Pen(Color.Red);
              int firstX = 0, firstY = 0;
              int secondX = 0, secondY = 0;
              firstX = buttons[i].Location.X + buttons[i].Width;
              firstY = buttons[i].Location.Y + buttons[i].Height;
              secondX = buttons[j].Location.X + buttons[i].Width;
              secondY = buttons[j].Location.Y + buttons[i].Height;
              myPen = new Pen(Color.Red);
              Pen myPenTwo = new Pen(Color.Green);
              g.DrawLine(myPen, firstX, firstY, secondX, secondY);
              Font myFont = new Font("Arial", 14);
              if (buttons[i].Location.X > buttons[j].Location.X)
              {
                theBiggestX = buttons[j].Location.X + (buttons[i].Location.X - buttons[j].Location.X) / 2;
              }
              else
              {
                theBiggestX = buttons[i].Location.X + (buttons[j].Location.X - buttons[i].Location.X) / 2;
              }
              if (buttons[i].Location.Y > buttons[j].Location.Y)
              {
                theBiggestY = buttons[j].Location.Y + (buttons[i].Location.Y - buttons[j].Location.Y) / 2;
              }
              else
              {
                theBiggestY = buttons[i].Location.Y + (buttons[j].Location.Y - buttons[i].Location.Y) / 2;
              }
              Point point = new Point(theBiggestX, theBiggestY);
              if (buttons[i].Location.X > buttons[j].Location.X)
              {
                g.DrawString(linksInLinks[i][j].ToString() + "<", myFont, Brushes.Green, point);
              }
              else
              {
                g.DrawString(linksInLinks[i][j].ToString() + ">", myFont, Brushes.Green, point);
              }
            }
          }
        }
      }
    }

    private static void Print(int[] distance, int verticesCount, int destination)
    {
      for (int i = 1; i < verticesCount; ++i)
      {
        MessageBox.Show("Вершина: " + (i + 1).ToString() + " Расстояние: " + distance[i].ToString());
      }
    }
    public static void DijkstraAlgo(int[,] graph, int source, int verticesCount, int destination)
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
        {
          if (!shortestPathTreeSet[v] && Convert.ToBoolean(graph[u, v]) && distance[u] != int.MaxValue && distance[u] + graph[u, v] < distance[v])
          {
            distance[v] = distance[u] + graph[u, v];
          }
        }
      }
      Print(distance, verticesCount, destination);
    }

    public void FordBellman(Vertex[] matrix, int sz)
    {
      int[] d = new int[buttonsCount];
      for (int i = 0; i < buttonsCount; i++)
      {
        d[i] = 2000000000;
      }
      d[0] = 0;
      for (int i = 1; i < buttonsCount; i++)
      {
        for (int j = 0; j < countOfLinks; j++)
        {
          if (d[matrix[j].second] > (d[matrix[j].first] + matrix[j].value))
          {
            d[matrix[j].second] = d[matrix[j].first] + matrix[j].value;
          }
        }
      }
      for(int i = 1; i < buttonsCount; i++)
      {
        MessageBox.Show("Вершина: " + (i+1).ToString() + " Расстояние: " + d[i].ToString());
      }
    }

    bool pressedLinking = false;
    int countOfLinks = 0;
    List<List<int>> linksInLinks = new List<List<int>>();
    Button first, second;
    bool seted = false;
    int choosedAll = 0;
    int buttonsCount = 0;
    List<Button> buttons = new List<Button>();
    private void createVertex_Click(object sender, EventArgs e)
    {
      UpdatePicture();
      buttonsCount++;
      Button btn = new Button();
      btn.Size = new Size(30, 30);
      btn.Location = new Point(this.Width / 2, this.Height/2);
      btn.Text = buttonsCount.ToString();
      btn.Name = buttonsCount.ToString();
      pictureBox1.Controls.Add(btn);
      btn.BringToFront();
      btn.BackColor = Color.White;
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

    public List<List<int>> GetArray()
    {
      return linksInLinks;
    }
    private void ButtonOnClick(object sender, EventArgs eventArgs)
    {
      UpdatePicture();
      Graphics clear = pictureBox1.CreateGraphics();
      if (pressedLinking)
      {
        clear.Clear(Color.White);
        UpdatePicture();
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
                if (buttons[i] != second && first != buttons[i])
                {
                  if (second != null)
                    second.BackColor = Color.White;
                  second = buttons[i];
                  buttons[i].BackColor = Color.DeepSkyBlue;
                  seted = false;
                  choosedAll++;
                }
              }
              else
              {
                if (buttons[i] != first && second != buttons[i])
                {
                  if (first != null)
                    first.BackColor = Color.White;
                  first = buttons[i];
                  buttons[i].BackColor = Color.Orange;
                  seted = true;
                  choosedAll++;
                }
              }
            }
          }
        }
      }
      if (pressedLinking && second != null && first != null)
      {
        clear = pictureBox1.CreateGraphics();
        clear.Clear(Color.White);
        pictureBox1.InitialImage = null;
        if (buttonsCount > 1)
        {
          int Weight = 0;
          int Width = buttons[0].Width / 2;
          int Height = buttons[0].Height / 2;
          Pen myPen = new Pen(Color.Red);
          using (Graphics g = pictureBox1.CreateGraphics())
          {
            try
            {
              Weight = int.Parse(textBox1.Text);
            }
            catch
            {
              Weight = 1;
            }
            linksInLinks[int.Parse(first.Text) - 1][int.Parse(second.Text) - 1] = Weight;
            choosedAll = 0;
            countOfLinks++;
            first.BackColor = Color.White;
            second.BackColor = Color.White;
            first = null;
            second = null;
          }
        }
        else
        {
          MessageBox.Show("Add some more vertexs");
        }
        clear.Clear(Color.White);
        UpdatePicture();
      }
    }
    private void button3_Click(object sender, EventArgs e)
    {
      Graphics clear = pictureBox1.CreateGraphics();
      clear.Clear(Color.White);
      UpdatePicture();
      if (buttonsCount > 1)
      {
        int[,] graph = new int[buttonsCount, buttonsCount];
        for (int i = 0; i < buttonsCount; i++)
        {
          for (int j = 0; j < buttonsCount; j++)
          {
            graph[i, j] = linksInLinks[i][j];
          }
        }
        DijkstraAlgo(graph, 0, linksInLinks.Count, 1);
      }
      else
      {
        MessageBox.Show("Add some more vertexs");
      }
    }
    private void label1_Click(object sender, EventArgs e)
    {

    }
    private void button4_Click(object sender, EventArgs e)
    {
      int counter = 0;
      Vertex[] matrix = new Vertex[(countOfLinks)]; 
      for(int i = 0; i < buttonsCount; i++)
      {
        for(int j = 0; j < buttonsCount; j++)
        {
          if (linksInLinks[i][j] != 0)
          {
            matrix[counter] = new Vertex();
            matrix[counter].first = i;
            matrix[counter].second = j;
            matrix[counter].value = linksInLinks[i][j];
            counter++;
          }
        }
      }
      FordBellman(matrix, buttonsCount);
    }
    private void button1_Click(object sender, EventArgs e)
    {
      if (buttonsCount != 0)
      {
        for (int i = 0; i < buttonsCount; i++)
        {
          buttons[i].Dispose();
        }
        buttons.Clear();
        linksInLinks.Clear();
        buttonsCount = 0;
        Graphics clear = pictureBox1.CreateGraphics();
        clear.Clear(Color.White);
      }
      Random rnd = new Random();
      buttonsCount = rnd.Next(3, 6);
      int offsetX = 0, offsetY = 0;
      int centerX = this.Width/2, CenterY = this.Height/2;
      int currentX = 0, currentY = 0;
      offsetX = 55;
      offsetY = 55;
      currentX = centerX + 46;
      currentY = CenterY + 49;
      for (int i = 0; i < buttonsCount; i++)
      {
        Button btn = new Button();
        btn.Size = new Size(30, 30);
        if(currentX < centerX && currentY < CenterY)
        {
          currentX = currentX + offsetX;
          currentY = currentY - offsetY;
          btn.Location = new Point(currentX, currentY);
        }
        if(currentX > centerX && currentY < CenterY)
        {
          currentX = currentX + offsetX;
          currentY = currentY + offsetY;
          btn.Location = new Point(currentX, currentY);
        }
        if (currentX > centerX && currentY > CenterY)
        {
          currentX = currentX - offsetX;
          currentY = currentY + offsetY;
          btn.Location = new Point(currentX, currentY);
        }
        if (currentX < centerX && currentY > CenterY)
        {
          currentX = currentX - offsetX;
          currentY = currentY - offsetY;
          btn.Location = new Point(currentX, currentY);
        }
        btn.Text = (i + 1).ToString();
        btn.Name = i.ToString();
        pictureBox1.Controls.Add(btn);
        btn.BringToFront();
        btn.BackColor = Color.White;
        ControlExtension.Draggable(btn, true);
        btn.Click += ButtonOnClick;
        buttons.Add(btn);
        string someString = btn.Name;
      }
      for (int i = 0; i < buttonsCount; i++)
      {
        linksInLinks.Add(new List<int>());
        for (int j = 0; j < buttonsCount; j++)
        {
          linksInLinks[i].Add(0);
        }
      }
      for (int k = 0; k < buttonsCount; k++)
      {
        for (int m = 0; m < buttonsCount; m++)
        {
          int createLink = rnd.Next(0, 5);
          if (createLink > 2 || k == 0)
          {
            if (k != 0)
            {
              int Weight = rnd.Next(1, 6);
              int first = rnd.Next(0, buttonsCount), second;
              do
              {
                second = rnd.Next(0, buttonsCount);
              }
              while (second == first);
              linksInLinks[first][second] = Weight;
              //linksInLinks[second][first] = Weight;
            }
            else
            {
              int Weight = rnd.Next(1, 6);
              int first = 0, second;
              do
              {
                second = rnd.Next(0, buttonsCount);
              }
              while (second == first);
              linksInLinks[first][second] = Weight;
              //linksInLinks[second][first] = Weight;
            }
          }
          UpdatePicture();
        }
      }
      countOfLinks = 0; 
      for (int i = 0; i < buttonsCount; i++)
      {
        for (int j = 0; j < buttonsCount; j++)
        {
          if(linksInLinks[i][j] != 0)
          {
            countOfLinks++;
          }
        }
      }
    }

    private void button5_Click(object sender, EventArgs e)
    {
      Form2 formTwo = new Form2();
      formTwo.Owner = this;
      formTwo.Show();
    }

    private void button6_Click(object sender, EventArgs e)
    {
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (pressedLinking == false)
      {
        pressedLinking = true;
        button2.BackColor = Color.Red;
      }
      else
      {
        button2.BackColor = Color.White;
        pressedLinking = false;
        if (first != null)
        {
          first.BackColor = Color.White;
          first = null;
        }
        if (second != null)
        {
          second.BackColor = Color.White;
          second = null;
        }
      }
    }
    public void Sinchronise(List<List<int>> array, int countOfVertexes)
    {
      if (buttonsCount != 0)
      {
        for (int i = 0; i < buttonsCount; i++)
        {
          buttons[i].Dispose();
        }
        buttons.Clear();
        linksInLinks.Clear();
        buttonsCount = 0;
        Graphics clear = pictureBox1.CreateGraphics();
        clear.Clear(Color.White);
      }
      buttonsCount = countOfVertexes;
      int offsetX = 0, offsetY = 0;
      int centerX = this.Width / 2, CenterY = this.Height / 2;
      int currentX = 0, currentY = 0;
      offsetX = 55;
      offsetY = 55;
      currentX = centerX + 46;
      currentY = CenterY + 49;
      
      for (int i = 0; i < buttonsCount; i++)
      {
        Button btn = new Button();
        btn.Size = new Size(30, 30);
        if (currentX < centerX && currentY < CenterY)
        {
          currentX = currentX + offsetX;
          currentY = currentY - offsetY;
          btn.Location = new Point(currentX, currentY);
        }
        if (currentX > centerX && currentY < CenterY)
        {
          currentX = currentX + offsetX;
          currentY = currentY + offsetY;
          btn.Location = new Point(currentX, currentY);
        }
        if (currentX > centerX && currentY > CenterY)
        {
          currentX = currentX - offsetX;
          currentY = currentY + offsetY;
          btn.Location = new Point(currentX, currentY);
        }
        if (currentX < centerX && currentY > CenterY)
        {
          currentX = currentX - offsetX;
          currentY = currentY - offsetY;
          btn.Location = new Point(currentX, currentY);
        }
        btn.Text = (i + 1).ToString();
        btn.Name = i.ToString();
        pictureBox1.Controls.Add(btn);
        btn.BringToFront();
        btn.BackColor = Color.White;
        ControlExtension.Draggable(btn, true);
        btn.Click += ButtonOnClick;
        buttons.Add(btn);
        string someString = btn.Name;
      }
      for (int i = 0; i < buttonsCount; i++)
      {
        linksInLinks.Add(new List<int>());
        for (int j = 0; j < buttonsCount; j++)
        {
          linksInLinks[i].Add(array[i][j]);
        }
      }
      array.Clear();
      countOfLinks = 0;
      for (int i = 0; i < buttonsCount; i++)
      {
        for (int j = 0; j < buttonsCount; j++)
        {
          if (linksInLinks[i][j] != 0)
          {
            countOfLinks++;
          }
        }
      }
      UpdatePicture();
    }
  }
}