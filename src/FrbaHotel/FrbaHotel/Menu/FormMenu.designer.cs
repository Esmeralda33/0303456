﻿namespace FrbaHotel.Menu
{
    partial class FormMenu
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
            this.btnListaHoteles = new System.Windows.Forms.Button();
            this.btnNuevoHotel = new System.Windows.Forms.Button();
            this.btnNuevaHabitacion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gestorDeRolesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListaHoteles
            // 
            this.btnListaHoteles.Location = new System.Drawing.Point(83, 34);
            this.btnListaHoteles.Name = "btnListaHoteles";
            this.btnListaHoteles.Size = new System.Drawing.Size(109, 23);
            this.btnListaHoteles.TabIndex = 0;
            this.btnListaHoteles.Text = "Listado de Hoteles";
            this.btnListaHoteles.UseVisualStyleBackColor = true;
            this.btnListaHoteles.Click += new System.EventHandler(this.btnListaHoteles_Click);
            // 
            // btnNuevoHotel
            // 
            this.btnNuevoHotel.Location = new System.Drawing.Point(83, 63);
            this.btnNuevoHotel.Name = "btnNuevoHotel";
            this.btnNuevoHotel.Size = new System.Drawing.Size(109, 23);
            this.btnNuevoHotel.TabIndex = 1;
            this.btnNuevoHotel.Text = "Nuevo Hotel";
            this.btnNuevoHotel.UseVisualStyleBackColor = true;
            this.btnNuevoHotel.Click += new System.EventHandler(this.btnNuevoHotel_Click);
            // 
            // btnNuevaHabitacion
            // 
            this.btnNuevaHabitacion.Location = new System.Drawing.Point(83, 92);
            this.btnNuevaHabitacion.Name = "btnNuevaHabitacion";
            this.btnNuevaHabitacion.Size = new System.Drawing.Size(109, 23);
            this.btnNuevaHabitacion.TabIndex = 2;
            this.btnNuevaHabitacion.Text = "Nueva Habitacion";
            this.btnNuevaHabitacion.UseVisualStyleBackColor = true;
            this.btnNuevaHabitacion.Click += new System.EventHandler(this.btnNuevaHabitacion_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Listado Habitacion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gestorDeRolesBtn
            // 
            this.gestorDeRolesBtn.Location = new System.Drawing.Point(83, 150);
            this.gestorDeRolesBtn.Name = "gestorDeRolesBtn";
            this.gestorDeRolesBtn.Size = new System.Drawing.Size(109, 27);
            this.gestorDeRolesBtn.TabIndex = 4;
            this.gestorDeRolesBtn.Text = "Gestor de Roles";
            this.gestorDeRolesBtn.UseVisualStyleBackColor = true;
            this.gestorDeRolesBtn.Click += new System.EventHandler(this.gestorDeRolesBtn_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.gestorDeRolesBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNuevaHabitacion);
            this.Controls.Add(this.btnNuevoHotel);
            this.Controls.Add(this.btnListaHoteles);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListaHoteles;
        private System.Windows.Forms.Button btnNuevoHotel;
        private System.Windows.Forms.Button btnNuevaHabitacion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button gestorDeRolesBtn;
    }
}