namespace ScannerV1
{
    partial class Form1
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
            this.labelCoordinates = new System.Windows.Forms.Label();
            this.labelSpeeds = new System.Windows.Forms.Label();
            this.labelLimits = new System.Windows.Forms.Label();
            this.buttonSetup = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonCalibration = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxMoveToCoordA = new System.Windows.Forms.TextBox();
            this.textBoxMoveToCoordZ = new System.Windows.Forms.TextBox();
            this.textBoxMoveToCoordY = new System.Windows.Forms.TextBox();
            this.textBoxMoveToCoordX = new System.Windows.Forms.TextBox();
            this.checkBoxAutoSetCoordinates = new System.Windows.Forms.CheckBox();
            this.trackBarA = new System.Windows.Forms.TrackBar();
            this.trackBarZ = new System.Windows.Forms.TrackBar();
            this.trackBarY = new System.Windows.Forms.TrackBar();
            this.trackBarX = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCoordinates
            // 
            this.labelCoordinates.AutoSize = true;
            this.labelCoordinates.Location = new System.Drawing.Point(12, 331);
            this.labelCoordinates.Name = "labelCoordinates";
            this.labelCoordinates.Size = new System.Drawing.Size(73, 13);
            this.labelCoordinates.TabIndex = 0;
            this.labelCoordinates.Text = "cx: cy: cz: ca:";
            // 
            // labelSpeeds
            // 
            this.labelSpeeds.AutoSize = true;
            this.labelSpeeds.Location = new System.Drawing.Point(12, 344);
            this.labelSpeeds.Name = "labelSpeeds";
            this.labelSpeeds.Size = new System.Drawing.Size(73, 13);
            this.labelSpeeds.TabIndex = 1;
            this.labelSpeeds.Text = "ux: uy: uz: ua:";
            // 
            // labelLimits
            // 
            this.labelLimits.AutoSize = true;
            this.labelLimits.Location = new System.Drawing.Point(12, 357);
            this.labelLimits.Name = "labelLimits";
            this.labelLimits.Size = new System.Drawing.Size(57, 13);
            this.labelLimits.TabIndex = 2;
            this.labelLimits.Text = "lx: ly: lz: la:";
            // 
            // buttonSetup
            // 
            this.buttonSetup.Location = new System.Drawing.Point(12, 12);
            this.buttonSetup.Name = "buttonSetup";
            this.buttonSetup.Size = new System.Drawing.Size(90, 23);
            this.buttonSetup.TabIndex = 8;
            this.buttonSetup.Text = "Setup";
            this.buttonSetup.UseVisualStyleBackColor = true;
            this.buttonSetup.Click += new System.EventHandler(this.buttonSetup_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(496, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(145, 23);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStop.Location = new System.Drawing.Point(12, 285);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(629, 43);
            this.buttonStop.TabIndex = 10;
            this.buttonStop.Text = "СТОП";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonCalibration
            // 
            this.buttonCalibration.Enabled = false;
            this.buttonCalibration.Location = new System.Drawing.Point(108, 12);
            this.buttonCalibration.Name = "buttonCalibration";
            this.buttonCalibration.Size = new System.Drawing.Size(94, 23);
            this.buttonCalibration.TabIndex = 11;
            this.buttonCalibration.Text = "Калибровка";
            this.buttonCalibration.UseVisualStyleBackColor = true;
            this.buttonCalibration.Click += new System.EventHandler(this.buttonCalibration_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxMoveToCoordA);
            this.groupBox1.Controls.Add(this.textBoxMoveToCoordZ);
            this.groupBox1.Controls.Add(this.textBoxMoveToCoordY);
            this.groupBox1.Controls.Add(this.textBoxMoveToCoordX);
            this.groupBox1.Controls.Add(this.checkBoxAutoSetCoordinates);
            this.groupBox1.Controls.Add(this.trackBarA);
            this.groupBox1.Controls.Add(this.trackBarZ);
            this.groupBox1.Controls.Add(this.trackBarY);
            this.groupBox1.Controls.Add(this.trackBarX);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 238);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление положением сканера (передвинуть сканер на заданные координаты)";
            // 
            // textBoxMoveToCoordA
            // 
            this.textBoxMoveToCoordA.Location = new System.Drawing.Point(56, 176);
            this.textBoxMoveToCoordA.Name = "textBoxMoveToCoordA";
            this.textBoxMoveToCoordA.Size = new System.Drawing.Size(60, 20);
            this.textBoxMoveToCoordA.TabIndex = 15;
            this.textBoxMoveToCoordA.Text = "0";
            this.textBoxMoveToCoordA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMoveToCoordA_KeyDown);
            // 
            // textBoxMoveToCoordZ
            // 
            this.textBoxMoveToCoordZ.Location = new System.Drawing.Point(55, 125);
            this.textBoxMoveToCoordZ.Name = "textBoxMoveToCoordZ";
            this.textBoxMoveToCoordZ.Size = new System.Drawing.Size(60, 20);
            this.textBoxMoveToCoordZ.TabIndex = 15;
            this.textBoxMoveToCoordZ.Text = "0";
            this.textBoxMoveToCoordZ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMoveToCoordZ_KeyDown);
            // 
            // textBoxMoveToCoordY
            // 
            this.textBoxMoveToCoordY.Location = new System.Drawing.Point(55, 74);
            this.textBoxMoveToCoordY.Name = "textBoxMoveToCoordY";
            this.textBoxMoveToCoordY.Size = new System.Drawing.Size(60, 20);
            this.textBoxMoveToCoordY.TabIndex = 15;
            this.textBoxMoveToCoordY.Text = "0";
            this.textBoxMoveToCoordY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMoveToCoordY_KeyDown);
            // 
            // textBoxMoveToCoordX
            // 
            this.textBoxMoveToCoordX.Location = new System.Drawing.Point(55, 23);
            this.textBoxMoveToCoordX.Name = "textBoxMoveToCoordX";
            this.textBoxMoveToCoordX.Size = new System.Drawing.Size(60, 20);
            this.textBoxMoveToCoordX.TabIndex = 15;
            this.textBoxMoveToCoordX.Text = "0";
            this.textBoxMoveToCoordX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMoveToCoordX_KeyDown);
            // 
            // checkBoxAutoSetCoordinates
            // 
            this.checkBoxAutoSetCoordinates.AutoSize = true;
            this.checkBoxAutoSetCoordinates.Enabled = false;
            this.checkBoxAutoSetCoordinates.Location = new System.Drawing.Point(10, 215);
            this.checkBoxAutoSetCoordinates.Name = "checkBoxAutoSetCoordinates";
            this.checkBoxAutoSetCoordinates.Size = new System.Drawing.Size(168, 17);
            this.checkBoxAutoSetCoordinates.TabIndex = 14;
            this.checkBoxAutoSetCoordinates.Text = "Устанавливать координаты";
            this.checkBoxAutoSetCoordinates.UseVisualStyleBackColor = true;
            this.checkBoxAutoSetCoordinates.CheckedChanged += new System.EventHandler(this.checkBoxAutoSetCoordinates_CheckedChanged);
            // 
            // trackBarA
            // 
            this.trackBarA.LargeChange = 80;
            this.trackBarA.Location = new System.Drawing.Point(121, 177);
            this.trackBarA.Maximum = 192000;
            this.trackBarA.Minimum = -192000;
            this.trackBarA.Name = "trackBarA";
            this.trackBarA.Size = new System.Drawing.Size(500, 45);
            this.trackBarA.TabIndex = 13;
            this.trackBarA.TickFrequency = 8000;
            this.trackBarA.Scroll += new System.EventHandler(this.trackBarA_Scroll);
            // 
            // trackBarZ
            // 
            this.trackBarZ.LargeChange = 20;
            this.trackBarZ.Location = new System.Drawing.Point(121, 126);
            this.trackBarZ.Maximum = 0;
            this.trackBarZ.Minimum = -200000;
            this.trackBarZ.Name = "trackBarZ";
            this.trackBarZ.Size = new System.Drawing.Size(500, 45);
            this.trackBarZ.TabIndex = 13;
            this.trackBarZ.TickFrequency = 2000;
            this.trackBarZ.Scroll += new System.EventHandler(this.trackBarZ_Scroll);
            // 
            // trackBarY
            // 
            this.trackBarY.LargeChange = 20;
            this.trackBarY.Location = new System.Drawing.Point(121, 75);
            this.trackBarY.Maximum = 200000;
            this.trackBarY.Name = "trackBarY";
            this.trackBarY.Size = new System.Drawing.Size(500, 45);
            this.trackBarY.TabIndex = 13;
            this.trackBarY.TickFrequency = 2000;
            this.trackBarY.Scroll += new System.EventHandler(this.trackBarY_Scroll);
            // 
            // trackBarX
            // 
            this.trackBarX.LargeChange = 20;
            this.trackBarX.Location = new System.Drawing.Point(121, 24);
            this.trackBarX.Maximum = 200000;
            this.trackBarX.Name = "trackBarX";
            this.trackBarX.Size = new System.Drawing.Size(500, 45);
            this.trackBarX.TabIndex = 13;
            this.trackBarX.TickFrequency = 2000;
            this.trackBarX.Scroll += new System.EventHandler(this.trackBarX_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "A, град";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Z, мм";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Y, мм";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "X, мм";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(282, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Повторная калибровка может привести к зависанию!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 383);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCalibration);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSetup);
            this.Controls.Add(this.labelLimits);
            this.Controls.Add(this.labelSpeeds);
            this.Controls.Add(this.labelCoordinates);
            this.Name = "Form1";
            this.Text = "Управление сканером";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCoordinates;
        private System.Windows.Forms.Label labelSpeeds;
        private System.Windows.Forms.Label labelLimits;
        private System.Windows.Forms.Button buttonSetup;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonCalibration;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarX;
        private System.Windows.Forms.TrackBar trackBarA;
        private System.Windows.Forms.TrackBar trackBarZ;
        private System.Windows.Forms.TrackBar trackBarY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMoveToCoordX;
        private System.Windows.Forms.TextBox textBoxMoveToCoordA;
        private System.Windows.Forms.TextBox textBoxMoveToCoordZ;
        private System.Windows.Forms.TextBox textBoxMoveToCoordY;
        private System.Windows.Forms.CheckBox checkBoxAutoSetCoordinates;
    }
}

