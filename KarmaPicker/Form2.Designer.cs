
namespace KarmaPicker
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.PnlNav = new System.Windows.Forms.Panel();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnKarmaPicker = new System.Windows.Forms.Button();
            this.BtnCustom = new System.Windows.Forms.Button();
            this.BtnAnalytics = new System.Windows.Forms.Button();
            this.BtnDashbord = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.PnlContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Controls.Add(this.PnlNav);
            this.panel1.Controls.Add(this.BtnSettings);
            this.panel1.Controls.Add(this.BtnKarmaPicker);
            this.panel1.Controls.Add(this.BtnCustom);
            this.panel1.Controls.Add(this.BtnAnalytics);
            this.panel1.Controls.Add(this.BtnDashbord);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 0;
            // 
            // BtnExit
            // 
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Nirmala UI Semilight", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.Location = new System.Drawing.Point(0, 516);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(186, 61);
            this.BtnExit.TabIndex = 8;
            this.BtnExit.Text = "Exit";
            this.BtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            this.BtnExit.Leave += new System.EventHandler(this.BtnExit_Leave);
            this.BtnExit.MouseHover += new System.EventHandler(this.BtnExit_MouseHover);
            // 
            // PnlNav
            // 
            this.PnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.PnlNav.Location = new System.Drawing.Point(0, 193);
            this.PnlNav.Name = "PnlNav";
            this.PnlNav.Size = new System.Drawing.Size(3, 100);
            this.PnlNav.TabIndex = 7;
            // 
            // BtnSettings
            // 
            this.BtnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSettings.FlatAppearance.BorderSize = 0;
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettings.Font = new System.Drawing.Font("Nirmala UI Semilight", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnSettings.Image = ((System.Drawing.Image)(resources.GetObject("BtnSettings.Image")));
            this.BtnSettings.Location = new System.Drawing.Point(0, 244);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(186, 61);
            this.BtnSettings.TabIndex = 6;
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            this.BtnSettings.Leave += new System.EventHandler(this.BtnSettings_Leave);
            this.BtnSettings.MouseHover += new System.EventHandler(this.BtnSettings_MouseHover);
            // 
            // BtnKarmaPicker
            // 
            this.BtnKarmaPicker.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnKarmaPicker.FlatAppearance.BorderSize = 0;
            this.BtnKarmaPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKarmaPicker.Font = new System.Drawing.Font("Nirmala UI Semilight", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKarmaPicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnKarmaPicker.Image = ((System.Drawing.Image)(resources.GetObject("BtnKarmaPicker.Image")));
            this.BtnKarmaPicker.Location = new System.Drawing.Point(0, 183);
            this.BtnKarmaPicker.Name = "BtnKarmaPicker";
            this.BtnKarmaPicker.Size = new System.Drawing.Size(186, 61);
            this.BtnKarmaPicker.TabIndex = 5;
            this.BtnKarmaPicker.Text = "KarmaPicker";
            this.BtnKarmaPicker.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnKarmaPicker.UseVisualStyleBackColor = true;
            this.BtnKarmaPicker.Click += new System.EventHandler(this.BtnKarmaPicker_Click);
            this.BtnKarmaPicker.Leave += new System.EventHandler(this.BtnKarmaPicker_Leave);
            this.BtnKarmaPicker.MouseHover += new System.EventHandler(this.BtnKarmaPicker_MouseHover);
            // 
            // BtnCustom
            // 
            this.BtnCustom.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCustom.FlatAppearance.BorderSize = 0;
            this.BtnCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCustom.Font = new System.Drawing.Font("Nirmala UI Semilight", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCustom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnCustom.Image = ((System.Drawing.Image)(resources.GetObject("BtnCustom.Image")));
            this.BtnCustom.Location = new System.Drawing.Point(0, 122);
            this.BtnCustom.Name = "BtnCustom";
            this.BtnCustom.Size = new System.Drawing.Size(186, 61);
            this.BtnCustom.TabIndex = 3;
            this.BtnCustom.Text = "Custom";
            this.BtnCustom.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnCustom.UseVisualStyleBackColor = true;
            this.BtnCustom.Click += new System.EventHandler(this.BtnCustom_Click);
            this.BtnCustom.Leave += new System.EventHandler(this.BtnCustom_Leave);
            this.BtnCustom.MouseHover += new System.EventHandler(this.BtnCustom_MouseHover);
            // 
            // BtnAnalytics
            // 
            this.BtnAnalytics.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAnalytics.FlatAppearance.BorderSize = 0;
            this.BtnAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnalytics.Font = new System.Drawing.Font("Nirmala UI Semilight", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnalytics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnAnalytics.Image = ((System.Drawing.Image)(resources.GetObject("BtnAnalytics.Image")));
            this.BtnAnalytics.Location = new System.Drawing.Point(0, 61);
            this.BtnAnalytics.Name = "BtnAnalytics";
            this.BtnAnalytics.Size = new System.Drawing.Size(186, 61);
            this.BtnAnalytics.TabIndex = 2;
            this.BtnAnalytics.Text = "Analytics";
            this.BtnAnalytics.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnAnalytics.UseVisualStyleBackColor = true;
            this.BtnAnalytics.Click += new System.EventHandler(this.BtnAnalytics_Click);
            this.BtnAnalytics.Leave += new System.EventHandler(this.BtnAnalytics_Leave);
            this.BtnAnalytics.MouseHover += new System.EventHandler(this.BtnAnalytics_MouseHover);
            // 
            // BtnDashbord
            // 
            this.BtnDashbord.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDashbord.FlatAppearance.BorderSize = 0;
            this.BtnDashbord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashbord.Font = new System.Drawing.Font("Nirmala UI Semilight", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDashbord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BtnDashbord.Image = ((System.Drawing.Image)(resources.GetObject("BtnDashbord.Image")));
            this.BtnDashbord.Location = new System.Drawing.Point(0, 0);
            this.BtnDashbord.Name = "BtnDashbord";
            this.BtnDashbord.Size = new System.Drawing.Size(186, 61);
            this.BtnDashbord.TabIndex = 1;
            this.BtnDashbord.Text = "Dashboard";
            this.BtnDashbord.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnDashbord.UseVisualStyleBackColor = true;
            this.BtnDashbord.Click += new System.EventHandler(this.BtnDashbord_Click);
            this.BtnDashbord.Leave += new System.EventHandler(this.BtnDashbord_Leave);
            this.BtnDashbord.MouseHover += new System.EventHandler(this.BtnDashbord_MouseHover);
            // 
            // PnlContainer
            // 
            this.PnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContainer.Location = new System.Drawing.Point(186, 0);
            this.PnlContainer.Name = "PnlContainer";
            this.PnlContainer.Size = new System.Drawing.Size(765, 577);
            this.PnlContainer.TabIndex = 2;
            this.PnlContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlContainer_Paint);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.PnlContainer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnDashbord;
        private System.Windows.Forms.Button BtnCustom;
        private System.Windows.Forms.Button BtnAnalytics;
        private System.Windows.Forms.Button BtnKarmaPicker;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Panel PnlNav;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Panel PnlContainer;
    }
}