using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GenericLIFO_stack_.Class1;

namespace GenericLIFO_stack_
{
    public partial class Form1 : Form
    {
        private GenericLIFO<string> _stack = new GenericLIFO<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newItem = txtNewItem.Text;
            if (!string.IsNullOrEmpty(newItem))
            {
                _stack.Push(newItem);
                UpdateStackDisplay();
            }
        }

        private void btnRemoveFirst_Click(object sender, EventArgs e)
        {
            try
            {
                string removedItem = _stack.Pop();
                MessageBox.Show($"Удален элемент: {removedItem}");
                UpdateStackDisplay();
                txtItemByIndex.Clear();
                txtIndex.Clear();
                txtCount.Clear();

            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFindByIndex_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIndex.Text, out int index))
            {
                try
                {
                    string item = _stack.Get(index-1);
                    txtItemByIndex.Text = item;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Введите корректный индекс.");
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            txtCount.Text = _stack.Count.ToString();
        }

        private void UpdateStackDisplay()
        {
            lstStack.Items.Clear();
            for (int i = 0; i < _stack.Count; i++)
            {
                lstStack.Items.Add(_stack.Get(i));
            }
        }

        private void txtNewItem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
