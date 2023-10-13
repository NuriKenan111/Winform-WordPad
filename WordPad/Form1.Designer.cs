namespace WordPad
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fontBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            sizeBox = new ComboBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            colorBox = new ComboBox();
            button4 = new Button();
            button5 = new Button();
            richTextBox1 = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            colorDialog1 = new ColorDialog();
            SuspendLayout();
            // 
            // fontBox
            // 
            fontBox.FormattingEnabled = true;
            fontBox.Location = new Point(12, 29);
            fontBox.Name = "fontBox";
            fontBox.Size = new Size(122, 23);
            fontBox.TabIndex = 0;
            fontBox.SelectedIndexChanged += fontBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(46, 7);
            label1.Name = "label1";
            label1.Size = new Size(39, 19);
            label1.TabIndex = 1;
            label1.Text = "Font\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(200, 7);
            label2.Name = "label2";
            label2.Size = new Size(36, 19);
            label2.TabIndex = 2;
            label2.Text = "Size";
            // 
            // sizeBox
            // 
            sizeBox.FormattingEnabled = true;
            sizeBox.Location = new Point(176, 29);
            sizeBox.Name = "sizeBox";
            sizeBox.Size = new Size(81, 23);
            sizeBox.TabIndex = 3;
            sizeBox.SelectedIndexChanged += sizeBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(314, 7);
            label3.Name = "label3";
            label3.Size = new Size(77, 19);
            label3.TabIndex = 4;
            label3.Text = "Font Style";
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(307, 29);
            button1.Name = "button1";
            button1.Size = new Size(24, 28);
            button1.TabIndex = 5;
            button1.Text = "B";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(337, 31);
            button2.Name = "button2";
            button2.Size = new Size(24, 26);
            button2.TabIndex = 6;
            button2.Text = "U";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(367, 31);
            button3.Name = "button3";
            button3.Size = new Size(24, 26);
            button3.TabIndex = 7;
            button3.Text = "/";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(460, 7);
            label4.Name = "label4";
            label4.Size = new Size(46, 19);
            label4.TabIndex = 8;
            label4.Text = "Color";
            // 
            // colorBox
            // 
            colorBox.FormattingEnabled = true;
            colorBox.Location = new Point(437, 34);
            colorBox.Name = "colorBox";
            colorBox.Size = new Size(99, 23);
            colorBox.TabIndex = 9;
            colorBox.MouseClick += colorBox_MouseClick;
            // 
            // button4
            // 
            button4.Location = new Point(569, 34);
            button4.Name = "button4";
            button4.Size = new Size(104, 28);
            button4.TabIndex = 10;
            button4.Text = "Load";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(679, 34);
            button5.Name = "button5";
            button5.Size = new Size(104, 28);
            button5.TabIndex = 11;
            button5.Text = "Save";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(2, 69);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(794, 310);
            richTextBox1.TabIndex = 12;
            richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(colorBox);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(sizeBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(fontBox);
            Name = "Form1";
            Text = "WordpadKiller";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox fontBox;
        private Label label1;
        private Label label2;
        private ComboBox sizeBox;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label4;
        private ComboBox colorBox;
        private Button button4;
        private Button button5;
        private RichTextBox richTextBox1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ColorDialog colorDialog1;
    }
}