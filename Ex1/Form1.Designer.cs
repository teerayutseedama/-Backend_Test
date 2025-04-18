namespace Ex1
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
            textEx1 = new TextBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            button1 = new Button();
            groupBox2 = new GroupBox();
            label3 = new Label();
            textEx2 = new TextBox();
            label2 = new Label();
            button2 = new Button();
            textEx2_result = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // textEx1
            // 
            textEx1.Location = new Point(61, 47);
            textEx1.Name = "textEx1";
            textEx1.Size = new Size(307, 27);
            textEx1.TabIndex = 0;
            textEx1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textEx1);
            groupBox1.Location = new Point(30, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(496, 125);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ex1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 23);
            label1.Name = "label1";
            label1.Size = new Size(216, 20);
            label1.TabIndex = 2;
            label1.Text = "Input  Text For Calculate Vowel ";
            // 
            // button1
            // 
            button1.Location = new Point(389, 47);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textEx2);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(textEx2_result);
            groupBox2.Location = new Point(30, 178);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(496, 510);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ex2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 88);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 7;
            label3.Text = "Result";
            // 
            // textEx2
            // 
            textEx2.Location = new Point(61, 52);
            textEx2.Name = "textEx2";
            textEx2.Size = new Size(307, 27);
            textEx2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 23);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 5;
            label2.Text = "Input Text";
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(388, 52);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textEx2_result
            // 
            textEx2_result.Location = new Point(61, 111);
            textEx2_result.Multiline = true;
            textEx2_result.Name = "textEx2_result";
            textEx2_result.ReadOnly = true;
            textEx2_result.ScrollBars = ScrollBars.Vertical;
            textEx2_result.Size = new Size(307, 393);
            textEx2_result.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 700);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Ex_BackEnd";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textEx1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button1;
        private Label label1;
        private Label label2;
        private Button button2;
        private TextBox textEx2_result;
        private TextBox textEx2;
        private Label label3;
    }
}
