namespace hometask6
{
    public partial class Form1 : Form
    {
        private readonly Random random = new();
        private readonly ErrorProvider errorProvider = new();
        private int num;
        private int attempts;
        private bool gameStarted;

        public Form1()
        {
            InitializeComponent();
            errorProvider.ContainerControl = this;
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            button1.Enabled = false;
            textBox1.Enabled = false;
        }

        private void yenioyunbtn_Click(object? sender, EventArgs e)
        {
            // Next(0, 101) includes both endpoints: 0 through 100.
            num = random.Next(0, 101);
            attempts = 0;
            gameStarted = true;
            textBox1.Clear();
            errorProvider.SetError(textBox1, string.Empty);
            label3.Text = "Ədəd tapılmalıdır.\nCəhd sayı: 0";
            textBox1.Enabled = true;
            button1.Enabled = true;
            textBox1.Focus();
        }

        private void button1_Click(object? sender, EventArgs e)
        {
            if (!gameStarted)
                return;

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider.SetError(textBox1, "Axtarılan ədədi daxil edin.");
                textBox1.Focus();
                return;
            }

            if (!int.TryParse(textBox1.Text, out int guess) || guess < 0 || guess > 100)
            {
                errorProvider.SetError(textBox1, "0 ilə 100 arasında tam ədəd daxil edin.");
                textBox1.Focus();
                return;
            }

            errorProvider.SetError(textBox1, string.Empty);
            attempts++;

            if (guess == num)
            {
                label3.Text = $"Oyunu qazandınız!\nCəhd sayı: {attempts}";
                gameStarted = false;
                textBox1.Enabled = false;
                button1.Enabled = false;
            }
            else if (guess < num)
            {
                label3.Text = $"Daxil edilən ədəd yanlışdır.\nTəsadüfi ədəddən kiçikdir.\nCəhd sayı: {attempts}";
            }
            else
            {
                label3.Text = $"Daxil edilən ədəd yanlışdır.\nTəsadüfi ədəddən böyükdür.\nCəhd sayı: {attempts}";
            }

            textBox1.SelectAll();
            textBox1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
