namespace pryFollentiIE
{
    partial class frmUsuarios
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMinimizarApp = new System.Windows.Forms.PictureBox();
            this.btnCerrarApp = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPerfiles = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomUs = new System.Windows.Forms.TextBox();
            this.txtContUs = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.PictureBox();
            this.eL_CLUBDataSet = new pryFollentiIE.EL_CLUBDataSet();
            this.uSERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSERSTableAdapter = new pryFollentiIE.EL_CLUBDataSetTableAdapters.USERSTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eL_CLUBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnMinimizarApp);
            this.panel1.Controls.Add(this.btnCerrarApp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 34);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(181, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Agregar nuevo usuario";
            // 
            // btnMinimizarApp
            // 
            this.btnMinimizarApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnMinimizarApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizarApp.Image = global::pryFollentiIE.Properties.Resources.minimizar_ventana;
            this.btnMinimizarApp.Location = new System.Drawing.Point(505, 7);
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
            this.btnCerrarApp.Location = new System.Drawing.Point(535, 7);
            this.btnCerrarApp.Name = "btnCerrarApp";
            this.btnCerrarApp.Size = new System.Drawing.Size(30, 24);
            this.btnCerrarApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarApp.TabIndex = 7;
            this.btnCerrarApp.TabStop = false;
            this.btnCerrarApp.Click += new System.EventHandler(this.btnCerrarApp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ingrese nombre de usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ingrese la contraseña para el usuario:";
            // 
            // cmbPerfiles
            // 
            this.cmbPerfiles.DataSource = this.uSERSBindingSource;
            this.cmbPerfiles.DisplayMember = "perfil";
            this.cmbPerfiles.FormattingEnabled = true;
            this.cmbPerfiles.Location = new System.Drawing.Point(300, 168);
            this.cmbPerfiles.Name = "cmbPerfiles";
            this.cmbPerfiles.Size = new System.Drawing.Size(171, 21);
            this.cmbPerfiles.TabIndex = 12;
            this.cmbPerfiles.ValueMember = "perfil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Seleccione el perfil del usuario:";
            // 
            // txtNomUs
            // 
            this.txtNomUs.Location = new System.Drawing.Point(300, 67);
            this.txtNomUs.Name = "txtNomUs";
            this.txtNomUs.Size = new System.Drawing.Size(171, 20);
            this.txtNomUs.TabIndex = 14;
            // 
            // txtContUs
            // 
            this.txtContUs.Location = new System.Drawing.Point(300, 115);
            this.txtContUs.Name = "txtContUs";
            this.txtContUs.Size = new System.Drawing.Size(171, 20);
            this.txtContUs.TabIndex = 15;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(208)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAgregar.Location = new System.Drawing.Point(185, 230);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(225, 35);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(520, 269);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Volver";
            // 
            // btnVolver
            // 
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Image = global::pryFollentiIE.Properties.Resources.volver;
            this.btnVolver.Location = new System.Drawing.Point(516, 226);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(49, 39);
            this.btnVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVolver.TabIndex = 18;
            this.btnVolver.TabStop = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // eL_CLUBDataSet
            // 
            this.eL_CLUBDataSet.DataSetName = "EL_CLUBDataSet";
            this.eL_CLUBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSERSBindingSource
            // 
            this.uSERSBindingSource.DataMember = "USERS";
            this.uSERSBindingSource.DataSource = this.eL_CLUBDataSet;
            // 
            // uSERSTableAdapter
            // 
            this.uSERSTableAdapter.ClearBeforeFill = true;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 294);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtContUs);
            this.Controls.Add(this.txtNomUs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbPerfiles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eL_CLUBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnMinimizarApp;
        private System.Windows.Forms.PictureBox btnCerrarApp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPerfiles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomUs;
        private System.Windows.Forms.TextBox txtContUs;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox btnVolver;
        private EL_CLUBDataSet eL_CLUBDataSet;
        private System.Windows.Forms.BindingSource uSERSBindingSource;
        private EL_CLUBDataSetTableAdapters.USERSTableAdapter uSERSTableAdapter;
    }
}