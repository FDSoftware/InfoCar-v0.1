namespace InfoCar
{
    partial class controlStartUp
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startInfocar = new System.Windows.Forms.Button();
            this.loadCar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.patentBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.textM = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(344, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // startInfocar
            // 
            this.startInfocar.Location = new System.Drawing.Point(63, 82);
            this.startInfocar.Name = "startInfocar";
            this.startInfocar.Size = new System.Drawing.Size(100, 60);
            this.startInfocar.TabIndex = 1;
            this.startInfocar.Text = "Nuevo vehículo";
            this.startInfocar.UseVisualStyleBackColor = true;
            this.startInfocar.Click += new System.EventHandler(this.newCar_Click);
            // 
            // loadCar
            // 
            this.loadCar.Location = new System.Drawing.Point(169, 82);
            this.loadCar.Name = "loadCar";
            this.loadCar.Size = new System.Drawing.Size(100, 60);
            this.loadCar.TabIndex = 2;
            this.loadCar.Text = "Buscar vehículo";
            this.loadCar.UseVisualStyleBackColor = true;
            this.loadCar.Click += new System.EventHandler(this.loadCar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bienvenido";
            // 
            // patentBox
            // 
            this.patentBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.patentBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.patentBox.Location = new System.Drawing.Point(63, 82);
            this.patentBox.MaxLength = 10;
            this.patentBox.Name = "patentBox";
            this.patentBox.Size = new System.Drawing.Size(206, 20);
            this.patentBox.TabIndex = 4;
            this.patentBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.patentBox.Visible = false;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(63, 108);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(100, 23);
            this.searchBtn.TabIndex = 5;
            this.searchBtn.Text = "Buscar";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Visible = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(169, 108);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 23);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancelar";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Visible = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // textM
            // 
            this.textM.AutoSize = true;
            this.textM.Location = new System.Drawing.Point(139, 66);
            this.textM.Name = "textM";
            this.textM.Size = new System.Drawing.Size(50, 13);
            this.textM.TabIndex = 7;
            this.textM.Text = "Matricula";
            this.textM.Visible = false;
            // 
            // controlStartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 202);
            this.Controls.Add(this.textM);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.patentBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadCar);
            this.Controls.Add(this.startInfocar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "controlStartUp";
            this.ShowIcon = false;
            this.Text = "InfoCar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.controlStartUp_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button startInfocar;
        private System.Windows.Forms.Button loadCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox patentBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label textM;


    }
}

