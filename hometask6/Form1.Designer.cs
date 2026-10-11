#nullable enable
namespace hometask6
{
    partial class Form1
    {
        private System.ComponentModel.IContainer? components = null;
        private Label titleLabel = null!;
        private Label promptLabel = null!;
        private TextBox textBox1 = null!;
        private Button button1 = null!;
        private Button yenioyunbtn = null!;
        private Label label3 = null!;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                errorProvider.Dispose();
                components?.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            titleLabel = new Label();
            promptLabel = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            yenioyunbtn = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            titleLabel.Location = new Point(55, 57);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(138, 28);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Ədəd axtarışı";
            // 
            // promptLabel
            // 
            promptLabel.AutoSize = true;
            promptLabel.Location = new Point(55, 111);
            promptLabel.Name = "promptLabel";
            promptLabel.Size = new Size(109, 20);
            promptLabel.TabIndex = 1;
            promptLabel.Text = "Axtarılan ədəd:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(55, 141);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(217, 27);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(102, 197);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(123, 45);
            button1.TabIndex = 3;
            button1.Text = "Yoxla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // yenioyunbtn
            // 
            yenioyunbtn.BackColor = Color.LightCoral;
            yenioyunbtn.FlatStyle = FlatStyle.Flat;
            yenioyunbtn.Location = new Point(334, 319);
            yenioyunbtn.Margin = new Padding(3, 4, 3, 4);
            yenioyunbtn.Name = "yenioyunbtn";
            yenioyunbtn.Size = new Size(229, 47);
            yenioyunbtn.TabIndex = 5;
            yenioyunbtn.Text = "Yeni oyun";
            yenioyunbtn.UseVisualStyleBackColor = false;
            yenioyunbtn.Click += yenioyunbtn_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(329, 57);
            label3.Name = "label3";
            label3.Padding = new Padding(16, 19, 16, 19);
            label3.Size = new Size(233, 249);
            label3.TabIndex = 4;
            label3.Text = "Yeni oyuna başlamaq üçün düyməni basın.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(617, 420);
            Controls.Add(yenioyunbtn);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(promptLabel);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ədəd axtarışı";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
