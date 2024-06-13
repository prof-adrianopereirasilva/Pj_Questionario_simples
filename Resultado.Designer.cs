namespace Pj_Questionario_simples
{
    partial class Resultado
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
            label1 = new Label();
            label2 = new Label();
            lb_errada = new Label();
            lb_certa = new Label();
            label5 = new Label();
            bt_avancar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(335, 9);
            label1.Name = "label1";
            label1.Size = new Size(601, 54);
            label1.TabIndex = 5;
            label1.Text = "Você concluiu o questionário!!!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(84, 178);
            label2.Name = "label2";
            label2.Size = new Size(186, 54);
            label2.TabIndex = 6;
            label2.Text = "CERTAS :";
            // 
            // lb_errada
            // 
            lb_errada.AutoSize = true;
            lb_errada.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_errada.ForeColor = Color.White;
            lb_errada.Location = new Point(306, 326);
            lb_errada.Name = "lb_errada";
            lb_errada.Size = new Size(213, 54);
            lb_errada.TabIndex = 7;
            lb_errada.Text = "Questão 2";
            // 
            // lb_certa
            // 
            lb_certa.AutoSize = true;
            lb_certa.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_certa.ForeColor = Color.White;
            lb_certa.Location = new Point(306, 178);
            lb_certa.Name = "lb_certa";
            lb_certa.Size = new Size(213, 54);
            lb_certa.TabIndex = 8;
            lb_certa.Text = "Questão 2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(45, 326);
            label5.Name = "label5";
            label5.Size = new Size(225, 54);
            label5.TabIndex = 9;
            label5.Text = "ERRADAS :";
            // 
            // bt_avancar
            // 
            bt_avancar.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_avancar.ForeColor = Color.Blue;
            bt_avancar.Location = new Point(505, 405);
            bt_avancar.Name = "bt_avancar";
            bt_avancar.Size = new Size(216, 77);
            bt_avancar.TabIndex = 10;
            bt_avancar.Text = "FIM";
            bt_avancar.UseVisualStyleBackColor = true;
            bt_avancar.Click += bt_avancar_Click;
            // 
            // Resultado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(1264, 681);
            Controls.Add(bt_avancar);
            Controls.Add(label5);
            Controls.Add(lb_certa);
            Controls.Add(lb_errada);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Resultado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Resultado";
            Load += Resultado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lb_errada;
        private Label lb_certa;
        private Label label5;
        private Button bt_avancar;
    }
}