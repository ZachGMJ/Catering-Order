namespace Catering_Order
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
            GormCheese = new RadioButton();
            fruit = new RadioButton();
            sausCheese = new RadioButton();
            veggie = new RadioButton();
            pinwheel = new RadioButton();
            textBox2 = new TextBox();
            prePay = new RadioButton();
            pickup = new RadioButton();
            caterPic = new PictureBox();
            label1 = new Label();
            loyaltyPoints = new TextBox();
            calculate = new Button();
            clear = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)caterPic).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // GormCheese
            // 
            GormCheese.AutoSize = true;
            GormCheese.BackColor = Color.FromArgb(255, 192, 128);
            GormCheese.Location = new Point(14, 26);
            GormCheese.Name = "GormCheese";
            GormCheese.Size = new Size(178, 24);
            GormCheese.TabIndex = 1;
            GormCheese.TabStop = true;
            GormCheese.Text = "Gormet Cheese $49.99";
            GormCheese.UseVisualStyleBackColor = false;
            // 
            // fruit
            // 
            fruit.AutoSize = true;
            fruit.BackColor = Color.FromArgb(255, 192, 128);
            fruit.Location = new Point(14, 147);
            fruit.Name = "fruit";
            fruit.Size = new Size(106, 24);
            fruit.TabIndex = 2;
            fruit.TabStop = true;
            fruit.Text = "Fruit $29.99";
            fruit.UseVisualStyleBackColor = false;
            // 
            // sausCheese
            // 
            sausCheese.AutoSize = true;
            sausCheese.BackColor = Color.FromArgb(255, 192, 128);
            sausCheese.Location = new Point(14, 117);
            sausCheese.Name = "sausCheese";
            sausCheese.Size = new Size(212, 24);
            sausCheese.TabIndex = 3;
            sausCheese.TabStop = true;
            sausCheese.Text = "Sausage and Cheese $49.99";
            sausCheese.UseVisualStyleBackColor = false;
            // 
            // veggie
            // 
            veggie.AutoSize = true;
            veggie.BackColor = Color.FromArgb(255, 192, 128);
            veggie.Location = new Point(14, 86);
            veggie.Name = "veggie";
            veggie.Size = new Size(123, 24);
            veggie.TabIndex = 4;
            veggie.TabStop = true;
            veggie.Text = "Veggie $29.99";
            veggie.UseVisualStyleBackColor = false;
            // 
            // pinwheel
            // 
            pinwheel.AutoSize = true;
            pinwheel.BackColor = Color.FromArgb(255, 192, 128);
            pinwheel.Location = new Point(14, 56);
            pinwheel.Name = "pinwheel";
            pinwheel.Size = new Size(182, 24);
            pinwheel.TabIndex = 5;
            pinwheel.TabStop = true;
            pinwheel.Text = "Pinwheel Wraps $59.99";
            pinwheel.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(255, 192, 128);
            textBox2.Enabled = false;
            textBox2.Location = new Point(146, 395);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(184, 101);
            textBox2.TabIndex = 6;
            // 
            // prePay
            // 
            prePay.AutoSize = true;
            prePay.BackColor = Color.FromArgb(255, 192, 128);
            prePay.Location = new Point(172, 414);
            prePay.Name = "prePay";
            prePay.Size = new Size(79, 24);
            prePay.TabIndex = 7;
            prePay.TabStop = true;
            prePay.Text = "Pre-Pay";
            prePay.UseVisualStyleBackColor = false;
            // 
            // pickup
            // 
            pickup.AutoSize = true;
            pickup.BackColor = Color.FromArgb(255, 192, 128);
            pickup.Location = new Point(172, 444);
            pickup.Name = "pickup";
            pickup.Size = new Size(120, 24);
            pickup.TabIndex = 8;
            pickup.TabStop = true;
            pickup.Text = "Pay on Pickup";
            pickup.UseVisualStyleBackColor = false;
            // 
            // caterPic
            // 
            caterPic.Image = Properties.Resources.platter;
            caterPic.Location = new Point(474, 12);
            caterPic.Name = "caterPic";
            caterPic.Size = new Size(382, 270);
            caterPic.SizeMode = PictureBoxSizeMode.StretchImage;
            caterPic.TabIndex = 9;
            caterPic.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(545, 312);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 10;
            label1.Text = "Loyalty Points";
            // 
            // loyaltyPoints
            // 
            loyaltyPoints.Location = new Point(707, 309);
            loyaltyPoints.Name = "loyaltyPoints";
            loyaltyPoints.Size = new Size(66, 27);
            loyaltyPoints.TabIndex = 11;
            // 
            // calculate
            // 
            calculate.BackColor = Color.FromArgb(255, 128, 0);
            calculate.ForeColor = Color.Black;
            calculate.Location = new Point(530, 433);
            calculate.Name = "calculate";
            calculate.Size = new Size(114, 40);
            calculate.TabIndex = 12;
            calculate.Text = "Calculate";
            calculate.UseVisualStyleBackColor = false;
            calculate.Click += calculate_Click;
            // 
            // clear
            // 
            clear.BackColor = Color.FromArgb(255, 128, 0);
            clear.ForeColor = Color.Black;
            clear.Location = new Point(687, 433);
            clear.Name = "clear";
            clear.Size = new Size(120, 40);
            clear.TabIndex = 13;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 531);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 14;
            label2.Text = "Please Pay:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(146, 531);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 15;
            label3.Text = "label3";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(172, 22);
            label4.Name = "label4";
            label4.Size = new Size(139, 41);
            label4.TabIndex = 16;
            label4.Text = "Catering";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(180, 81);
            label5.Name = "label5";
            label5.Size = new Size(112, 25);
            label5.TabIndex = 17;
            label5.Text = "Star Market";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 192, 128);
            groupBox1.Controls.Add(GormCheese);
            groupBox1.Controls.Add(pinwheel);
            groupBox1.Controls.Add(veggie);
            groupBox1.Controls.Add(sausCheese);
            groupBox1.Controls.Add(fruit);
            groupBox1.Location = new Point(85, 123);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(344, 209);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(893, 604);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(clear);
            Controls.Add(calculate);
            Controls.Add(loyaltyPoints);
            Controls.Add(label1);
            Controls.Add(caterPic);
            Controls.Add(pickup);
            Controls.Add(prePay);
            Controls.Add(textBox2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)caterPic).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton GormCheese;
        private RadioButton fruit;
        private RadioButton sausCheese;
        private RadioButton veggie;
        private RadioButton pinwheel;
        private TextBox textBox2;
        private RadioButton prePay;
        private RadioButton pickup;
        private PictureBox caterPic;
        private Label label1;
        private TextBox loyaltyPoints;
        private Button calculate;
        private Button clear;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
    }
}
