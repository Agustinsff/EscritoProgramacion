
namespace CapaVisual
{
    partial class Login
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation1 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.ElipseLogin = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelTop = new System.Windows.Forms.Panel();
            this.DragControlLogin = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnIngresar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtPass = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtUser = new Bunifu.UI.WinForms.BunifuTextBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.transicionBienvenida = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.panelBienvenida = new System.Windows.Forms.Panel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pbCargando = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timerBienvenida = new System.Windows.Forms.Timer(this.components);
            this.panelLogin.SuspendLayout();
            this.panelBienvenida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCargando)).BeginInit();
            this.SuspendLayout();
            // 
            // ElipseLogin
            // 
            this.ElipseLogin.ElipseRadius = 12;
            this.ElipseLogin.TargetControl = this;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.transicionBienvenida.SetDecoration(this.panelTop, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1280, 25);
            this.panelTop.TabIndex = 38;
            // 
            // DragControlLogin
            // 
            this.DragControlLogin.Fixed = true;
            this.DragControlLogin.Horizontal = true;
            this.DragControlLogin.TargetControl = this.panelTop;
            this.DragControlLogin.Vertical = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.transicionBienvenida.SetDecoration(this.label1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 40);
            this.label1.TabIndex = 39;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.transicionBienvenida.SetDecoration(this.lblError, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Maroon;
            this.lblError.Location = new System.Drawing.Point(18, 227);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(38, 17);
            this.lblError.TabIndex = 43;
            this.lblError.Text = "Error";
            this.lblError.Visible = false;
            // 
            // btnIngresar
            // 
            this.btnIngresar.AllowAnimations = true;
            this.btnIngresar.AllowMouseEffects = true;
            this.btnIngresar.AllowToggling = false;
            this.btnIngresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIngresar.AnimationSpeed = 200;
            this.btnIngresar.AutoGenerateColors = false;
            this.btnIngresar.AutoRoundBorders = false;
            this.btnIngresar.AutoSizeLeftIcon = true;
            this.btnIngresar.AutoSizeRightIcon = true;
            this.btnIngresar.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIngresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIngresar.BackgroundImage")));
            this.btnIngresar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnIngresar.ButtonText = "Ingresar";
            this.btnIngresar.ButtonTextMarginLeft = 0;
            this.btnIngresar.ColorContrastOnClick = 45;
            this.btnIngresar.ColorContrastOnHover = 45;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnIngresar.CustomizableEdges = borderEdges1;
            this.transicionBienvenida.SetDecoration(this.btnIngresar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnIngresar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnIngresar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnIngresar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnIngresar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnIngresar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Hover;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnIngresar.ForeColor = System.Drawing.Color.Gray;
            this.btnIngresar.IconLeft = null;
            this.btnIngresar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnIngresar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnIngresar.IconMarginLeft = 11;
            this.btnIngresar.IconPadding = 10;
            this.btnIngresar.IconRight = null;
            this.btnIngresar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIngresar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnIngresar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnIngresar.IconSize = 25;
            this.btnIngresar.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIngresar.IdleBorderRadius = 34;
            this.btnIngresar.IdleBorderThickness = 2;
            this.btnIngresar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIngresar.IdleIconLeftImage = null;
            this.btnIngresar.IdleIconRightImage = null;
            this.btnIngresar.IndicateFocus = false;
            this.btnIngresar.Location = new System.Drawing.Point(21, 296);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnIngresar.OnDisabledState.BorderRadius = 34;
            this.btnIngresar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnIngresar.OnDisabledState.BorderThickness = 2;
            this.btnIngresar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnIngresar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnIngresar.OnDisabledState.IconLeftImage = null;
            this.btnIngresar.OnDisabledState.IconRightImage = null;
            this.btnIngresar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIngresar.onHoverState.BorderRadius = 34;
            this.btnIngresar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnIngresar.onHoverState.BorderThickness = 2;
            this.btnIngresar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIngresar.onHoverState.ForeColor = System.Drawing.Color.Gray;
            this.btnIngresar.onHoverState.IconLeftImage = null;
            this.btnIngresar.onHoverState.IconRightImage = null;
            this.btnIngresar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIngresar.OnIdleState.BorderRadius = 34;
            this.btnIngresar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnIngresar.OnIdleState.BorderThickness = 2;
            this.btnIngresar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIngresar.OnIdleState.ForeColor = System.Drawing.Color.Gray;
            this.btnIngresar.OnIdleState.IconLeftImage = null;
            this.btnIngresar.OnIdleState.IconRightImage = null;
            this.btnIngresar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIngresar.OnPressedState.BorderRadius = 34;
            this.btnIngresar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnIngresar.OnPressedState.BorderThickness = 2;
            this.btnIngresar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIngresar.OnPressedState.ForeColor = System.Drawing.Color.Gray;
            this.btnIngresar.OnPressedState.IconLeftImage = null;
            this.btnIngresar.OnPressedState.IconRightImage = null;
            this.btnIngresar.Size = new System.Drawing.Size(260, 39);
            this.btnIngresar.TabIndex = 42;
            this.btnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIngresar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnIngresar.TextMarginLeft = 0;
            this.btnIngresar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnIngresar.UseDefaultRadiusAndThickness = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtPass
            // 
            this.txtPass.AcceptsReturn = false;
            this.txtPass.AcceptsTab = false;
            this.txtPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPass.AnimationSpeed = 200;
            this.txtPass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPass.AutoSizeHeight = true;
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(98)))));
            this.txtPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPass.BackgroundImage")));
            this.txtPass.BorderColorActive = System.Drawing.Color.Gray;
            this.txtPass.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtPass.BorderColorHover = System.Drawing.Color.DarkGray;
            this.txtPass.BorderColorIdle = System.Drawing.Color.DimGray;
            this.txtPass.BorderRadius = 1;
            this.txtPass.BorderThickness = 1;
            this.txtPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transicionBienvenida.SetDecoration(this.txtPass, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.txtPass.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtPass.DefaultText = "";
            this.txtPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(98)))));
            this.txtPass.ForeColor = System.Drawing.Color.Silver;
            this.txtPass.HideSelection = true;
            this.txtPass.IconLeft = null;
            this.txtPass.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.IconPadding = 10;
            this.txtPass.IconRight = null;
            this.txtPass.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.Lines = new string[0];
            this.txtPass.Location = new System.Drawing.Point(21, 174);
            this.txtPass.MaxLength = 32767;
            this.txtPass.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPass.Modified = false;
            this.txtPass.Multiline = false;
            this.txtPass.Name = "txtPass";
            stateProperties1.BorderColor = System.Drawing.Color.Gray;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPass.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPass.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.DarkGray;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPass.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.DimGray;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(91)))), ((int)(((byte)(98)))));
            stateProperties4.ForeColor = System.Drawing.Color.Silver;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPass.OnIdleState = stateProperties4;
            this.txtPass.Padding = new System.Windows.Forms.Padding(3);
            this.txtPass.PasswordChar = '\0';
            this.txtPass.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPass.PlaceholderText = "Constraseña";
            this.txtPass.ReadOnly = false;
            this.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.ShortcutsEnabled = true;
            this.txtPass.Size = new System.Drawing.Size(260, 37);
            this.txtPass.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txtPass.TabIndex = 41;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPass.TextMarginBottom = 0;
            this.txtPass.TextMarginLeft = 3;
            this.txtPass.TextMarginTop = 0;
            this.txtPass.TextPlaceholder = "Constraseña";
            this.txtPass.UseSystemPasswordChar = false;
            this.txtPass.WordWrap = true;
            // 
            // txtUser
            // 
            this.txtUser.AcceptsReturn = false;
            this.txtUser.AcceptsTab = false;
            this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUser.AnimationSpeed = 200;
            this.txtUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUser.AutoSizeHeight = true;
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.txtUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtUser.BackgroundImage")));
            this.txtUser.BorderColorActive = System.Drawing.Color.Gray;
            this.txtUser.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtUser.BorderColorHover = System.Drawing.Color.DarkGray;
            this.txtUser.BorderColorIdle = System.Drawing.Color.DimGray;
            this.txtUser.BorderRadius = 1;
            this.txtUser.BorderThickness = 1;
            this.txtUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transicionBienvenida.SetDecoration(this.txtUser, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.txtUser.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtUser.DefaultText = "";
            this.txtUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.txtUser.ForeColor = System.Drawing.Color.Silver;
            this.txtUser.HideSelection = true;
            this.txtUser.IconLeft = null;
            this.txtUser.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.IconPadding = 10;
            this.txtUser.IconRight = null;
            this.txtUser.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.Lines = new string[0];
            this.txtUser.Location = new System.Drawing.Point(21, 91);
            this.txtUser.MaxLength = 32767;
            this.txtUser.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtUser.Modified = false;
            this.txtUser.Multiline = false;
            this.txtUser.Name = "txtUser";
            stateProperties5.BorderColor = System.Drawing.Color.Gray;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUser.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtUser.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.DarkGray;
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUser.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.DimGray;
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            stateProperties8.ForeColor = System.Drawing.Color.Silver;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUser.OnIdleState = stateProperties8;
            this.txtUser.Padding = new System.Windows.Forms.Padding(3);
            this.txtUser.PasswordChar = '\0';
            this.txtUser.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtUser.PlaceholderText = "Usuario";
            this.txtUser.ReadOnly = false;
            this.txtUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.ShortcutsEnabled = true;
            this.txtUser.Size = new System.Drawing.Size(260, 37);
            this.txtUser.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txtUser.TabIndex = 40;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUser.TextMarginBottom = 0;
            this.txtUser.TextMarginLeft = 3;
            this.txtUser.TextMarginTop = 0;
            this.txtUser.TextPlaceholder = "Usuario";
            this.txtUser.UseSystemPasswordChar = false;
            this.txtUser.WordWrap = true;
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.Transparent;
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.txtPass);
            this.panelLogin.Controls.Add(this.lblError);
            this.panelLogin.Controls.Add(this.btnIngresar);
            this.panelLogin.Controls.Add(this.txtUser);
            this.transicionBienvenida.SetDecoration(this.panelLogin, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panelLogin.Location = new System.Drawing.Point(498, 172);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(300, 342);
            this.panelLogin.TabIndex = 44;
            // 
            // transicionBienvenida
            // 
            this.transicionBienvenida.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.Transparent;
            this.transicionBienvenida.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.transicionBienvenida.DefaultAnimation = animation1;
            // 
            // panelBienvenida
            // 
            this.panelBienvenida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelBienvenida.BackColor = System.Drawing.Color.Transparent;
            this.panelBienvenida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelBienvenida.Controls.Add(this.bunifuLabel5);
            this.panelBienvenida.Controls.Add(this.pbCargando);
            this.transicionBienvenida.SetDecoration(this.panelBienvenida, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panelBienvenida.ForeColor = System.Drawing.Color.White;
            this.panelBienvenida.Location = new System.Drawing.Point(839, 93);
            this.panelBienvenida.Name = "panelBienvenida";
            this.panelBienvenida.Size = new System.Drawing.Size(195, 218);
            this.panelBienvenida.TabIndex = 45;
            this.panelBienvenida.Visible = false;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.CursorType = null;
            this.transicionBienvenida.SetDecoration(this.bunifuLabel5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel5.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuLabel5.Location = new System.Drawing.Point(3, 165);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(189, 50);
            this.bunifuLabel5.TabIndex = 36;
            this.bunifuLabel5.Text = "Bienvenido";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pbCargando
            // 
            this.pbCargando.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbCargando.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.transicionBienvenida.SetDecoration(this.pbCargando, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pbCargando.Image = ((System.Drawing.Image)(resources.GetObject("pbCargando.Image")));
            this.pbCargando.Location = new System.Drawing.Point(21, 3);
            this.pbCargando.Name = "pbCargando";
            this.pbCargando.Size = new System.Drawing.Size(156, 156);
            this.pbCargando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCargando.TabIndex = 1;
            this.pbCargando.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.transicionBienvenida.SetDecoration(this.label2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1091, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 80);
            this.label2.TabIndex = 44;
            this.label2.Text = "User: admin\r\nPass: admin";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timerBienvenida
            // 
            this.timerBienvenida.Interval = 10;
            this.timerBienvenida.Tick += new System.EventHandler(this.timerBienvenida_Tick);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelBienvenida);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelTop);
            this.transicionBienvenida.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1024, 576);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelBienvenida.ResumeLayout(false);
            this.panelBienvenida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCargando)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ElipseLogin;
        private System.Windows.Forms.Panel panelTop;
        private Bunifu.Framework.UI.BunifuDragControl DragControlLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblError;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnIngresar;
        private Bunifu.UI.WinForms.BunifuTextBox txtPass;
        private Bunifu.UI.WinForms.BunifuTextBox txtUser;
        private System.Windows.Forms.Panel panelLogin;
        private Bunifu.UI.WinForms.BunifuTransition transicionBienvenida;
        private System.Windows.Forms.Timer timerBienvenida;
        private System.Windows.Forms.Panel panelBienvenida;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private System.Windows.Forms.PictureBox pbCargando;
        private System.Windows.Forms.Label label2;
    }
}