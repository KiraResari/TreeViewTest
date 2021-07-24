using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeViewTest
{
    class GameCharacter
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public string Weapon { get; set; }
        private List<GameCharacter> Children { get; set; } = new List<GameCharacter>();

        public GameCharacter(string name, string species, string weapon)
        {
            this.Name = name;
            this.Species = species;
            this.Weapon = weapon;
        }


        public GameCharacter(
            string name,
            string species,
            string weapon,
            List<GameCharacter> children
        ) : this(name, species, weapon) {
            this.Children = children;
        }

        public bool HasChildren()
        {
            if (Children == null)
            {
                return false;
            }
            return Children.Any();
        }

        public TreeNode ToTreeNode()
        {
            if (HasChildren())
            {
                TreeNode[] childrenNodes = GetChildrenNodes();
                return new TreeNode(Name, childrenNodes);
            }
            return new TreeNode(Name);
        }

        private TreeNode[] GetChildrenNodes()
        {
            List<TreeNode> childrenNodeList = new List<TreeNode>();
            foreach (GameCharacter childCharacter in Children)
            {
                TreeNode childNode = childCharacter.ToTreeNode();
                childrenNodeList.Add(childNode);
            }
            return childrenNodeList.ToArray();
        }
    }
}
