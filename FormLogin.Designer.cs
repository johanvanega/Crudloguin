namespace CapaDePresentacion
{
    partial class FormLogin
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
            this.panelLogin = new System.Windows.Forms.Panel();
            this.iconLogin = new FontAwesome.Sharp.IconPictureBox();
            this.iconCerrar = new FontAwesome.Sharp.IconPictureBox();
            this.labelTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxContraseña = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnIngresar = new MaterialSkin.Controls.MaterialFlatButton();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelLogin.Controls.Add(this.iconLogin);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(200, 300);
            this.panelLogin.TabIndex = 0;
            // 
            // iconLogin
            // 
            this.iconLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.iconLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconLogin.IconChar = FontAwesome.Sharp.IconChar.UserNinja;
            this.iconLogin.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconLogin.IconSize = 200;
            this.iconLogin.Location = new System.Drawing.Point(0, 0);
            this.iconLogin.Name = "iconLogin";
            this.iconLogin.Size = new System.Drawing.Size(200, 300);
            this.iconLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconLogin.TabIndex = 0;
            this.iconLogin.TabStop = false;
            this.iconLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.iconLogin_MouseDown);
            // 
            // iconCerrar
            // 
            this.iconCerrar.BackColor = System.Drawing.Color.Silver;
            this.iconCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconCerrar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconCerrar.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCerrar.Location = new System.Drawing.Point(568, 0);
            this.iconCerrar.Name = "iconCerrar";
            this.iconCerrar.Size = new System.Drawing.Size(32, 32);
            this.iconCerrar.TabIndex = 1;
            this.iconCerrar.TabStop = false;
            this.iconCerrar.Click += new System.EventHandler(this.iconCerrar_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Depth = 0;
            this.labelTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTitulo.Location = new System.Drawing.Point(307, 9);
            this.labelTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(162, 24);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "INICIO DE SESIÓN";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Depth = 0;
            this.textBoxUsuario.Hint = "Usuario";
            this.textBoxUsuario.Location = new System.Drawing.Point(262, 73);
            this.textBoxUsuario.MaxLength = 32767;
            this.textBoxUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.PasswordChar = '\0';
            this.textBoxUsuario.SelectedText = "";
            this.textBoxUsuario.SelectionLength = 0;
            this.textBoxUsuario.SelectionStart = 0;
            this.textBoxUsuario.Size = new System.Drawing.Size(277, 28);
            this.textBoxUsuario.TabIndex = 3;
            this.textBoxUsuario.TabStop = false;
            this.textBoxUsuario.UseSystemPasswordChar = false;
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Depth = 0;
            this.textBoxContraseña.Hint = "Contraseña";
            this.textBoxContraseña.Location = new System.Drawing.Point(262, 146);
            this.textBoxContraseña.MaxLength = 32767;
            this.textBoxContraseña.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.PasswordChar = '*';
            this.textBoxContraseña.SelectedText = "";
            this.textBoxContraseña.SelectionLength = 0;
            this.textBoxContraseña.SelectionStart = 0;
            this.textBoxContraseña.Size = new System.Drawing.Size(277, 28);
            this.textBoxContraseña.TabIndex = 4;
            this.textBoxContraseña.TabStop = false;
            this.textBoxContraseña.UseSystemPasswordChar = false;
            // 
            // btnIngresar
            // 
            this.btnIngresar.AutoSize = true;
            this.btnIngresar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnIngresar.Depth = 0;
            this.btnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Icon = null;
            this.btnIngresar.Location = new System.Drawing.Point(322, 232);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIngresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Primary = false;
            this.btnIngresar.Size = new System.Drawing.Size(130, 36);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.iconCerrar);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseDown);
            this.panelLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private FontAwesome.Sharp.IconPictureBox iconLogin;
        private FontAwesome.Sharp.IconPictureBox iconCerrar;
        private MaterialSkin.Controls.MaterialLabel labelTitulo;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxContraseña;
        private MaterialSkin.Controls.MaterialFlatButton btnIngresar;
    }
}