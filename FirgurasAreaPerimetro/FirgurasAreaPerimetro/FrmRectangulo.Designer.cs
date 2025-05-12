namespace FirgurasAreaPerimetro
{
    partial class FrmRectangulo
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
            this.grbProcesos = new System.Windows.Forms.GroupBox();
            this.btnResetear = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.grpOutputs = new System.Windows.Forms.GroupBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.grbInputs = new System.Windows.Forms.GroupBox();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.lblAncho = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLargo = new System.Windows.Forms.Label();
            this.txtLargo = new System.Windows.Forms.TextBox();
            this.grbProcesos.SuspendLayout();
            this.grpOutputs.SuspendLayout();
            this.grbInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbProcesos
            // 
            this.grbProcesos.Controls.Add(this.btnResetear);
            this.grbProcesos.Controls.Add(this.btnCalcular);
            this.grbProcesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProcesos.Location = new System.Drawing.Point(120, 227);
            this.grbProcesos.Margin = new System.Windows.Forms.Padding(4);
            this.grbProcesos.Name = "grbProcesos";
            this.grbProcesos.Padding = new System.Windows.Forms.Padding(4);
            this.grbProcesos.Size = new System.Drawing.Size(375, 112);
            this.grbProcesos.TabIndex = 9;
            this.grbProcesos.TabStop = false;
            this.grbProcesos.Text = "Proceso";
            // 
            // btnResetear
            // 
            this.btnResetear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnResetear.Location = new System.Drawing.Point(220, 43);
            this.btnResetear.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(100, 28);
            this.btnResetear.TabIndex = 1;
            this.btnResetear.Text = "Resetear";
            this.btnResetear.UseVisualStyleBackColor = false;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.IndianRed;
            this.btnCalcular.Location = new System.Drawing.Point(67, 43);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 28);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // grpOutputs
            // 
            this.grpOutputs.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpOutputs.Controls.Add(this.txtArea);
            this.grpOutputs.Controls.Add(this.txtPerimetro);
            this.grpOutputs.Controls.Add(this.lblArea);
            this.grpOutputs.Controls.Add(this.lblPerimetro);
            this.grpOutputs.Enabled = false;
            this.grpOutputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOutputs.Location = new System.Drawing.Point(120, 347);
            this.grpOutputs.Margin = new System.Windows.Forms.Padding(4);
            this.grpOutputs.Name = "grpOutputs";
            this.grpOutputs.Padding = new System.Windows.Forms.Padding(4);
            this.grpOutputs.Size = new System.Drawing.Size(375, 157);
            this.grpOutputs.TabIndex = 8;
            this.grpOutputs.TabStop = false;
            this.grpOutputs.Text = "Salidas";
            // 
            // txtArea
            // 
            this.txtArea.BackColor = System.Drawing.Color.Lime;
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(32, 113);
            this.txtArea.Margin = new System.Windows.Forms.Padding(4);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(307, 23);
            this.txtArea.TabIndex = 4;
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.BackColor = System.Drawing.Color.Lime;
            this.txtPerimetro.Enabled = false;
            this.txtPerimetro.Location = new System.Drawing.Point(32, 54);
            this.txtPerimetro.Margin = new System.Windows.Forms.Padding(4);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.Size = new System.Drawing.Size(307, 23);
            this.txtPerimetro.TabIndex = 3;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(28, 94);
            this.lblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(47, 17);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Area:";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(28, 34);
            this.lblPerimetro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(83, 17);
            this.lblPerimetro.TabIndex = 2;
            this.lblPerimetro.Text = "Perímetro:";
            // 
            // grbInputs
            // 
            this.grbInputs.Controls.Add(this.txtLargo);
            this.grbInputs.Controls.Add(this.lblLargo);
            this.grbInputs.Controls.Add(this.txtAncho);
            this.grbInputs.Controls.Add(this.lblAncho);
            this.grbInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInputs.Location = new System.Drawing.Point(120, 50);
            this.grbInputs.Margin = new System.Windows.Forms.Padding(4);
            this.grbInputs.Name = "grbInputs";
            this.grbInputs.Padding = new System.Windows.Forms.Padding(4);
            this.grbInputs.Size = new System.Drawing.Size(375, 169);
            this.grbInputs.TabIndex = 7;
            this.grbInputs.TabStop = false;
            this.grbInputs.Text = "Entradas";
            // 
            // txtAncho
            // 
            this.txtAncho.BackColor = System.Drawing.Color.Lime;
            this.txtAncho.Location = new System.Drawing.Point(31, 41);
            this.txtAncho.Margin = new System.Windows.Forms.Padding(4);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(307, 23);
            this.txtAncho.TabIndex = 1;
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Location = new System.Drawing.Point(28, 20);
            this.lblAncho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(58, 17);
            this.lblAncho.TabIndex = 0;
            this.lblAncho.Text = "Ancho:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::FirgurasAreaPerimetro.Properties.Resources.rectangulo;
            this.pictureBox1.Location = new System.Drawing.Point(578, 159);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblLargo
            // 
            this.lblLargo.AutoSize = true;
            this.lblLargo.Location = new System.Drawing.Point(31, 100);
            this.lblLargo.Name = "lblLargo";
            this.lblLargo.Size = new System.Drawing.Size(55, 17);
            this.lblLargo.TabIndex = 2;
            this.lblLargo.Text = "Largo:";
            // 
            // txtLargo
            // 
            this.txtLargo.BackColor = System.Drawing.Color.Lime;
            this.txtLargo.Location = new System.Drawing.Point(31, 120);
            this.txtLargo.Name = "txtLargo";
            this.txtLargo.Size = new System.Drawing.Size(308, 23);
            this.txtLargo.TabIndex = 3;
            // 
            // FrmRectangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grbProcesos);
            this.Controls.Add(this.grpOutputs);
            this.Controls.Add(this.grbInputs);
            this.Name = "FrmRectangulo";
            this.Text = "FrmRectangulo";
            this.grbProcesos.ResumeLayout(false);
            this.grpOutputs.ResumeLayout(false);
            this.grpOutputs.PerformLayout();
            this.grbInputs.ResumeLayout(false);
            this.grbInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grbProcesos;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox grpOutputs;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.GroupBox grbInputs;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.Label lblAncho;
        private System.Windows.Forms.TextBox txtLargo;
        private System.Windows.Forms.Label lblLargo;
    }
}