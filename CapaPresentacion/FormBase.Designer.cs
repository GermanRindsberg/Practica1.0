namespace Practica1._0.CapaPresentacion
{
    partial class FormBase
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
            this.lbl_bienvenidos = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.pic_marca = new System.Windows.Forms.PictureBox();
            this.pic_camion = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_marca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_camion)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_bienvenidos
            // 
            this.lbl_bienvenidos.AutoSize = true;
            this.lbl_bienvenidos.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_bienvenidos.Location = new System.Drawing.Point(12, 154);
            this.lbl_bienvenidos.Name = "lbl_bienvenidos";
            this.lbl_bienvenidos.Size = new System.Drawing.Size(93, 19);
            this.lbl_bienvenidos.TabIndex = 1;
            this.lbl_bienvenidos.Text = "Bienvenido:";
            this.lbl_bienvenidos.Click += new System.EventHandler(this.lbl_bienvenidos_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Salir.ForeColor = System.Drawing.Color.Black;
            this.btn_Salir.Location = new System.Drawing.Point(1008, 525);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(97, 70);
            this.btn_Salir.TabIndex = 3;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Maroon;
            this.panel.Controls.Add(this.pic_marca);
            this.panel.Controls.Add(this.pic_camion);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1163, 134);
            this.panel.TabIndex = 0;
            // 
            // pic_marca
            // 
            this.pic_marca.BackgroundImage = global::Practica1._0.Properties.Resources.btn_nintendo1;
            this.pic_marca.Image = global::Practica1._0.Properties.Resources.btn_nintendo1;
            this.pic_marca.Location = new System.Drawing.Point(189, 0);
            this.pic_marca.Name = "pic_marca";
            this.pic_marca.Size = new System.Drawing.Size(974, 134);
            this.pic_marca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_marca.TabIndex = 1;
            this.pic_marca.TabStop = false;
            // 
            // pic_camion
            // 
            this.pic_camion.Image = global::Practica1._0.Properties.Resources.png_camion2;
            this.pic_camion.Location = new System.Drawing.Point(3, 3);
            this.pic_camion.Name = "pic_camion";
            this.pic_camion.Size = new System.Drawing.Size(168, 122);
            this.pic_camion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_camion.TabIndex = 0;
            this.pic_camion.TabStop = false;
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1163, 635);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.lbl_bienvenidos);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormBase";
            this.Text = "Logistica y Servicios";
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_marca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_camion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btn_Salir;
        public System.Windows.Forms.PictureBox pic_camion;
        public System.Windows.Forms.Panel panel;
        public System.Windows.Forms.PictureBox pic_marca;
        public System.Windows.Forms.Label lbl_bienvenidos;
    }
}