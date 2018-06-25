/**
 * Daryl Crosbie
 * ID: P453055
 * Date: 23/02/2018
 * AT1.2
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BST
{
    public partial class BST : Form
    {
        public BST()
        {
            InitializeComponent();
        }
        //Integer type binary tree object
        BinarySearchTree<int> intTree = new BinarySearchTree<int>();
        string trace;

        //Method populates the tree with 10 random integer values 
        private void bFill_Click(object sender, EventArgs e)
        {
            Random r = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < 10; i++)
            {
                int randomInt = r.Next(1, 500);
                intTree.Insert(randomInt);
                trace += randomInt + " ";
            }
            display();
        }

        //Insert button, checks the data, inserts to the tree
        private void bInsert_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(insertBx.Text))
            {
                try
                {
                    Convert.ToInt32(insertBx.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Numeric values only");
                    return;
                }
                intTree.Insert(Convert.ToInt32(insertBx.Text));
                trace += Convert.ToInt32(insertBx.Text) + " ";
                display();
            }
           
        }

        //Remove button, checks the data and tree for the value, removes it 
        private void bRemove_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(removeBx.Text))
            {
                try
                {
                    Convert.ToInt32(removeBx.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Numeric values only");
                    removeBx.Clear();
                    return;
                }
                int a = intTree.Find(Convert.ToInt32(removeBx.Text));
                if(a == 0)
                {
                    MessageBox.Show("Not in tree");
                    removeBx.Clear();
                    return;
                }
                intTree.Remove(Convert.ToInt32(removeBx.Text));
                removeBx.Clear();
                display();
            }
        }

        //Find button, checks the data, searches tree for the value
        private void bFind_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(findBx.Text))
            {
                try
                {
                    Convert.ToInt32(findBx.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Numeric values only");
                    findBx.Clear();
                    return;
                }
                int a = intTree.Find(Convert.ToInt32(findBx.Text));
                if (a == 0)
                {
                    MessageBox.Show("Item not found");
                    findBx.Clear();
                    return;
                }
                else
                {
                    MessageBox.Show("Item Found");
                }
                findBx.Clear();
                list.Items.Clear();
            }
        }

        //Button finds minimum value and displays it
        private void bFindMin_Click(object sender, EventArgs e)
        {
            if(intTree.FindMin() != 0)
            findMinBx.Text = intTree.FindMin().ToString();
        }

        //Button finds maximum value and displays it
        private void bFindMax_Click(object sender, EventArgs e)
        {
            findMaxBx.Text = intTree.FindMax().ToString();
        }
        //Method displays tree to listbox
        public void display()
        {
            list.Items.Clear();
            if(trace != null)
            {
                list.Items.Add(trace);
            }
            if (!intTree.IsEmpty())
            {
                list.Items.Add(intTree);
            }
        }
        //Button shows the root value
        private void bRoot_Click(object sender, EventArgs e)
        {
            if(intTree.Root != null)
            {
                rootBx.Text = intTree.Root.Element.ToString();
            }
           
        }
        //Button checks if tree has data
        private void bIsEmpty_Click(object sender, EventArgs e)
        {
            if (intTree.IsEmpty())
            {
                MessageBox.Show("Tree is empty");
            }
            else
            {
                MessageBox.Show("No");
            }
            display();
        }
        //Button when clicked, asks to clear the tree of data
        private void bMakeEmpty_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure?"," ", MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            intTree.MakeEmpty();
            display();
        }
        //Button removes the minimum value from the tree
        private void bRemoveMin_Click(object sender, EventArgs e)
        {
            if (!intTree.IsEmpty())
            {
                intTree.RemoveMin();
                display();
            }
        }

        private void StatusLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
