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
            this.menu_salir = new System.Windows.Forms.MenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Automatico = new System.Windows.Forms.TabPage();
            this.panel_auto_ganador = new System.Windows.Forms.Panel();
            this.ganados_jugador2 = new System.Windows.Forms.Label();
            this.ganados_jugador1 = new System.Windows.Forms.Label();
            this.ganador_automatico = new System.Windows.Forms.Label();
            this.panel_automatico = new System.Windows.Forms.Panel();
            this.txt_nombre_jugador2 = new System.Windows.Forms.TextBox();
            this.txt_nombre_jugador1 = new System.Windows.Forms.TextBox();
            this.lbl_nombre_jugador2 = new System.Windows.Forms.Label();
            this.lbl_nombre_jugador1 = new System.Windows.Forms.Label();
            this.lbl_automatico = new System.Windows.Forms.Label();
            this.btn_jugar_automatico = new System.Windows.Forms.Button();
            this.txt_automatico = new System.Windows.Forms.TextBox();
            this.Manual = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.Automatico.SuspendLayout();
            this.panel_auto_ganador.SuspendLayout();
            this.panel_automatico.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menu_salir});
            // 
            // menu_salir
            // 
            this.menu_salir.Index = 0;
            this.menu_salir.Text = "Salir";
            this.menu_salir.Click += new System.EventHandler(this.menu_salir_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Automatico);
            this.tabControl1.Controls.Add(this.Manual);
            this.tabControl1.Location = new System.Drawing.Point(-2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 451);
            this.tabControl1.TabIndex = 3;
            // 
            // Automatico
            // 
            this.Automatico.Controls.Add(this.panel_auto_ganador);
            this.Automatico.Controls.Add(this.panel_automatico);
            this.Automatico.Location = new System.Drawing.Point(4, 22);
            this.Automatico.Name = "Automatico";
            this.Automatico.Padding = new System.Windows.Forms.Padding(3);
            this.Automatico.Size = new System.Drawing.Size(792, 425);
            this.Automatico.TabIndex = 0;
            this.Automatico.Text = "Automatico";
            this.Automatico.UseVisualStyleBackColor = true;
            // 
            // panel_auto_ganador
            // 
            this.panel_auto_ganador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_auto_ganador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_auto_ganador.Controls.Add(this.ganados_jugador2);
            this.panel_auto_ganador.Controls.Add(this.ganados_jugador1);
            this.panel_auto_ganador.Controls.Add(this.ganador_automatico);
            this.panel_auto_ganador.Location = new System.Drawing.Point(133, 35);
            this.panel_auto_ganador.Name = "panel_auto_ganador";
            this.panel_auto_ganador.Size = new System.Drawing.Size(527, 144);
            this.panel_auto_ganador.TabIndex = 3;
            // 
            // ganados_jugador2
            // 
            this.ganados_jugador2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ganados_jugador2.Location = new System.Drawing.Point(282, 81);
            this.ganados_jugador2.Name = "ganados_jugador2";
            this.ganados_jugador2.Size = new System.Drawing.Size(240, 23);
            this.ganados_jugador2.TabIndex = 2;
            this.ganados_jugador2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ganados_jugador1
            // 
            this.ganados_jugador1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ganados_jugador1.Location = new System.Drawing.Point(3, 81);
            this.ganados_jugador1.Name = "ganados_jugador1";
            this.ganados_jugador1.Size = new System.Drawing.Size(276, 23);
            this.ganados_jugador1.TabIndex = 1;
            this.ganados_jugador1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ganador_automatico
            // 
            this.ganador_automatico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ganador_automatico.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.ganador_automatico.Location = new System.Drawing.Point(3, 16);
            this.ganador_automatico.Name = "ganador_automatico";
            this.ganador_automatico.Size = new System.Drawing.Size(519, 22);
            this.ganador_automatico.TabIndex = 0;
            this.ganador_automatico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_automatico
            // 
            this.panel_automatico.CausesValidation = false;
            this.panel_automatico.Controls.Add(this.txt_nombre_jugador2);
            this.panel_automatico.Controls.Add(this.txt_nombre_jugador1);
            this.panel_automatico.Controls.Add(this.lbl_nombre_jugador2);
            this.panel_automatico.Controls.Add(this.lbl_nombre_jugador1);
            this.panel_automatico.Controls.Add(this.lbl_automatico);
            this.panel_automatico.Controls.Add(this.btn_jugar_automatico);
            this.panel_automatico.Controls.Add(this.txt_automatico);
            this.panel_automatico.Location = new System.Drawing.Point(90, 223);
            this.panel_automatico.Name = "panel_automatico";
            this.panel_automatico.Size = new System.Drawing.Size(613, 166);
            this.panel_automatico.TabIndex = 2;
            // 
            // txt_nombre_jugador2
            // 
            this.txt_nombre_jugador2.Location = new System.Drawing.Point(143, 130);
            this.txt_nombre_jugador2.Name = "txt_nombre_jugador2";
            this.txt_nombre_jugador2.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre_jugador2.TabIndex = 10;
            // 
            // txt_nombre_jugador1
            // 
            this.txt_nombre_jugador1.Location = new System.Drawing.Point(143, 101);
            this.txt_nombre_jugador1.Name = "txt_nombre_jugador1";
            this.txt_nombre_jugador1.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre_jugador1.TabIndex = 9;
            // 
            // lbl_nombre_jugador2
            // 
            this.lbl_nombre_jugador2.AutoSize = true;
            this.lbl_nombre_jugador2.Location = new System.Drawing.Point(40, 133);
            this.lbl_nombre_jugador2.Name = "lbl_nombre_jugador2";
            this.lbl_nombre_jugador2.Size = new System.Drawing.Size(97, 13);
            this.lbl_nombre_jugador2.TabIndex = 8;
            this.lbl_nombre_jugador2.Text = "Nombre Jugador 2:";
            // 
            // lbl_nombre_jugador1
            // 
            this.lbl_nombre_jugador1.AutoSize = true;
            this.lbl_nombre_jugador1.Location = new System.Drawing.Point(40, 104);
            this.lbl_nombre_jugador1.Name = "lbl_nombre_jugador1";
            this.lbl_nombre_jugador1.Size = new System.Drawing.Size(97, 13);
            this.lbl_nombre_jugador1.TabIndex = 7;
            this.lbl_nombre_jugador1.Text = "Nombre Jugador 1:";
            // 
            // lbl_automatico
            // 
            this.lbl_automatico.AutoSize = true;
            this.lbl_automatico.Location = new System.Drawing.Point(40, 30);
            this.lbl_automatico.Name = "lbl_automatico";
            this.lbl_automatico.Size = new System.Drawing.Size(178, 13);
            this.lbl_automatico.TabIndex = 1;
            this.lbl_automatico.Text = "Ingrese la cantidad de simulaciones:";
            // 
            // btn_jugar_automatico
            // 
            this.btn_jugar_automatico.Location = new System.Drawing.Point(444, 71);
            this.btn_jugar_automatico.Name = "btn_jugar_automatico";
            this.btn_jugar_automatico.Size = new System.Drawing.Size(126, 28);
            this.btn_jugar_automatico.TabIndex = 6;
            this.btn_jugar_automatico.Text = "Jugar";
            this.btn_jugar_automatico.UseVisualStyleBackColor = true;
            this.btn_jugar_automatico.Click += new System.EventHandler(this.btn_jugar_automatico_Click);
            // 
            // txt_automatico
            // 
            this.txt_automatico.Location = new System.Drawing.Point(224, 27);
            this.txt_automatico.Name = "txt_automatico";
            this.txt_automatico.Size = new System.Drawing.Size(100, 20);
            this.txt_automatico.TabIndex = 4;
            // 
            // Manual
            // 
            this.Manual.Location = new System.Drawing.Point(4, 22);
            this.Manual.Name = "Manual";
            this.Manual.Padding = new System.Windows.Forms.Padding(3);
            this.Manual.Size = new System.Drawing.Size(792, 425);
            this.Manual.TabIndex = 1;
            this.Manual.Text = "Manual";
            this.Manual.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Automatico.ResumeLayout(false);
            this.panel_auto_ganador.ResumeLayout(false);
            this.panel_automatico.ResumeLayout(false);
            this.panel_automatico.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menu_salir;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Automatico;
        private System.Windows.Forms.Panel panel_auto_ganador;
        private System.Windows.Forms.Label ganados_jugador2;
        private System.Windows.Forms.Label ganados_jugador1;
        private System.Windows.Forms.Label ganador_automatico;
        private System.Windows.Forms.Panel panel_automatico;
        private System.Windows.Forms.TextBox txt_nombre_jugador2;
        private System.Windows.Forms.TextBox txt_nombre_jugador1;
        private System.Windows.Forms.Label lbl_nombre_jugador2;
        private System.Windows.Forms.Label lbl_nombre_jugador1;
        private System.Windows.Forms.Label lbl_automatico;
        private System.Windows.Forms.Button btn_jugar_automatico;
        private System.Windows.Forms.TextBox txt_automatico;
        private System.Windows.Forms.TabPage Manual;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

