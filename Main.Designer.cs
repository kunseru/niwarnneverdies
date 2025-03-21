namespace niwarnneverdies
{
	partial class Main
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
			Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
			Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
			Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
			this.mainDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.MainTop = new Bunifu.UI.WinForms.BunifuGradientPanel();
			this.MinimizeButton = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
			this.CloseButton = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
			this.mainNotifications = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
			this.Creator = new Bunifu.UI.WinForms.BunifuLabel();
			this.MainProgressBar = new Bunifu.UI.WinForms.BunifuProgressBar();
			this.RestoreGameButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
			this.PatchGameButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
			this.MainTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// mainDragControl
			// 
			this.mainDragControl.Fixed = true;
			this.mainDragControl.Horizontal = true;
			this.mainDragControl.TargetControl = this.MainTop;
			this.mainDragControl.Vertical = true;
			// 
			// MainTop
			// 
			this.MainTop.BackColor = System.Drawing.Color.Transparent;
			this.MainTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainTop.BackgroundImage")));
			this.MainTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.MainTop.BorderRadius = 15;
			this.MainTop.Controls.Add(this.MinimizeButton);
			this.MainTop.Controls.Add(this.CloseButton);
			this.MainTop.Controls.Add(this.pictureBox1);
			this.MainTop.Controls.Add(this.bunifuLabel1);
			this.MainTop.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
			this.MainTop.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
			this.MainTop.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
			this.MainTop.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
			this.MainTop.Location = new System.Drawing.Point(-21, -5);
			this.MainTop.Name = "MainTop";
			this.MainTop.Quality = 10;
			this.MainTop.Size = new System.Drawing.Size(449, 35);
			this.MainTop.TabIndex = 0;
			// 
			// MinimizeButton
			// 
			this.MinimizeButton.AllowAnimations = true;
			this.MinimizeButton.AllowBorderColorChanges = true;
			this.MinimizeButton.AllowMouseEffects = true;
			this.MinimizeButton.AnimationSpeed = 200;
			this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
			this.MinimizeButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(189)))), ((int)(((byte)(47)))));
			this.MinimizeButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(189)))), ((int)(((byte)(47)))));
			this.MinimizeButton.BorderRadius = 1;
			this.MinimizeButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
			this.MinimizeButton.BorderThickness = 1;
			this.MinimizeButton.ColorContrastOnClick = 30;
			this.MinimizeButton.ColorContrastOnHover = 30;
			this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Default;
			borderEdges1.BottomLeft = true;
			borderEdges1.BottomRight = true;
			borderEdges1.TopLeft = true;
			borderEdges1.TopRight = true;
			this.MinimizeButton.CustomizableEdges = borderEdges1;
			this.MinimizeButton.DialogResult = System.Windows.Forms.DialogResult.None;
			this.MinimizeButton.Image = global::niwarnneverdies.Properties.Resources.minimize_new;
			this.MinimizeButton.ImageMargin = new System.Windows.Forms.Padding(0);
			this.MinimizeButton.Location = new System.Drawing.Point(355, 8);
			this.MinimizeButton.Name = "MinimizeButton";
			this.MinimizeButton.RoundBorders = true;
			this.MinimizeButton.ShowBorders = true;
			this.MinimizeButton.Size = new System.Drawing.Size(24, 24);
			this.MinimizeButton.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
			this.MinimizeButton.TabIndex = 6;
			this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
			// 
			// CloseButton
			// 
			this.CloseButton.AllowAnimations = true;
			this.CloseButton.AllowBorderColorChanges = true;
			this.CloseButton.AllowMouseEffects = true;
			this.CloseButton.AnimationSpeed = 200;
			this.CloseButton.BackColor = System.Drawing.Color.Transparent;
			this.CloseButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(87)))), ((int)(((byte)(82)))));
			this.CloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(87)))), ((int)(((byte)(82)))));
			this.CloseButton.BorderRadius = 1;
			this.CloseButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
			this.CloseButton.BorderThickness = 1;
			this.CloseButton.ColorContrastOnClick = 30;
			this.CloseButton.ColorContrastOnHover = 30;
			this.CloseButton.Cursor = System.Windows.Forms.Cursors.Default;
			borderEdges2.BottomLeft = true;
			borderEdges2.BottomRight = true;
			borderEdges2.TopLeft = true;
			borderEdges2.TopRight = true;
			this.CloseButton.CustomizableEdges = borderEdges2;
			this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.None;
			this.CloseButton.Image = global::niwarnneverdies.Properties.Resources.close_new;
			this.CloseButton.ImageMargin = new System.Windows.Forms.Padding(0);
			this.CloseButton.Location = new System.Drawing.Point(385, 8);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.RoundBorders = true;
			this.CloseButton.ShowBorders = true;
			this.CloseButton.Size = new System.Drawing.Size(24, 24);
			this.CloseButton.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
			this.CloseButton.TabIndex = 5;
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::niwarnneverdies.Properties.Resources.nnd_logo;
			this.pictureBox1.Location = new System.Drawing.Point(30, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(24, 24);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// bunifuLabel1
			// 
			this.bunifuLabel1.AllowParentOverrides = false;
			this.bunifuLabel1.AutoEllipsis = false;
			this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
			this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
			this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
			this.bunifuLabel1.Location = new System.Drawing.Point(60, 9);
			this.bunifuLabel1.Name = "bunifuLabel1";
			this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.bunifuLabel1.Size = new System.Drawing.Size(131, 21);
			this.bunifuLabel1.TabIndex = 0;
			this.bunifuLabel1.Text = "Niwarn Never Dies";
			this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
			// 
			// mainNotifications
			// 
			this.mainNotifications.AllowDragging = false;
			this.mainNotifications.AllowMultipleViews = true;
			this.mainNotifications.ClickToClose = true;
			this.mainNotifications.DoubleClickToClose = true;
			this.mainNotifications.DurationAfterIdle = 3000;
			this.mainNotifications.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.mainNotifications.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.mainNotifications.ErrorOptions.ActionBorderRadius = 1;
			this.mainNotifications.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
			this.mainNotifications.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
			this.mainNotifications.ErrorOptions.BackColor = System.Drawing.Color.White;
			this.mainNotifications.ErrorOptions.BorderColor = System.Drawing.Color.White;
			this.mainNotifications.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
			this.mainNotifications.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.mainNotifications.ErrorOptions.ForeColor = System.Drawing.Color.Black;
			this.mainNotifications.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
			this.mainNotifications.ErrorOptions.IconLeftMargin = 12;
			this.mainNotifications.FadeCloseIcon = false;
			this.mainNotifications.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
			this.mainNotifications.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.mainNotifications.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.mainNotifications.InformationOptions.ActionBorderRadius = 1;
			this.mainNotifications.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
			this.mainNotifications.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
			this.mainNotifications.InformationOptions.BackColor = System.Drawing.Color.White;
			this.mainNotifications.InformationOptions.BorderColor = System.Drawing.Color.White;
			this.mainNotifications.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
			this.mainNotifications.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.mainNotifications.InformationOptions.ForeColor = System.Drawing.Color.Black;
			this.mainNotifications.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
			this.mainNotifications.InformationOptions.IconLeftMargin = 12;
			this.mainNotifications.Margin = 10;
			this.mainNotifications.MaximumSize = new System.Drawing.Size(0, 0);
			this.mainNotifications.MaximumViews = 7;
			this.mainNotifications.MessageRightMargin = 15;
			this.mainNotifications.MinimumSize = new System.Drawing.Size(0, 0);
			this.mainNotifications.ShowBorders = false;
			this.mainNotifications.ShowCloseIcon = false;
			this.mainNotifications.ShowIcon = true;
			this.mainNotifications.ShowShadows = true;
			this.mainNotifications.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.mainNotifications.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.mainNotifications.SuccessOptions.ActionBorderRadius = 1;
			this.mainNotifications.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
			this.mainNotifications.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
			this.mainNotifications.SuccessOptions.BackColor = System.Drawing.Color.White;
			this.mainNotifications.SuccessOptions.BorderColor = System.Drawing.Color.White;
			this.mainNotifications.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
			this.mainNotifications.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.mainNotifications.SuccessOptions.ForeColor = System.Drawing.Color.Black;
			this.mainNotifications.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
			this.mainNotifications.SuccessOptions.IconLeftMargin = 12;
			this.mainNotifications.ViewsMargin = 7;
			this.mainNotifications.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.mainNotifications.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.mainNotifications.WarningOptions.ActionBorderRadius = 1;
			this.mainNotifications.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
			this.mainNotifications.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
			this.mainNotifications.WarningOptions.BackColor = System.Drawing.Color.White;
			this.mainNotifications.WarningOptions.BorderColor = System.Drawing.Color.White;
			this.mainNotifications.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
			this.mainNotifications.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.mainNotifications.WarningOptions.ForeColor = System.Drawing.Color.Black;
			this.mainNotifications.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
			this.mainNotifications.WarningOptions.IconLeftMargin = 12;
			this.mainNotifications.ZoomCloseIcon = true;
			// 
			// Creator
			// 
			this.Creator.AllowParentOverrides = false;
			this.Creator.AutoEllipsis = false;
			this.Creator.Cursor = System.Windows.Forms.Cursors.Default;
			this.Creator.CursorType = System.Windows.Forms.Cursors.Default;
			this.Creator.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.Creator.ForeColor = System.Drawing.Color.White;
			this.Creator.Location = new System.Drawing.Point(274, 36);
			this.Creator.Name = "Creator";
			this.Creator.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Creator.Size = new System.Drawing.Size(103, 15);
			this.Creator.TabIndex = 4;
			this.Creator.Text = "Created  by Kunseru";
			this.Creator.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.Creator.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
			this.Creator.Click += new System.EventHandler(this.Creator_Click);
			// 
			// MainProgressBar
			// 
			this.MainProgressBar.AllowAnimations = false;
			this.MainProgressBar.Animation = 0;
			this.MainProgressBar.AnimationSpeed = 220;
			this.MainProgressBar.AnimationStep = 10;
			this.MainProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
			this.MainProgressBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainProgressBar.BackgroundImage")));
			this.MainProgressBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
			this.MainProgressBar.BorderRadius = 9;
			this.MainProgressBar.BorderThickness = 1;
			this.MainProgressBar.Location = new System.Drawing.Point(-7, 192);
			this.MainProgressBar.Maximum = 100;
			this.MainProgressBar.MaximumValue = 100;
			this.MainProgressBar.Minimum = 0;
			this.MainProgressBar.MinimumValue = 0;
			this.MainProgressBar.Name = "MainProgressBar";
			this.MainProgressBar.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.MainProgressBar.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
			this.MainProgressBar.ProgressColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
			this.MainProgressBar.ProgressColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
			this.MainProgressBar.Size = new System.Drawing.Size(435, 29);
			this.MainProgressBar.TabIndex = 3;
			this.MainProgressBar.Value = 0;
			this.MainProgressBar.ValueByTransition = 0;
			// 
			// RestoreGameButton
			// 
			this.RestoreGameButton.AllowAnimations = true;
			this.RestoreGameButton.AllowMouseEffects = true;
			this.RestoreGameButton.AllowToggling = false;
			this.RestoreGameButton.AnimationSpeed = 200;
			this.RestoreGameButton.AutoGenerateColors = false;
			this.RestoreGameButton.AutoRoundBorders = false;
			this.RestoreGameButton.AutoSizeLeftIcon = true;
			this.RestoreGameButton.AutoSizeRightIcon = true;
			this.RestoreGameButton.BackColor = System.Drawing.Color.Transparent;
			this.RestoreGameButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
			this.RestoreGameButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RestoreGameButton.BackgroundImage")));
			this.RestoreGameButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
			this.RestoreGameButton.ButtonText = "Restore Game";
			this.RestoreGameButton.ButtonTextMarginLeft = 0;
			this.RestoreGameButton.ColorContrastOnClick = 45;
			this.RestoreGameButton.ColorContrastOnHover = 45;
			this.RestoreGameButton.Cursor = System.Windows.Forms.Cursors.Default;
			borderEdges3.BottomLeft = true;
			borderEdges3.BottomRight = true;
			borderEdges3.TopLeft = true;
			borderEdges3.TopRight = true;
			this.RestoreGameButton.CustomizableEdges = borderEdges3;
			this.RestoreGameButton.DialogResult = System.Windows.Forms.DialogResult.None;
			this.RestoreGameButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.RestoreGameButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.RestoreGameButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.RestoreGameButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
			this.RestoreGameButton.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.RestoreGameButton.ForeColor = System.Drawing.Color.White;
			this.RestoreGameButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.RestoreGameButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
			this.RestoreGameButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
			this.RestoreGameButton.IconMarginLeft = 11;
			this.RestoreGameButton.IconPadding = 10;
			this.RestoreGameButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.RestoreGameButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
			this.RestoreGameButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
			this.RestoreGameButton.IconSize = 25;
			this.RestoreGameButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
			this.RestoreGameButton.IdleBorderRadius = 15;
			this.RestoreGameButton.IdleBorderThickness = 1;
			this.RestoreGameButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
			this.RestoreGameButton.IdleIconLeftImage = null;
			this.RestoreGameButton.IdleIconRightImage = null;
			this.RestoreGameButton.IndicateFocus = false;
			this.RestoreGameButton.Location = new System.Drawing.Point(230, 128);
			this.RestoreGameButton.Name = "RestoreGameButton";
			this.RestoreGameButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.RestoreGameButton.OnDisabledState.BorderRadius = 15;
			this.RestoreGameButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
			this.RestoreGameButton.OnDisabledState.BorderThickness = 1;
			this.RestoreGameButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.RestoreGameButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.RestoreGameButton.OnDisabledState.IconLeftImage = null;
			this.RestoreGameButton.OnDisabledState.IconRightImage = null;
			this.RestoreGameButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.RestoreGameButton.onHoverState.BorderRadius = 15;
			this.RestoreGameButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
			this.RestoreGameButton.onHoverState.BorderThickness = 1;
			this.RestoreGameButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.RestoreGameButton.onHoverState.ForeColor = System.Drawing.Color.White;
			this.RestoreGameButton.onHoverState.IconLeftImage = null;
			this.RestoreGameButton.onHoverState.IconRightImage = null;
			this.RestoreGameButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
			this.RestoreGameButton.OnIdleState.BorderRadius = 15;
			this.RestoreGameButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
			this.RestoreGameButton.OnIdleState.BorderThickness = 1;
			this.RestoreGameButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
			this.RestoreGameButton.OnIdleState.ForeColor = System.Drawing.Color.White;
			this.RestoreGameButton.OnIdleState.IconLeftImage = null;
			this.RestoreGameButton.OnIdleState.IconRightImage = null;
			this.RestoreGameButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			this.RestoreGameButton.OnPressedState.BorderRadius = 15;
			this.RestoreGameButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
			this.RestoreGameButton.OnPressedState.BorderThickness = 1;
			this.RestoreGameButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			this.RestoreGameButton.OnPressedState.ForeColor = System.Drawing.Color.White;
			this.RestoreGameButton.OnPressedState.IconLeftImage = null;
			this.RestoreGameButton.OnPressedState.IconRightImage = null;
			this.RestoreGameButton.Size = new System.Drawing.Size(128, 35);
			this.RestoreGameButton.TabIndex = 2;
			this.RestoreGameButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.RestoreGameButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.RestoreGameButton.TextMarginLeft = 0;
			this.RestoreGameButton.TextPadding = new System.Windows.Forms.Padding(0);
			this.RestoreGameButton.UseDefaultRadiusAndThickness = true;
			this.RestoreGameButton.Click += new System.EventHandler(this.RestoreGameButton_Click);
			// 
			// PatchGameButton
			// 
			this.PatchGameButton.AllowAnimations = true;
			this.PatchGameButton.AllowMouseEffects = true;
			this.PatchGameButton.AllowToggling = false;
			this.PatchGameButton.AnimationSpeed = 200;
			this.PatchGameButton.AutoGenerateColors = false;
			this.PatchGameButton.AutoRoundBorders = false;
			this.PatchGameButton.AutoSizeLeftIcon = true;
			this.PatchGameButton.AutoSizeRightIcon = true;
			this.PatchGameButton.BackColor = System.Drawing.Color.Transparent;
			this.PatchGameButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
			this.PatchGameButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PatchGameButton.BackgroundImage")));
			this.PatchGameButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
			this.PatchGameButton.ButtonText = "Patch Game";
			this.PatchGameButton.ButtonTextMarginLeft = 0;
			this.PatchGameButton.ColorContrastOnClick = 45;
			this.PatchGameButton.ColorContrastOnHover = 45;
			this.PatchGameButton.Cursor = System.Windows.Forms.Cursors.Default;
			borderEdges4.BottomLeft = true;
			borderEdges4.BottomRight = true;
			borderEdges4.TopLeft = true;
			borderEdges4.TopRight = true;
			this.PatchGameButton.CustomizableEdges = borderEdges4;
			this.PatchGameButton.DialogResult = System.Windows.Forms.DialogResult.None;
			this.PatchGameButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.PatchGameButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.PatchGameButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.PatchGameButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
			this.PatchGameButton.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.PatchGameButton.ForeColor = System.Drawing.Color.White;
			this.PatchGameButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.PatchGameButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
			this.PatchGameButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
			this.PatchGameButton.IconMarginLeft = 11;
			this.PatchGameButton.IconPadding = 10;
			this.PatchGameButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.PatchGameButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
			this.PatchGameButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
			this.PatchGameButton.IconSize = 25;
			this.PatchGameButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
			this.PatchGameButton.IdleBorderRadius = 15;
			this.PatchGameButton.IdleBorderThickness = 1;
			this.PatchGameButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
			this.PatchGameButton.IdleIconLeftImage = null;
			this.PatchGameButton.IdleIconRightImage = null;
			this.PatchGameButton.IndicateFocus = false;
			this.PatchGameButton.Location = new System.Drawing.Point(42, 128);
			this.PatchGameButton.Name = "PatchGameButton";
			this.PatchGameButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.PatchGameButton.OnDisabledState.BorderRadius = 15;
			this.PatchGameButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
			this.PatchGameButton.OnDisabledState.BorderThickness = 1;
			this.PatchGameButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.PatchGameButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
			this.PatchGameButton.OnDisabledState.IconLeftImage = null;
			this.PatchGameButton.OnDisabledState.IconRightImage = null;
			this.PatchGameButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.PatchGameButton.onHoverState.BorderRadius = 15;
			this.PatchGameButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
			this.PatchGameButton.onHoverState.BorderThickness = 1;
			this.PatchGameButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
			this.PatchGameButton.onHoverState.ForeColor = System.Drawing.Color.White;
			this.PatchGameButton.onHoverState.IconLeftImage = null;
			this.PatchGameButton.onHoverState.IconRightImage = null;
			this.PatchGameButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
			this.PatchGameButton.OnIdleState.BorderRadius = 15;
			this.PatchGameButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
			this.PatchGameButton.OnIdleState.BorderThickness = 1;
			this.PatchGameButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
			this.PatchGameButton.OnIdleState.ForeColor = System.Drawing.Color.White;
			this.PatchGameButton.OnIdleState.IconLeftImage = null;
			this.PatchGameButton.OnIdleState.IconRightImage = null;
			this.PatchGameButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			this.PatchGameButton.OnPressedState.BorderRadius = 15;
			this.PatchGameButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
			this.PatchGameButton.OnPressedState.BorderThickness = 1;
			this.PatchGameButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
			this.PatchGameButton.OnPressedState.ForeColor = System.Drawing.Color.White;
			this.PatchGameButton.OnPressedState.IconLeftImage = null;
			this.PatchGameButton.OnPressedState.IconRightImage = null;
			this.PatchGameButton.Size = new System.Drawing.Size(128, 35);
			this.PatchGameButton.TabIndex = 1;
			this.PatchGameButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.PatchGameButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.PatchGameButton.TextMarginLeft = 0;
			this.PatchGameButton.TextPadding = new System.Windows.Forms.Padding(0);
			this.PatchGameButton.UseDefaultRadiusAndThickness = true;
			this.PatchGameButton.Click += new System.EventHandler(this.PatchGameButton_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
			this.BorderRadius = 15;
			this.ClientSize = new System.Drawing.Size(414, 248);
			this.Controls.Add(this.Creator);
			this.Controls.Add(this.MainProgressBar);
			this.Controls.Add(this.RestoreGameButton);
			this.Controls.Add(this.PatchGameButton);
			this.Controls.Add(this.MainTop);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Main";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
			this.MainTop.ResumeLayout(false);
			this.MainTop.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public Bunifu.Framework.UI.BunifuDragControl mainDragControl;
		private Bunifu.UI.WinForms.BunifuGradientPanel MainTop;
		private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 PatchGameButton;
		private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 RestoreGameButton;
		private Bunifu.UI.WinForms.BunifuProgressBar MainProgressBar;
		public Bunifu.UI.WinForms.BunifuSnackbar mainNotifications;
		private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private Bunifu.UI.WinForms.BunifuLabel Creator;
		private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton CloseButton;
		private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton MinimizeButton;
	}
}

