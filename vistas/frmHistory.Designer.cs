
namespace final_motoDix.Vistas
{
    partial class frmHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistory));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.bfdgvHistorial = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bflblDesde = new Bunifu.UI.WinForms.BunifuLabel();
            this.bflblHasta = new Bunifu.UI.WinForms.BunifuLabel();
            this.bfdtpkDesde = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.bfdtpkHasta = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.bfbtnLimpiarFiltro = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.bfbtnConsultarHistorial = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bfSnackbarViajeHistory = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bfdgvHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // bfdgvHistorial
            // 
            this.bfdgvHistorial.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.bfdgvHistorial.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.bfdgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.bfdgvHistorial.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.bfdgvHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bfdgvHistorial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bfdgvHistorial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bfdgvHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.bfdgvHistorial.ColumnHeadersHeight = 40;
            this.bfdgvHistorial.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.bfdgvHistorial.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bfdgvHistorial.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bfdgvHistorial.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bfdgvHistorial.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bfdgvHistorial.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.bfdgvHistorial.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bfdgvHistorial.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.bfdgvHistorial.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bfdgvHistorial.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bfdgvHistorial.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.bfdgvHistorial.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bfdgvHistorial.CurrentTheme.Name = null;
            this.bfdgvHistorial.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.bfdgvHistorial.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bfdgvHistorial.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bfdgvHistorial.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bfdgvHistorial.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bfdgvHistorial.DefaultCellStyle = dataGridViewCellStyle6;
            this.bfdgvHistorial.EnableHeadersVisualStyles = false;
            this.bfdgvHistorial.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bfdgvHistorial.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bfdgvHistorial.HeaderBgColor = System.Drawing.Color.Empty;
            this.bfdgvHistorial.HeaderForeColor = System.Drawing.Color.White;
            this.bfdgvHistorial.Location = new System.Drawing.Point(36, 198);
            this.bfdgvHistorial.Name = "bfdgvHistorial";
            this.bfdgvHistorial.RowHeadersVisible = false;
            this.bfdgvHistorial.RowTemplate.Height = 40;
            this.bfdgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bfdgvHistorial.Size = new System.Drawing.Size(718, 267);
            this.bfdgvHistorial.TabIndex = 0;
            this.bfdgvHistorial.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // bflblDesde
            // 
            this.bflblDesde.AllowParentOverrides = false;
            this.bflblDesde.AutoEllipsis = false;
            this.bflblDesde.Cursor = System.Windows.Forms.Cursors.Default;
            this.bflblDesde.CursorType = System.Windows.Forms.Cursors.Default;
            this.bflblDesde.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bflblDesde.Location = new System.Drawing.Point(36, 93);
            this.bflblDesde.Name = "bflblDesde";
            this.bflblDesde.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bflblDesde.Size = new System.Drawing.Size(32, 15);
            this.bflblDesde.TabIndex = 1;
            this.bflblDesde.Text = "Desde";
            this.bflblDesde.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bflblDesde.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bflblHasta
            // 
            this.bflblHasta.AllowParentOverrides = false;
            this.bflblHasta.AutoEllipsis = false;
            this.bflblHasta.CursorType = null;
            this.bflblHasta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bflblHasta.Location = new System.Drawing.Point(383, 93);
            this.bflblHasta.Name = "bflblHasta";
            this.bflblHasta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bflblHasta.Size = new System.Drawing.Size(30, 15);
            this.bflblHasta.TabIndex = 2;
            this.bflblHasta.Text = "Hasta";
            this.bflblHasta.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bflblHasta.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bfdtpkDesde
            // 
            this.bfdtpkDesde.BackColor = System.Drawing.Color.Transparent;
            this.bfdtpkDesde.BorderColor = System.Drawing.Color.Silver;
            this.bfdtpkDesde.BorderRadius = 1;
            this.bfdtpkDesde.Color = System.Drawing.Color.Silver;
            this.bfdtpkDesde.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.bfdtpkDesde.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.bfdtpkDesde.DisabledColor = System.Drawing.Color.Gray;
            this.bfdtpkDesde.DisplayWeekNumbers = false;
            this.bfdtpkDesde.DPHeight = 0;
            this.bfdtpkDesde.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.bfdtpkDesde.FillDatePicker = false;
            this.bfdtpkDesde.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bfdtpkDesde.ForeColor = System.Drawing.Color.Black;
            this.bfdtpkDesde.Icon = ((System.Drawing.Image)(resources.GetObject("bfdtpkDesde.Icon")));
            this.bfdtpkDesde.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bfdtpkDesde.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.bfdtpkDesde.LeftTextMargin = 5;
            this.bfdtpkDesde.Location = new System.Drawing.Point(36, 122);
            this.bfdtpkDesde.MinimumSize = new System.Drawing.Size(4, 32);
            this.bfdtpkDesde.Name = "bfdtpkDesde";
            this.bfdtpkDesde.Size = new System.Drawing.Size(217, 32);
            this.bfdtpkDesde.TabIndex = 3;
            this.bfdtpkDesde.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // bfdtpkHasta
            // 
            this.bfdtpkHasta.BackColor = System.Drawing.Color.Transparent;
            this.bfdtpkHasta.BorderColor = System.Drawing.Color.Silver;
            this.bfdtpkHasta.BorderRadius = 1;
            this.bfdtpkHasta.Color = System.Drawing.Color.Silver;
            this.bfdtpkHasta.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.bfdtpkHasta.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.bfdtpkHasta.DisabledColor = System.Drawing.Color.Gray;
            this.bfdtpkHasta.DisplayWeekNumbers = false;
            this.bfdtpkHasta.DPHeight = 0;
            this.bfdtpkHasta.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.bfdtpkHasta.FillDatePicker = false;
            this.bfdtpkHasta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bfdtpkHasta.ForeColor = System.Drawing.Color.Black;
            this.bfdtpkHasta.Icon = ((System.Drawing.Image)(resources.GetObject("bfdtpkHasta.Icon")));
            this.bfdtpkHasta.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bfdtpkHasta.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.bfdtpkHasta.LeftTextMargin = 5;
            this.bfdtpkHasta.Location = new System.Drawing.Point(383, 122);
            this.bfdtpkHasta.MinimumSize = new System.Drawing.Size(4, 32);
            this.bfdtpkHasta.Name = "bfdtpkHasta";
            this.bfdtpkHasta.Size = new System.Drawing.Size(247, 32);
            this.bfdtpkHasta.TabIndex = 4;
            this.bfdtpkHasta.Value = new System.DateTime(2021, 11, 14, 0, 0, 0, 0);
            // 
            // bfbtnLimpiarFiltro
            // 
            this.bfbtnLimpiarFiltro.AllowAnimations = true;
            this.bfbtnLimpiarFiltro.AllowMouseEffects = true;
            this.bfbtnLimpiarFiltro.AllowToggling = false;
            this.bfbtnLimpiarFiltro.AnimationSpeed = 200;
            this.bfbtnLimpiarFiltro.AutoGenerateColors = false;
            this.bfbtnLimpiarFiltro.AutoRoundBorders = true;
            this.bfbtnLimpiarFiltro.AutoSizeLeftIcon = true;
            this.bfbtnLimpiarFiltro.AutoSizeRightIcon = true;
            this.bfbtnLimpiarFiltro.BackColor = System.Drawing.Color.Transparent;
            this.bfbtnLimpiarFiltro.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.bfbtnLimpiarFiltro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bfbtnLimpiarFiltro.BackgroundImage")));
            this.bfbtnLimpiarFiltro.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bfbtnLimpiarFiltro.ButtonText = "Limpiar filtro";
            this.bfbtnLimpiarFiltro.ButtonTextMarginLeft = 0;
            this.bfbtnLimpiarFiltro.ColorContrastOnClick = 45;
            this.bfbtnLimpiarFiltro.ColorContrastOnHover = 45;
            this.bfbtnLimpiarFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = false;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = false;
            this.bfbtnLimpiarFiltro.CustomizableEdges = borderEdges3;
            this.bfbtnLimpiarFiltro.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bfbtnLimpiarFiltro.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bfbtnLimpiarFiltro.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bfbtnLimpiarFiltro.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bfbtnLimpiarFiltro.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.bfbtnLimpiarFiltro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bfbtnLimpiarFiltro.ForeColor = System.Drawing.Color.White;
            this.bfbtnLimpiarFiltro.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbtnLimpiarFiltro.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.bfbtnLimpiarFiltro.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bfbtnLimpiarFiltro.IconMarginLeft = 11;
            this.bfbtnLimpiarFiltro.IconPadding = 10;
            this.bfbtnLimpiarFiltro.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bfbtnLimpiarFiltro.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bfbtnLimpiarFiltro.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bfbtnLimpiarFiltro.IconSize = 25;
            this.bfbtnLimpiarFiltro.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bfbtnLimpiarFiltro.IdleBorderRadius = 21;
            this.bfbtnLimpiarFiltro.IdleBorderThickness = 1;
            this.bfbtnLimpiarFiltro.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bfbtnLimpiarFiltro.IdleIconLeftImage = null;
            this.bfbtnLimpiarFiltro.IdleIconRightImage = null;
            this.bfbtnLimpiarFiltro.IndicateFocus = false;
            this.bfbtnLimpiarFiltro.Location = new System.Drawing.Point(640, 169);
            this.bfbtnLimpiarFiltro.Name = "bfbtnLimpiarFiltro";
            this.bfbtnLimpiarFiltro.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bfbtnLimpiarFiltro.OnDisabledState.BorderRadius = 1;
            this.bfbtnLimpiarFiltro.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bfbtnLimpiarFiltro.OnDisabledState.BorderThickness = 1;
            this.bfbtnLimpiarFiltro.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bfbtnLimpiarFiltro.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bfbtnLimpiarFiltro.OnDisabledState.IconLeftImage = null;
            this.bfbtnLimpiarFiltro.OnDisabledState.IconRightImage = null;
            this.bfbtnLimpiarFiltro.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bfbtnLimpiarFiltro.onHoverState.BorderRadius = 1;
            this.bfbtnLimpiarFiltro.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bfbtnLimpiarFiltro.onHoverState.BorderThickness = 1;
            this.bfbtnLimpiarFiltro.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bfbtnLimpiarFiltro.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bfbtnLimpiarFiltro.onHoverState.IconLeftImage = null;
            this.bfbtnLimpiarFiltro.onHoverState.IconRightImage = null;
            this.bfbtnLimpiarFiltro.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bfbtnLimpiarFiltro.OnIdleState.BorderRadius = 1;
            this.bfbtnLimpiarFiltro.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bfbtnLimpiarFiltro.OnIdleState.BorderThickness = 1;
            this.bfbtnLimpiarFiltro.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bfbtnLimpiarFiltro.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bfbtnLimpiarFiltro.OnIdleState.IconLeftImage = null;
            this.bfbtnLimpiarFiltro.OnIdleState.IconRightImage = null;
            this.bfbtnLimpiarFiltro.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bfbtnLimpiarFiltro.OnPressedState.BorderRadius = 1;
            this.bfbtnLimpiarFiltro.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bfbtnLimpiarFiltro.OnPressedState.BorderThickness = 1;
            this.bfbtnLimpiarFiltro.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bfbtnLimpiarFiltro.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bfbtnLimpiarFiltro.OnPressedState.IconLeftImage = null;
            this.bfbtnLimpiarFiltro.OnPressedState.IconRightImage = null;
            this.bfbtnLimpiarFiltro.Size = new System.Drawing.Size(103, 23);
            this.bfbtnLimpiarFiltro.TabIndex = 5;
            this.bfbtnLimpiarFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bfbtnLimpiarFiltro.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bfbtnLimpiarFiltro.TextMarginLeft = 0;
            this.bfbtnLimpiarFiltro.TextPadding = new System.Windows.Forms.Padding(0);
            this.bfbtnLimpiarFiltro.UseDefaultRadiusAndThickness = true;
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorial.Location = new System.Drawing.Point(31, 40);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(131, 20);
            this.lblHistorial.TabIndex = 6;
            this.lblHistorial.Text = "Historial de viajes";
            // 
            // bfbtnConsultarHistorial
            // 
            this.bfbtnConsultarHistorial.AllowAnimations = true;
            this.bfbtnConsultarHistorial.AllowMouseEffects = true;
            this.bfbtnConsultarHistorial.AllowToggling = false;
            this.bfbtnConsultarHistorial.AnimationSpeed = 200;
            this.bfbtnConsultarHistorial.AutoGenerateColors = false;
            this.bfbtnConsultarHistorial.AutoRoundBorders = false;
            this.bfbtnConsultarHistorial.AutoSizeLeftIcon = true;
            this.bfbtnConsultarHistorial.AutoSizeRightIcon = true;
            this.bfbtnConsultarHistorial.BackColor = System.Drawing.Color.Transparent;
            this.bfbtnConsultarHistorial.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.bfbtnConsultarHistorial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bfbtnConsultarHistorial.BackgroundImage")));
            this.bfbtnConsultarHistorial.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bfbtnConsultarHistorial.ButtonText = "Consultar";
            this.bfbtnConsultarHistorial.ButtonTextMarginLeft = 0;
            this.bfbtnConsultarHistorial.ColorContrastOnClick = 45;
            this.bfbtnConsultarHistorial.ColorContrastOnHover = 45;
            this.bfbtnConsultarHistorial.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.bfbtnConsultarHistorial.CustomizableEdges = borderEdges4;
            this.bfbtnConsultarHistorial.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bfbtnConsultarHistorial.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bfbtnConsultarHistorial.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bfbtnConsultarHistorial.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bfbtnConsultarHistorial.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.bfbtnConsultarHistorial.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bfbtnConsultarHistorial.ForeColor = System.Drawing.Color.White;
            this.bfbtnConsultarHistorial.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbtnConsultarHistorial.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bfbtnConsultarHistorial.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bfbtnConsultarHistorial.IconMarginLeft = 11;
            this.bfbtnConsultarHistorial.IconPadding = 10;
            this.bfbtnConsultarHistorial.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bfbtnConsultarHistorial.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bfbtnConsultarHistorial.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bfbtnConsultarHistorial.IconSize = 25;
            this.bfbtnConsultarHistorial.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bfbtnConsultarHistorial.IdleBorderRadius = 1;
            this.bfbtnConsultarHistorial.IdleBorderThickness = 1;
            this.bfbtnConsultarHistorial.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bfbtnConsultarHistorial.IdleIconLeftImage = null;
            this.bfbtnConsultarHistorial.IdleIconRightImage = null;
            this.bfbtnConsultarHistorial.IndicateFocus = false;
            this.bfbtnConsultarHistorial.Location = new System.Drawing.Point(636, 122);
            this.bfbtnConsultarHistorial.Name = "bfbtnConsultarHistorial";
            this.bfbtnConsultarHistorial.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bfbtnConsultarHistorial.OnDisabledState.BorderRadius = 1;
            this.bfbtnConsultarHistorial.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bfbtnConsultarHistorial.OnDisabledState.BorderThickness = 1;
            this.bfbtnConsultarHistorial.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bfbtnConsultarHistorial.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bfbtnConsultarHistorial.OnDisabledState.IconLeftImage = null;
            this.bfbtnConsultarHistorial.OnDisabledState.IconRightImage = null;
            this.bfbtnConsultarHistorial.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bfbtnConsultarHistorial.onHoverState.BorderRadius = 1;
            this.bfbtnConsultarHistorial.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bfbtnConsultarHistorial.onHoverState.BorderThickness = 1;
            this.bfbtnConsultarHistorial.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bfbtnConsultarHistorial.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bfbtnConsultarHistorial.onHoverState.IconLeftImage = null;
            this.bfbtnConsultarHistorial.onHoverState.IconRightImage = null;
            this.bfbtnConsultarHistorial.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bfbtnConsultarHistorial.OnIdleState.BorderRadius = 1;
            this.bfbtnConsultarHistorial.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bfbtnConsultarHistorial.OnIdleState.BorderThickness = 1;
            this.bfbtnConsultarHistorial.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bfbtnConsultarHistorial.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bfbtnConsultarHistorial.OnIdleState.IconLeftImage = null;
            this.bfbtnConsultarHistorial.OnIdleState.IconRightImage = null;
            this.bfbtnConsultarHistorial.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bfbtnConsultarHistorial.OnPressedState.BorderRadius = 1;
            this.bfbtnConsultarHistorial.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bfbtnConsultarHistorial.OnPressedState.BorderThickness = 1;
            this.bfbtnConsultarHistorial.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bfbtnConsultarHistorial.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bfbtnConsultarHistorial.OnPressedState.IconLeftImage = null;
            this.bfbtnConsultarHistorial.OnPressedState.IconRightImage = null;
            this.bfbtnConsultarHistorial.Size = new System.Drawing.Size(107, 30);
            this.bfbtnConsultarHistorial.TabIndex = 7;
            this.bfbtnConsultarHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bfbtnConsultarHistorial.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bfbtnConsultarHistorial.TextMarginLeft = 0;
            this.bfbtnConsultarHistorial.TextPadding = new System.Windows.Forms.Padding(0);
            this.bfbtnConsultarHistorial.UseDefaultRadiusAndThickness = true;
            this.bfbtnConsultarHistorial.Click += new System.EventHandler(this.bfbtnConsultarHistorial_Click);
            // 
            // bfSnackbarViajeHistory
            // 
            this.bfSnackbarViajeHistory.AllowDragging = false;
            this.bfSnackbarViajeHistory.AllowMultipleViews = true;
            this.bfSnackbarViajeHistory.ClickToClose = true;
            this.bfSnackbarViajeHistory.DoubleClickToClose = true;
            this.bfSnackbarViajeHistory.DurationAfterIdle = 4000;
            this.bfSnackbarViajeHistory.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bfSnackbarViajeHistory.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bfSnackbarViajeHistory.ErrorOptions.ActionBorderRadius = 1;
            this.bfSnackbarViajeHistory.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bfSnackbarViajeHistory.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bfSnackbarViajeHistory.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.bfSnackbarViajeHistory.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.bfSnackbarViajeHistory.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.bfSnackbarViajeHistory.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bfSnackbarViajeHistory.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.bfSnackbarViajeHistory.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.bfSnackbarViajeHistory.ErrorOptions.IconLeftMargin = 12;
            this.bfSnackbarViajeHistory.FadeCloseIcon = false;
            this.bfSnackbarViajeHistory.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.bfSnackbarViajeHistory.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bfSnackbarViajeHistory.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bfSnackbarViajeHistory.InformationOptions.ActionBorderRadius = 1;
            this.bfSnackbarViajeHistory.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bfSnackbarViajeHistory.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bfSnackbarViajeHistory.InformationOptions.BackColor = System.Drawing.Color.White;
            this.bfSnackbarViajeHistory.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.bfSnackbarViajeHistory.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.bfSnackbarViajeHistory.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bfSnackbarViajeHistory.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.bfSnackbarViajeHistory.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.bfSnackbarViajeHistory.InformationOptions.IconLeftMargin = 12;
            this.bfSnackbarViajeHistory.Margin = 5;
            this.bfSnackbarViajeHistory.MaximumSize = new System.Drawing.Size(0, 0);
            this.bfSnackbarViajeHistory.MaximumViews = 7;
            this.bfSnackbarViajeHistory.MessageRightMargin = 15;
            this.bfSnackbarViajeHistory.MinimumSize = new System.Drawing.Size(0, 0);
            this.bfSnackbarViajeHistory.ShowBorders = false;
            this.bfSnackbarViajeHistory.ShowCloseIcon = false;
            this.bfSnackbarViajeHistory.ShowIcon = true;
            this.bfSnackbarViajeHistory.ShowShadows = true;
            this.bfSnackbarViajeHistory.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bfSnackbarViajeHistory.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bfSnackbarViajeHistory.SuccessOptions.ActionBorderRadius = 1;
            this.bfSnackbarViajeHistory.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bfSnackbarViajeHistory.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bfSnackbarViajeHistory.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.bfSnackbarViajeHistory.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.bfSnackbarViajeHistory.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.bfSnackbarViajeHistory.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bfSnackbarViajeHistory.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.bfSnackbarViajeHistory.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.bfSnackbarViajeHistory.SuccessOptions.IconLeftMargin = 12;
            this.bfSnackbarViajeHistory.ViewsMargin = 7;
            this.bfSnackbarViajeHistory.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bfSnackbarViajeHistory.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bfSnackbarViajeHistory.WarningOptions.ActionBorderRadius = 1;
            this.bfSnackbarViajeHistory.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bfSnackbarViajeHistory.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bfSnackbarViajeHistory.WarningOptions.BackColor = System.Drawing.Color.White;
            this.bfSnackbarViajeHistory.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.bfSnackbarViajeHistory.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.bfSnackbarViajeHistory.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bfSnackbarViajeHistory.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.bfSnackbarViajeHistory.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.bfSnackbarViajeHistory.WarningOptions.IconLeftMargin = 12;
            this.bfSnackbarViajeHistory.ZoomCloseIcon = true;
            // 
            // frmHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 504);
            this.ControlBox = false;
            this.Controls.Add(this.bfbtnConsultarHistorial);
            this.Controls.Add(this.lblHistorial);
            this.Controls.Add(this.bfbtnLimpiarFiltro);
            this.Controls.Add(this.bfdtpkHasta);
            this.Controls.Add(this.bfdtpkDesde);
            this.Controls.Add(this.bflblHasta);
            this.Controls.Add(this.bflblDesde);
            this.Controls.Add(this.bfdgvHistorial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHistory";
            this.Text = "frmHistory";
            this.Load += new System.EventHandler(this.frmHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bfdgvHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView bfdgvHistorial;
        private Bunifu.UI.WinForms.BunifuLabel bflblDesde;
        private Bunifu.UI.WinForms.BunifuLabel bflblHasta;
        private Bunifu.UI.WinForms.BunifuDatePicker bfdtpkDesde;
        private Bunifu.UI.WinForms.BunifuDatePicker bfdtpkHasta;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bfbtnLimpiarFiltro;
        private System.Windows.Forms.Label lblHistorial;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bfbtnConsultarHistorial;
        private Bunifu.UI.WinForms.BunifuSnackbar bfSnackbarViajeHistory;
    }
}