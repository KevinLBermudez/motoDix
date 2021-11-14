
namespace final_motoDix.Vistas
{
    partial class frmSolicitudViajes
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSolicitudViajes));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.bfdgvSolicitudes = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bftxtPuntoLlegada = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bftxtPuntoInicio = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lnlLlegada = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.bftxtCliente = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bfbtnAceptar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.contadorSolicitud = new System.Windows.Forms.Timer(this.components);
            this.bfSnackbarSolicitud = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bfdgvSolicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(297, 59);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(205, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "SOLICITUDES DE VIAJES";
            // 
            // bfdgvSolicitudes
            // 
            this.bfdgvSolicitudes.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bfdgvSolicitudes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bfdgvSolicitudes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.bfdgvSolicitudes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bfdgvSolicitudes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bfdgvSolicitudes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bfdgvSolicitudes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bfdgvSolicitudes.ColumnHeadersHeight = 40;
            this.bfdgvSolicitudes.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.bfdgvSolicitudes.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bfdgvSolicitudes.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bfdgvSolicitudes.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bfdgvSolicitudes.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bfdgvSolicitudes.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.bfdgvSolicitudes.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bfdgvSolicitudes.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.bfdgvSolicitudes.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bfdgvSolicitudes.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bfdgvSolicitudes.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.bfdgvSolicitudes.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bfdgvSolicitudes.CurrentTheme.Name = null;
            this.bfdgvSolicitudes.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.bfdgvSolicitudes.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bfdgvSolicitudes.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bfdgvSolicitudes.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bfdgvSolicitudes.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bfdgvSolicitudes.DefaultCellStyle = dataGridViewCellStyle3;
            this.bfdgvSolicitudes.EnableHeadersVisualStyles = false;
            this.bfdgvSolicitudes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bfdgvSolicitudes.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bfdgvSolicitudes.HeaderBgColor = System.Drawing.Color.Empty;
            this.bfdgvSolicitudes.HeaderForeColor = System.Drawing.Color.White;
            this.bfdgvSolicitudes.Location = new System.Drawing.Point(12, 93);
            this.bfdgvSolicitudes.Name = "bfdgvSolicitudes";
            this.bfdgvSolicitudes.RowHeadersVisible = false;
            this.bfdgvSolicitudes.RowTemplate.Height = 40;
            this.bfdgvSolicitudes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bfdgvSolicitudes.Size = new System.Drawing.Size(804, 204);
            this.bfdgvSolicitudes.TabIndex = 1;
            this.bfdgvSolicitudes.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.bfdgvSolicitudes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bfdgvSolicitudes_CellClick);
            // 
            // bftxtPuntoLlegada
            // 
            this.bftxtPuntoLlegada.AcceptsReturn = false;
            this.bftxtPuntoLlegada.AcceptsTab = false;
            this.bftxtPuntoLlegada.AnimationSpeed = 200;
            this.bftxtPuntoLlegada.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bftxtPuntoLlegada.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bftxtPuntoLlegada.AutoSizeHeight = true;
            this.bftxtPuntoLlegada.BackColor = System.Drawing.Color.Transparent;
            this.bftxtPuntoLlegada.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bftxtPuntoLlegada.BackgroundImage")));
            this.bftxtPuntoLlegada.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.bftxtPuntoLlegada.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bftxtPuntoLlegada.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bftxtPuntoLlegada.BorderColorIdle = System.Drawing.Color.Silver;
            this.bftxtPuntoLlegada.BorderRadius = 1;
            this.bftxtPuntoLlegada.BorderThickness = 1;
            this.bftxtPuntoLlegada.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bftxtPuntoLlegada.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bftxtPuntoLlegada.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.bftxtPuntoLlegada.DefaultText = "";
            this.bftxtPuntoLlegada.FillColor = System.Drawing.Color.White;
            this.bftxtPuntoLlegada.HideSelection = true;
            this.bftxtPuntoLlegada.IconLeft = null;
            this.bftxtPuntoLlegada.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.bftxtPuntoLlegada.IconPadding = 10;
            this.bftxtPuntoLlegada.IconRight = null;
            this.bftxtPuntoLlegada.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.bftxtPuntoLlegada.Lines = new string[0];
            this.bftxtPuntoLlegada.Location = new System.Drawing.Point(354, 404);
            this.bftxtPuntoLlegada.MaxLength = 32767;
            this.bftxtPuntoLlegada.MinimumSize = new System.Drawing.Size(1, 1);
            this.bftxtPuntoLlegada.Modified = false;
            this.bftxtPuntoLlegada.Multiline = false;
            this.bftxtPuntoLlegada.Name = "bftxtPuntoLlegada";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bftxtPuntoLlegada.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.bftxtPuntoLlegada.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bftxtPuntoLlegada.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bftxtPuntoLlegada.OnIdleState = stateProperties4;
            this.bftxtPuntoLlegada.Padding = new System.Windows.Forms.Padding(3);
            this.bftxtPuntoLlegada.PasswordChar = '\0';
            this.bftxtPuntoLlegada.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.bftxtPuntoLlegada.PlaceholderText = "Enter text";
            this.bftxtPuntoLlegada.ReadOnly = false;
            this.bftxtPuntoLlegada.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bftxtPuntoLlegada.SelectedText = "";
            this.bftxtPuntoLlegada.SelectionLength = 0;
            this.bftxtPuntoLlegada.SelectionStart = 0;
            this.bftxtPuntoLlegada.ShortcutsEnabled = true;
            this.bftxtPuntoLlegada.Size = new System.Drawing.Size(166, 33);
            this.bftxtPuntoLlegada.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.bftxtPuntoLlegada.TabIndex = 28;
            this.bftxtPuntoLlegada.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bftxtPuntoLlegada.TextMarginBottom = 0;
            this.bftxtPuntoLlegada.TextMarginLeft = 3;
            this.bftxtPuntoLlegada.TextMarginTop = 1;
            this.bftxtPuntoLlegada.TextPlaceholder = "Enter text";
            this.bftxtPuntoLlegada.UseSystemPasswordChar = false;
            this.bftxtPuntoLlegada.WordWrap = true;
            // 
            // bftxtPuntoInicio
            // 
            this.bftxtPuntoInicio.AcceptsReturn = false;
            this.bftxtPuntoInicio.AcceptsTab = false;
            this.bftxtPuntoInicio.AnimationSpeed = 200;
            this.bftxtPuntoInicio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bftxtPuntoInicio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bftxtPuntoInicio.AutoSizeHeight = true;
            this.bftxtPuntoInicio.BackColor = System.Drawing.Color.White;
            this.bftxtPuntoInicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bftxtPuntoInicio.BackgroundImage")));
            this.bftxtPuntoInicio.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.bftxtPuntoInicio.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bftxtPuntoInicio.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bftxtPuntoInicio.BorderColorIdle = System.Drawing.Color.Silver;
            this.bftxtPuntoInicio.BorderRadius = 1;
            this.bftxtPuntoInicio.BorderThickness = 1;
            this.bftxtPuntoInicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bftxtPuntoInicio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bftxtPuntoInicio.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.bftxtPuntoInicio.DefaultText = "";
            this.bftxtPuntoInicio.FillColor = System.Drawing.Color.White;
            this.bftxtPuntoInicio.HideSelection = true;
            this.bftxtPuntoInicio.IconLeft = null;
            this.bftxtPuntoInicio.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.bftxtPuntoInicio.IconPadding = 10;
            this.bftxtPuntoInicio.IconRight = null;
            this.bftxtPuntoInicio.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.bftxtPuntoInicio.Lines = new string[0];
            this.bftxtPuntoInicio.Location = new System.Drawing.Point(94, 404);
            this.bftxtPuntoInicio.MaxLength = 32767;
            this.bftxtPuntoInicio.MinimumSize = new System.Drawing.Size(1, 1);
            this.bftxtPuntoInicio.Modified = false;
            this.bftxtPuntoInicio.Multiline = false;
            this.bftxtPuntoInicio.Name = "bftxtPuntoInicio";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bftxtPuntoInicio.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.bftxtPuntoInicio.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bftxtPuntoInicio.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bftxtPuntoInicio.OnIdleState = stateProperties8;
            this.bftxtPuntoInicio.Padding = new System.Windows.Forms.Padding(3);
            this.bftxtPuntoInicio.PasswordChar = '\0';
            this.bftxtPuntoInicio.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.bftxtPuntoInicio.PlaceholderText = "Enter text";
            this.bftxtPuntoInicio.ReadOnly = false;
            this.bftxtPuntoInicio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bftxtPuntoInicio.SelectedText = "";
            this.bftxtPuntoInicio.SelectionLength = 0;
            this.bftxtPuntoInicio.SelectionStart = 0;
            this.bftxtPuntoInicio.ShortcutsEnabled = true;
            this.bftxtPuntoInicio.Size = new System.Drawing.Size(166, 33);
            this.bftxtPuntoInicio.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.bftxtPuntoInicio.TabIndex = 27;
            this.bftxtPuntoInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bftxtPuntoInicio.TextMarginBottom = 0;
            this.bftxtPuntoInicio.TextMarginLeft = 3;
            this.bftxtPuntoInicio.TextMarginTop = 1;
            this.bftxtPuntoInicio.TextPlaceholder = "Enter text";
            this.bftxtPuntoInicio.UseSystemPasswordChar = false;
            this.bftxtPuntoInicio.WordWrap = true;
            // 
            // lnlLlegada
            // 
            this.lnlLlegada.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lnlLlegada.AutoSize = true;
            this.lnlLlegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlLlegada.Location = new System.Drawing.Point(355, 365);
            this.lnlLlegada.Name = "lnlLlegada";
            this.lnlLlegada.Size = new System.Drawing.Size(128, 20);
            this.lnlLlegada.TabIndex = 26;
            this.lnlLlegada.Text = "Punto de llegada";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(90, 365);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(112, 20);
            this.lblInicio.TabIndex = 25;
            this.lblInicio.Text = "Punto de inicio";
            // 
            // bftxtCliente
            // 
            this.bftxtCliente.AcceptsReturn = false;
            this.bftxtCliente.AcceptsTab = false;
            this.bftxtCliente.AnimationSpeed = 200;
            this.bftxtCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bftxtCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bftxtCliente.AutoSizeHeight = true;
            this.bftxtCliente.BackColor = System.Drawing.Color.White;
            this.bftxtCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bftxtCliente.BackgroundImage")));
            this.bftxtCliente.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.bftxtCliente.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bftxtCliente.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bftxtCliente.BorderColorIdle = System.Drawing.Color.Silver;
            this.bftxtCliente.BorderRadius = 1;
            this.bftxtCliente.BorderThickness = 1;
            this.bftxtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bftxtCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bftxtCliente.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.bftxtCliente.DefaultText = "";
            this.bftxtCliente.FillColor = System.Drawing.Color.White;
            this.bftxtCliente.HideSelection = true;
            this.bftxtCliente.IconLeft = null;
            this.bftxtCliente.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.bftxtCliente.IconPadding = 10;
            this.bftxtCliente.IconRight = null;
            this.bftxtCliente.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.bftxtCliente.Lines = new string[0];
            this.bftxtCliente.Location = new System.Drawing.Point(94, 496);
            this.bftxtCliente.MaxLength = 32767;
            this.bftxtCliente.MinimumSize = new System.Drawing.Size(1, 1);
            this.bftxtCliente.Modified = false;
            this.bftxtCliente.Multiline = false;
            this.bftxtCliente.Name = "bftxtCliente";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bftxtCliente.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.bftxtCliente.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bftxtCliente.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bftxtCliente.OnIdleState = stateProperties12;
            this.bftxtCliente.Padding = new System.Windows.Forms.Padding(3);
            this.bftxtCliente.PasswordChar = '\0';
            this.bftxtCliente.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.bftxtCliente.PlaceholderText = "Enter text";
            this.bftxtCliente.ReadOnly = false;
            this.bftxtCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bftxtCliente.SelectedText = "";
            this.bftxtCliente.SelectionLength = 0;
            this.bftxtCliente.SelectionStart = 0;
            this.bftxtCliente.ShortcutsEnabled = true;
            this.bftxtCliente.Size = new System.Drawing.Size(166, 33);
            this.bftxtCliente.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.bftxtCliente.TabIndex = 31;
            this.bftxtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bftxtCliente.TextMarginBottom = 0;
            this.bftxtCliente.TextMarginLeft = 3;
            this.bftxtCliente.TextMarginTop = 1;
            this.bftxtCliente.TextPlaceholder = "Enter text";
            this.bftxtCliente.UseSystemPasswordChar = false;
            this.bftxtCliente.WordWrap = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Cliente";
            // 
            // bfbtnAceptar
            // 
            this.bfbtnAceptar.AllowAnimations = true;
            this.bfbtnAceptar.AllowMouseEffects = true;
            this.bfbtnAceptar.AllowToggling = false;
            this.bfbtnAceptar.AnimationSpeed = 200;
            this.bfbtnAceptar.AutoGenerateColors = false;
            this.bfbtnAceptar.AutoRoundBorders = false;
            this.bfbtnAceptar.AutoSizeLeftIcon = true;
            this.bfbtnAceptar.AutoSizeRightIcon = true;
            this.bfbtnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.bfbtnAceptar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bfbtnAceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bfbtnAceptar.BackgroundImage")));
            this.bfbtnAceptar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bfbtnAceptar.ButtonText = "Aceptar Viaje";
            this.bfbtnAceptar.ButtonTextMarginLeft = 0;
            this.bfbtnAceptar.ColorContrastOnClick = 45;
            this.bfbtnAceptar.ColorContrastOnHover = 45;
            this.bfbtnAceptar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bfbtnAceptar.CustomizableEdges = borderEdges1;
            this.bfbtnAceptar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bfbtnAceptar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bfbtnAceptar.DisabledFillColor = System.Drawing.Color.Empty;
            this.bfbtnAceptar.DisabledForecolor = System.Drawing.Color.Empty;
            this.bfbtnAceptar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bfbtnAceptar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bfbtnAceptar.ForeColor = System.Drawing.Color.White;
            this.bfbtnAceptar.IconLeft = null;
            this.bfbtnAceptar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbtnAceptar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bfbtnAceptar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bfbtnAceptar.IconMarginLeft = 11;
            this.bfbtnAceptar.IconPadding = 10;
            this.bfbtnAceptar.IconRight = null;
            this.bfbtnAceptar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bfbtnAceptar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bfbtnAceptar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bfbtnAceptar.IconSize = 25;
            this.bfbtnAceptar.IdleBorderColor = System.Drawing.Color.Empty;
            this.bfbtnAceptar.IdleBorderRadius = 0;
            this.bfbtnAceptar.IdleBorderThickness = 0;
            this.bfbtnAceptar.IdleFillColor = System.Drawing.Color.Empty;
            this.bfbtnAceptar.IdleIconLeftImage = null;
            this.bfbtnAceptar.IdleIconRightImage = null;
            this.bfbtnAceptar.IndicateFocus = false;
            this.bfbtnAceptar.Location = new System.Drawing.Point(359, 494);
            this.bfbtnAceptar.Name = "bfbtnAceptar";
            this.bfbtnAceptar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bfbtnAceptar.OnDisabledState.BorderRadius = 1;
            this.bfbtnAceptar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bfbtnAceptar.OnDisabledState.BorderThickness = 1;
            this.bfbtnAceptar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bfbtnAceptar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bfbtnAceptar.OnDisabledState.IconLeftImage = null;
            this.bfbtnAceptar.OnDisabledState.IconRightImage = null;
            this.bfbtnAceptar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.bfbtnAceptar.onHoverState.BorderRadius = 1;
            this.bfbtnAceptar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bfbtnAceptar.onHoverState.BorderThickness = 1;
            this.bfbtnAceptar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.bfbtnAceptar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bfbtnAceptar.onHoverState.IconLeftImage = null;
            this.bfbtnAceptar.onHoverState.IconRightImage = null;
            this.bfbtnAceptar.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bfbtnAceptar.OnIdleState.BorderRadius = 1;
            this.bfbtnAceptar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bfbtnAceptar.OnIdleState.BorderThickness = 1;
            this.bfbtnAceptar.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bfbtnAceptar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bfbtnAceptar.OnIdleState.IconLeftImage = null;
            this.bfbtnAceptar.OnIdleState.IconRightImage = null;
            this.bfbtnAceptar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bfbtnAceptar.OnPressedState.BorderRadius = 1;
            this.bfbtnAceptar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bfbtnAceptar.OnPressedState.BorderThickness = 1;
            this.bfbtnAceptar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bfbtnAceptar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bfbtnAceptar.OnPressedState.IconLeftImage = null;
            this.bfbtnAceptar.OnPressedState.IconRightImage = null;
            this.bfbtnAceptar.Size = new System.Drawing.Size(126, 35);
            this.bfbtnAceptar.TabIndex = 33;
            this.bfbtnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bfbtnAceptar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bfbtnAceptar.TextMarginLeft = 0;
            this.bfbtnAceptar.TextPadding = new System.Windows.Forms.Padding(0);
            this.bfbtnAceptar.UseDefaultRadiusAndThickness = true;
            this.bfbtnAceptar.Click += new System.EventHandler(this.bfbtnAceptar_Click);
            // 
            // contadorSolicitud
            // 
            this.contadorSolicitud.Enabled = true;
            this.contadorSolicitud.Interval = 5000;
            this.contadorSolicitud.Tick += new System.EventHandler(this.contadorSolicitud_Tick);
            // 
            // bfSnackbarSolicitud
            // 
            this.bfSnackbarSolicitud.AllowDragging = false;
            this.bfSnackbarSolicitud.AllowMultipleViews = true;
            this.bfSnackbarSolicitud.ClickToClose = true;
            this.bfSnackbarSolicitud.DoubleClickToClose = true;
            this.bfSnackbarSolicitud.DurationAfterIdle = 3000;
            this.bfSnackbarSolicitud.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bfSnackbarSolicitud.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bfSnackbarSolicitud.ErrorOptions.ActionBorderRadius = 1;
            this.bfSnackbarSolicitud.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bfSnackbarSolicitud.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bfSnackbarSolicitud.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.bfSnackbarSolicitud.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.bfSnackbarSolicitud.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.bfSnackbarSolicitud.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bfSnackbarSolicitud.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.bfSnackbarSolicitud.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.bfSnackbarSolicitud.ErrorOptions.IconLeftMargin = 12;
            this.bfSnackbarSolicitud.FadeCloseIcon = false;
            this.bfSnackbarSolicitud.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.bfSnackbarSolicitud.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bfSnackbarSolicitud.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bfSnackbarSolicitud.InformationOptions.ActionBorderRadius = 1;
            this.bfSnackbarSolicitud.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bfSnackbarSolicitud.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bfSnackbarSolicitud.InformationOptions.BackColor = System.Drawing.Color.White;
            this.bfSnackbarSolicitud.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.bfSnackbarSolicitud.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.bfSnackbarSolicitud.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bfSnackbarSolicitud.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.bfSnackbarSolicitud.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.bfSnackbarSolicitud.InformationOptions.IconLeftMargin = 12;
            this.bfSnackbarSolicitud.Margin = 10;
            this.bfSnackbarSolicitud.MaximumSize = new System.Drawing.Size(0, 0);
            this.bfSnackbarSolicitud.MaximumViews = 7;
            this.bfSnackbarSolicitud.MessageRightMargin = 15;
            this.bfSnackbarSolicitud.MinimumSize = new System.Drawing.Size(0, 0);
            this.bfSnackbarSolicitud.ShowBorders = false;
            this.bfSnackbarSolicitud.ShowCloseIcon = false;
            this.bfSnackbarSolicitud.ShowIcon = true;
            this.bfSnackbarSolicitud.ShowShadows = true;
            this.bfSnackbarSolicitud.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bfSnackbarSolicitud.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bfSnackbarSolicitud.SuccessOptions.ActionBorderRadius = 1;
            this.bfSnackbarSolicitud.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bfSnackbarSolicitud.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bfSnackbarSolicitud.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.bfSnackbarSolicitud.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.bfSnackbarSolicitud.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.bfSnackbarSolicitud.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bfSnackbarSolicitud.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.bfSnackbarSolicitud.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.bfSnackbarSolicitud.SuccessOptions.IconLeftMargin = 12;
            this.bfSnackbarSolicitud.ViewsMargin = 7;
            this.bfSnackbarSolicitud.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bfSnackbarSolicitud.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bfSnackbarSolicitud.WarningOptions.ActionBorderRadius = 1;
            this.bfSnackbarSolicitud.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bfSnackbarSolicitud.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bfSnackbarSolicitud.WarningOptions.BackColor = System.Drawing.Color.White;
            this.bfSnackbarSolicitud.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.bfSnackbarSolicitud.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.bfSnackbarSolicitud.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bfSnackbarSolicitud.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.bfSnackbarSolicitud.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.bfSnackbarSolicitud.WarningOptions.IconLeftMargin = 12;
            this.bfSnackbarSolicitud.ZoomCloseIcon = true;
            // 
            // frmSolicitudViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 604);
            this.Controls.Add(this.bfbtnAceptar);
            this.Controls.Add(this.bftxtCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bftxtPuntoLlegada);
            this.Controls.Add(this.bftxtPuntoInicio);
            this.Controls.Add(this.lnlLlegada);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.bfdgvSolicitudes);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSolicitudViajes";
            this.Text = "frmSolicitudViajes";
            this.Load += new System.EventHandler(this.frmSolicitudViajes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bfdgvSolicitudes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private Bunifu.UI.WinForms.BunifuDataGridView bfdgvSolicitudes;
        private Bunifu.UI.WinForms.BunifuTextBox bftxtPuntoLlegada;
        private Bunifu.UI.WinForms.BunifuTextBox bftxtPuntoInicio;
        private System.Windows.Forms.Label lnlLlegada;
        private System.Windows.Forms.Label lblInicio;
        private Bunifu.UI.WinForms.BunifuTextBox bftxtCliente;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bfbtnAceptar;
        private System.Windows.Forms.Timer contadorSolicitud;
        private Bunifu.UI.WinForms.BunifuSnackbar bfSnackbarSolicitud;
    }
}