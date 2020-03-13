namespace WMI
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_nome_pc = new System.Windows.Forms.Label();
            this.lb_mac = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_ip = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_internet = new System.Windows.Forms.Label();
            this.bt_atualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 235);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(350, 156);
            this.listBox1.TabIndex = 0;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(312, 9);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(37, 13);
            this.status.TabIndex = 2;
            this.status.Text = "Status";
            this.status.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(9, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome do PC:";
            // 
            // lb_nome_pc
            // 
            this.lb_nome_pc.AutoSize = true;
            this.lb_nome_pc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome_pc.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lb_nome_pc.Location = new System.Drawing.Point(82, 65);
            this.lb_nome_pc.Name = "lb_nome_pc";
            this.lb_nome_pc.Size = new System.Drawing.Size(98, 13);
            this.lb_nome_pc.TabIndex = 4;
            this.lb_nome_pc.Text = "Não encontrado";
            // 
            // lb_mac
            // 
            this.lb_mac.AutoSize = true;
            this.lb_mac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mac.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lb_mac.Location = new System.Drawing.Point(82, 95);
            this.lb_mac.Name = "lb_mac";
            this.lb_mac.Size = new System.Drawing.Size(98, 13);
            this.lb_mac.TabIndex = 5;
            this.lb_mac.Text = "Não encontrado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(46, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "MAC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(238, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "IP:";
            // 
            // lb_ip
            // 
            this.lb_ip.AutoSize = true;
            this.lb_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ip.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lb_ip.Location = new System.Drawing.Point(261, 65);
            this.lb_ip.Name = "lb_ip";
            this.lb_ip.Size = new System.Drawing.Size(98, 13);
            this.lb_ip.TabIndex = 7;
            this.lb_ip.Text = "Não encontrado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(212, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Internet:";
            // 
            // lb_internet
            // 
            this.lb_internet.AutoSize = true;
            this.lb_internet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_internet.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lb_internet.Location = new System.Drawing.Point(261, 95);
            this.lb_internet.Name = "lb_internet";
            this.lb_internet.Size = new System.Drawing.Size(98, 13);
            this.lb_internet.TabIndex = 9;
            this.lb_internet.Text = "Não encontrado";
            // 
            // bt_atualizar
            // 
            this.bt_atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_atualizar.Location = new System.Drawing.Point(4, 4);
            this.bt_atualizar.Name = "bt_atualizar";
            this.bt_atualizar.Size = new System.Drawing.Size(62, 23);
            this.bt_atualizar.TabIndex = 11;
            this.bt_atualizar.Text = "Atualizar";
            this.bt_atualizar.UseVisualStyleBackColor = true;
            this.bt_atualizar.Click += new System.EventHandler(this.bt_atualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(392, 403);
            this.Controls.Add(this.bt_atualizar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_internet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_ip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_mac);
            this.Controls.Add(this.lb_nome_pc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.listBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_nome_pc;
        private System.Windows.Forms.Label lb_mac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_ip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_internet;
        private System.Windows.Forms.Button bt_atualizar;

    }
}

