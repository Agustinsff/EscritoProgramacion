
namespace CapaVisual
{
    partial class Compras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compras));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.btnComprar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lblError = new System.Windows.Forms.Label();
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
            this.dgvStock.Size = new System.Drawing.Size(606, 436);
            this.dgvStock.TabIndex = 2;
            this.dgvStock.TabStop = false;
            // 
            // btnComprar
            // 
            this.btnComprar.AllowAnimations = true;
            this.btnComprar.AllowMouseEffects = true;
            this.btnComprar.AllowToggling = false;
            this.btnComprar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnComprar.AnimationSpeed = 200;
            this.btnComprar.AutoGenerateColors = false;
            this.btnComprar.AutoRoundBorders = false;
            this.btnComprar.AutoSizeLeftIcon = true;
            this.btnComprar.AutoSizeRightIcon = true;
            this.btnComprar.BackColor = System.Drawing.Color.Transparent;
            this.btnComprar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnComprar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnComprar.BackgroundImage")));
            this.btnComprar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnComprar.ButtonText = "Comprar";
            this.btnComprar.ButtonTextMarginLeft = 0;
            this.btnComprar.ColorContrastOnClick = 45;
            this.btnComprar.ColorContrastOnHover = 45;
            this.btnComprar.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnComprar.CustomizableEdges = borderEdges1;
            this.btnComprar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnComprar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnComprar.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnComprar.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnComprar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btnComprar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.ForeColor = System.Drawing.Color.White;
            this.btnComprar.IconLeft = null;
            this.btnComprar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComprar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnComprar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnComprar.IconMarginLeft = 11;
            this.btnComprar.IconPadding = 10;
            this.btnComprar.IconRight = null;
            this.btnComprar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComprar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnComprar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnComprar.IconSize = 25;
            this.btnComprar.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnComprar.IdleBorderRadius = 0;
            this.btnComprar.IdleBorderThickness = 0;
            this.btnComprar.IdleFillColor = System.Drawing.Color.Empty;
            this.btnComprar.IdleIconLeftImage = null;
            this.btnComprar.IdleIconRightImage = null;
            this.btnComprar.IndicateFocus = false;
            this.btnComprar.Location = new System.Drawing.Point(640, 172);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnComprar.OnDisabledState.BorderRadius = 12;
            this.btnComprar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnComprar.OnDisabledState.BorderThickness = 1;
            this.btnComprar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnComprar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnComprar.OnDisabledState.IconLeftImage = null;
            this.btnComprar.OnDisabledState.IconRightImage = null;
            this.btnComprar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.btnComprar.onHoverState.BorderRadius = 12;
            this.btnComprar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnComprar.onHoverState.BorderThickness = 1;
            this.btnComprar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.btnComprar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnComprar.onHoverState.IconLeftImage = null;
            this.btnComprar.onHoverState.IconRightImage = null;
            this.btnComprar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.btnComprar.OnIdleState.BorderRadius = 12;
            this.btnComprar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnComprar.OnIdleState.BorderThickness = 1;
            this.btnComprar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.btnComprar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnComprar.OnIdleState.IconLeftImage = null;
            this.btnComprar.OnIdleState.IconRightImage = null;
            this.btnComprar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.btnComprar.OnPressedState.BorderRadius = 12;
            this.btnComprar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnComprar.OnPressedState.BorderThickness = 1;
            this.btnComprar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.btnComprar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnComprar.OnPressedState.IconLeftImage = null;
            this.btnComprar.OnPressedState.IconRightImage = null;
            this.btnComprar.Size = new System.Drawing.Size(170, 59);
            this.btnComprar.TabIndex = 10;
            this.btnComprar.TabStop = false;
            this.btnComprar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnComprar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnComprar.TextMarginLeft = 0;
            this.btnComprar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnComprar.UseDefaultRadiusAndThickness = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Maroon;
            this.lblError.Location = new System.Drawing.Point(637, 127);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(29, 13);
            this.lblError.TabIndex = 11;
            this.lblError.Text = "Error";
            this.lblError.Visible = false;
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
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 70;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 70;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 120;
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(841, 460);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.dgvStock);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Name = "Compras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStock;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnComprar;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
    }
}