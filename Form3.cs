using System.Windows.Forms;
using Work_to_form.Exceptions;

namespace Work_to_form
{
    public partial class Form3 : Form
    {
        Product GetProduct = new Product();
        public Form3(string name, string countries, double price)
        {
            InitializeComponent();
            textBoxEditNamePreoduct.Text = name;
            textBoxEditCountry.Text = countries;
            textBoxEditPrice.Text = price.ToString();
        }

        public string Getinfo
        {
            get => GetProduct.ToString();
        }
        private void buttonOKForm3_Click(object sender, System.EventArgs e)
        {
            try
            {
                GetProduct.NameProduct = textBoxEditNamePreoduct.Text;
                GetProduct.Countries = textBoxEditCountry.Text;
                if (GetProduct.NameProduct == "" || GetProduct.Countries == "")
                    throw new FieldNullException();
                if (!double.TryParse(textBoxEditPrice.Text, out GetProduct.Price))
                    throw new DoubleArgumentException();
                this.DialogResult = DialogResult.OK;
            }
            catch (FieldNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (DoubleArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonCancelForm3_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
