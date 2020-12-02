using System.Windows.Forms;
using Work_to_form.Exceptions;

namespace Work_to_form
{
    public partial class Form2 : Form
    {
        Product product = new Product();
        public Form2()
        {
            InitializeComponent();
        }

        public string GetInfo
        {
            get => product.ToString();
        }
        private void buttonOK_form2_Click(object sender, System.EventArgs e)
        {
            try
            {
                product.NameProduct = textBoxNameProduct.Text;
                product.Countries = textBoxCountries.Text;
                if (!double.TryParse(textBoxPrice.Text, out product.Price))
                    throw new DoubleArgumentException();
                if (product.NameProduct == "" || product.Countries == "")
                    throw new FieldNullException();
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

        private void buttonCancelForm2_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Form2_Load(object sender, System.EventArgs e)
        {

        }
    }
}
