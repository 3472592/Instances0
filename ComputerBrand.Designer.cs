namespace Basic_Insta_Practice
{
    partial class ComputerBrand
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
            Dell = new Button();
            label1 = new Label();
            Apple = new Button();
            LenoVova = new Button();
            Lenovo = new Button();
            HP = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // Dell
            // 
            Dell.Location = new Point(21, 19);
            Dell.Margin = new Padding(5);
            Dell.Name = "Dell";
            Dell.Size = new Size(164, 45);
            Dell.TabIndex = 0;
            Dell.Text = "Dell";
            Dell.UseVisualStyleBackColor = true;
            Dell.Click += Dell_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlDark;
            label1.Location = new Point(195, 19);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(1111, 45);
            label1.TabIndex = 1;
            // 
            // Apple
            // 
            Apple.Location = new Point(21, 74);
            Apple.Margin = new Padding(5);
            Apple.Name = "Apple";
            Apple.Size = new Size(164, 45);
            Apple.TabIndex = 2;
            Apple.Text = "Apple";
            Apple.UseVisualStyleBackColor = true;
            Apple.Click += Apple_Click;
            // 
            // LenoVova
            // 
            LenoVova.Location = new Point(21, 129);
            LenoVova.Margin = new Padding(5);
            LenoVova.Name = "LenoVova";
            LenoVova.Size = new Size(164, 45);
            LenoVova.TabIndex = 3;
            LenoVova.Text = "LenoVova";
            LenoVova.UseVisualStyleBackColor = true;
            LenoVova.Click += LenoVova_Click;
            // 
            // Lenovo
            // 
            Lenovo.Location = new Point(21, 184);
            Lenovo.Margin = new Padding(5);
            Lenovo.Name = "Lenovo";
            Lenovo.Size = new Size(164, 45);
            Lenovo.TabIndex = 4;
            Lenovo.Text = "Lenovo";
            Lenovo.UseVisualStyleBackColor = true;
            Lenovo.Click += Lenovo_Click;
            // 
            // HP
            // 
            HP.Location = new Point(21, 239);
            HP.Margin = new Padding(5);
            HP.Name = "HP";
            HP.Size = new Size(164, 45);
            HP.TabIndex = 5;
            HP.Text = "HP";
            HP.UseVisualStyleBackColor = true;
            HP.Click += HP_Click;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ControlDark;
            label2.Location = new Point(195, 74);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(1111, 45);
            label2.TabIndex = 6;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ControlDark;
            label3.Location = new Point(195, 129);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(1111, 45);
            label3.TabIndex = 7;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ControlDark;
            label4.Location = new Point(195, 184);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(1111, 45);
            label4.TabIndex = 8;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ControlDark;
            label5.Location = new Point(195, 239);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(1111, 45);
            label5.TabIndex = 9;
            // 
            // ComputerBrand
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1320, 538);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(HP);
            Controls.Add(Lenovo);
            Controls.Add(LenoVova);
            Controls.Add(Apple);
            Controls.Add(label1);
            Controls.Add(Dell);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "ComputerBrand";
            Text = "Computers";
            Load += ComputerBrand_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Dell;
        private Label label1;
        private Button Apple;
        private Button LenoVova;
        private Button Lenovo;
        private Button HP;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}