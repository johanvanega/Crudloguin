namespace CapaDePresentacion
{
    partial class FormPrincipal
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
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.panelDeFormularios = new System.Windows.Forms.Panel();
            this.tabControlMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageInicio = new System.Windows.Forms.TabPage();
            this.tabPagAdministacion = new System.Windows.Forms.TabPage();
            this.tabPageCitas = new System.Windows.Forms.TabPage();
            this.tabPageSeguridad = new System.Windows.Forms.TabPage();
            this.tabSelectorMenu = new MaterialSkin.Controls.MaterialTabSelector();
            this.iconInicio = new FontAwesome.Sharp.IconPictureBox();
            this.iconButtonSalir = new FontAwesome.Sharp.IconButton();
            this.iconAdministracion = new FontAwesome.Sharp.IconPictureBox();
            this.buttonClientes = new FontAwesome.Sharp.IconButton();
            this.buttonVeterinarios = new FontAwesome.Sharp.IconButton();
            this.buttonMascotas = new FontAwesome.Sharp.IconButton();
            this.iconCitas = new FontAwesome.Sharp.IconPictureBox();
            this.buttonAgendar = new FontAwesome.Sharp.IconButton();
            this.buttonConsultar = new FontAwesome.Sharp.IconButton();
            this.PanelPrincipal.SuspendLayout();
            this.panelMenuLateral.SuspendLayout();
            this.tabControlMenu.SuspendLayout();
            this.tabPageInicio.SuspendLayout();
            this.tabPagAdministacion.SuspendLayout();
            this.tabPageCitas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconAdministracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelPrincipal.Controls.Add(this.panelDeFormularios);
            this.PanelPrincipal.Controls.Add(this.panelMenuLateral);
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 63);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(800, 527);
            this.PanelPrincipal.TabIndex = 0;
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelMenuLateral.Controls.Add(this.tabControlMenu);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(200, 527);
            this.panelMenuLateral.TabIndex = 0;
            // 
            // panelDeFormularios
            // 
            this.panelDeFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDeFormularios.Location = new System.Drawing.Point(200, 0);
            this.panelDeFormularios.Name = "panelDeFormularios";
            this.panelDeFormularios.Size = new System.Drawing.Size(600, 527);
            this.panelDeFormularios.TabIndex = 1;
            // 
            // tabControlMenu
            // 
            this.tabControlMenu.Controls.Add(this.tabPageInicio);
            this.tabControlMenu.Controls.Add(this.tabPagAdministacion);
            this.tabControlMenu.Controls.Add(this.tabPageCitas);
            this.tabControlMenu.Controls.Add(this.tabPageSeguridad);
            this.tabControlMenu.Depth = 0;
            this.tabControlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMenu.Location = new System.Drawing.Point(0, 0);
            this.tabControlMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControlMenu.Name = "tabControlMenu";
            this.tabControlMenu.SelectedIndex = 0;
            this.tabControlMenu.Size = new System.Drawing.Size(200, 527);
            this.tabControlMenu.TabIndex = 0;
            // 
            // tabPageInicio
            // 
            this.tabPageInicio.BackColor = System.Drawing.SystemColors.Highlight;
            this.tabPageInicio.Controls.Add(this.iconButtonSalir);
            this.tabPageInicio.Controls.Add(this.iconInicio);
            this.tabPageInicio.Location = new System.Drawing.Point(4, 25);
            this.tabPageInicio.Name = "tabPageInicio";
            this.tabPageInicio.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInicio.Size = new System.Drawing.Size(192, 498);
            this.tabPageInicio.TabIndex = 0;
            this.tabPageInicio.Text = "INICIO";
            // 
            // tabPagAdministacion
            // 
            this.tabPagAdministacion.BackColor = System.Drawing.SystemColors.Highlight;
            this.tabPagAdministacion.Controls.Add(this.buttonMascotas);
            this.tabPagAdministacion.Controls.Add(this.buttonVeterinarios);
            this.tabPagAdministacion.Controls.Add(this.buttonClientes);
            this.tabPagAdministacion.Controls.Add(this.iconAdministracion);
            this.tabPagAdministacion.Location = new System.Drawing.Point(4, 25);
            this.tabPagAdministacion.Name = "tabPagAdministacion";
            this.tabPagAdministacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagAdministacion.Size = new System.Drawing.Size(192, 498);
            this.tabPagAdministacion.TabIndex = 1;
            this.tabPagAdministacion.Text = "ADMINISTRACIÓN";
            // 
            // tabPageCitas
            // 
            this.tabPageCitas.BackColor = System.Drawing.SystemColors.Highlight;
            this.tabPageCitas.Controls.Add(this.buttonConsultar);
            this.tabPageCitas.Controls.Add(this.buttonAgendar);
            this.tabPageCitas.Controls.Add(this.iconCitas);
            this.tabPageCitas.Location = new System.Drawing.Point(4, 25);
            this.tabPageCitas.Name = "tabPageCitas";
            this.tabPageCitas.Size = new System.Drawing.Size(192, 498);
            this.tabPageCitas.TabIndex = 2;
            this.tabPageCitas.Text = "CITAS";
            // 
            // tabPageSeguridad
            // 
            this.tabPageSeguridad.BackColor = System.Drawing.SystemColors.Highlight;
            this.tabPageSeguridad.Location = new System.Drawing.Point(4, 25);
            this.tabPageSeguridad.Name = "tabPageSeguridad";
            this.tabPageSeguridad.Size = new System.Drawing.Size(192, 498);
            this.tabPageSeguridad.TabIndex = 3;
            this.tabPageSeguridad.Text = "SEGURIDAD";
            // 
            // tabSelectorMenu
            // 
            this.tabSelectorMenu.BaseTabControl = this.tabControlMenu;
            this.tabSelectorMenu.Depth = 0;
            this.tabSelectorMenu.Location = new System.Drawing.Point(200, 34);
            this.tabSelectorMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelectorMenu.Name = "tabSelectorMenu";
            this.tabSelectorMenu.Size = new System.Drawing.Size(588, 23);
            this.tabSelectorMenu.TabIndex = 1;
            // 
            // iconInicio
            // 
            this.iconInicio.BackColor = System.Drawing.SystemColors.Highlight;
            this.iconInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconInicio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconInicio.IconChar = FontAwesome.Sharp.IconChar.Paw;
            this.iconInicio.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconInicio.IconSize = 136;
            this.iconInicio.Location = new System.Drawing.Point(3, 3);
            this.iconInicio.Name = "iconInicio";
            this.iconInicio.Size = new System.Drawing.Size(186, 136);
            this.iconInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconInicio.TabIndex = 0;
            this.iconInicio.TabStop = false;
            // 
            // iconButtonSalir
            // 
            this.iconButtonSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButtonSalir.FlatAppearance.BorderSize = 0;
            this.iconButtonSalir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.iconButtonSalir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.iconButtonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSalir.ForeColor = System.Drawing.Color.White;
            this.iconButtonSalir.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.iconButtonSalir.IconColor = System.Drawing.Color.White;
            this.iconButtonSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSalir.Location = new System.Drawing.Point(3, 450);
            this.iconButtonSalir.Name = "iconButtonSalir";
            this.iconButtonSalir.Size = new System.Drawing.Size(186, 45);
            this.iconButtonSalir.TabIndex = 1;
            this.iconButtonSalir.Text = "SALIR";
            this.iconButtonSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSalir.UseVisualStyleBackColor = true;
            this.iconButtonSalir.Click += new System.EventHandler(this.iconButtonSalir_Click);
            // 
            // iconAdministracion
            // 
            this.iconAdministracion.BackColor = System.Drawing.SystemColors.Highlight;
            this.iconAdministracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconAdministracion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconAdministracion.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.iconAdministracion.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconAdministracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAdministracion.IconSize = 136;
            this.iconAdministracion.Location = new System.Drawing.Point(3, 3);
            this.iconAdministracion.Name = "iconAdministracion";
            this.iconAdministracion.Size = new System.Drawing.Size(186, 136);
            this.iconAdministracion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconAdministracion.TabIndex = 0;
            this.iconAdministracion.TabStop = false;
            // 
            // buttonClientes
            // 
            this.buttonClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonClientes.FlatAppearance.BorderSize = 0;
            this.buttonClientes.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonClientes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClientes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClientes.ForeColor = System.Drawing.Color.White;
            this.buttonClientes.IconChar = FontAwesome.Sharp.IconChar.Pager;
            this.buttonClientes.IconColor = System.Drawing.Color.White;
            this.buttonClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonClientes.Location = new System.Drawing.Point(3, 139);
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.Size = new System.Drawing.Size(186, 72);
            this.buttonClientes.TabIndex = 1;
            this.buttonClientes.Text = "Clientes";
            this.buttonClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonClientes.UseVisualStyleBackColor = true;
            this.buttonClientes.Click += new System.EventHandler(this.buttonClientes_Click);
            // 
            // buttonVeterinarios
            // 
            this.buttonVeterinarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVeterinarios.FlatAppearance.BorderSize = 0;
            this.buttonVeterinarios.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonVeterinarios.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonVeterinarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVeterinarios.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVeterinarios.ForeColor = System.Drawing.Color.White;
            this.buttonVeterinarios.IconChar = FontAwesome.Sharp.IconChar.Microscope;
            this.buttonVeterinarios.IconColor = System.Drawing.Color.White;
            this.buttonVeterinarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonVeterinarios.Location = new System.Drawing.Point(3, 211);
            this.buttonVeterinarios.Name = "buttonVeterinarios";
            this.buttonVeterinarios.Size = new System.Drawing.Size(186, 72);
            this.buttonVeterinarios.TabIndex = 2;
            this.buttonVeterinarios.Text = "Veterinarios";
            this.buttonVeterinarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonVeterinarios.UseVisualStyleBackColor = true;
            // 
            // buttonMascotas
            // 
            this.buttonMascotas.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMascotas.FlatAppearance.BorderSize = 0;
            this.buttonMascotas.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonMascotas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonMascotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMascotas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMascotas.ForeColor = System.Drawing.Color.White;
            this.buttonMascotas.IconChar = FontAwesome.Sharp.IconChar.Cat;
            this.buttonMascotas.IconColor = System.Drawing.Color.White;
            this.buttonMascotas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonMascotas.Location = new System.Drawing.Point(3, 283);
            this.buttonMascotas.Name = "buttonMascotas";
            this.buttonMascotas.Size = new System.Drawing.Size(186, 72);
            this.buttonMascotas.TabIndex = 3;
            this.buttonMascotas.Text = "Mascotas";
            this.buttonMascotas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMascotas.UseVisualStyleBackColor = true;
            // 
            // iconCitas
            // 
            this.iconCitas.BackColor = System.Drawing.SystemColors.Highlight;
            this.iconCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconCitas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconCitas.IconChar = FontAwesome.Sharp.IconChar.PhoneSquare;
            this.iconCitas.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconCitas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCitas.IconSize = 136;
            this.iconCitas.Location = new System.Drawing.Point(0, 0);
            this.iconCitas.Name = "iconCitas";
            this.iconCitas.Size = new System.Drawing.Size(192, 136);
            this.iconCitas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconCitas.TabIndex = 0;
            this.iconCitas.TabStop = false;
            // 
            // buttonAgendar
            // 
            this.buttonAgendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAgendar.FlatAppearance.BorderSize = 0;
            this.buttonAgendar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAgendar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgendar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgendar.ForeColor = System.Drawing.Color.White;
            this.buttonAgendar.IconChar = FontAwesome.Sharp.IconChar.PeopleArrows;
            this.buttonAgendar.IconColor = System.Drawing.Color.White;
            this.buttonAgendar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonAgendar.Location = new System.Drawing.Point(0, 136);
            this.buttonAgendar.Name = "buttonAgendar";
            this.buttonAgendar.Size = new System.Drawing.Size(192, 72);
            this.buttonAgendar.TabIndex = 2;
            this.buttonAgendar.Text = "Agendar citas";
            this.buttonAgendar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAgendar.UseVisualStyleBackColor = true;
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonConsultar.FlatAppearance.BorderSize = 0;
            this.buttonConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConsultar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultar.ForeColor = System.Drawing.Color.White;
            this.buttonConsultar.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.buttonConsultar.IconColor = System.Drawing.Color.White;
            this.buttonConsultar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonConsultar.Location = new System.Drawing.Point(0, 208);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(192, 72);
            this.buttonConsultar.TabIndex = 3;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonConsultar.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 591);
            this.Controls.Add(this.tabSelectorMenu);
            this.Controls.Add(this.PanelPrincipal);
            this.Name = "FormPrincipal";
            this.Text = "MENU PRINCIPAL";
            this.PanelPrincipal.ResumeLayout(false);
            this.panelMenuLateral.ResumeLayout(false);
            this.tabControlMenu.ResumeLayout(false);
            this.tabPageInicio.ResumeLayout(false);
            this.tabPagAdministacion.ResumeLayout(false);
            this.tabPageCitas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconAdministracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Panel panelDeFormularios;
        private System.Windows.Forms.Panel panelMenuLateral;
        private MaterialSkin.Controls.MaterialTabControl tabControlMenu;
        private System.Windows.Forms.TabPage tabPageInicio;
        private System.Windows.Forms.TabPage tabPagAdministacion;
        private System.Windows.Forms.TabPage tabPageCitas;
        private System.Windows.Forms.TabPage tabPageSeguridad;
        private MaterialSkin.Controls.MaterialTabSelector tabSelectorMenu;
        private FontAwesome.Sharp.IconButton iconButtonSalir;
        private FontAwesome.Sharp.IconPictureBox iconInicio;
        private FontAwesome.Sharp.IconButton buttonMascotas;
        private FontAwesome.Sharp.IconButton buttonVeterinarios;
        private FontAwesome.Sharp.IconButton buttonClientes;
        private FontAwesome.Sharp.IconPictureBox iconAdministracion;
        private FontAwesome.Sharp.IconButton buttonConsultar;
        private FontAwesome.Sharp.IconButton buttonAgendar;
        private FontAwesome.Sharp.IconPictureBox iconCitas;
    }
}