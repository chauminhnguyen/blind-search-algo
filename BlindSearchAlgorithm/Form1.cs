using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace BlindSearchAlgorithm
{
    public partial class Form1 : Form
    {
        DataTable dtTable;
        int V = 0;

        public Form1()
        {
            InitializeComponent();
            SetGraph();
        }



        private void MoveSidePanel(Control c)
        {
            SidePanel.Height = c.Height;
            SidePanel.Top = c.Top;
        }
        void SetGraph()
        {
            All.Text = "1";

            Line_Start.Text = "1";
            Line_End.Text = "2";
        }

        private void DFS_Click(object sender, EventArgs e)
        {
            MoveSidePanel(DFS);
            result.Text = DFSAll(Convert.ToInt16(All.Text));
        }


        private void DFS_Line_Click(object sender, EventArgs e)
        {
            MoveSidePanel(DFS_Line);
            result.Text = DFSFromTo(Convert.ToInt16(Line_Start.Text), Convert.ToInt16(Line_End.Text));
        }

        private void BFS_Click(object sender, EventArgs e)
        {
            MoveSidePanel(BFS);
            result.Text = BFSAll(Convert.ToInt16(All.Text));
        }

        private void BFS_Line_Click(object sender, EventArgs e)
        {
            MoveSidePanel(BFS_Line);
            result.Text = BFSFromTo(Convert.ToInt16(Line_Start.Text), Convert.ToInt16(Line_End.Text));
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int Dequeue(int[] Queue, int cur)
        {
            for (int i = 0; i <= cur; i++)
            {
                Queue[i] = Queue[i + 1];
            }
            cur--;
            return cur;
        }

        string DFSAll(int Start)
        {
            string res = "";
            int[] res_arr = new int[20];
            int index = 0;

            int[] Stack = new int[20];
            int[] Close = new int[20];
            int top = 0;
            Stack[top] = Start;
            //cout << Stack[top] << " ";
            res_arr[index] = Stack[top];
            index++;

            while (top >= 0)
            {
                int flag = 0;
                int i = Stack[top];
                Close[i] = 1;
                for (int j = 0; j < V; j++)
                {
                    if (Convert.ToInt16(dtTable.Rows[i][j].ToString()) > 0 && Close[j] != 1)
                    {
                        //cout << j << " ";
                        res_arr[index] = j;
                        index++;

                        flag = 1;
                        top++;
                        Stack[top] = j;
                        Close[j] = 1;
                        break;
                    }
                }
                if (flag == 0) top--;
            }

            for (int i = 0; i < index - 1; i++)
            {
                res += res_arr[i].ToString() + "-->";
            }
            res += res_arr[index - 1];

            return res;
        }

        string BFSAll(int Start)
        {
            string res = "";
            int[] res_arr = new int[20];
            int index = 0;

            int[] Queue = new int[20];
            int[] Close = new int[20];
            int cur = 0;
            Queue[cur] = Start;
            //cout << Queue[cur] << " ";
            res_arr[index] = Queue[cur];
            index++;

            while (cur >= 0)
            {
                int i = Queue[0];
                cur = Dequeue(Queue, cur);
                for (int j = 0; j < V; j++)
                {
                    if (Convert.ToInt16(dtTable.Rows[i][j].ToString()) > 0 && Close[j] != 1)
                    {
                        //cout << j << " ";
                        res_arr[index] = j;
                        index++;

                        cur++;
                        Queue[cur] = j;
                        Close[j] = 1;
                    }
                }
                Close[i] = 1;
            }

            for (int i = 0; i < index - 1; i++)
            {
                res += res_arr[i].ToString() + "-->";
            }
            res += res_arr[index - 1];

            return res;
        }

        string DFSFromTo(int Start, int End)
        {
            string res = "";
            int[] res_arr = new int[20];
            int index = 0;
            bool isDone = false;

            int[] Stack = new int[20];
            int[] Close = new int[20];
            int top = 0;
            Stack[top] = Start;
            //cout << Stack[top] << " ";
            res_arr[index] = Stack[top];
            index++;

            while (top >= 0)
            {
                int flag = 0;
                int i = Stack[top];
                Close[i] = 1;
                for (int j = 0; j < V; j++)
                {
                    if (Convert.ToInt16(dtTable.Rows[i][j].ToString()) > 0 && Close[j] != 1)
                    {
                        //cout << j << " ";
                        res_arr[index] = j;
                        index++;

                        flag = 1;
                        top++;
                        Stack[top] = j;
                        Close[j] = 1;
                        if (j == End)
                        {
                            isDone = true;
                            break;
                        }
                    }
                }
                if (isDone) break;
                if (flag == 0) top--;
            }

            for (int i = 0; i < index - 1; i++)
            {
                res += res_arr[i].ToString() + "-->";
            }
            res += res_arr[index - 1];

            return res;
        }

        string BFSFromTo(int Start, int End)
        {
            string res = "";
            int[] res_arr = new int[20];
            int index = 0;
            bool isDone = false;

            int[] Queue = new int[20];
            int[] Close = new int[20];
            int cur = 0;
            Queue[cur] = Start;
            //cout << Queue[cur] << " ";
            res_arr[index] = Queue[cur];
            index++;

            while (cur >= 0)
            {
                int i = Queue[0];
                cur = Dequeue(Queue, cur);
                for (int j = 0; j < V; j++)
                {
                    if (Convert.ToInt16(dtTable.Rows[i][j].ToString()) > 0 && Close[j] != 1)
                    {
                        //cout << j << " ";
                        res_arr[index] = j;
                        index++;

                        cur++;
                        Queue[cur] = j;
                        Close[j] = 1;
                        if (j == End)
                        {
                            isDone = true;
                            break;
                        }
                    }
                }
                if (isDone) break;
                Close[i] = 1;
            }

            for (int i = 0; i < index - 1; i++)
            {
                res += res_arr[i].ToString() + "-->";
            }
            res += res_arr[index - 1];

            return res;
        }

        void ReadMatrixArr(string filename)
        {
            dtTable = new DataTable();
            string[] lines = File.ReadAllLines(filename);
            int flag = 0;
            foreach (string s in lines)
            {
                if (flag == 0)
                    V = Convert.ToInt16(s);
                else
                {
                    string[] st = s.Split('\t');
                    if (dtTable.Columns.Count == 0)
                        for (int i = 0; i < st.Length; i++)
                            dtTable.Columns.Add(i.ToString());
                    dtTable.Rows.Add(st);
                }
                flag = 1;
            }
            dataGridView1.DataSource = dtTable;
        }

        private void graph1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graph.Text = "Graph 1";
            pictureBox2.Image = global::BlindSearchAlgorithm.Properties.Resources.G1;
            ReadMatrixArr(@"G1.txt");
        }

        private void graph2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graph.Text = "Graph 2";
            pictureBox2.Image = global::BlindSearchAlgorithm.Properties.Resources.G2;
            ReadMatrixArr(@"G2.txt");
        }

        private void graph3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graph.Text = "Graph 3";
            pictureBox2.Image = global::BlindSearchAlgorithm.Properties.Resources.G3;
            ReadMatrixArr(@"G3.txt");
        }

        private void graph4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graph.Text = "Graph 4";
            pictureBox2.Image = global::BlindSearchAlgorithm.Properties.Resources.G4;
            ReadMatrixArr(@"G4.txt");
        }
    }
}
