namespace RenombraArchivos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlZonaArrastre = new Panel();
            lblArrastreCarpeta = new Label();
            lblDescripcion = new Label();
            lblEstado = new Label();
            pnlZonaArrastre.SuspendLayout();
            SuspendLayout();
            // 
            // pnlZonaArrastre
            // 
            pnlZonaArrastre.AllowDrop = true;
            pnlZonaArrastre.Controls.Add(lblArrastreCarpeta);
            pnlZonaArrastre.Location = new Point(49, 87);
            pnlZonaArrastre.Name = "pnlZonaArrastre";
            pnlZonaArrastre.Size = new Size(735, 322);
            pnlZonaArrastre.TabIndex = 2;
            pnlZonaArrastre.DragDrop += pnlZonaArrastre_DragDrop;
            pnlZonaArrastre.DragEnter += pnlZonaArrastre_DragEnter;
            // 
            // lblArrastreCarpeta
            // 
            lblArrastreCarpeta.AutoSize = true;
            lblArrastreCarpeta.Location = new Point(157, 148);
            lblArrastreCarpeta.Name = "lblArrastreCarpeta";
            lblArrastreCarpeta.Size = new Size(415, 20);
            lblArrastreCarpeta.TabIndex = 4;
            lblArrastreCarpeta.Text = "Arrastra la carpeta con los archivos dentro para renombrarlos";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(49, 21);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(489, 20);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Este programa renombra todos los archivos con el nombre de la carpeta";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(59, 470);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(0, 20);
            lblEstado.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 538);
            Controls.Add(lblEstado);
            Controls.Add(lblDescripcion);
            Controls.Add(pnlZonaArrastre);
            Name = "Form1";
            Text = "Renombra archivos";
            Load += Form1_Load;
            pnlZonaArrastre.ResumeLayout(false);
            pnlZonaArrastre.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlZonaArrastre;
        private Label lblDescripcion;
        private Label lblArrastreCarpeta;
        private Label lblEstado;
    }
}
