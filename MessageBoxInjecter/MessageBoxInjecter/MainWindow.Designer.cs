namespace MessageBoxInjecter
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbpath = new System.Windows.Forms.TextBox();
            this.cbmethods = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tbout = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSfd = new CheapMetro.MetroButton();
            this.btnofd = new CheapMetro.MetroButton();
            this.btnInject = new CheapMetro.MetroButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tbmsg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbpath
            // 
            this.tbpath.Location = new System.Drawing.Point(12, 26);
            this.tbpath.Multiline = true;
            this.tbpath.Name = "tbpath";
            this.tbpath.Size = new System.Drawing.Size(438, 26);
            this.tbpath.TabIndex = 1;
            // 
            // cbmethods
            // 
            this.cbmethods.FormattingEnabled = true;
            this.cbmethods.Location = new System.Drawing.Point(12, 211);
            this.cbmethods.Name = "cbmethods";
            this.cbmethods.Size = new System.Drawing.Size(429, 21);
            this.cbmethods.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inject Into:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(447, 215);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(123, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Inject Into Entrypoint";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // tbout
            // 
            this.tbout.Location = new System.Drawing.Point(12, 84);
            this.tbout.Multiline = true;
            this.tbout.Name = "tbout";
            this.tbout.Size = new System.Drawing.Size(438, 26);
            this.tbout.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Input:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Output:";
            // 
            // btnSfd
            // 
            this.btnSfd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSfd.FlatAppearance.BorderSize = 0;
            this.btnSfd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSfd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSfd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSfd.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSfd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnSfd.Location = new System.Drawing.Point(456, 84);
            this.btnSfd.Name = "btnSfd";
            this.btnSfd.Size = new System.Drawing.Size(114, 26);
            this.btnSfd.TabIndex = 7;
            this.btnSfd.Text = "...";
            this.btnSfd.Theme = CheapMetro.Theme.MightyBlue;
            this.btnSfd.UseVisualStyleBackColor = false;
            this.btnSfd.Click += new System.EventHandler(this.btnSfd_Click);
            // 
            // btnofd
            // 
            this.btnofd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnofd.FlatAppearance.BorderSize = 0;
            this.btnofd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnofd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnofd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnofd.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnofd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnofd.Location = new System.Drawing.Point(456, 26);
            this.btnofd.Name = "btnofd";
            this.btnofd.Size = new System.Drawing.Size(114, 26);
            this.btnofd.TabIndex = 2;
            this.btnofd.Text = "...";
            this.btnofd.Theme = CheapMetro.Theme.MightyBlue;
            this.btnofd.UseVisualStyleBackColor = false;
            this.btnofd.Click += new System.EventHandler(this.btnofd_Click);
            // 
            // btnInject
            // 
            this.btnInject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnInject.FlatAppearance.BorderSize = 0;
            this.btnInject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnInject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnInject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInject.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnInject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnInject.Location = new System.Drawing.Point(15, 267);
            this.btnInject.Name = "btnInject";
            this.btnInject.Size = new System.Drawing.Size(558, 80);
            this.btnInject.TabIndex = 0;
            this.btnInject.Text = "Inject";
            this.btnInject.Theme = CheapMetro.Theme.MightyBlue;
            this.btnInject.UseVisualStyleBackColor = false;
            this.btnInject.Click += new System.EventHandler(this.btnInject_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Messagebox Text:";
            // 
            // tbmsg
            // 
            this.tbmsg.Location = new System.Drawing.Point(12, 145);
            this.tbmsg.Multiline = true;
            this.tbmsg.Name = "tbmsg";
            this.tbmsg.Size = new System.Drawing.Size(558, 26);
            this.tbmsg.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(495, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Show Preview";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 368);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbmsg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSfd);
            this.Controls.Add(this.tbout);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbmethods);
            this.Controls.Add(this.btnofd);
            this.Controls.Add(this.tbpath);
            this.Controls.Add(this.btnInject);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "MessageBox Injecter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheapMetro.MetroButton btnInject;
        private System.Windows.Forms.TextBox tbpath;
        private CheapMetro.MetroButton btnofd;
        private System.Windows.Forms.ComboBox cbmethods;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private CheapMetro.MetroButton btnSfd;
        private System.Windows.Forms.TextBox tbout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbmsg;
        private System.Windows.Forms.Label label5;
    }
}

