namespace WindowsFormsApp1
{
    partial class Form1
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
            this.mostrar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // mostrar
            // 
            this.mostrar.FormattingEnabled = true;
            this.mostrar.Location = new System.Drawing.Point(40, 26);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(283, 329);
            this.mostrar.TabIndex = 0;
            this.mostrar.SelectedIndexChanged += new System.EventHandler(this.mostrar_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 384);
            this.Controls.Add(this.mostrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.mostrar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox mostrar;
    }
}