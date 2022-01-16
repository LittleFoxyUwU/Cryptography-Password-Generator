namespace Password_Generator_WinForms
{
    public partial class Form1 : Form
    {
        bool doesContainLetters = false;
        bool doesContainPunctuation = false;
        int amount = 1;
        int length = 1;
        string amountStr = "1";
        string lengthStr = "1";
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void DoesContainLetters_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            doesContainLetters = checkBox.Checked;
        }

        private void DoesContainPunct_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            doesContainPunctuation = checkBox.Checked;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                amount = int.Parse(amountStr);
                length = int.Parse(lengthStr);
            }
            catch
            {
                MessageBox.Show("Invalid amount or length!\n" +
                    $"Amount = {amountStr}\nLength = {lengthStr}");
                return;
            }

            if (amount <= 0 || length <= 0)
            {
                MessageBox.Show("Error: Length or amount can't be equal or less than zero\n" +
                    $"Amount = {amount} \nLength = {length}");
                return;
            }

            string[] lines = new string[amount];
            Generator generator = new();
           

            for (int i = 0; i < amount; i++)
                lines[i] = $"{i + 1}: {generator.CryptoGenerator(length, doesContainLetters, doesContainPunctuation)}\n";
            OutputTextBox.Lines = lines;
        }

        private void AmountBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            amountStr = textBox.Text;
        }
        private void LengthBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            lengthStr = textBox.Text;
        }
    }
}