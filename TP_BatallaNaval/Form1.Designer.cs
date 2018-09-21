namespace TP_BatallaNaval
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
            this.components = new System.ComponentModel.Container();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menu_partida = new System.Windows.Forms.MenuItem();
            this.menu_automatico = new System.Windows.Forms.MenuItem();
            this.menu_manual = new System.Windows.Forms.MenuItem();
            this.menu_salir = new System.Windows.Forms.MenuItem();
            this.panel_tablero = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_tablero.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menu_partida,
            this.menu_salir});
            // 
            // menu_partida
            // 
            this.menu_partida.Index = 0;
            this.menu_partida.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menu_automatico,
            this.menu_manual});
            this.menu_partida.Text = "Nueva Partida";
            // 
            // menu_automatico
            // 
            this.menu_automatico.Index = 0;
            this.menu_automatico.Text = "Modo Automatico";
            this.menu_automatico.Click += new System.EventHandler(this.menu_automatico_Click);
            // 
            // menu_manual
            // 
            this.menu_manual.Index = 1;
            this.menu_manual.Text = "Modo Manual";
            // 
            // menu_salir
            // 
            this.menu_salir.Index = 1;
            this.menu_salir.Text = "Salir";
            this.menu_salir.Click += new System.EventHandler(this.menu_salir_Click);
            // 
            // panel_tablero
            // 
            this.panel_tablero.CausesValidation = false;
            this.panel_tablero.Controls.Add(this.label1);
            this.panel_tablero.Location = new System.Drawing.Point(97, 209);
            this.panel_tablero.Name = "panel_tablero";
            this.panel_tablero.Size = new System.Drawing.Size(613, 131);
            this.panel_tablero.TabIndex = 0;
            this.panel_tablero.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(419, 243);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese la cantidad de partidas: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Jugar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel_tablero);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_tablero.ResumeLayout(false);
            this.panel_tablero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menu_partida;
        private System.Windows.Forms.MenuItem menu_automatico;
        private System.Windows.Forms.MenuItem menu_manual;
        private System.Windows.Forms.MenuItem menu_salir;
        private System.Windows.Forms.Panel panel_tablero;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

