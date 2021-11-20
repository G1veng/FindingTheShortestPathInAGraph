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

    public class templates
    {
      public bool created = false;
      public int countOfTemplates = 3;
      public List<List<int>> firstGraph;
      public int sizeOfFirst = 6;
      public List<List<int>> secondGraph;
      public int sizeOfSecond = 10;
      public List<List<int>> thirdGraph;
      public int sizeOfThird = 7;
      public string[] pathForFirstGraph;
      public string[] pathForSecondGraph;
      public string[] pathForThirdGraph;
    }

    public void fillClassTemplates(templates Graph)
    {
      Graph.created = true;
      Graph.firstGraph = new List<List<int>>(Graph.sizeOfFirst);
      for(int i = 0; i < Graph.sizeOfFirst; i++)
      {
        Graph.firstGraph.Add(new List<int>());
      }
      Graph.firstGraph[0].Add(0); Graph.firstGraph[0].Add(2); Graph.firstGraph[0].Add(0); Graph.firstGraph[0].Add(7); Graph.firstGraph[0].Add(0); Graph.firstGraph[0].Add(0);
      Graph.firstGraph[1].Add(0); Graph.firstGraph[1].Add(0); Graph.firstGraph[1].Add(4); Graph.firstGraph[1].Add(0); Graph.firstGraph[1].Add(0); Graph.firstGraph[1].Add(0);
      Graph.firstGraph[2].Add(2); Graph.firstGraph[2].Add(0); Graph.firstGraph[2].Add(0); Graph.firstGraph[2].Add(13); Graph.firstGraph[2].Add(0); Graph.firstGraph[2].Add(0);
      Graph.firstGraph[3].Add(0); Graph.firstGraph[3].Add(0); Graph.firstGraph[3].Add(0); Graph.firstGraph[3].Add(0); Graph.firstGraph[3].Add(1); Graph.firstGraph[3].Add(0);
      Graph.firstGraph[4].Add(0); Graph.firstGraph[4].Add(0); Graph.firstGraph[4].Add(12); Graph.firstGraph[4].Add(0); Graph.firstGraph[4].Add(0); Graph.firstGraph[4].Add(5);
      Graph.firstGraph[5].Add(0); Graph.firstGraph[5].Add(0); Graph.firstGraph[5].Add(2); Graph.firstGraph[5].Add(0); Graph.firstGraph[5].Add(0); Graph.firstGraph[5].Add(0);

      Graph.secondGraph = new List<List<int>>(Graph.sizeOfSecond);
      for (int i = 0; i < Graph.sizeOfSecond; i++)
      {
        Graph.secondGraph.Add(new List<int>());
      }
      Graph.secondGraph[0].Add(0); Graph.secondGraph[0].Add(3); Graph.secondGraph[0].Add(4); Graph.secondGraph[0].Add(2); Graph.secondGraph[0].Add(0); Graph.secondGraph[0].Add(0);
      Graph.secondGraph[0].Add(0); Graph.secondGraph[0].Add(0); Graph.secondGraph[0].Add(0); Graph.secondGraph[0].Add(0);
      Graph.secondGraph[1].Add(0); Graph.secondGraph[1].Add(0); Graph.secondGraph[1].Add(0); Graph.secondGraph[1].Add(0); Graph.secondGraph[1].Add(3); Graph.secondGraph[1].Add(0);
      Graph.secondGraph[1].Add(0); Graph.secondGraph[1].Add(0); Graph.secondGraph[1].Add(0); Graph.secondGraph[1].Add(0);
      Graph.secondGraph[2].Add(0); Graph.secondGraph[2].Add(0); Graph.secondGraph[2].Add(0); Graph.secondGraph[2].Add(0); Graph.secondGraph[2].Add(6); Graph.secondGraph[2].Add(0);
      Graph.secondGraph[2].Add(0); Graph.secondGraph[2].Add(0); Graph.secondGraph[2].Add(0); Graph.secondGraph[2].Add(0);
      Graph.secondGraph[3].Add(0); Graph.secondGraph[3].Add(0); Graph.secondGraph[3].Add(0); Graph.secondGraph[3].Add(0); Graph.secondGraph[3].Add(3); Graph.secondGraph[3].Add(1);
      Graph.secondGraph[3].Add(0); Graph.secondGraph[3].Add(0); Graph.secondGraph[3].Add(0); Graph.secondGraph[3].Add(0);
      Graph.secondGraph[4].Add(0); Graph.secondGraph[4].Add(0); Graph.secondGraph[4].Add(0); Graph.secondGraph[4].Add(0); Graph.secondGraph[4].Add(0); Graph.secondGraph[4].Add(1);
      Graph.secondGraph[4].Add(8); Graph.secondGraph[4].Add(0); Graph.secondGraph[4].Add(7); Graph.secondGraph[4].Add(0);
      Graph.secondGraph[5].Add(0); Graph.secondGraph[5].Add(0); Graph.secondGraph[5].Add(0); Graph.secondGraph[5].Add(0); Graph.secondGraph[5].Add(0); Graph.secondGraph[5].Add(0);
      Graph.secondGraph[5].Add(6); Graph.secondGraph[5].Add(12); Graph.secondGraph[5].Add(0); Graph.secondGraph[5].Add(0);
      Graph.secondGraph[6].Add(0); Graph.secondGraph[6].Add(0); Graph.secondGraph[6].Add(0); Graph.secondGraph[6].Add(0); Graph.secondGraph[6].Add(0); Graph.secondGraph[6].Add(0);
      Graph.secondGraph[6].Add(0); Graph.secondGraph[6].Add(0); Graph.secondGraph[6].Add(0); Graph.secondGraph[6].Add(14);
      Graph.secondGraph[7].Add(0); Graph.secondGraph[7].Add(0); Graph.secondGraph[7].Add(0); Graph.secondGraph[7].Add(0); Graph.secondGraph[7].Add(0); Graph.secondGraph[7].Add(0);
      Graph.secondGraph[7].Add(0); Graph.secondGraph[7].Add(0); Graph.secondGraph[7].Add(6); Graph.secondGraph[7].Add(11);
      Graph.secondGraph[8].Add(0); Graph.secondGraph[8].Add(0); Graph.secondGraph[8].Add(0); Graph.secondGraph[8].Add(0); Graph.secondGraph[8].Add(0); Graph.secondGraph[8].Add(0);
      Graph.secondGraph[8].Add(0); Graph.secondGraph[8].Add(0); Graph.secondGraph[8].Add(0); Graph.secondGraph[8].Add(3);
      Graph.secondGraph[9].Add(0); Graph.secondGraph[9].Add(0); Graph.secondGraph[9].Add(0); Graph.secondGraph[9].Add(0); Graph.secondGraph[9].Add(0); Graph.secondGraph[9].Add(0);
      Graph.secondGraph[9].Add(0); Graph.secondGraph[9].Add(0); Graph.secondGraph[9].Add(0); Graph.secondGraph[9].Add(0);

      Graph.thirdGraph = new List<List<int>>(Graph.sizeOfThird);
      for (int i = 0; i < Graph.sizeOfThird; i++)
      {
        Graph.thirdGraph.Add(new List<int>());
      }
      Graph.thirdGraph[0].Add(0); Graph.thirdGraph[0].Add(1); Graph.thirdGraph[0].Add(0); Graph.thirdGraph[0].Add(0); Graph.thirdGraph[0].Add(0); Graph.thirdGraph[0].Add(0); Graph.thirdGraph[0].Add(0);
      Graph.thirdGraph[1].Add(0); Graph.thirdGraph[1].Add(0); Graph.thirdGraph[1].Add(3); Graph.thirdGraph[1].Add(2); Graph.thirdGraph[1].Add(1); Graph.thirdGraph[1].Add(0); Graph.thirdGraph[1].Add(0);
      Graph.thirdGraph[2].Add(0); Graph.thirdGraph[2].Add(0); Graph.thirdGraph[2].Add(0); Graph.thirdGraph[2].Add(1); Graph.thirdGraph[2].Add(4); Graph.thirdGraph[2].Add(0); Graph.thirdGraph[2].Add(0);
      Graph.thirdGraph[3].Add(2); Graph.thirdGraph[3].Add(0); Graph.thirdGraph[3].Add(0); Graph.thirdGraph[3].Add(0); Graph.thirdGraph[3].Add(2); Graph.thirdGraph[3].Add(0); Graph.thirdGraph[3].Add(0);
      Graph.thirdGraph[4].Add(0); Graph.thirdGraph[4].Add(0); Graph.thirdGraph[4].Add(0); Graph.thirdGraph[4].Add(0); Graph.thirdGraph[4].Add(0); Graph.thirdGraph[4].Add(3); Graph.thirdGraph[4].Add(0);
      Graph.thirdGraph[5].Add(0); Graph.thirdGraph[5].Add(0); Graph.thirdGraph[5].Add(0); Graph.thirdGraph[5].Add(0); Graph.thirdGraph[5].Add(0); Graph.thirdGraph[5].Add(0); Graph.thirdGraph[5].Add(0);
      Graph.thirdGraph[6].Add(0); Graph.thirdGraph[6].Add(0); Graph.thirdGraph[6].Add(0); Graph.thirdGraph[6].Add(1); Graph.thirdGraph[6].Add(0); Graph.thirdGraph[6].Add(0); Graph.thirdGraph[6].Add(0);

      Graph.pathForSecondGraph = new string[Graph.sizeOfSecond];
      Graph.pathForSecondGraph[0] = "1 >"; Graph.pathForSecondGraph[1] = "1 >2"; Graph.pathForSecondGraph[2] = "1 > 3"; Graph.pathForSecondGraph[3] = "1 > 4";
      Graph.pathForSecondGraph[4] = "1 > 4 > 5"; Graph.pathForSecondGraph[5] = "1 >4 >6"; Graph.pathForSecondGraph[6] = "1 >4 > 6 >7"; Graph.pathForSecondGraph[7] = "1 >4 > 6 > 8";
      Graph.pathForSecondGraph[8] = "1 >4 > 5 >9"; Graph.pathForSecondGraph[9] = "1 >4 > 5 >9 >10";

      Graph.pathForFirstGraph = new string[Graph.sizeOfFirst];
      Graph.pathForFirstGraph[0] = "1 >"; Graph.pathForFirstGraph[1] = "1 >2"; Graph.pathForFirstGraph[2] = "1 >2 >3"; Graph.pathForFirstGraph[3] = "1 >4";
      Graph.pathForFirstGraph[4] = "1 >4 > 5"; Graph.pathForFirstGraph[5] = "1 >4 >5 >6";

      Graph.pathForThirdGraph = new string[Graph.sizeOfThird];
      Graph.pathForThirdGraph[0] = "1 >"; Graph.pathForThirdGraph[1] = "1 >2"; Graph.pathForThirdGraph[2] = "1 >2 >3"; Graph.pathForThirdGraph[3] = "1 >2 >4";
      Graph.pathForThirdGraph[4] = "1 >2 >5"; Graph.pathForThirdGraph[5] = "1 >2 >5 >6"; Graph.pathForThirdGraph[6] = "null";
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
      //pictureBox1.BackColor = Color.White;
      clear.Clear(Color.White);
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

    private void Print(int[] distance, int verticesCount, int destination, string[] routes)
    {
      for (int i = 1; i < verticesCount; ++i)
      {
        if (!Graph.created)
        {
          if (routes[i] != null)
          {
            routes[i] = routes[i].Trim(new char[] { ' ', '>' });
            MessageBox.Show("Вершина: " + (i + 1).ToString() + " Расстояние: " + distance[i].ToString() + '\n' + "Маршрут: " + routes[i]);
          }
          else
          {
            MessageBox.Show("Вершина: " + (i + 1).ToString() + " Расстояние: недостижимо" + '\n' + "Маршрут: нет");
          }
        }
        else
        {
          if (verticesCount == Graph.sizeOfFirst)
          {
            routes[i] = routes[i].Trim(new char[] { ' ', '>' });
            MessageBox.Show("Вершина: " + (i + 1).ToString() + " Расстояние: " + distance[i].ToString() + '\n' + "Маршрут: " + routes[i] + '\n' + "Правильный маршрут: " + Graph.pathForFirstGraph[i]);
          }
          if (verticesCount == Graph.sizeOfSecond)
          {
            routes[i] = routes[i].Trim(new char[] { ' ', '>' });
            MessageBox.Show("Вершина: " + (i + 1).ToString() + " Расстояние: " + distance[i].ToString() + '\n' + "Маршрут: " + routes[i] + '\n' + "Правильный маршрут: " + Graph.pathForSecondGraph[i]);
          }
          if (verticesCount == Graph.sizeOfThird)
          {
            routes[i] = routes[i].Trim(new char[] { ' ', '>' });
            MessageBox.Show("Вершина: " + (i + 1).ToString() + " Расстояние: " + distance[i].ToString() + '\n' + "Маршрут: " + routes[i] + '\n' + "Правильный маршрут: " + Graph.pathForThirdGraph[i]);
          }
        }
      }
      MessageBox.Show("Количество совершённых действий: " + countOfActions.ToString());
    }
    public void DijkstraAlgo(int[,] graph, int source, int verticesCount, int destination)
    {
      countOfActions = 0;
      int[] distance = new int[verticesCount];
      string[] routes = new string[verticesCount];
      bool[] shortestPathTreeSet = new bool[verticesCount];
      for (int i = 0; i < verticesCount; ++i)
      {
        distance[i] = int.MaxValue;
        shortestPathTreeSet[i] = false;
      }
      distance[source] = 0;
      routes[source] = (source + 1).ToString() + " >";
      for (int count = 0; count < verticesCount - 1; ++count)
      {
        int u = MinimumDistance(distance, shortestPathTreeSet, verticesCount);
        shortestPathTreeSet[u] = true;

        for (int v = 0; v < verticesCount; ++v)
        {
          if (!shortestPathTreeSet[v] && Convert.ToBoolean(graph[u, v]) && distance[u] != int.MaxValue && distance[u] + graph[u, v] < distance[v])
          {
            countOfActions++;
            distance[v] = distance[u] + graph[u, v];
            routes[v] = routes[u] + (v + 1) + " >";
          }
        }
      }
      Print(distance, verticesCount, destination, routes);
    }
    public void FordBellman(Vertex[] matrix, int sz)
    {
      countOfActions = 0;
      int[] d = new int[buttonsCount];
      string[] routes = new string[buttonsCount];
      for (int i = 0; i < buttonsCount; i++)
      {
        d[i] = 2000000000;
      }
      d[0] = 0;
      routes[0] = "1 >";
      for (int i = 1; i < buttonsCount; i++)
      {
        for (int j = 0; j < countOfLinks; j++)
        {
          if (d[matrix[j].second] > (d[matrix[j].first] + matrix[j].value))
          {
            countOfActions++;
            d[matrix[j].second] = d[matrix[j].first] + matrix[j].value;
            routes[matrix[j].second] = routes[matrix[j].first] + (matrix[j].second + 1) + " >";
          }
        }
      }
      for(int i = 1; i < buttonsCount; i++)
      {
        if (!Graph.created)
        {
          if (routes[i] != null)
          {
            routes[i] = routes[i].Trim(new char[] { ' ', '>' });
            MessageBox.Show("Вершина: " + (i + 1).ToString() + " Расстояние: " + d[i].ToString() + '\n' + "Маршрут: " + routes[i]);
          }
          else
          {
            MessageBox.Show("Вершина: " + (i + 1).ToString() + " Расстояние: недостижимо" + '\n' + "Маршрут: нет");
          }
        }
        if (Graph.created)
        {
          if(sz == Graph.sizeOfFirst)
          {
            routes[i] = routes[i].Trim(new char[] { ' ', '>' });
            MessageBox.Show("Вершина: " + (i + 1).ToString() + " Расстояние: " + d[i].ToString() + '\n' + "Маршрут: " + routes[i] + '\n' + "Правильный маршрут: " + Graph.pathForFirstGraph[i]);
          }
          if(sz == Graph.sizeOfSecond)
          {
            routes[i] = routes[i].Trim(new char[] { ' ', '>' });
            MessageBox.Show("Вершина: " + (i + 1).ToString() + " Расстояние: " + d[i].ToString() + '\n' + "Маршрут: " + routes[i] + '\n' + "Правильный маршрут: " + Graph.pathForSecondGraph[i]);
          }
          if(sz == Graph.sizeOfThird)
          {
            routes[i] = routes[i].Trim(new char[] { ' ', '>' });
            MessageBox.Show("Вершина: " + (i + 1).ToString() + " Расстояние: " + d[i].ToString() + '\n' + "Маршрут: " + routes[i] + '\n' + "Правильный маршрут: " + Graph.pathForThirdGraph[i]);
          }
        }
      }
      MessageBox.Show("Количество совершённых действий: " + countOfActions.ToString());
    }

    int countOfActions = 0;
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
      Graph.created = false;
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

    templates Graph = new templates();
    private void button1_Click(object sender, EventArgs e)
    {
      /*      if (buttonsCount != 0)
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
            }*/
      //templates Graph = new templates();
      fillClassTemplates(Graph);
      Random rnd = new Random();
      linksInLinks.Clear();
      int whichGraph = rnd.Next(1, Graph.countOfTemplates + 1);
      if(whichGraph == 1)
      {
        Sinchronise(Graph.firstGraph, Graph.sizeOfFirst);
      }
      if(whichGraph == 2)
      {
        Sinchronise(Graph.secondGraph, Graph.sizeOfSecond);
      }
      if(whichGraph == 3)
      {
        Sinchronise(Graph.thirdGraph, Graph.sizeOfThird);
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
      currentX = centerX + 54;
      currentY = CenterY - 10;
      //Graph.created = false;
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