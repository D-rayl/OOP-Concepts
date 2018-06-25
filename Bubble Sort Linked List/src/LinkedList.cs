/**
 * Daryl Crosbie
 * ID: P453055
 * Date: 09/02/2018
 * AT1.3
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LInked_List
{
    public partial class LinkedList : Form
    {
        public LinkedList()
        {
            //On startup populate the list
            InitializeComponent();
            populateList();
            showList();
        }
        LinkedList<string> myCars = new LinkedList<string>();

        //Adds car to the list giving it the first position
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameBx.Text))
            {
                myCars.AddFirst(nameBx.Text);
                showList();
            }
            else MessageBox.Show("Enter car");
        }
        //Adds car to the list giving it the last position
        private void addLastBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameBx.Text))
            {
                myCars.AddLast(nameBx.Text);
                showList();
            }
            else MessageBox.Show("Enter car");
        }
        //Adds car to the list giving it the position before a selected item
        private void addBeforeBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameBx.Text))
            {
                if (!string.IsNullOrEmpty(nodePosBx.Text))
                {
                    LinkedListNode<string> current = myCars.Find(nodePosBx.Text);
                    myCars.AddBefore(current, nameBx.Text);
                    showList();
                }
                else MessageBox.Show("Enter the position");
            }
            else MessageBox.Show("Enter car");
        }
        //Adds car to the list giving it the position after a selected item
        private void addAfterBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameBx.Text))
            {
                if (!string.IsNullOrEmpty(nodePosBx.Text))
                {
                    LinkedListNode<string> current = myCars.Find(nodePosBx.Text);
                    myCars.AddAfter(current, nameBx.Text);
                    showList();
                }
                else MessageBox.Show("Enter the position");
            }
            else MessageBox.Show("Enter car");
        }
        //Removes the given car from the list
        //Removes selected car from the list
        private void removeBtn_Click(object sender, EventArgs e)
        {
            string name;
            if (!string.IsNullOrEmpty(nameBx.Text))
            {
                if (myCars.Contains(nameBx.Text))
                {
                    name = nameBx.Text;
                    myCars.Remove(nameBx.Text);
                    showList();
                    MessageBox.Show(name + " removed");
                }
                else MessageBox.Show("Car not in the list");
                nameBx.Clear();
            }
            else if (!string.IsNullOrEmpty(nodePosBx.Text))
            {
                myCars.Remove(nodePosBx.Text);
                showList();
                MessageBox.Show(nameBx.Text + " removed");
            }
            else
            {
                MessageBox.Show("Enter car");
            }
        }
        //Displays the list
        private void showList()
        {
            listBx.Items.Clear();
            nameBx.Clear();
            nodePosBx.Clear();
            numNodes.Text = numberOfNodes().ToString();

            foreach (string car in myCars)
            {
                listBx.Items.Add(car);
            }
        }
        //Clears all items from the list
        private void clearBtn_Click(object sender, EventArgs e)
        {
            myCars.Clear();
            showList();
        }
        //Counts the list
        private int numberOfNodes()
        {
            return myCars.Count();
        }
        //Populates node position box from selecting from the list
        private void listBx_MouseClick(object sender, MouseEventArgs e)
        {
            nodePosBx.Text = listBx.SelectedItem.ToString();
        }
        //Searches the list for the given item
        private void findBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameBx.Text))
            {
                try
                {
                    string fCar = myCars.Find(nameBx.Text).Value;
                    MessageBox.Show("Car found");
                    listBx.SelectedItem = fCar;
                }
                catch
                {
                    MessageBox.Show("Car not Found");
                }
            }
            else MessageBox.Show("Enter car");
        }
        //Hard coded entries to fill the list
        public void populateList()
        {
            myCars.AddLast("Opal");
            myCars.AddLast("Ford");
            myCars.AddLast("Fiat");
            myCars.AddLast("Renault");
            myCars.AddLast("Honda");
            myCars.AddLast("Toyota");
            myCars.AddLast("Hyundai");
            myCars.AddLast("Geely");
            myCars.AddLast("Nissan");
            myCars.AddLast("BMW");
            myCars.AddLast("Mercedes");

        }
        //Sort button
        private void bSort_Click(object sender, EventArgs e)
        {
            bubbleSort();
        }
        //Bubble Sort for linked list, uses compared to method to check off the elements
        // and a linked list node to get the values of the elements for the swaps.
        public void bubbleSort()
        {
            int max = numberOfNodes();

            for(int i = 0; i < max; i++)
            {
                for (int j = 0; j < max - 1; j++)
                {
                    if (myCars.ElementAt(j).CompareTo(myCars.ElementAt(j + 1))>0)
                    {
                        LinkedListNode<string> current = myCars.Find(myCars.ElementAt(j));
                        var temp = current.Next.Value;
                        current.Next.Value = current.Value;
                        current.Value = temp;
                        showList();
                        Application.DoEvents();
                        Thread.Sleep(200);
                    }
                }
            }
        }
    }
}
