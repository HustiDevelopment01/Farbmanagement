namespace Farbmanagement
{
    partial class Farbenmanagement
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
            this.DataGridColorManagement = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSelectGroundColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridColorManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridColorManagement
            // 
            this.DataGridColorManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridColorManagement.Location = new System.Drawing.Point(12, 301);
            this.DataGridColorManagement.Name = "DataGridColorManagement";
            this.DataGridColorManagement.Size = new System.Drawing.Size(1200, 459);
            this.DataGridColorManagement.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Farbmanagement.Properties.Resources.logo_google;
            this.pictureBox1.Location = new System.Drawing.Point(810, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 291);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(762, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lackiererei Husterer Farbenmanagement";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(580, 240);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnSelectGroundColor
            // 
            this.btnSelectGroundColor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectGroundColor.Location = new System.Drawing.Point(598, 231);
            this.btnSelectGroundColor.Name = "btnSelectGroundColor";
            this.btnSelectGroundColor.Size = new System.Drawing.Size(206, 64);
            this.btnSelectGroundColor.TabIndex = 4;
            this.btnSelectGroundColor.Text = "Auswählen";
            this.btnSelectGroundColor.UseVisualStyleBackColor = true;
            this.btnSelectGroundColor.Click += new System.EventHandler(this.btnSelectGroundColor_Click);
            // 
            // Farbenmanagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 772);
            this.Controls.Add(this.btnSelectGroundColor);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DataGridColorManagement);
            this.Name = "Farbenmanagement";
            this.Text = "Farbenmanagement";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridColorManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridColorManagement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSelectGroundColor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

