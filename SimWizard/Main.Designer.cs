
namespace SimWizard
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgBalance = new System.Windows.Forms.DataGridView();
            this.dgSim = new System.Windows.Forms.DataGridView();
            this.btSimSearch = new System.Windows.Forms.Button();
            this.tbSimSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btSimAdd = new System.Windows.Forms.Button();
            this.lbSim = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSim)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1015, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controllToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // controllToolStripMenuItem
            // 
            this.controllToolStripMenuItem.Name = "controllToolStripMenuItem";
            this.controllToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.controllToolStripMenuItem.Text = "Controll";
            this.controllToolStripMenuItem.Click += new System.EventHandler(this.controllToolStripMenuItem_Click);
            // 
            // dgBalance
            // 
            this.dgBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBalance.Location = new System.Drawing.Point(31, 337);
            this.dgBalance.Name = "dgBalance";
            this.dgBalance.Size = new System.Drawing.Size(965, 167);
            this.dgBalance.TabIndex = 1;
            // 
            // dgSim
            // 
            this.dgSim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSim.Location = new System.Drawing.Point(34, 149);
            this.dgSim.Name = "dgSim";
            this.dgSim.Size = new System.Drawing.Size(962, 151);
            this.dgSim.TabIndex = 2;
            this.dgSim.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSim_CellClick);
            this.dgSim.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSim_CellContentDoubleClick);
            this.dgSim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgSim_KeyDown);
            // 
            // btSimSearch
            // 
            this.btSimSearch.Location = new System.Drawing.Point(119, 85);
            this.btSimSearch.Name = "btSimSearch";
            this.btSimSearch.Size = new System.Drawing.Size(75, 23);
            this.btSimSearch.TabIndex = 3;
            this.btSimSearch.Text = "Search";
            this.btSimSearch.UseVisualStyleBackColor = true;
            this.btSimSearch.Click += new System.EventHandler(this.btSimSearch_Click);
            // 
            // tbSimSearch
            // 
            this.tbSimSearch.Location = new System.Drawing.Point(119, 59);
            this.tbSimSearch.Name = "tbSimSearch";
            this.tbSimSearch.Size = new System.Drawing.Size(278, 20);
            this.tbSimSearch.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sim Informations:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Balance Informations:";
            // 
            // btSimAdd
            // 
            this.btSimAdd.Location = new System.Drawing.Point(322, 85);
            this.btSimAdd.Name = "btSimAdd";
            this.btSimAdd.Size = new System.Drawing.Size(75, 23);
            this.btSimAdd.TabIndex = 8;
            this.btSimAdd.Text = "Add/Modify";
            this.btSimAdd.UseVisualStyleBackColor = true;
            this.btSimAdd.Click += new System.EventHandler(this.btSimAdd_Click);
            // 
            // lbSim
            // 
            this.lbSim.AutoSize = true;
            this.lbSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbSim.Location = new System.Drawing.Point(31, 62);
            this.lbSim.Name = "lbSim";
            this.lbSim.Size = new System.Drawing.Size(82, 13);
            this.lbSim.TabIndex = 9;
            this.lbSim.Text = "Sim you want";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 536);
            this.Controls.Add(this.lbSim);
            this.Controls.Add(this.btSimAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSimSearch);
            this.Controls.Add(this.btSimSearch);
            this.Controls.Add(this.dgSim);
            this.Controls.Add(this.dgBalance);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Sim Wizard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controllToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgBalance;
        private System.Windows.Forms.DataGridView dgSim;
        private System.Windows.Forms.Button btSimSearch;
        private System.Windows.Forms.TextBox tbSimSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSimAdd;
        private System.Windows.Forms.Label lbSim;
    }
}

