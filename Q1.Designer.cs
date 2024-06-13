namespace Pj_Questionario_simples
{
    partial class Q1
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
            groupBox1 = new GroupBox();
            rbt_errada3 = new RadioButton();
            rbt_certa = new RadioButton();
            rbt_errada2 = new RadioButton();
            rbt_errada1 = new RadioButton();
            label1 = new Label();
            bt_avancar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbt_errada3);
            groupBox1.Controls.Add(rbt_certa);
            groupBox1.Controls.Add(rbt_errada2);
            groupBox1.Controls.Add(rbt_errada1);
            groupBox1.Location = new Point(128, 138);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(868, 394);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // rbt_errada3
            // 
            rbt_errada3.AutoSize = true;
            rbt_errada3.Font = new Font("Segoe UI", 27F, FontStyle.Bold);
            rbt_errada3.ForeColor = Color.White;
            rbt_errada3.Location = new Point(117, 323);
            rbt_errada3.Name = "rbt_errada3";
            rbt_errada3.Size = new Size(145, 52);
            rbt_errada3.TabIndex = 4;
            rbt_errada3.TabStop = true;
            rbt_errada3.Text = "Errada";
            rbt_errada3.UseVisualStyleBackColor = true;
            // 
            // rbt_certa
            // 
            rbt_certa.AutoSize = true;
            rbt_certa.Font = new Font("Segoe UI", 27F, FontStyle.Bold);
            rbt_certa.ForeColor = Color.White;
            rbt_certa.Location = new Point(117, 231);
            rbt_certa.Name = "rbt_certa";
            rbt_certa.Size = new Size(127, 52);
            rbt_certa.TabIndex = 3;
            rbt_certa.TabStop = true;
            rbt_certa.Text = "Certa";
            rbt_certa.UseVisualStyleBackColor = true;
            rbt_certa.CheckedChanged += rbt_certa_CheckedChanged;
            // 
            // rbt_errada2
            // 
            rbt_errada2.AutoSize = true;
            rbt_errada2.Font = new Font("Segoe UI", 27F, FontStyle.Bold);
            rbt_errada2.ForeColor = Color.White;
            rbt_errada2.Location = new Point(117, 146);
            rbt_errada2.Name = "rbt_errada2";
            rbt_errada2.Size = new Size(145, 52);
            rbt_errada2.TabIndex = 2;
            rbt_errada2.TabStop = true;
            rbt_errada2.Text = "Errada";
            rbt_errada2.UseVisualStyleBackColor = true;
            rbt_errada2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rbt_errada1
            // 
            rbt_errada1.AutoSize = true;
            rbt_errada1.Font = new Font("Segoe UI", 27F, FontStyle.Bold);
            rbt_errada1.ForeColor = Color.White;
            rbt_errada1.Location = new Point(117, 63);
            rbt_errada1.Name = "rbt_errada1";
            rbt_errada1.Size = new Size(145, 52);
            rbt_errada1.TabIndex = 1;
            rbt_errada1.TabStop = true;
            rbt_errada1.Text = "Errada";
            rbt_errada1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(128, 48);
            label1.Name = "label1";
            label1.Size = new Size(213, 54);
            label1.TabIndex = 1;
            label1.Text = "Questão 1";
            // 
            // bt_avancar
            // 
            bt_avancar.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_avancar.ForeColor = Color.Blue;
            bt_avancar.Location = new Point(423, 538);
            bt_avancar.Name = "bt_avancar";
            bt_avancar.Size = new Size(216, 77);
            bt_avancar.TabIndex = 0;
            bt_avancar.Text = "Avançar";
            bt_avancar.UseVisualStyleBackColor = true;
            bt_avancar.Click += button1_Click;
            // 
            // Q1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(1264, 681);
            Controls.Add(bt_avancar);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Q1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Q1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button bt_avancar;
        private RadioButton rbt_errada3;
        private RadioButton rbt_certa;
        private RadioButton rbt_errada2;
        private RadioButton rbt_errada1;
    }
}