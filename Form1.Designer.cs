namespace Pj_Questionario_simples
{
    partial class Inicio
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
            button1 = new Button();
            bt_sair = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(316, 45);
            label1.Name = "label1";
            label1.Size = new Size(656, 54);
            label1.TabIndex = 0;
            label1.Text = "Seja bem vindo ao questionário!!!";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Blue;
            button1.Location = new Point(316, 205);
            button1.Name = "button1";
            button1.Size = new Size(272, 85);
            button1.TabIndex = 1;
            button1.Text = "COMEÇAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // bt_sair
            // 
            bt_sair.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_sair.ForeColor = Color.Red;
            bt_sair.Location = new Point(679, 205);
            bt_sair.Name = "bt_sair";
            bt_sair.Size = new Size(272, 85);
            bt_sair.TabIndex = 2;
            bt_sair.Text = "SAIR";
            bt_sair.UseVisualStyleBackColor = true;
            bt_sair.Click += button2_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(1264, 681);
            Controls.Add(bt_sair);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bem vindo !";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button bt_sair;
    }
}
