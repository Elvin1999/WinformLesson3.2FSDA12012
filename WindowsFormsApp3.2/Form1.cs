using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            List<string> names = new List<string>
            {
                "Elxan",
                "Tural",
                "Cavid",
                "Murad",
                "Fidan",
                "Anara"
            };
            //checkedListBox1.Items.AddRange(names.ToArray());
            comboBox1.DataSource = names;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                builder.Append($"{(item as string)}\n");
            }
            label1.Text = builder.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = comboBox1.SelectedItem as string;
            label1.Text = item;
        }
    }
}
