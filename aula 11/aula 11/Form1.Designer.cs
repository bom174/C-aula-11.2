namespace aula_11
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            Data = new TextBox();
            dataA = new TextBox();
            dataL = new TextBox();
            horaL = new TextBox();
            horaA = new TextBox();
            dataC = new TextBox();
            horaC = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(208, 111);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 0;
            label1.Text = "Data";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 185);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 1;
            label2.Text = "Data Abreviada";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(154, 228);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 2;
            label3.Text = "Data Longa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 275);
            label4.Name = "label4";
            label4.Size = new Size(157, 25);
            label4.TabIndex = 3;
            label4.Text = "Data Customizada";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(98, 428);
            label5.Name = "label5";
            label5.Size = new Size(159, 25);
            label5.TabIndex = 6;
            label5.Text = "Hora Customizada";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(152, 387);
            label6.Name = "label6";
            label6.Size = new Size(105, 25);
            label6.TabIndex = 5;
            label6.Text = "Hora Longa";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(121, 344);
            label7.Name = "label7";
            label7.Size = new Size(136, 25);
            label7.TabIndex = 4;
            label7.Text = "Hora Abreviada";
            // 
            // button1
            // 
            button1.Location = new Point(585, 111);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 7;
            button1.Text = "Gerar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Data
            // 
            Data.Location = new Point(307, 114);
            Data.Name = "Data";
            Data.Size = new Size(260, 31);
            Data.TabIndex = 8;
            // 
            // dataA
            // 
            dataA.Location = new Point(307, 185);
            dataA.Name = "dataA";
            dataA.Size = new Size(260, 31);
            dataA.TabIndex = 9;
            // 
            // dataL
            // 
            dataL.Location = new Point(307, 228);
            dataL.Name = "dataL";
            dataL.Size = new Size(307, 31);
            dataL.TabIndex = 10;
            // 
            // horaL
            // 
            horaL.Location = new Point(307, 387);
            horaL.Name = "horaL";
            horaL.Size = new Size(307, 31);
            horaL.TabIndex = 13;
            horaL.Text = "'";
            // 
            // horaA
            // 
            horaA.Location = new Point(307, 344);
            horaA.Name = "horaA";
            horaA.Size = new Size(260, 31);
            horaA.TabIndex = 12;
            // 
            // dataC
            // 
            dataC.Location = new Point(307, 275);
            dataC.Name = "dataC";
            dataC.Size = new Size(260, 31);
            dataC.TabIndex = 11;
            // 
            // horaC
            // 
            horaC.Location = new Point(307, 428);
            horaC.Name = "horaC";
            horaC.Size = new Size(260, 31);
            horaC.TabIndex = 14;
            // 
            // button2
            // 
            button2.Location = new Point(723, 111);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 15;
            button2.Text = "Data Atual";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 731);
            Controls.Add(button2);
            Controls.Add(horaC);
            Controls.Add(horaL);
            Controls.Add(horaA);
            Controls.Add(dataC);
            Controls.Add(dataL);
            Controls.Add(dataA);
            Controls.Add(Data);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private TextBox Data;
        private TextBox dataA;
        private TextBox dataL;
        private TextBox horaL;
        private TextBox horaA;
        private TextBox dataC;
        private TextBox horaC;
        private Button button2;
    }
}