namespace Krzysztof_Badelek_Quiz
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
            CbFragen = new ComboBox();
            CbAntworten = new ComboBox();
            BtnRundeStarten = new Button();
            RbAntwort1 = new RadioButton();
            RbAntwort2 = new RadioButton();
            RbAntwort3 = new RadioButton();
            LbFrage = new Label();
            RbAntwort4 = new RadioButton();
            BtnNeueFrage = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(226, 45);
            label1.TabIndex = 0;
            label1.Text = "Fragen wählen";
            label1.Click += label1_Click;
            // 
            // CbFragen
            // 
            CbFragen.FormattingEnabled = true;
            CbFragen.Location = new Point(53, 85);
            CbFragen.Name = "CbFragen";
            CbFragen.Size = new Size(132, 23);
            CbFragen.TabIndex = 2;
            CbFragen.Text = "Fragenart";
            CbFragen.SelectedIndexChanged += CbFragen_SelectedIndexChanged;
            // 
            // CbAntworten
            // 
            CbAntworten.FormattingEnabled = true;
            CbAntworten.Location = new Point(53, 134);
            CbAntworten.Name = "CbAntworten";
            CbAntworten.Size = new Size(132, 23);
            CbAntworten.TabIndex = 3;
            CbAntworten.Text = "Antworten";
            // 
            // BtnRundeStarten
            // 
            BtnRundeStarten.Location = new Point(53, 193);
            BtnRundeStarten.Name = "BtnRundeStarten";
            BtnRundeStarten.Size = new Size(132, 23);
            BtnRundeStarten.TabIndex = 4;
            BtnRundeStarten.Text = "Runde starten";
            BtnRundeStarten.UseVisualStyleBackColor = true;
            BtnRundeStarten.Click += BtnRundeStarten_Click;
            // 
            // RbAntwort1
            // 
            RbAntwort1.AutoSize = true;
            RbAntwort1.Location = new Point(267, 262);
            RbAntwort1.Name = "RbAntwort1";
            RbAntwort1.Size = new Size(14, 13);
            RbAntwort1.TabIndex = 5;
            RbAntwort1.TabStop = true;
            RbAntwort1.UseVisualStyleBackColor = true;
            // 
            // RbAntwort2
            // 
            RbAntwort2.AutoSize = true;
            RbAntwort2.Location = new Point(386, 262);
            RbAntwort2.Name = "RbAntwort2";
            RbAntwort2.Size = new Size(14, 13);
            RbAntwort2.TabIndex = 6;
            RbAntwort2.TabStop = true;
            RbAntwort2.UseVisualStyleBackColor = true;
            // 
            // RbAntwort3
            // 
            RbAntwort3.AutoSize = true;
            RbAntwort3.Location = new Point(498, 262);
            RbAntwort3.Name = "RbAntwort3";
            RbAntwort3.Size = new Size(14, 13);
            RbAntwort3.TabIndex = 7;
            RbAntwort3.TabStop = true;
            RbAntwort3.UseVisualStyleBackColor = true;
            // 
            // LbFrage
            // 
            LbFrage.AutoSize = true;
            LbFrage.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            LbFrage.Location = new Point(481, 134);
            LbFrage.Name = "LbFrage";
            LbFrage.Size = new Size(0, 45);
            LbFrage.TabIndex = 8;
            LbFrage.TextChanged += LbFrage_TextChanged;
            // 
            // RbAntwort4
            // 
            RbAntwort4.AutoSize = true;
            RbAntwort4.Location = new Point(608, 262);
            RbAntwort4.Name = "RbAntwort4";
            RbAntwort4.Size = new Size(14, 13);
            RbAntwort4.TabIndex = 9;
            RbAntwort4.TabStop = true;
            RbAntwort4.UseVisualStyleBackColor = true;
            // 
            // BtnNeueFrage
            // 
            BtnNeueFrage.Location = new Point(406, 315);
            BtnNeueFrage.Name = "BtnNeueFrage";
            BtnNeueFrage.Size = new Size(75, 23);
            BtnNeueFrage.TabIndex = 10;
            BtnNeueFrage.Text = "Neue Frage";
            BtnNeueFrage.UseVisualStyleBackColor = true;
            BtnNeueFrage.Click += BtnNeueFrage_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnNeueFrage);
            Controls.Add(RbAntwort4);
            Controls.Add(LbFrage);
            Controls.Add(RbAntwort3);
            Controls.Add(RbAntwort2);
            Controls.Add(RbAntwort1);
            Controls.Add(BtnRundeStarten);
            Controls.Add(CbAntworten);
            Controls.Add(CbFragen);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Quiz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox CbFragen;
        private ComboBox CbAntworten;
        private Button BtnRundeStarten;
        private RadioButton RbAntwort1;
        private RadioButton RbAntwort2;
        private RadioButton RbAntwort3;
        private Label LbFrage;
        private RadioButton RbAntwort4;
        private Button BtnNeueFrage;
    }
}