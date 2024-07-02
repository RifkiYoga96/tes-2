using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tes_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            treeView1.Nodes.Clear();
           

            TreeNode hand = new TreeNode("Hand");
            hand.Nodes.Add("Muscle: Bicep");
            hand.Nodes.Add("Muscle: Tricep");
            hand.Nodes.Add("Muscle: Shoulder");

            TreeNode back = new TreeNode("Back");
            back.Nodes.Add("Muscle: traps");
            back.Nodes.Add("Muscle: Lower Back");
            back.Nodes.Add("Muscle: Deltoid");

            TreeNode leg = new TreeNode("Leg");
            leg.Nodes.Add("Muscle: Quadricep");
            leg.Nodes.Add("Muscle: Hamstring");
            leg.Nodes.Add("Muscle: Calves");


            treeView1.Nodes.Add(hand);
            treeView1.Nodes.Add(back);
            treeView1.Nodes.Add(leg);

         }
    }
}
