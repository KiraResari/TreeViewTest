using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeViewTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(
                GameCharacter gameCharacter in SampleGameCharacters.sampleGameCharacters
            )
            {
                AddNodeForGameCharacter(gameCharacter);
            }
        }

        private void AddNodeForGameCharacter(GameCharacter gameCharacter)
        {
            treeView1.Nodes.Add(gameCharacter.ToTreeNode());
        }

        private void TreeView1_NodeMouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            TreeNode node = treeView1.SelectedNode;
            
            MessageBox.Show(string.Format("You selected: {0}", node.Text));
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = treeView1.SelectedNode;
            this.label1.Text = selectedNode.Text;
        }
    }
}
