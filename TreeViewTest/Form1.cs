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
                GameCharacter gameCharacter in GameCharacterRepository.sampleGameCharacters
            )
            {
                AddNodeForGameCharacter(gameCharacter);
            }
            dataGridView.DataSource = GenerateSampleDataTable();
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

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = treeView1.SelectedNode;
            string characterName = selectedNode.Text;
            this.characterNameDisplay.Text = characterName;
            this.speciesDisplay.Text
                = GameCharacterRepository.GetSpeciesByCharacterName(characterName);
            this.weaponDisplay.Text
                = GameCharacterRepository.GetWeaponByCharacterName(characterName);
        }

        private DataTable GenerateSampleDataTable()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Species", typeof(string));
            dataTable.Columns.Add("Weapon", typeof(string));

            dataTable.Rows.Add("Ozymandias", "Wel", "Glaive");
            dataTable.Rows.Add("Vashya", "Draykin", "Force Rod");
            dataTable.Rows.Add("Amadeus", "Seraph", "Staff");

            return dataTable;
        }
    }
}
