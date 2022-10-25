namespace DecimalToBinaryConverter;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void ButtonConvert_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(textBoxDecimal.Text))
        {
            MessageBox.Show("Заполните десятическое число!!!");
            return;
        }

        int.TryParse(textBoxDecimal.Text, out int decimalValue);

        textBoxBinary.Text = NumbersConverter.DecimalToBinary(decimalValue);
    }

    private void ButtonExit_Click(object sender, EventArgs e)
    {
        Close();
    }
}