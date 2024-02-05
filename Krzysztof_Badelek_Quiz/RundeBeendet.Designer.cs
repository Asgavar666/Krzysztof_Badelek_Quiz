namespace Krzysztof_Badelek_Quiz
{
    partial class RundeBeendet
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
            LbPunkte = new Label();
            BtnHighscore = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // LbPunkte
            // 
            LbPunkte.AutoSize = true;
            LbPunkte.Location = new Point(327, 28);
            LbPunkte.Name = "LbPunkte";
            LbPunkte.Size = new Size(44, 15);
            LbPunkte.TabIndex = 0;
            LbPunkte.Text = "punkte";
            // 
            // BtnHighscore
            // 
            BtnHighscore.Location = new Point(268, 69);
            BtnHighscore.Name = "BtnHighscore";
            BtnHighscore.Size = new Size(173, 23);
            BtnHighscore.TabIndex = 1;
            BtnHighscore.Text = "Highscore Ansehen";
            BtnHighscore.UseVisualStyleBackColor = true;
            BtnHighscore.Click += BtnHighscore_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(238, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(240, 245);
            dataGridView1.TabIndex = 2;
            // 
            // RundeBeendet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(BtnHighscore);
            Controls.Add(LbPunkte);
            Name = "RundeBeendet";
            Text = "RundeBeendet";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbPunkte;
        private Button BtnHighscore;
        private DataGridView dataGridView1;
    }
}