﻿namespace pryFollentiIE
{
    partial class abmSocios
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizarApp = new System.Windows.Forms.PictureBox();
            this.btnCerrarApp = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnBuscarId = new System.Windows.Forms.Button();
            this.lblbusq = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarApp)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.panel1.Controls.Add(this.btnMinimizarApp);
            this.panel1.Controls.Add(this.btnCerrarApp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 34);
            this.panel1.TabIndex = 9;
            // 
            // btnMinimizarApp
            // 
            this.btnMinimizarApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnMinimizarApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizarApp.Image = global::pryFollentiIE.Properties.Resources.minimizar_ventana;
            this.btnMinimizarApp.Location = new System.Drawing.Point(1011, 3);
            this.btnMinimizarApp.Name = "btnMinimizarApp";
            this.btnMinimizarApp.Size = new System.Drawing.Size(24, 23);
            this.btnMinimizarApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizarApp.TabIndex = 6;
            this.btnMinimizarApp.TabStop = false;
            this.btnMinimizarApp.Click += new System.EventHandler(this.btnMinimizarApp_Click);
            // 
            // btnCerrarApp
            // 
            this.btnCerrarApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnCerrarApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarApp.Image = global::pryFollentiIE.Properties.Resources.cerrar__1_;
            this.btnCerrarApp.Location = new System.Drawing.Point(1041, 3);
            this.btnCerrarApp.Name = "btnCerrarApp";
            this.btnCerrarApp.Size = new System.Drawing.Size(30, 24);
            this.btnCerrarApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarApp.TabIndex = 7;
            this.btnCerrarApp.TabStop = false;
            this.btnCerrarApp.Click += new System.EventHandler(this.btnCerrarApp_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblbusq);
            this.panel2.Controls.Add(this.btnBuscarId);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 645);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvMostrar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(226, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(854, 645);
            this.panel3.TabIndex = 11;
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMostrar.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMostrar.Location = new System.Drawing.Point(0, 0);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.Size = new System.Drawing.Size(854, 645);
            this.dgvMostrar.TabIndex = 0;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(50, 87);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 23);
            this.txtID.TabIndex = 1;
            // 
            // btnBuscarId
            // 
            this.btnBuscarId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(208)))));
            this.btnBuscarId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarId.FlatAppearance.BorderSize = 0;
            this.btnBuscarId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarId.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBuscarId.Location = new System.Drawing.Point(29, 139);
            this.btnBuscarId.Name = "btnBuscarId";
            this.btnBuscarId.Size = new System.Drawing.Size(147, 35);
            this.btnBuscarId.TabIndex = 7;
            this.btnBuscarId.Text = "Buscar por ID";
            this.btnBuscarId.UseVisualStyleBackColor = false;
            this.btnBuscarId.Click += new System.EventHandler(this.btnBuscarId_Click);
            // 
            // lblbusq
            // 
            this.lblbusq.AutoSize = true;
            this.lblbusq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbusq.Location = new System.Drawing.Point(12, 53);
            this.lblbusq.Name = "lblbusq";
            this.lblbusq.Size = new System.Drawing.Size(189, 13);
            this.lblbusq.TabIndex = 8;
            this.lblbusq.Text = "Ingrese el ID que desea buscar:";
            // 
            // abmSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 679);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "abmSocios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "abmSocios";
            this.Load += new System.EventHandler(this.abmSocios_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarApp)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnMinimizarApp;
        private System.Windows.Forms.PictureBox btnCerrarApp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.Label lblbusq;
        private System.Windows.Forms.Button btnBuscarId;
    }
}