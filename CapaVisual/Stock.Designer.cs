
namespace CapaVisual
{
    partial class Stock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnEliminar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnModificar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.AllowUserToResizeColumns = false;
            this.dgvStock.AllowUserToResizeRows = false;
            this.dgvStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dgvStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.descripcion,
            this.Cantidad,
            this.precio,
            this.fecha});
            this.dgvStock.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStock.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(36)))));
            this.dgvStock.Location = new System.Drawing.Point(12, 12);
            this.dgvStock.MultiSelect = false;
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStock.RowTemplate.ReadOnly = true;
            this.dgvStock.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(674, 471);
            this.dgvStock.TabIndex = 1;
            this.dgvStock.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AllowAnimations = true;
            this.btnAgregar.AllowMouseEffects = true;
            this.btnAgregar.AllowToggling = false;
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.AnimationSpeed = 200;
            this.btnAgregar.AutoGenerateColors = false;
            this.btnAgregar.AutoRoundBorders = false;
            this.btnAgregar.AutoSizeLeftIcon = true;
            this.btnAgregar.AutoSizeRightIcon = true;
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregar.ButtonText = "Agregar";
            this.btnAgregar.ButtonTextMarginLeft = 0;
            this.btnAgregar.ColorContrastOnClick = 45;
            this.btnAgregar.ColorContrastOnHover = 45;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAgregar.CustomizableEdges = borderEdges1;
            this.btnAgregar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAgregar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAgregar.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnAgregar.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnAgregar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.IconLeft = null;
            this.btnAgregar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAgregar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAgregar.IconMarginLeft = 11;
            this.btnAgregar.IconPadding = 10;
            this.btnAgregar.IconRight = null;
            this.btnAgregar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAgregar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAgregar.IconSize = 25;
            this.btnAgregar.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnAgregar.IdleBorderRadius = 0;
            this.btnAgregar.IdleBorderThickness = 0;
            this.btnAgregar.IdleFillColor = System.Drawing.Color.Empty;
            this.btnAgregar.IdleIconLeftImage = null;
            this.btnAgregar.IdleIconRightImage = null;
            this.btnAgregar.IndicateFocus = false;
            this.btnAgregar.Location = new System.Drawing.Point(692, 52);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAgregar.OnDisabledState.BorderRadius = 12;
            this.btnAgregar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregar.OnDisabledState.BorderThickness = 1;
            this.btnAgregar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAgregar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAgregar.OnDisabledState.IconLeftImage = null;
            this.btnAgregar.OnDisabledState.IconRightImage = null;
            this.btnAgregar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.btnAgregar.onHoverState.BorderRadius = 12;
            this.btnAgregar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregar.onHoverState.BorderThickness = 1;
            this.btnAgregar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.btnAgregar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.onHoverState.IconLeftImage = null;
            this.btnAgregar.onHoverState.IconRightImage = null;
            this.btnAgregar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.btnAgregar.OnIdleState.BorderRadius = 12;
            this.btnAgregar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregar.OnIdleState.BorderThickness = 1;
            this.btnAgregar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.btnAgregar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.OnIdleState.IconLeftImage = null;
            this.btnAgregar.OnIdleState.IconRightImage = null;
            this.btnAgregar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.btnAgregar.OnPressedState.BorderRadius = 12;
            this.btnAgregar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregar.OnPressedState.BorderThickness = 1;
            this.btnAgregar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.btnAgregar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.OnPressedState.IconLeftImage = null;
            this.btnAgregar.OnPressedState.IconRightImage = null;
            this.btnAgregar.Size = new System.Drawing.Size(170, 59);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.TabStop = false;
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAgregar.TextMarginLeft = 0;
            this.btnAgregar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAgregar.UseDefaultRadiusAndThickness = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AllowAnimations = true;
            this.btnEliminar.AllowMouseEffects = true;
            this.btnEliminar.AllowToggling = false;
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.AnimationSpeed = 200;
            this.btnEliminar.AutoGenerateColors = false;
            this.btnEliminar.AutoRoundBorders = false;
            this.btnEliminar.AutoSizeLeftIcon = true;
            this.btnEliminar.AutoSizeRightIcon = true;
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEliminar.ButtonText = "Eliminar";
            this.btnEliminar.ButtonTextMarginLeft = 0;
            this.btnEliminar.ColorContrastOnClick = 45;
            this.btnEliminar.ColorContrastOnHover = 45;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnEliminar.CustomizableEdges = borderEdges2;
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEliminar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEliminar.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnEliminar.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnEliminar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.IconLeft = null;
            this.btnEliminar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnEliminar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnEliminar.IconMarginLeft = 11;
            this.btnEliminar.IconPadding = 10;
            this.btnEliminar.IconRight = null;
            this.btnEliminar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnEliminar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnEliminar.IconSize = 25;
            this.btnEliminar.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnEliminar.IdleBorderRadius = 0;
            this.btnEliminar.IdleBorderThickness = 0;
            this.btnEliminar.IdleFillColor = System.Drawing.Color.Empty;
            this.btnEliminar.IdleIconLeftImage = null;
            this.btnEliminar.IdleIconRightImage = null;
            this.btnEliminar.IndicateFocus = false;
            this.btnEliminar.Location = new System.Drawing.Point(692, 424);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEliminar.OnDisabledState.BorderRadius = 12;
            this.btnEliminar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEliminar.OnDisabledState.BorderThickness = 1;
            this.btnEliminar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEliminar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEliminar.OnDisabledState.IconLeftImage = null;
            this.btnEliminar.OnDisabledState.IconRightImage = null;
            this.btnEliminar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.btnEliminar.onHoverState.BorderRadius = 12;
            this.btnEliminar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEliminar.onHoverState.BorderThickness = 1;
            this.btnEliminar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.btnEliminar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.onHoverState.IconLeftImage = null;
            this.btnEliminar.onHoverState.IconRightImage = null;
            this.btnEliminar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.btnEliminar.OnIdleState.BorderRadius = 12;
            this.btnEliminar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEliminar.OnIdleState.BorderThickness = 1;
            this.btnEliminar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.btnEliminar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.OnIdleState.IconLeftImage = null;
            this.btnEliminar.OnIdleState.IconRightImage = null;
            this.btnEliminar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.btnEliminar.OnPressedState.BorderRadius = 12;
            this.btnEliminar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEliminar.OnPressedState.BorderThickness = 1;
            this.btnEliminar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.btnEliminar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.OnPressedState.IconLeftImage = null;
            this.btnEliminar.OnPressedState.IconRightImage = null;
            this.btnEliminar.Size = new System.Drawing.Size(170, 59);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.TabStop = false;
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEliminar.TextMarginLeft = 0;
            this.btnEliminar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnEliminar.UseDefaultRadiusAndThickness = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.AllowAnimations = true;
            this.btnModificar.AllowMouseEffects = true;
            this.btnModificar.AllowToggling = false;
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.AnimationSpeed = 200;
            this.btnModificar.AutoGenerateColors = false;
            this.btnModificar.AutoRoundBorders = false;
            this.btnModificar.AutoSizeLeftIcon = true;
            this.btnModificar.AutoSizeRightIcon = true;
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificar.BackgroundImage")));
            this.btnModificar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnModificar.ButtonText = "Modificar";
            this.btnModificar.ButtonTextMarginLeft = 0;
            this.btnModificar.ColorContrastOnClick = 45;
            this.btnModificar.ColorContrastOnHover = 45;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnModificar.CustomizableEdges = borderEdges3;
            this.btnModificar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnModificar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnModificar.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnModificar.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnModificar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.IconLeft = null;
            this.btnModificar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnModificar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnModificar.IconMarginLeft = 11;
            this.btnModificar.IconPadding = 10;
            this.btnModificar.IconRight = null;
            this.btnModificar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnModificar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnModificar.IconSize = 25;
            this.btnModificar.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnModificar.IdleBorderRadius = 0;
            this.btnModificar.IdleBorderThickness = 0;
            this.btnModificar.IdleFillColor = System.Drawing.Color.Empty;
            this.btnModificar.IdleIconLeftImage = null;
            this.btnModificar.IdleIconRightImage = null;
            this.btnModificar.IndicateFocus = false;
            this.btnModificar.Location = new System.Drawing.Point(692, 147);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnModificar.OnDisabledState.BorderRadius = 12;
            this.btnModificar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnModificar.OnDisabledState.BorderThickness = 1;
            this.btnModificar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnModificar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnModificar.OnDisabledState.IconLeftImage = null;
            this.btnModificar.OnDisabledState.IconRightImage = null;
            this.btnModificar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.btnModificar.onHoverState.BorderRadius = 12;
            this.btnModificar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnModificar.onHoverState.BorderThickness = 1;
            this.btnModificar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.btnModificar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnModificar.onHoverState.IconLeftImage = null;
            this.btnModificar.onHoverState.IconRightImage = null;
            this.btnModificar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.btnModificar.OnIdleState.BorderRadius = 12;
            this.btnModificar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnModificar.OnIdleState.BorderThickness = 1;
            this.btnModificar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.btnModificar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnModificar.OnIdleState.IconLeftImage = null;
            this.btnModificar.OnIdleState.IconRightImage = null;
            this.btnModificar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.btnModificar.OnPressedState.BorderRadius = 12;
            this.btnModificar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnModificar.OnPressedState.BorderThickness = 1;
            this.btnModificar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.btnModificar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnModificar.OnPressedState.IconLeftImage = null;
            this.btnModificar.OnPressedState.IconRightImage = null;
            this.btnModificar.Size = new System.Drawing.Size(170, 59);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.TabStop = false;
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModificar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnModificar.TextMarginLeft = 0;
            this.btnModificar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnModificar.UseDefaultRadiusAndThickness = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcion.HeaderText = "descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 70;
            // 
            // precio
            // 
            this.precio.HeaderText = "precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 70;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 120;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(874, 495);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvStock);
            this.MinimumSize = new System.Drawing.Size(890, 534);
            this.Name = "Stock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStock;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAgregar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnEliminar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
    }
}