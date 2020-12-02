using System.Windows.Forms;
using Work_to_form.Exceptions;

namespace Work_to_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonInputProduct_Click(object sender, System.EventArgs e)
        {
            Form2 obj = new Form2();
            if (obj.ShowDialog() == DialogResult.OK)
                MyList.Items.Add(obj.GetInfo);
        }

        private void buttonEditProduct_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (MyList.SelectedItem == null)
                    throw new ArgumentEmptyException();
                string[] charSep = { "Name: ", " Countries: ", " Price: " };
                string[] result = MyList.SelectedItem.ToString().Split(charSep, System.StringSplitOptions.RemoveEmptyEntries);
                Form3 obj2 = new Form3(result[0], result[1], double.Parse(result[2]));
                if (obj2.ShowDialog() == DialogResult.OK)
                {
                    MyList.Items.Insert(MyList.SelectedIndex, obj2.Getinfo);
                    MyList.Items.RemoveAt(MyList.SelectedIndex);
                }
            }
            catch (ArgumentEmptyException ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.time);
            }
        }

        private void buttonDeleteProduct_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (MyList.SelectedItem == null)
                    throw new ArgumentEmptyException();
                MyList.Items.RemoveAt(MyList.SelectedIndex);
            }
            catch (ArgumentEmptyException ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.time);
            }
        }

        private void buttonClearList_Click(object sender, System.EventArgs e)
        {
            MyList.Items.Clear();
        }
    }
}
