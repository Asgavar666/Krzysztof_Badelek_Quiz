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
            this.label1 = new System.Windows.Forms.Label();
            this.CbFragen = new System.Windows.Forms.ComboBox();
            this.CbAntworten = new System.Windows.Forms.ComboBox();
            this.BtnRundeStarten = new System.Windows.Forms.Button();
            this.RbAntwort1 = new System.Windows.Forms.RadioButton();
            this.RbAntwort2 = new System.Windows.Forms.RadioButton();
            this.RbAntwort3 = new System.Windows.Forms.RadioButton();
            this.LbFrage = new System.Windows.Forms.Label();
            this.RbAntwort4 = new System.Windows.Forms.RadioButton();
            this.BtnNeueFrage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(293, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fragen wählen";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CbFragen
            // 
            this.CbFragen.FormattingEnabled = true;
            this.CbFragen.Location = new System.Drawing.Point(53, 85);
            this.CbFragen.Name = "CbFragen";
            this.CbFragen.Size = new System.Drawing.Size(132, 23);
            this.CbFragen.TabIndex = 2;
            this.CbFragen.Text = "Fragenart";
            this.CbFragen.SelectedIndexChanged += new System.EventHandler(this.CbFragen_SelectedIndexChanged);
            // 
            // CbAntworten
            // 
            this.CbAntworten.FormattingEnabled = true;
            this.CbAntworten.Location = new System.Drawing.Point(53, 134);
            this.CbAntworten.Name = "CbAntworten";
            this.CbAntworten.Size = new System.Drawing.Size(132, 23);
            this.CbAntworten.TabIndex = 3;
            this.CbAntworten.Text = "Antworten";
            // 
            // BtnRundeStarten
            // 
            this.BtnRundeStarten.Location = new System.Drawing.Point(53, 193);
            this.BtnRundeStarten.Name = "BtnRundeStarten";
            this.BtnRundeStarten.Size = new System.Drawing.Size(132, 23);
            this.BtnRundeStarten.TabIndex = 4;
            this.BtnRundeStarten.Text = "Runde starten";
            this.BtnRundeStarten.UseVisualStyleBackColor = true;
            this.BtnRundeStarten.Click += new System.EventHandler(this.BtnRundeStarten_Click);
            // 
            // RbAntwort1
            // 
            this.RbAntwort1.AutoSize = true;
            this.RbAntwort1.Location = new System.Drawing.Point(267, 262);
            this.RbAntwort1.Name = "RbAntwort1";
            this.RbAntwort1.Size = new System.Drawing.Size(14, 13);
            this.RbAntwort1.TabIndex = 5;
            this.RbAntwort1.TabStop = true;
            this.RbAntwort1.UseVisualStyleBackColor = true;
            // 
            // RbAntwort2
            // 
            this.RbAntwort2.AutoSize = true;
            this.RbAntwort2.Location = new System.Drawing.Point(386, 262);
            this.RbAntwort2.Name = "RbAntwort2";
            this.RbAntwort2.Size = new System.Drawing.Size(14, 13);
            this.RbAntwort2.TabIndex = 6;
            this.RbAntwort2.TabStop = true;
            this.RbAntwort2.UseVisualStyleBackColor = true;
            // 
            // RbAntwort3
            // 
            this.RbAntwort3.AutoSize = true;
            this.RbAntwort3.Location = new System.Drawing.Point(498, 262);
            this.RbAntwort3.Name = "RbAntwort3";
            this.RbAntwort3.Size = new System.Drawing.Size(14, 13);
            this.RbAntwort3.TabIndex = 7;
            this.RbAntwort3.TabStop = true;
            this.RbAntwort3.UseVisualStyleBackColor = true;
            // 
            // LbFrage
            // 
            this.LbFrage.AutoSize = true;
            this.LbFrage.Location = new System.Drawing.Point(416, 218);
            this.LbFrage.Name = "LbFrage";
            this.LbFrage.Size = new System.Drawing.Size(36, 15);
            this.LbFrage.TabIndex = 8;
            this.LbFrage.Text = "Frage";
            // 
            // RbAntwort4
            // 
            this.RbAntwort4.AutoSize = true;
            this.RbAntwort4.Location = new System.Drawing.Point(608, 262);
            this.RbAntwort4.Name = "RbAntwort4";
            this.RbAntwort4.Size = new System.Drawing.Size(14, 13);
            this.RbAntwort4.TabIndex = 9;
            this.RbAntwort4.TabStop = true;
            this.RbAntwort4.UseVisualStyleBackColor = true;
            // 
            // BtnNeueFrage
            // 
            this.BtnNeueFrage.Location = new System.Drawing.Point(406, 315);
            this.BtnNeueFrage.Name = "BtnNeueFrage";
            this.BtnNeueFrage.Size = new System.Drawing.Size(75, 23);
            this.BtnNeueFrage.TabIndex = 10;
            this.BtnNeueFrage.Text = "Neue Frage";
            this.BtnNeueFrage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnNeueFrage);
            this.Controls.Add(this.RbAntwort4);
            this.Controls.Add(this.LbFrage);
            this.Controls.Add(this.RbAntwort3);
            this.Controls.Add(this.RbAntwort2);
            this.Controls.Add(this.RbAntwort1);
            this.Controls.Add(this.BtnRundeStarten);
            this.Controls.Add(this.CbAntworten);
            this.Controls.Add(this.CbFragen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();

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