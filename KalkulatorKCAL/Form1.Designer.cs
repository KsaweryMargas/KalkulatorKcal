namespace KalkulatorKCAL
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
            barkcal = new ProgressBar();
            lblprotein = new Label();
            lblfat = new Label();
            lblcarbs = new Label();
            breakfast = new ListBox();
            lunch = new ListBox();
            snack = new ListBox();
            dinner = new ListBox();
            btnbreakfast = new Button();
            btnlunch = new Button();
            btnsnack = new Button();
            btndinner = new Button();
            lblkcal = new Label();
            SuspendLayout();
            // 
            // barkcal
            // 
            barkcal.Location = new Point(12, 26);
            barkcal.Name = "barkcal";
            barkcal.Size = new Size(429, 47);
            barkcal.TabIndex = 0;
            // 
            // lblprotein
            // 
            lblprotein.AutoSize = true;
            lblprotein.Location = new Point(492, 42);
            lblprotein.Name = "lblprotein";
            lblprotein.Size = new Size(20, 15);
            lblprotein.TabIndex = 1;
            lblprotein.Text = "B: ";
            // 
            // lblfat
            // 
            lblfat.AutoSize = true;
            lblfat.Location = new Point(585, 42);
            lblfat.Name = "lblfat";
            lblfat.Size = new Size(20, 15);
            lblfat.TabIndex = 2;
            lblfat.Text = "T: ";
            // 
            // lblcarbs
            // 
            lblcarbs.AutoSize = true;
            lblcarbs.Location = new Point(679, 42);
            lblcarbs.Name = "lblcarbs";
            lblcarbs.Size = new Size(24, 15);
            lblcarbs.TabIndex = 3;
            lblcarbs.Text = "W: ";
            // 
            // breakfast
            // 
            breakfast.FormattingEnabled = true;
            breakfast.ItemHeight = 15;
            breakfast.Location = new Point(12, 103);
            breakfast.Name = "breakfast";
            breakfast.Size = new Size(190, 289);
            breakfast.TabIndex = 4;
            // 
            // lunch
            // 
            lunch.FormattingEnabled = true;
            lunch.ItemHeight = 15;
            lunch.Location = new Point(208, 103);
            lunch.Name = "lunch";
            lunch.Size = new Size(190, 289);
            lunch.TabIndex = 5;
            // 
            // snack
            // 
            snack.FormattingEnabled = true;
            snack.ItemHeight = 15;
            snack.Location = new Point(404, 103);
            snack.Name = "snack";
            snack.Size = new Size(190, 289);
            snack.TabIndex = 6;
            // 
            // dinner
            // 
            dinner.FormattingEnabled = true;
            dinner.ItemHeight = 15;
            dinner.Location = new Point(600, 103);
            dinner.Name = "dinner";
            dinner.Size = new Size(190, 289);
            dinner.TabIndex = 7;
            // 
            // btnbreakfast
            // 
            btnbreakfast.Location = new Point(12, 398);
            btnbreakfast.Name = "btnbreakfast";
            btnbreakfast.Size = new Size(190, 40);
            btnbreakfast.TabIndex = 8;
            btnbreakfast.Text = "Dodaj";
            btnbreakfast.UseVisualStyleBackColor = true;
            btnbreakfast.Click += btnbreakfast_Click;
            // 
            // btnlunch
            // 
            btnlunch.Location = new Point(208, 398);
            btnlunch.Name = "btnlunch";
            btnlunch.Size = new Size(190, 40);
            btnlunch.TabIndex = 9;
            btnlunch.Text = "Dodaj";
            btnlunch.UseVisualStyleBackColor = true;
            btnlunch.Click += btnlunch_Click;
            // 
            // btnsnack
            // 
            btnsnack.Location = new Point(404, 398);
            btnsnack.Name = "btnsnack";
            btnsnack.Size = new Size(190, 40);
            btnsnack.TabIndex = 10;
            btnsnack.Text = "Dodaj";
            btnsnack.UseVisualStyleBackColor = true;
            btnsnack.Click += btnsnack_Click;
            // 
            // btndinner
            // 
            btndinner.Location = new Point(600, 398);
            btndinner.Name = "btndinner";
            btndinner.Size = new Size(190, 40);
            btndinner.TabIndex = 11;
            btndinner.Text = "Dodaj";
            btndinner.UseVisualStyleBackColor = true;
            btndinner.Click += btndinner_Click;
            // 
            // lblkcal
            // 
            lblkcal.AutoSize = true;
            lblkcal.Location = new Point(12, 9);
            lblkcal.Name = "lblkcal";
            lblkcal.Size = new Size(35, 15);
            lblkcal.TabIndex = 12;
            lblkcal.Text = "Kcal: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblkcal);
            Controls.Add(btndinner);
            Controls.Add(btnsnack);
            Controls.Add(btnlunch);
            Controls.Add(btnbreakfast);
            Controls.Add(dinner);
            Controls.Add(snack);
            Controls.Add(lunch);
            Controls.Add(breakfast);
            Controls.Add(lblcarbs);
            Controls.Add(lblfat);
            Controls.Add(lblprotein);
            Controls.Add(barkcal);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar barkcal;
        private Label lblprotein;
        private Label lblfat;
        private Label lblcarbs;
        private ListBox breakfast;
        private ListBox lunch;
        private ListBox snack;
        private ListBox dinner;
        private Button btnbreakfast;
        private Button btnlunch;
        private Button btnsnack;
        private Button btndinner;
        private Label lblkcal;
    }
}
