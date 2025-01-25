namespace ShowList
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
            listBox1 = new ListBox();
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            listBox2 = new ListBox();
            button9 = new Button();
            button10 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(434, 148);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(354, 289);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(577, 94);
            label1.Name = "label1";
            label1.Size = new Size(71, 35);
            label1.TabIndex = 1;
            label1.Text = "list";
            // 
            // button1
            // 
            button1.Location = new Point(34, 115);
            button1.Name = "button1";
            button1.Size = new Size(38, 274);
            button1.TabIndex = 2;
            button1.Text = "add end";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(401, 23);
            textBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(92, 115);
            button2.Name = "button2";
            button2.Size = new Size(38, 274);
            button2.TabIndex = 4;
            button2.Text = "start";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(146, 115);
            button3.Name = "button3";
            button3.Size = new Size(38, 274);
            button3.TabIndex = 5;
            button3.Text = "end";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(203, 115);
            button4.Name = "button4";
            button4.Size = new Size(38, 274);
            button4.TabIndex = 6;
            button4.Text = "next";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(255, 115);
            button5.Name = "button5";
            button5.Size = new Size(38, 274);
            button5.TabIndex = 7;
            button5.Text = "prev";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(309, 115);
            button6.Name = "button6";
            button6.Size = new Size(38, 274);
            button6.TabIndex = 8;
            button6.Text = "add start";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(363, 115);
            button7.Name = "button7";
            button7.Size = new Size(38, 274);
            button7.TabIndex = 9;
            button7.Text = "delete";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(12, 396);
            button8.Name = "button8";
            button8.Size = new Size(42, 42);
            button8.TabIndex = 10;
            button8.Text = "Q";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(708, 58);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(67, 49);
            listBox2.TabIndex = 11;
            // 
            // button9
            // 
            button9.Location = new Point(88, 396);
            button9.Name = "button9";
            button9.Size = new Size(42, 42);
            button9.TabIndex = 12;
            button9.Text = "->";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(155, 396);
            button10.Name = "button10";
            button10.Size = new Size(42, 42);
            button10.TabIndex = 13;
            button10.Text = "<-";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(listBox2);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private ListBox listBox2;
        private Button button9;
        private Button button10;
    }
}
