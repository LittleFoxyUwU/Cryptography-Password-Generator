
namespace Password_Generator_WinForms
{
    public partial class Form1 : Form
    {
        #region Declarations
        bool writeToFile = false;
        bool doesContainSmallLetters = false;
        bool doesContainPunctuation = false;
        bool doesContainBigLetters = false;
        bool doesContainNumbers = false;
        int amount = 0;
        int length = 0;
        string amountStr = "0";
        string lengthStr = "0"; 
        #endregion

        public Form1()
        {
            InitializeComponent();           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region CheckedChanged

        private void Write_CheckedChanged(object sender, EventArgs e)
        {
            writeToFile = ((CheckBox)sender).Checked;
        }
        private void Numbers_CheckedChanged(object sender, EventArgs e)
        {
            doesContainNumbers = ((CheckBox)sender).Checked;
        }

        private void SmallLetters_CheckedChanged(object sender, EventArgs e)
        {
            doesContainSmallLetters = ((CheckBox)sender).Checked;
        }

        private void BigLetters_CheckedChanged(object sender, EventArgs e)
        {
            doesContainBigLetters = ((CheckBox)sender).Checked;
        }

        private void Punctuation_CheckedChanged(object sender, EventArgs e)
        {
            doesContainPunctuation = ((CheckBox)sender).Checked;
        }

        #endregion CheckedChanged

        #region TextChanged by user

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

        #endregion TextChanged by user

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

            #region Exceptions
            if (amount <= 0 || length <= 0)
            {
                MessageBox.Show("Error: Length or amount can't be equal or less than zero\n" +
                    $"Amount = {amount} \nLength = {length}");
                return;
            }

            if (!doesContainSmallLetters && !doesContainPunctuation && !doesContainNumbers && !doesContainBigLetters)
            {
                MessageBox.Show("Choose at least one option!");
                return;
            }
            #endregion Exceptions

            string[] lines = new string[amount];

            for (int i = 0; i < amount; i++)
                lines[i] = $"{i + 1}: {Generator.PasswordGenerator(length, doesContainBigLetters, doesContainPunctuation, doesContainNumbers, doesContainSmallLetters)}\n";
            OutputTextBox.Lines = lines;

            Stream myStream;
            if (writeToFile)
            {
                if (savePasswordsDialog.ShowDialog() == DialogResult.OK)
                    if ((myStream = savePasswordsDialog.OpenFile()) != null)
                        foreach (string line in lines)
                            foreach(char c in line)
                                myStream.WriteByte((byte)c);
            }               
        }

        private void OutputTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}