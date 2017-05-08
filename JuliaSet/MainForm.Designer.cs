namespace JuliaSet
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDraw = new System.Windows.Forms.Button();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.textBoxcRe = new System.Windows.Forms.TextBox();
            this.textBoxcIm = new System.Windows.Forms.TextBox();
            this.textBoxIterations = new System.Windows.Forms.TextBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.labelcRe = new System.Windows.Forms.Label();
            this.labelcIm = new System.Windows.Forms.Label();
            this.labelIterations = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.textBoxr = new System.Windows.Forms.TextBox();
            this.textBoxg = new System.Windows.Forms.TextBox();
            this.textBoxb = new System.Windows.Forms.TextBox();
            this.labelr = new System.Windows.Forms.Label();
            this.labelg = new System.Windows.Forms.Label();
            this.labelb = new System.Windows.Forms.Label();
            this.textBoxZoom = new System.Windows.Forms.TextBox();
            this.labelZoom = new System.Windows.Forms.Label();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.textBoxMoveX = new System.Windows.Forms.TextBox();
            this.textBoxMoveY = new System.Windows.Forms.TextBox();
            this.buttonGetPBSize = new System.Windows.Forms.Button();
            this.buttonOpenImage = new System.Windows.Forms.Button();
            this.labelImagePath = new System.Windows.Forms.Label();
            this.textBoxreFactor = new System.Windows.Forms.TextBox();
            this.textBoximFactor = new System.Windows.Forms.TextBox();
            this.labelreFactor = new System.Windows.Forms.Label();
            this.labelimFactor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDraw
            // 
            this.buttonDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDraw.Location = new System.Drawing.Point(698, 415);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(75, 23);
            this.buttonDraw.TabIndex = 0;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMain.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMain.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(691, 478);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMain.TabIndex = 1;
            this.pictureBoxMain.TabStop = false;
            // 
            // textBoxcRe
            // 
            this.textBoxcRe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxcRe.Location = new System.Drawing.Point(814, 12);
            this.textBoxcRe.Name = "textBoxcRe";
            this.textBoxcRe.Size = new System.Drawing.Size(100, 20);
            this.textBoxcRe.TabIndex = 2;
            this.textBoxcRe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxcRe_KeyPress);
            // 
            // textBoxcIm
            // 
            this.textBoxcIm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxcIm.Location = new System.Drawing.Point(814, 38);
            this.textBoxcIm.Name = "textBoxcIm";
            this.textBoxcIm.Size = new System.Drawing.Size(100, 20);
            this.textBoxcIm.TabIndex = 2;
            this.textBoxcIm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxcRe_KeyPress);
            // 
            // textBoxIterations
            // 
            this.textBoxIterations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIterations.Location = new System.Drawing.Point(814, 64);
            this.textBoxIterations.Name = "textBoxIterations";
            this.textBoxIterations.Size = new System.Drawing.Size(100, 20);
            this.textBoxIterations.TabIndex = 2;
            this.textBoxIterations.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxcRe_KeyPress);
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWidth.Location = new System.Drawing.Point(814, 120);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(100, 20);
            this.textBoxWidth.TabIndex = 2;
            this.textBoxWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxcRe_KeyPress);
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHeight.Location = new System.Drawing.Point(814, 146);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeight.TabIndex = 2;
            this.textBoxHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxcRe_KeyPress);
            // 
            // labelcRe
            // 
            this.labelcRe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelcRe.AutoSize = true;
            this.labelcRe.Location = new System.Drawing.Point(695, 15);
            this.labelcRe.Name = "labelcRe";
            this.labelcRe.Size = new System.Drawing.Size(27, 13);
            this.labelcRe.TabIndex = 3;
            this.labelcRe.Text = "cRe";
            // 
            // labelcIm
            // 
            this.labelcIm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelcIm.AutoSize = true;
            this.labelcIm.Location = new System.Drawing.Point(695, 41);
            this.labelcIm.Name = "labelcIm";
            this.labelcIm.Size = new System.Drawing.Size(24, 13);
            this.labelcIm.TabIndex = 3;
            this.labelcIm.Text = "cIm";
            // 
            // labelIterations
            // 
            this.labelIterations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIterations.AutoSize = true;
            this.labelIterations.Location = new System.Drawing.Point(695, 67);
            this.labelIterations.Name = "labelIterations";
            this.labelIterations.Size = new System.Drawing.Size(50, 13);
            this.labelIterations.TabIndex = 3;
            this.labelIterations.Text = "Iterations";
            // 
            // labelWidth
            // 
            this.labelWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(695, 123);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(35, 13);
            this.labelWidth.TabIndex = 3;
            this.labelWidth.Text = "Width";
            // 
            // labelHeight
            // 
            this.labelHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(695, 149);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(38, 13);
            this.labelHeight.TabIndex = 3;
            this.labelHeight.Text = "Height";
            // 
            // textBoxr
            // 
            this.textBoxr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxr.Location = new System.Drawing.Point(814, 172);
            this.textBoxr.Name = "textBoxr";
            this.textBoxr.Size = new System.Drawing.Size(100, 20);
            this.textBoxr.TabIndex = 2;
            this.textBoxr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxcRe_KeyPress);
            // 
            // textBoxg
            // 
            this.textBoxg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxg.Location = new System.Drawing.Point(814, 198);
            this.textBoxg.Name = "textBoxg";
            this.textBoxg.Size = new System.Drawing.Size(100, 20);
            this.textBoxg.TabIndex = 2;
            this.textBoxg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxcRe_KeyPress);
            // 
            // textBoxb
            // 
            this.textBoxb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxb.Location = new System.Drawing.Point(814, 224);
            this.textBoxb.Name = "textBoxb";
            this.textBoxb.Size = new System.Drawing.Size(100, 20);
            this.textBoxb.TabIndex = 2;
            this.textBoxb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxcRe_KeyPress);
            // 
            // labelr
            // 
            this.labelr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelr.AutoSize = true;
            this.labelr.Location = new System.Drawing.Point(695, 175);
            this.labelr.Name = "labelr";
            this.labelr.Size = new System.Drawing.Size(10, 13);
            this.labelr.TabIndex = 3;
            this.labelr.Text = "r";
            // 
            // labelg
            // 
            this.labelg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelg.AutoSize = true;
            this.labelg.Location = new System.Drawing.Point(695, 201);
            this.labelg.Name = "labelg";
            this.labelg.Size = new System.Drawing.Size(13, 13);
            this.labelg.TabIndex = 3;
            this.labelg.Text = "g";
            // 
            // labelb
            // 
            this.labelb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelb.AutoSize = true;
            this.labelb.Location = new System.Drawing.Point(695, 227);
            this.labelb.Name = "labelb";
            this.labelb.Size = new System.Drawing.Size(13, 13);
            this.labelb.TabIndex = 3;
            this.labelb.Text = "b";
            // 
            // textBoxZoom
            // 
            this.textBoxZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxZoom.Location = new System.Drawing.Point(814, 250);
            this.textBoxZoom.Name = "textBoxZoom";
            this.textBoxZoom.Size = new System.Drawing.Size(100, 20);
            this.textBoxZoom.TabIndex = 2;
            this.textBoxZoom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxcRe_KeyPress);
            // 
            // labelZoom
            // 
            this.labelZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelZoom.AutoSize = true;
            this.labelZoom.Location = new System.Drawing.Point(695, 253);
            this.labelZoom.Name = "labelZoom";
            this.labelZoom.Size = new System.Drawing.Size(34, 13);
            this.labelZoom.TabIndex = 3;
            this.labelZoom.Text = "Zoom";
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.Location = new System.Drawing.Point(728, 334);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 23);
            this.buttonUp.TabIndex = 4;
            this.buttonUp.Text = "U";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.Location = new System.Drawing.Point(698, 359);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 23);
            this.buttonLeft.TabIndex = 4;
            this.buttonLeft.Text = "L";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.Location = new System.Drawing.Point(728, 384);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 23);
            this.buttonDown.TabIndex = 4;
            this.buttonDown.Text = "D";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.Location = new System.Drawing.Point(759, 359);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 23);
            this.buttonRight.TabIndex = 4;
            this.buttonRight.Text = "R";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // textBoxMoveX
            // 
            this.textBoxMoveX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMoveX.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxMoveX.Location = new System.Drawing.Point(814, 361);
            this.textBoxMoveX.Name = "textBoxMoveX";
            this.textBoxMoveX.Size = new System.Drawing.Size(36, 20);
            this.textBoxMoveX.TabIndex = 2;
            this.textBoxMoveX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxcRe_KeyPress);
            // 
            // textBoxMoveY
            // 
            this.textBoxMoveY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMoveY.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxMoveY.Location = new System.Drawing.Point(856, 361);
            this.textBoxMoveY.Name = "textBoxMoveY";
            this.textBoxMoveY.Size = new System.Drawing.Size(36, 20);
            this.textBoxMoveY.TabIndex = 2;
            this.textBoxMoveY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxcRe_KeyPress);
            // 
            // buttonGetPBSize
            // 
            this.buttonGetPBSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGetPBSize.Location = new System.Drawing.Point(814, 91);
            this.buttonGetPBSize.Name = "buttonGetPBSize";
            this.buttonGetPBSize.Size = new System.Drawing.Size(100, 23);
            this.buttonGetPBSize.TabIndex = 5;
            this.buttonGetPBSize.Text = "Use PB size";
            this.buttonGetPBSize.UseVisualStyleBackColor = true;
            this.buttonGetPBSize.Click += new System.EventHandler(this.buttonGetPBSize_Click);
            // 
            // buttonOpenImage
            // 
            this.buttonOpenImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenImage.Location = new System.Drawing.Point(819, 415);
            this.buttonOpenImage.Name = "buttonOpenImage";
            this.buttonOpenImage.Size = new System.Drawing.Size(95, 23);
            this.buttonOpenImage.TabIndex = 6;
            this.buttonOpenImage.Text = "Open image";
            this.buttonOpenImage.UseVisualStyleBackColor = true;
            this.buttonOpenImage.Click += new System.EventHandler(this.buttonOpenImage_Click);
            // 
            // labelImagePath
            // 
            this.labelImagePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelImagePath.AutoSize = true;
            this.labelImagePath.Location = new System.Drawing.Point(698, 441);
            this.labelImagePath.Name = "labelImagePath";
            this.labelImagePath.Size = new System.Drawing.Size(0, 13);
            this.labelImagePath.TabIndex = 7;
            // 
            // textBoxreFactor
            // 
            this.textBoxreFactor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxreFactor.Location = new System.Drawing.Point(814, 276);
            this.textBoxreFactor.Name = "textBoxreFactor";
            this.textBoxreFactor.Size = new System.Drawing.Size(100, 20);
            this.textBoxreFactor.TabIndex = 2;
            this.textBoxreFactor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxcRe_KeyPress);
            // 
            // textBoximFactor
            // 
            this.textBoximFactor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoximFactor.Location = new System.Drawing.Point(814, 302);
            this.textBoximFactor.Name = "textBoximFactor";
            this.textBoximFactor.Size = new System.Drawing.Size(100, 20);
            this.textBoximFactor.TabIndex = 2;
            this.textBoximFactor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxcRe_KeyPress);
            // 
            // labelreFactor
            // 
            this.labelreFactor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelreFactor.AutoSize = true;
            this.labelreFactor.Location = new System.Drawing.Point(695, 279);
            this.labelreFactor.Name = "labelreFactor";
            this.labelreFactor.Size = new System.Drawing.Size(46, 13);
            this.labelreFactor.TabIndex = 3;
            this.labelreFactor.Text = "reFactor";
            // 
            // labelimFactor
            // 
            this.labelimFactor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelimFactor.AutoSize = true;
            this.labelimFactor.Location = new System.Drawing.Point(695, 305);
            this.labelimFactor.Name = "labelimFactor";
            this.labelimFactor.Size = new System.Drawing.Size(47, 13);
            this.labelimFactor.TabIndex = 3;
            this.labelimFactor.Text = "imFactor";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(921, 485);
            this.Controls.Add(this.labelImagePath);
            this.Controls.Add(this.buttonOpenImage);
            this.Controls.Add(this.buttonGetPBSize);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.labelimFactor);
            this.Controls.Add(this.labelZoom);
            this.Controls.Add(this.labelreFactor);
            this.Controls.Add(this.labelb);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelg);
            this.Controls.Add(this.labelr);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.labelIterations);
            this.Controls.Add(this.labelcIm);
            this.Controls.Add(this.textBoxMoveY);
            this.Controls.Add(this.textBoxMoveX);
            this.Controls.Add(this.textBoximFactor);
            this.Controls.Add(this.textBoxreFactor);
            this.Controls.Add(this.textBoxZoom);
            this.Controls.Add(this.textBoxb);
            this.Controls.Add(this.labelcRe);
            this.Controls.Add(this.textBoxg);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxr);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.textBoxIterations);
            this.Controls.Add(this.textBoxcIm);
            this.Controls.Add(this.textBoxcRe);
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.buttonDraw);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Julia set";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.TextBox textBoxcRe;
        private System.Windows.Forms.TextBox textBoxcIm;
        private System.Windows.Forms.TextBox textBoxIterations;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label labelcRe;
        private System.Windows.Forms.Label labelcIm;
        private System.Windows.Forms.Label labelIterations;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.TextBox textBoxr;
        private System.Windows.Forms.TextBox textBoxg;
        private System.Windows.Forms.TextBox textBoxb;
        private System.Windows.Forms.Label labelr;
        private System.Windows.Forms.Label labelg;
        private System.Windows.Forms.Label labelb;
        private System.Windows.Forms.TextBox textBoxZoom;
        private System.Windows.Forms.Label labelZoom;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.TextBox textBoxMoveX;
        private System.Windows.Forms.TextBox textBoxMoveY;
        private System.Windows.Forms.Button buttonGetPBSize;
        private System.Windows.Forms.Button buttonOpenImage;
        private System.Windows.Forms.Label labelImagePath;
        private System.Windows.Forms.TextBox textBoxreFactor;
        private System.Windows.Forms.TextBox textBoximFactor;
        private System.Windows.Forms.Label labelreFactor;
        private System.Windows.Forms.Label labelimFactor;
    }
}

