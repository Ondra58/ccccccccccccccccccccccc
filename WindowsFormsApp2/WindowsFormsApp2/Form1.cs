using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> list = new List<int>();
        public void Vypis(List<int> list)
        {
            foreach(int cislo in list)
            {
                listBox1.Items.Add(cislo);
            }
        }
        public int Druhemax()
        {
            int max = int.MinValue;
            foreach (int cislo in list)
            {
                if(cislo > max)
                {
                    max = cislo;
                }
            }
            return druhemax;
        }
    }
}
