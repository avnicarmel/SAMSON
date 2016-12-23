namespace Graphic_Map
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.panel3 = new System.Windows.Forms.Panel();
            this.DrawIcon_b = new System.Windows.Forms.Button();
            this.DrawPoint_b = new System.Windows.Forms.Button();
            this.lat_t = new System.Windows.Forms.TextBox();
            this.long_t = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Night_ch = new System.Windows.Forms.CheckBox();
            this.Sun_ch = new System.Windows.Forms.CheckBox();
            this.Grid_ch = new System.Windows.Forms.CheckBox();
            this.ChangeMap_b = new System.Windows.Forms.Button();
            this.LatLon_p = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.NS_l = new System.Windows.Forms.Label();
            this.long_l = new System.Windows.Forms.Label();
            this.EW_l = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lat_l = new System.Windows.Forms.Label();
            this.Map_Panel = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.LatLon_p.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.DrawIcon_b);
            this.panel3.Controls.Add(this.DrawPoint_b);
            this.panel3.Controls.Add(this.lat_t);
            this.panel3.Controls.Add(this.long_t);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(12, 410);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(276, 106);
            this.panel3.TabIndex = 9;
            // 
            // DrawIcon_b
            // 
            this.DrawIcon_b.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrawIcon_b.Location = new System.Drawing.Point(127, 67);
            this.DrawIcon_b.Name = "DrawIcon_b";
            this.DrawIcon_b.Size = new System.Drawing.Size(91, 23);
            this.DrawIcon_b.TabIndex = 7;
            this.DrawIcon_b.Text = "Draw Icon";
            this.DrawIcon_b.UseVisualStyleBackColor = true;
            this.DrawIcon_b.Click += new System.EventHandler(this.DrawIcon_b_Click);
            // 
            // DrawPoint_b
            // 
            this.DrawPoint_b.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrawPoint_b.Location = new System.Drawing.Point(36, 67);
            this.DrawPoint_b.Name = "DrawPoint_b";
            this.DrawPoint_b.Size = new System.Drawing.Size(91, 23);
            this.DrawPoint_b.TabIndex = 6;
            this.DrawPoint_b.Text = "Draw Point";
            this.DrawPoint_b.UseVisualStyleBackColor = true;
            this.DrawPoint_b.Click += new System.EventHandler(this.DrawPoint_b_Click);
            // 
            // lat_t
            // 
            this.lat_t.Location = new System.Drawing.Point(118, 41);
            this.lat_t.Name = "lat_t";
            this.lat_t.Size = new System.Drawing.Size(100, 20);
            this.lat_t.TabIndex = 5;
            this.lat_t.Text = "35";
            // 
            // long_t
            // 
            this.long_t.Location = new System.Drawing.Point(118, 16);
            this.long_t.Name = "long_t";
            this.long_t.Size = new System.Drawing.Size(100, 20);
            this.long_t.TabIndex = 4;
            this.long_t.Text = "51";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(33, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Longitude :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(33, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Latitude :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.Night_ch);
            this.groupBox1.Controls.Add(this.Sun_ch);
            this.groupBox1.Controls.Add(this.Grid_ch);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(523, 410);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 106);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display Options";
            // 
            // Night_ch
            // 
            this.Night_ch.AutoSize = true;
            this.Night_ch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Night_ch.Enabled = false;
            this.Night_ch.Location = new System.Drawing.Point(15, 82);
            this.Night_ch.Name = "Night_ch";
            this.Night_ch.Size = new System.Drawing.Size(115, 19);
            this.Night_ch.TabIndex = 2;
            this.Night_ch.Text = "Night Shadow";
            this.Night_ch.UseVisualStyleBackColor = true;
            // 
            // Sun_ch
            // 
            this.Sun_ch.AutoSize = true;
            this.Sun_ch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sun_ch.Enabled = false;
            this.Sun_ch.Location = new System.Drawing.Point(15, 57);
            this.Sun_ch.Name = "Sun_ch";
            this.Sun_ch.Size = new System.Drawing.Size(51, 19);
            this.Sun_ch.TabIndex = 1;
            this.Sun_ch.Text = "Sun";
            this.Sun_ch.UseVisualStyleBackColor = true;
            // 
            // Grid_ch
            // 
            this.Grid_ch.AutoSize = true;
            this.Grid_ch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Grid_ch.Location = new System.Drawing.Point(15, 32);
            this.Grid_ch.Name = "Grid_ch";
            this.Grid_ch.Size = new System.Drawing.Size(113, 19);
            this.Grid_ch.TabIndex = 0;
            this.Grid_ch.Text = "Lat/Long Grid";
            this.Grid_ch.UseVisualStyleBackColor = true;
            this.Grid_ch.CheckedChanged += new System.EventHandler(this.Grid_ch_CheckedChanged);
            // 
            // ChangeMap_b
            // 
            this.ChangeMap_b.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeMap_b.Location = new System.Drawing.Point(361, 446);
            this.ChangeMap_b.Name = "ChangeMap_b";
            this.ChangeMap_b.Size = new System.Drawing.Size(95, 26);
            this.ChangeMap_b.TabIndex = 11;
            this.ChangeMap_b.Text = "Change Map";
            this.ChangeMap_b.UseVisualStyleBackColor = true;
            this.ChangeMap_b.Click += new System.EventHandler(this.ChangeMap_b_Click);
            // 
            // LatLon_p
            // 
            this.LatLon_p.Controls.Add(this.label1);
            this.LatLon_p.Controls.Add(this.NS_l);
            this.LatLon_p.Controls.Add(this.long_l);
            this.LatLon_p.Controls.Add(this.EW_l);
            this.LatLon_p.Controls.Add(this.label3);
            this.LatLon_p.Controls.Add(this.lat_l);
            this.LatLon_p.Location = new System.Drawing.Point(74, 376);
            this.LatLon_p.Name = "LatLon_p";
            this.LatLon_p.Size = new System.Drawing.Size(576, 28);
            this.LatLon_p.TabIndex = 8;
            this.LatLon_p.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(41, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Longitude :";
            // 
            // NS_l
            // 
            this.NS_l.AutoSize = true;
            this.NS_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NS_l.ForeColor = System.Drawing.Color.Maroon;
            this.NS_l.Location = new System.Drawing.Point(501, 5);
            this.NS_l.Name = "NS_l";
            this.NS_l.Size = new System.Drawing.Size(42, 15);
            this.NS_l.TabIndex = 6;
            this.NS_l.Text = "North";
            // 
            // long_l
            // 
            this.long_l.AutoSize = true;
            this.long_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.long_l.ForeColor = System.Drawing.Color.Maroon;
            this.long_l.Location = new System.Drawing.Point(126, 5);
            this.long_l.Name = "long_l";
            this.long_l.Size = new System.Drawing.Size(31, 15);
            this.long_l.TabIndex = 2;
            this.long_l.Text = "100";
            // 
            // EW_l
            // 
            this.EW_l.AutoSize = true;
            this.EW_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EW_l.ForeColor = System.Drawing.Color.Maroon;
            this.EW_l.Location = new System.Drawing.Point(179, 5);
            this.EW_l.Name = "EW_l";
            this.EW_l.Size = new System.Drawing.Size(35, 15);
            this.EW_l.TabIndex = 5;
            this.EW_l.Text = "East";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(364, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Latitude :";
            // 
            // lat_l
            // 
            this.lat_l.AutoSize = true;
            this.lat_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lat_l.ForeColor = System.Drawing.Color.Maroon;
            this.lat_l.Location = new System.Drawing.Point(437, 5);
            this.lat_l.Name = "lat_l";
            this.lat_l.Size = new System.Drawing.Size(23, 15);
            this.lat_l.TabIndex = 4;
            this.lat_l.Text = "90";
            // 
            // Map_Panel
            // 
            this.Map_Panel.BackgroundImage = global::Graphic_Map.Properties.Resources._6;
            this.Map_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Map_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Map_Panel.Location = new System.Drawing.Point(12, 12);
            this.Map_Panel.Name = "Map_Panel";
            this.Map_Panel.Size = new System.Drawing.Size(720, 360);
            this.Map_Panel.TabIndex = 1;
            this.Map_Panel.MouseLeave += new System.EventHandler(this.Map_Panel_MouseLeave);
            this.Map_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Map_Panel_Paint);
            this.Map_Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Map_Panel_MouseMove);
            this.Map_Panel.MouseEnter += new System.EventHandler(this.Map_Panel_MouseEnter);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(741, 521);
            this.Controls.Add(this.ChangeMap_b);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.LatLon_p);
            this.Controls.Add(this.Map_Panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graphic Map";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.LatLon_p.ResumeLayout(false);
            this.LatLon_p.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Map_Panel;
        private System.Windows.Forms.Panel LatLon_p;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NS_l;
        private System.Windows.Forms.Label long_l;
        private System.Windows.Forms.Label EW_l;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lat_l;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button DrawIcon_b;
        private System.Windows.Forms.Button DrawPoint_b;
        private System.Windows.Forms.TextBox lat_t;
        private System.Windows.Forms.TextBox long_t;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Night_ch;
        private System.Windows.Forms.CheckBox Sun_ch;
        private System.Windows.Forms.CheckBox Grid_ch;
        private System.Windows.Forms.Button ChangeMap_b;
    }
}

