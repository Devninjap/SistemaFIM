﻿namespace CapaPresentacion
{
    partial class Frm_Responsable
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
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvListadoResp = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtApePat = new System.Windows.Forms.TextBox();
            this.txtApeMat = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtGrado = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoResp)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(53, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 68);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(62, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "GESTIÓN DE RESPONSABLE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label10.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(937, 24);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 56);
            this.label10.TabIndex = 15;
            this.label10.Text = "X";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(13, 143);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(974, 662);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dgvListadoResp);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(966, 622);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(33, 402);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(854, 111);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro por Apellidos";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.textBox1.Location = new System.Drawing.Point(9, 46);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(806, 35);
            this.textBox1.TabIndex = 1;
            // 
            // dgvListadoResp
            // 
            this.dgvListadoResp.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvListadoResp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoResp.Location = new System.Drawing.Point(33, 26);
            this.dgvListadoResp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvListadoResp.Name = "dgvListadoResp";
            this.dgvListadoResp.Size = new System.Drawing.Size(854, 348);
            this.dgvListadoResp.TabIndex = 0;
            this.dgvListadoResp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoResp_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.btnCancelar);
            this.tabPage2.Controls.Add(this.btnRegistrar);
            this.tabPage2.Controls.Add(this.btnNuevo);
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(966, 622);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Responsable";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbArea);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtNom);
            this.groupBox3.Controls.Add(this.txtApePat);
            this.groupBox3.Controls.Add(this.txtApeMat);
            this.groupBox3.Controls.Add(this.txtCargo);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtGrado);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Location = new System.Drawing.Point(40, 55);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(867, 449);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            // 
            // cmbArea
            // 
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(216, 268);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(265, 35);
            this.cmbArea.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 27);
            this.label2.TabIndex = 21;
            this.label2.Text = "Area";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 28);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(176, 29);
            this.label12.TabIndex = 4;
            this.label12.Text = "Nombre Completo:";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(216, 26);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(298, 35);
            this.txtNom.TabIndex = 0;
            // 
            // txtApePat
            // 
            this.txtApePat.Location = new System.Drawing.Point(216, 71);
            this.txtApePat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApePat.Name = "txtApePat";
            this.txtApePat.Size = new System.Drawing.Size(265, 35);
            this.txtApePat.TabIndex = 1;
            // 
            // txtApeMat
            // 
            this.txtApeMat.Location = new System.Drawing.Point(216, 115);
            this.txtApeMat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApeMat.Name = "txtApeMat";
            this.txtApeMat.Size = new System.Drawing.Size(265, 35);
            this.txtApeMat.TabIndex = 2;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(216, 163);
            this.txtCargo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(162, 35);
            this.txtCargo.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(36, 66);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(161, 29);
            this.label13.TabIndex = 5;
            this.label13.Text = "Apellido Parteno:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(32, 115);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(165, 29);
            this.label14.TabIndex = 6;
            this.label14.Text = "Apellido Materno:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(125, 163);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 29);
            this.label15.TabIndex = 7;
            this.label15.Text = "Cargo:";
            // 
            // txtGrado
            // 
            this.txtGrado.Location = new System.Drawing.Point(216, 211);
            this.txtGrado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.Size = new System.Drawing.Size(162, 35);
            this.txtGrado.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(16, 212);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(175, 29);
            this.label16.TabIndex = 17;
            this.label16.Text = "Grado Académico:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(250, 11);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(411, 40);
            this.label11.TabIndex = 3;
            this.label11.Text = "DATOS PERSONALES";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(678, 538);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(165, 54);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(389, 540);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(165, 54);
            this.btnRegistrar.TabIndex = 15;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(66, 540);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(0);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(165, 54);
            this.btnNuevo.TabIndex = 14;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(-6, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(15, 594);
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.pictureBox2.Location = new System.Drawing.Point(17, -7);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1006, 140);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // Frm_Responsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 896);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Frm_Responsable";
            this.Load += new System.EventHandler(this.Frm_Responsable_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoResp)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvListadoResp;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtApePat;
        private System.Windows.Forms.TextBox txtApeMat;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtGrado;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}