
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.userControl11 = new WindowsFormsControlLibrary2.UserControl1();
            this.userControl12 = new WindowsFormsControlLibrary2.UserControl1();
            this.userControl13 = new WindowsFormsControlLibrary2.UserControl1();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.Maroon;
            this.userControl11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userControl11.Location = new System.Drawing.Point(12, 12);
            this.userControl11.Name = "userControl11";
            this.userControl11.PropiedadDeCarlos = "Hola!";
            this.userControl11.Size = new System.Drawing.Size(304, 316);
            this.userControl11.TabIndex = 0;
            // 
            // userControl12
            // 
            this.userControl12.BackColor = System.Drawing.Color.GreenYellow;
            this.userControl12.Location = new System.Drawing.Point(350, 12);
            this.userControl12.Name = "userControl12";
            this.userControl12.PropiedadDeCarlos = "¿Que tal?";
            this.userControl12.Size = new System.Drawing.Size(285, 316);
            this.userControl12.TabIndex = 1;
            // 
            // userControl13
            // 
            this.userControl13.BackColor = System.Drawing.Color.Magenta;
            this.userControl13.Location = new System.Drawing.Point(683, 12);
            this.userControl13.Name = "userControl13";
            this.userControl13.PropiedadDeCarlos = "Adios";
            this.userControl13.Size = new System.Drawing.Size(285, 316);
            this.userControl13.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 551);
            this.Controls.Add(this.userControl13);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.userControl11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsFormsControlLibrary2.UserControl1 userControl11;
        private WindowsFormsControlLibrary2.UserControl1 userControl12;
        private WindowsFormsControlLibrary2.UserControl1 userControl13;
    }
}

