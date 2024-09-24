using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BianrySearchTree;

namespace BinarySearchTree
{
    public partial class Form1 : Form
    {
        private BST bst;
      
        public Form1()
        {
            InitializeComponent();
            bst = new BST();
            // Liên kết sự kiện Paint của Form với hàm Form1_Paint
            this.Paint += new PaintEventHandler(Form1_Paint);
        }

        private void DrawNode(Graphics g, Node node, int x, int y, int xOffset, int yOffset)
        {
            if (node == null)
                return;

            // Vẽ vòng tròn cho node
            g.FillEllipse(Brushes.LightBlue, x - 20, y - 20, 40, 40);
            g.DrawEllipse(Pens.Black, x - 20, y - 20, 40, 40);

            // Vẽ giá trị của node
            g.DrawString(node.Value.ToString(), new Font("Arial", 10), Brushes.Black, x - 10, y - 10);

            // Vẽ đường nối tới node con trái
            if (node.Left != null)
            {
                g.DrawLine(Pens.Black, x, y, x - xOffset, y + yOffset);
                DrawNode(g, node.Left, x - xOffset, y + yOffset, xOffset / 2, yOffset);
            }

            // Vẽ đường nối tới node con phải
            if (node.Right != null)
            {
                g.DrawLine(Pens.Black, x, y, x + xOffset, y + yOffset);
                DrawNode(g, node.Right, x + xOffset, y + yOffset, xOffset / 2, yOffset);
            }
        }

        private void DrawTree(Graphics g)
        {
            if (bst.Root != null)
            {
                // Vẽ cây bắt đầu từ gốc (root) với tọa độ trung tâm form
                DrawNode(g, bst.Root, this.ClientSize.Width / 2, 50, this.ClientSize.Width / 4, 50);
            }
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawTree(e.Graphics); // Gọi hàm vẽ cây
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int value = int.Parse(txtValue.Text); // Lấy giá trị từ textbox
            bst.Add(value);
            this.Invalidate(); // Gọi lại sự kiện Paint để vẽ lại cây
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
