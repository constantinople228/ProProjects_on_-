namespace ПР_29
{
    partial class HumanForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            button4 = new Button();
            label4 = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 15.75F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(310, 23);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 32);
            label2.Name = "label2";
            label2.Size = new Size(310, 23);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 10F);
            button1.Location = new Point(12, 179);
            button1.Name = "button1";
            button1.Size = new Size(140, 40);
            button1.TabIndex = 2;
            button1.Text = "Eat";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 10F);
            button2.Location = new Point(12, 223);
            button2.Name = "button2";
            button2.Size = new Size(140, 40);
            button2.TabIndex = 3;
            button2.Text = "Relax";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 10F);
            button3.Location = new Point(182, 179);
            button3.Name = "button3";
            button3.Size = new Size(140, 40);
            button3.TabIndex = 4;
            button3.Text = "Work";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label3
            // 
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 55);
            label3.Name = "label3";
            label3.Size = new Size(308, 23);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // button4
            // 
            button4.Font = new Font("Times New Roman", 10F);
            button4.Location = new Point(182, 223);
            button4.Name = "button4";
            button4.Size = new Size(140, 40);
            button4.TabIndex = 6;
            button4.Text = "Learn";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 78);
            label4.Name = "label4";
            label4.Size = new Size(308, 23);
            label4.TabIndex = 7;
            label4.Text = "label4";
            // 
            // timer2
            // 
            timer2.Interval = 5000;
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Interval = 15000;
            timer3.Tick += timer3_Tick;
            // 
            // HumanForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 271);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "HumanForm";
            Text = "HumanForm";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private System.Windows.Forms.Timer timer1;
        private Label label3;
        private Button button4;
        private Label label4;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}