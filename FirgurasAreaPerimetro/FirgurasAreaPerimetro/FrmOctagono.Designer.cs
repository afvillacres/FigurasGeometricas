namespace FirgurasAreaPerimetro
{
    partial class FrmOctagono
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
            this.grpOutputs = new System.Windows.Forms.GroupBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbInputs = new System.Windows.Forms.GroupBox();
            this.txtApotema = new System.Windows.Forms.TextBox();
            this.lblApotema = new System.Windows.Forms.Label();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.lblLado = new System.Windows.Forms.Label();
            this.grbProcesos = new System.Windows.Forms.GroupBox();
            this.btnResetear = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.grpOutputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbInputs.SuspendLayout();
            this.grbProcesos.SuspendLayout();
            this.SuspendLayout();
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::FirgurasAreaPerimetro.Properties.Resources.octagono;
            this.pictureBox1.Location = new System.Drawing.Point(578, 159);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // grbInputs
            // 
            this.grbInputs.Controls.Add(this.txtApotema);
            this.grbInputs.Controls.Add(this.lblApotema);
            this.grbInputs.Controls.Add(this.txtLado);
            this.grbInputs.Controls.Add(this.lblLado);
            this.grbInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInputs.Location = new System.Drawing.Point(120, 35);
            this.grbInputs.Margin = new System.Windows.Forms.Padding(4);
            this.grbInputs.Name = "grbInputs";
            this.grbInputs.Padding = new System.Windows.Forms.Padding(4);
            this.grbInputs.Size = new System.Drawing.Size(375, 165);
            this.grbInputs.TabIndex = 15;
            this.grbInputs.TabStop = false;
            this.grbInputs.Text = "Entradas";
            // 
            // txtApotema
            // 
            this.txtApotema.BackColor = System.Drawing.Color.Lime;
            this.txtApotema.Location = new System.Drawing.Point(31, 113);
            this.txtApotema.Name = "txtApotema";
            this.txtApotema.Size = new System.Drawing.Size(305, 23);
            this.txtApotema.TabIndex = 3;
            // 
            // lblApotema
            // 
            this.lblApotema.AutoSize = true;
            this.lblApotema.Location = new System.Drawing.Point(28, 93);
            this.lblApotema.Name = "lblApotema";
            this.lblApotema.Size = new System.Drawing.Size(76, 17);
            this.lblApotema.TabIndex = 2;
            this.lblApotema.Text = "Apotema:";
            // 
            // txtLado
            // 
            this.txtLado.BackColor = System.Drawing.Color.Lime;
            this.txtLado.Location = new System.Drawing.Point(32, 52);
            this.txtLado.Margin = new System.Windows.Forms.Padding(4);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(307, 23);
            this.txtLado.TabIndex = 1;
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Location = new System.Drawing.Point(29, 31);
            this.lblLado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(49, 17);
            this.lblLado.TabIndex = 0;
            this.lblLado.Text = "Lado:";
            // 
            // grbProcesos
            // 
            this.grbProcesos.Controls.Add(this.btnResetear);
            this.grbProcesos.Controls.Add(this.btnCalcular);
            this.grbProcesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProcesos.Location = new System.Drawing.Point(120, 218);
            this.grbProcesos.Margin = new System.Windows.Forms.Padding(4);
            this.grbProcesos.Name = "grbProcesos";
            this.grbProcesos.Padding = new System.Windows.Forms.Padding(4);
            this.grbProcesos.Size = new System.Drawing.Size(375, 112);
            this.grbProcesos.TabIndex = 14;
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
            // FrmOctagono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(900, 554);
            this.Controls.Add(this.grbInputs);
            this.Controls.Add(this.grbProcesos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpOutputs);
            this.Name = "FrmOctagono";
            this.Text = "FrmOctagono";
            this.grpOutputs.ResumeLayout(false);
            this.grpOutputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbInputs.ResumeLayout(false);
            this.grbInputs.PerformLayout();
            this.grbProcesos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpOutputs;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.GroupBox grbInputs;
        private System.Windows.Forms.TextBox txtApotema;
        private System.Windows.Forms.Label lblApotema;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.GroupBox grbProcesos;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.Button btnCalcular;
    }
}