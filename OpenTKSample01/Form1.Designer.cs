namespace OpenTKSample01
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.glControl1 = new OpenTK.GLControl();
            this.trbEyeX = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEyeX = new System.Windows.Forms.Label();
            this.lblEyeY = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trbEyeY = new System.Windows.Forms.TrackBar();
            this.lblEyeZ = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trbEyeZ = new System.Windows.Forms.TrackBar();
            this.lblUpZ = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.trbUpZ = new System.Windows.Forms.TrackBar();
            this.lblUpY = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.trbUpY = new System.Windows.Forms.TrackBar();
            this.lblUpX = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.trbUpX = new System.Windows.Forms.TrackBar();
            this.lblTargetZ = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.trbTargetZ = new System.Windows.Forms.TrackBar();
            this.lblTargetY = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.trbTargetY = new System.Windows.Forms.TrackBar();
            this.lblTargetX = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.trbTargetX = new System.Windows.Forms.TrackBar();
            this.lblFovy = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trbFovy = new System.Windows.Forms.TrackBar();
            this.btnReset = new System.Windows.Forms.Button();
            this.chkInterlock = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trbEyeX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbEyeY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbEyeZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbUpZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbUpY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbUpX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbTargetZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbTargetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbTargetX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbFovy)).BeginInit();
            this.SuspendLayout();
            // 
            // glControl1
            // 
            this.glControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.glControl1.AutoSize = true;
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(0, 0);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(624, 376);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = false;
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            // 
            // trbEyeX
            // 
            this.trbEyeX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trbEyeX.AutoSize = false;
            this.trbEyeX.Location = new System.Drawing.Point(40, 376);
            this.trbEyeX.Maximum = 1000;
            this.trbEyeX.Minimum = -1000;
            this.trbEyeX.Name = "trbEyeX";
            this.trbEyeX.Size = new System.Drawing.Size(128, 24);
            this.trbEyeX.TabIndex = 1;
            this.trbEyeX.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbEyeX.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Location = new System.Drawing.Point(0, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "EyeX";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEyeX
            // 
            this.lblEyeX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEyeX.Location = new System.Drawing.Point(168, 376);
            this.lblEyeX.Name = "lblEyeX";
            this.lblEyeX.Size = new System.Drawing.Size(32, 24);
            this.lblEyeX.TabIndex = 3;
            this.lblEyeX.Text = "000";
            this.lblEyeX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEyeY
            // 
            this.lblEyeY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEyeY.Location = new System.Drawing.Point(168, 400);
            this.lblEyeY.Name = "lblEyeY";
            this.lblEyeY.Size = new System.Drawing.Size(32, 24);
            this.lblEyeY.TabIndex = 6;
            this.lblEyeY.Text = "000";
            this.lblEyeY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.Location = new System.Drawing.Point(0, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "EyeY";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trbEyeY
            // 
            this.trbEyeY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trbEyeY.AutoSize = false;
            this.trbEyeY.Location = new System.Drawing.Point(40, 400);
            this.trbEyeY.Maximum = 1000;
            this.trbEyeY.Minimum = -1000;
            this.trbEyeY.Name = "trbEyeY";
            this.trbEyeY.Size = new System.Drawing.Size(128, 24);
            this.trbEyeY.TabIndex = 4;
            this.trbEyeY.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbEyeY.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // lblEyeZ
            // 
            this.lblEyeZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEyeZ.Location = new System.Drawing.Point(168, 424);
            this.lblEyeZ.Name = "lblEyeZ";
            this.lblEyeZ.Size = new System.Drawing.Size(32, 24);
            this.lblEyeZ.TabIndex = 9;
            this.lblEyeZ.Text = "000";
            this.lblEyeZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.Location = new System.Drawing.Point(0, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "EyeZ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trbEyeZ
            // 
            this.trbEyeZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trbEyeZ.AutoSize = false;
            this.trbEyeZ.Location = new System.Drawing.Point(40, 424);
            this.trbEyeZ.Maximum = 1000;
            this.trbEyeZ.Minimum = -1000;
            this.trbEyeZ.Name = "trbEyeZ";
            this.trbEyeZ.Size = new System.Drawing.Size(128, 24);
            this.trbEyeZ.TabIndex = 7;
            this.trbEyeZ.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbEyeZ.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // lblUpZ
            // 
            this.lblUpZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUpZ.Location = new System.Drawing.Point(592, 424);
            this.lblUpZ.Name = "lblUpZ";
            this.lblUpZ.Size = new System.Drawing.Size(32, 24);
            this.lblUpZ.TabIndex = 18;
            this.lblUpZ.Text = "000";
            this.lblUpZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.Location = new System.Drawing.Point(424, 424);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "UpZ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trbUpZ
            // 
            this.trbUpZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trbUpZ.AutoSize = false;
            this.trbUpZ.Location = new System.Drawing.Point(464, 424);
            this.trbUpZ.Maximum = 1000;
            this.trbUpZ.Minimum = -1000;
            this.trbUpZ.Name = "trbUpZ";
            this.trbUpZ.Size = new System.Drawing.Size(128, 24);
            this.trbUpZ.TabIndex = 16;
            this.trbUpZ.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbUpZ.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // lblUpY
            // 
            this.lblUpY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUpY.Location = new System.Drawing.Point(592, 400);
            this.lblUpY.Name = "lblUpY";
            this.lblUpY.Size = new System.Drawing.Size(32, 24);
            this.lblUpY.TabIndex = 15;
            this.lblUpY.Text = "000";
            this.lblUpY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.Location = new System.Drawing.Point(424, 400);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 24);
            this.label10.TabIndex = 14;
            this.label10.Text = "UpY";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trbUpY
            // 
            this.trbUpY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trbUpY.AutoSize = false;
            this.trbUpY.Location = new System.Drawing.Point(464, 400);
            this.trbUpY.Maximum = 1000;
            this.trbUpY.Minimum = -1000;
            this.trbUpY.Name = "trbUpY";
            this.trbUpY.Size = new System.Drawing.Size(128, 24);
            this.trbUpY.TabIndex = 13;
            this.trbUpY.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbUpY.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // lblUpX
            // 
            this.lblUpX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUpX.Location = new System.Drawing.Point(592, 376);
            this.lblUpX.Name = "lblUpX";
            this.lblUpX.Size = new System.Drawing.Size(32, 24);
            this.lblUpX.TabIndex = 12;
            this.lblUpX.Text = "000";
            this.lblUpX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.Location = new System.Drawing.Point(424, 376);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 24);
            this.label12.TabIndex = 11;
            this.label12.Text = "UpX";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trbUpX
            // 
            this.trbUpX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trbUpX.AutoSize = false;
            this.trbUpX.Location = new System.Drawing.Point(464, 376);
            this.trbUpX.Maximum = 1000;
            this.trbUpX.Minimum = -1000;
            this.trbUpX.Name = "trbUpX";
            this.trbUpX.Size = new System.Drawing.Size(128, 24);
            this.trbUpX.TabIndex = 10;
            this.trbUpX.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbUpX.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // lblTargetZ
            // 
            this.lblTargetZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTargetZ.Location = new System.Drawing.Point(384, 424);
            this.lblTargetZ.Name = "lblTargetZ";
            this.lblTargetZ.Size = new System.Drawing.Size(32, 24);
            this.lblTargetZ.TabIndex = 27;
            this.lblTargetZ.Text = "000";
            this.lblTargetZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.Location = new System.Drawing.Point(208, 424);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 24);
            this.label14.TabIndex = 26;
            this.label14.Text = "TragetZ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trbTargetZ
            // 
            this.trbTargetZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trbTargetZ.AutoSize = false;
            this.trbTargetZ.Location = new System.Drawing.Point(256, 424);
            this.trbTargetZ.Maximum = 1000;
            this.trbTargetZ.Minimum = -1000;
            this.trbTargetZ.Name = "trbTargetZ";
            this.trbTargetZ.Size = new System.Drawing.Size(128, 24);
            this.trbTargetZ.TabIndex = 25;
            this.trbTargetZ.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbTargetZ.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // lblTargetY
            // 
            this.lblTargetY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTargetY.Location = new System.Drawing.Point(384, 400);
            this.lblTargetY.Name = "lblTargetY";
            this.lblTargetY.Size = new System.Drawing.Size(32, 24);
            this.lblTargetY.TabIndex = 24;
            this.lblTargetY.Text = "000";
            this.lblTargetY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.Location = new System.Drawing.Point(208, 400);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 24);
            this.label16.TabIndex = 23;
            this.label16.Text = "TargetY";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trbTargetY
            // 
            this.trbTargetY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trbTargetY.AutoSize = false;
            this.trbTargetY.Location = new System.Drawing.Point(256, 400);
            this.trbTargetY.Maximum = 1000;
            this.trbTargetY.Minimum = -1000;
            this.trbTargetY.Name = "trbTargetY";
            this.trbTargetY.Size = new System.Drawing.Size(128, 24);
            this.trbTargetY.TabIndex = 22;
            this.trbTargetY.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbTargetY.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // lblTargetX
            // 
            this.lblTargetX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTargetX.Location = new System.Drawing.Point(384, 376);
            this.lblTargetX.Name = "lblTargetX";
            this.lblTargetX.Size = new System.Drawing.Size(32, 24);
            this.lblTargetX.TabIndex = 21;
            this.lblTargetX.Text = "000";
            this.lblTargetX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label18.Location = new System.Drawing.Point(208, 376);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 24);
            this.label18.TabIndex = 20;
            this.label18.Text = "TargetX";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trbTargetX
            // 
            this.trbTargetX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trbTargetX.AutoSize = false;
            this.trbTargetX.Location = new System.Drawing.Point(256, 376);
            this.trbTargetX.Maximum = 1000;
            this.trbTargetX.Minimum = -1000;
            this.trbTargetX.Name = "trbTargetX";
            this.trbTargetX.Size = new System.Drawing.Size(128, 24);
            this.trbTargetX.TabIndex = 19;
            this.trbTargetX.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbTargetX.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // lblFovy
            // 
            this.lblFovy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFovy.Location = new System.Drawing.Point(168, 448);
            this.lblFovy.Name = "lblFovy";
            this.lblFovy.Size = new System.Drawing.Size(32, 24);
            this.lblFovy.TabIndex = 30;
            this.lblFovy.Text = "000";
            this.lblFovy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.Location = new System.Drawing.Point(0, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "Fovy";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trbFovy
            // 
            this.trbFovy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trbFovy.AutoSize = false;
            this.trbFovy.Location = new System.Drawing.Point(40, 448);
            this.trbFovy.Maximum = 90;
            this.trbFovy.Minimum = 1;
            this.trbFovy.Name = "trbFovy";
            this.trbFovy.Size = new System.Drawing.Size(128, 24);
            this.trbFovy.TabIndex = 28;
            this.trbFovy.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbFovy.Value = 45;
            this.trbFovy.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReset.Location = new System.Drawing.Point(208, 448);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 31;
            this.btnReset.Text = "リセット";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // chkInterlock
            // 
            this.chkInterlock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkInterlock.AutoSize = true;
            this.chkInterlock.Checked = true;
            this.chkInterlock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInterlock.Location = new System.Drawing.Point(288, 452);
            this.chkInterlock.Name = "chkInterlock";
            this.chkInterlock.Size = new System.Drawing.Size(106, 16);
            this.chkInterlock.TabIndex = 32;
            this.chkInterlock.Text = "Eye・Target連動";
            this.chkInterlock.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 475);
            this.Controls.Add(this.chkInterlock);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblFovy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trbFovy);
            this.Controls.Add(this.lblTargetZ);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.trbTargetZ);
            this.Controls.Add(this.lblTargetY);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.trbTargetY);
            this.Controls.Add(this.lblTargetX);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.trbTargetX);
            this.Controls.Add(this.lblUpZ);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.trbUpZ);
            this.Controls.Add(this.lblUpY);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.trbUpY);
            this.Controls.Add(this.lblUpX);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.trbUpX);
            this.Controls.Add(this.lblEyeZ);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trbEyeZ);
            this.Controls.Add(this.lblEyeY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trbEyeY);
            this.Controls.Add(this.lblEyeX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trbEyeX);
            this.Controls.Add(this.glControl1);
            this.Name = "Form1";
            this.Text = "OpenTKSample01";
            ((System.ComponentModel.ISupportInitialize)(this.trbEyeX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbEyeY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbEyeZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbUpZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbUpY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbUpX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbTargetZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbTargetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbTargetX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbFovy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.TrackBar trbEyeX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEyeX;
        private System.Windows.Forms.Label lblEyeY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trbEyeY;
        private System.Windows.Forms.Label lblEyeZ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trbEyeZ;
        private System.Windows.Forms.Label lblUpZ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trbUpZ;
        private System.Windows.Forms.Label lblUpY;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar trbUpY;
        private System.Windows.Forms.Label lblUpX;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TrackBar trbUpX;
        private System.Windows.Forms.Label lblTargetZ;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TrackBar trbTargetZ;
        private System.Windows.Forms.Label lblTargetY;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TrackBar trbTargetY;
        private System.Windows.Forms.Label lblTargetX;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TrackBar trbTargetX;
        private System.Windows.Forms.Label lblFovy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trbFovy;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.CheckBox chkInterlock;
    }
}

