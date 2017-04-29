namespace Éditeur_de_PNJ
{
    partial class tool
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
            this.editor = new theme.FormSkin();
            this.gb3 = new theme.FlatGroupBox();
            this.send = new theme.FlatButton();
            this.pnj_sexe = new theme.FlatComboBox();
            this.pnj_gfxid = new theme.FlatTextBox();
            this.flatLabel2 = new theme.FlatLabel();
            this.pnj_id = new theme.FlatTextBox();
            this.tcgrfds = new theme.FlatLabel();
            this.pnj_name = new theme.FlatTextBox();
            this.flatLabel1 = new theme.FlatLabel();
            this.load_swf = new theme.FlatButton();
            this.load_bdd = new theme.FlatButton();
            this.list = new System.Windows.Forms.ListView();
            this.kind = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_config = new theme.FlatButton();
            this.flatMini1 = new theme.FlatMini();
            this.flatClose1 = new theme.FlatClose();
            this.editor.SuspendLayout();
            this.gb3.SuspendLayout();
            this.SuspendLayout();
            // 
            // editor
            // 
            this.editor.BackColor = System.Drawing.Color.White;
            this.editor.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.editor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.editor.Controls.Add(this.gb3);
            this.editor.Controls.Add(this.load_swf);
            this.editor.Controls.Add(this.load_bdd);
            this.editor.Controls.Add(this.list);
            this.editor.Controls.Add(this.ch_config);
            this.editor.Controls.Add(this.flatMini1);
            this.editor.Controls.Add(this.flatClose1);
            this.editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editor.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.editor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.editor.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.editor.HeaderMaximize = false;
            this.editor.Location = new System.Drawing.Point(0, 0);
            this.editor.Name = "editor";
            this.editor.Size = new System.Drawing.Size(797, 475);
            this.editor.TabIndex = 0;
            this.editor.Text = "Éditeur de PNJ";
            // 
            // gb3
            // 
            this.gb3.BackColor = System.Drawing.Color.Transparent;
            this.gb3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.gb3.Controls.Add(this.send);
            this.gb3.Controls.Add(this.pnj_sexe);
            this.gb3.Controls.Add(this.pnj_gfxid);
            this.gb3.Controls.Add(this.flatLabel2);
            this.gb3.Controls.Add(this.pnj_id);
            this.gb3.Controls.Add(this.tcgrfds);
            this.gb3.Controls.Add(this.pnj_name);
            this.gb3.Controls.Add(this.flatLabel1);
            this.gb3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gb3.Location = new System.Drawing.Point(277, 93);
            this.gb3.Name = "gb3";
            this.gb3.ShowText = true;
            this.gb3.Size = new System.Drawing.Size(520, 369);
            this.gb3.TabIndex = 9;
            this.gb3.Text = "PNJ";
            this.gb3.Visible = false;
            // 
            // send
            // 
            this.send.BackColor = System.Drawing.Color.Transparent;
            this.send.BaseColor = System.Drawing.Color.DarkSeaGreen;
            this.send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.send.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.send.Location = new System.Drawing.Point(407, 346);
            this.send.Name = "send";
            this.send.Rounded = false;
            this.send.Size = new System.Drawing.Size(97, 24);
            this.send.TabIndex = 7;
            this.send.Text = "Sauvegarde";
            this.send.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // pnj_sexe
            // 
            this.pnj_sexe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnj_sexe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnj_sexe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.pnj_sexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pnj_sexe.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.pnj_sexe.ForeColor = System.Drawing.Color.White;
            this.pnj_sexe.FormattingEnabled = true;
            this.pnj_sexe.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.pnj_sexe.ItemHeight = 18;
            this.pnj_sexe.Items.AddRange(new object[] {
            "Male",
            "Femelle"});
            this.pnj_sexe.Location = new System.Drawing.Point(448, 38);
            this.pnj_sexe.Name = "pnj_sexe";
            this.pnj_sexe.Size = new System.Drawing.Size(69, 24);
            this.pnj_sexe.TabIndex = 6;
            // 
            // pnj_gfxid
            // 
            this.pnj_gfxid.BackColor = System.Drawing.Color.Transparent;
            this.pnj_gfxid.Location = new System.Drawing.Point(385, 36);
            this.pnj_gfxid.MaxLength = 11;
            this.pnj_gfxid.Multiline = false;
            this.pnj_gfxid.Name = "pnj_gfxid";
            this.pnj_gfxid.ReadOnly = false;
            this.pnj_gfxid.Size = new System.Drawing.Size(60, 29);
            this.pnj_gfxid.TabIndex = 5;
            this.pnj_gfxid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnj_gfxid.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnj_gfxid.UseSystemPasswordChar = false;
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(306, 43);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(76, 13);
            this.flatLabel2.TabIndex = 4;
            this.flatLabel2.Text = "Apparence ID";
            // 
            // pnj_id
            // 
            this.pnj_id.BackColor = System.Drawing.Color.Transparent;
            this.pnj_id.Location = new System.Drawing.Point(46, 36);
            this.pnj_id.MaxLength = 11;
            this.pnj_id.Multiline = false;
            this.pnj_id.Name = "pnj_id";
            this.pnj_id.ReadOnly = true;
            this.pnj_id.Size = new System.Drawing.Size(63, 29);
            this.pnj_id.TabIndex = 3;
            this.pnj_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnj_id.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnj_id.UseSystemPasswordChar = false;
            // 
            // tcgrfds
            // 
            this.tcgrfds.AutoSize = true;
            this.tcgrfds.BackColor = System.Drawing.Color.Transparent;
            this.tcgrfds.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.tcgrfds.ForeColor = System.Drawing.Color.White;
            this.tcgrfds.Location = new System.Drawing.Point(25, 43);
            this.tcgrfds.Name = "tcgrfds";
            this.tcgrfds.Size = new System.Drawing.Size(18, 13);
            this.tcgrfds.TabIndex = 2;
            this.tcgrfds.Text = "ID";
            // 
            // pnj_name
            // 
            this.pnj_name.BackColor = System.Drawing.Color.Transparent;
            this.pnj_name.Location = new System.Drawing.Point(147, 36);
            this.pnj_name.MaxLength = 255;
            this.pnj_name.Multiline = false;
            this.pnj_name.Name = "pnj_name";
            this.pnj_name.ReadOnly = false;
            this.pnj_name.Size = new System.Drawing.Size(156, 29);
            this.pnj_name.TabIndex = 1;
            this.pnj_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnj_name.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnj_name.UseSystemPasswordChar = false;
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(113, 43);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(31, 13);
            this.flatLabel1.TabIndex = 0;
            this.flatLabel1.Text = "Nom";
            // 
            // load_swf
            // 
            this.load_swf.BackColor = System.Drawing.Color.Transparent;
            this.load_swf.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.load_swf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.load_swf.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.load_swf.Location = new System.Drawing.Point(533, 54);
            this.load_swf.Name = "load_swf";
            this.load_swf.Rounded = false;
            this.load_swf.Size = new System.Drawing.Size(204, 32);
            this.load_swf.TabIndex = 8;
            this.load_swf.Text = "Charger les swf";
            this.load_swf.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.load_swf.Visible = false;
            this.load_swf.Click += new System.EventHandler(this.load_swf_Click);
            // 
            // load_bdd
            // 
            this.load_bdd.BackColor = System.Drawing.Color.Transparent;
            this.load_bdd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.load_bdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.load_bdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.load_bdd.Location = new System.Drawing.Point(323, 54);
            this.load_bdd.Name = "load_bdd";
            this.load_bdd.Rounded = false;
            this.load_bdd.Size = new System.Drawing.Size(204, 32);
            this.load_bdd.TabIndex = 7;
            this.load_bdd.Text = "Charger la base de donnée";
            this.load_bdd.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.load_bdd.Visible = false;
            this.load_bdd.Click += new System.EventHandler(this.load_bdd_Click);
            // 
            // list
            // 
            this.list.AllowColumnReorder = true;
            this.list.AutoArrange = false;
            this.list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.kind,
            this.id,
            this.name});
            this.list.Cursor = System.Windows.Forms.Cursors.Default;
            this.list.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.list.ForeColor = System.Drawing.Color.White;
            this.list.FullRowSelect = true;
            this.list.HoverSelection = true;
            this.list.LabelWrap = false;
            this.list.Location = new System.Drawing.Point(3, 50);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(266, 413);
            this.list.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.list.TabIndex = 6;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            this.list.DoubleClick += new System.EventHandler(this.choose_item);
            // 
            // kind
            // 
            this.kind.Text = "#";
            this.kind.Width = 25;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.id.Width = 75;
            // 
            // name
            // 
            this.name.Text = "Titre";
            this.name.Width = 160;
            // 
            // ch_config
            // 
            this.ch_config.BackColor = System.Drawing.Color.Transparent;
            this.ch_config.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ch_config.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ch_config.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ch_config.Location = new System.Drawing.Point(148, 12);
            this.ch_config.Name = "ch_config";
            this.ch_config.Rounded = false;
            this.ch_config.Size = new System.Drawing.Size(220, 32);
            this.ch_config.TabIndex = 4;
            this.ch_config.Text = "Changer de configuration";
            this.ch_config.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ch_config.Click += new System.EventHandler(this.ch_config_Click);
            this.ch_config.MouseLeave += new System.EventHandler(this.ch_config_leave);
            this.ch_config.MouseHover += new System.EventHandler(this.ch_config_hover);
            // 
            // flatMini1
            // 
            this.flatMini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMini1.BackColor = System.Drawing.Color.White;
            this.flatMini1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMini1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatMini1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMini1.Location = new System.Drawing.Point(743, 12);
            this.flatMini1.Name = "flatMini1";
            this.flatMini1.Size = new System.Drawing.Size(18, 18);
            this.flatMini1.TabIndex = 3;
            this.flatMini1.Text = "flatMini1";
            this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatMini1.Click += new System.EventHandler(this.flatMini1_Click);
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatClose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(767, 12);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 2;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatClose1.Click += new System.EventHandler(this.flatClose1_Click);
            // 
            // tool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 475);
            this.Controls.Add(this.editor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tool";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.me_close);
            this.editor.ResumeLayout(false);
            this.gb3.ResumeLayout(false);
            this.gb3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private theme.FormSkin editor;
        private theme.FlatMini flatMini1;
        private theme.FlatClose flatClose1;
        private theme.FlatButton ch_config;
        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.ColumnHeader kind;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private theme.FlatButton load_swf;
        private theme.FlatButton load_bdd;
        private theme.FlatGroupBox gb3;
        private theme.FlatTextBox pnj_name;
        private theme.FlatLabel flatLabel1;
        private theme.FlatTextBox pnj_id;
        private theme.FlatLabel tcgrfds;
        private theme.FlatTextBox pnj_gfxid;
        private theme.FlatLabel flatLabel2;
        private theme.FlatComboBox pnj_sexe;
        private theme.FlatButton send;
    }
}