namespace Éditeur_de_PNJ
{
    partial class win_config
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
            this.main = new theme.FormSkin();
            this.gb2 = new theme.FlatGroupBox();
            this.content = new theme.FlatTextBox();
            this.flatLabel5 = new theme.FlatLabel();
            this.url = new theme.FlatTextBox();
            this.swf = new theme.FlatToggle();
            this.flatLabel4 = new theme.FlatLabel();
            this.end = new theme.FlatButton();
            this.gb1 = new theme.FlatGroupBox();
            this.save = new theme.FlatButton();
            this.db = new theme.FlatTextBox();
            this.pass = new theme.FlatTextBox();
            this.user = new theme.FlatTextBox();
            this.host = new theme.FlatTextBox();
            this.flatLabel3 = new theme.FlatLabel();
            this.flatLabel2 = new theme.FlatLabel();
            this.flatLabel1 = new theme.FlatLabel();
            this.lbl2 = new theme.FlatLabel();
            this.bdd = new theme.FlatToggle();
            this.lbl1 = new theme.FlatLabel();
            this.flatMini1 = new theme.FlatMini();
            this.flatClose1 = new theme.FlatClose();
            this.main.SuspendLayout();
            this.gb2.SuspendLayout();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // main
            // 
            this.main.BackColor = System.Drawing.Color.White;
            this.main.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.main.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.main.Controls.Add(this.gb2);
            this.main.Controls.Add(this.swf);
            this.main.Controls.Add(this.flatLabel4);
            this.main.Controls.Add(this.end);
            this.main.Controls.Add(this.gb1);
            this.main.Controls.Add(this.bdd);
            this.main.Controls.Add(this.lbl1);
            this.main.Controls.Add(this.flatMini1);
            this.main.Controls.Add(this.flatClose1);
            this.main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.main.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.main.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.main.HeaderMaximize = false;
            this.main.Location = new System.Drawing.Point(0, 0);
            this.main.MaximumSize = new System.Drawing.Size(584, 361);
            this.main.MinimumSize = new System.Drawing.Size(584, 361);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(584, 361);
            this.main.TabIndex = 0;
            this.main.Text = "Configuration";
            // 
            // gb2
            // 
            this.gb2.BackColor = System.Drawing.Color.Transparent;
            this.gb2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.gb2.Controls.Add(this.content);
            this.gb2.Controls.Add(this.flatLabel5);
            this.gb2.Controls.Add(this.url);
            this.gb2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gb2.Location = new System.Drawing.Point(269, 94);
            this.gb2.Name = "gb2";
            this.gb2.ShowText = true;
            this.gb2.Size = new System.Drawing.Size(303, 219);
            this.gb2.TabIndex = 19;
            this.gb2.Text = "Sauvegarde SWF";
            this.gb2.Visible = false;
            // 
            // content
            // 
            this.content.BackColor = System.Drawing.Color.Transparent;
            this.content.Location = new System.Drawing.Point(15, 87);
            this.content.MaxLength = 32767;
            this.content.Multiline = true;
            this.content.Name = "content";
            this.content.ReadOnly = false;
            this.content.Size = new System.Drawing.Size(278, 128);
            this.content.TabIndex = 18;
            this.content.Text = "Contenu de votre fichier npc_fr_x.swf";
            this.content.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.content.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.content.UseSystemPasswordChar = false;
            // 
            // flatLabel5
            // 
            this.flatLabel5.AutoSize = true;
            this.flatLabel5.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel5.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel5.ForeColor = System.Drawing.Color.White;
            this.flatLabel5.Location = new System.Drawing.Point(69, 36);
            this.flatLabel5.Name = "flatLabel5";
            this.flatLabel5.Size = new System.Drawing.Size(151, 13);
            this.flatLabel5.TabIndex = 17;
            this.flatLabel5.Text = "L\'URL vers le fichier npc.php";
            // 
            // url
            // 
            this.url.BackColor = System.Drawing.Color.Transparent;
            this.url.Location = new System.Drawing.Point(15, 52);
            this.url.MaxLength = 32767;
            this.url.Multiline = false;
            this.url.Name = "url";
            this.url.ReadOnly = false;
            this.url.Size = new System.Drawing.Size(278, 29);
            this.url.TabIndex = 16;
            this.url.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.url.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.url.UseSystemPasswordChar = false;
            // 
            // swf
            // 
            this.swf.BackColor = System.Drawing.Color.Transparent;
            this.swf.Checked = false;
            this.swf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swf.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.swf.Location = new System.Drawing.Point(463, 59);
            this.swf.Name = "swf";
            this.swf.Options = theme.FlatToggle._Options.Style3;
            this.swf.Size = new System.Drawing.Size(76, 33);
            this.swf.TabIndex = 15;
            this.swf.Text = "flatToggle1";
            this.swf.CheckedChanged += new theme.FlatToggle.CheckedChangedEventHandler(this.swf_CheckedChanged);
            // 
            // flatLabel4
            // 
            this.flatLabel4.AutoSize = true;
            this.flatLabel4.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel4.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel4.ForeColor = System.Drawing.Color.White;
            this.flatLabel4.Location = new System.Drawing.Point(313, 69);
            this.flatLabel4.Name = "flatLabel4";
            this.flatLabel4.Size = new System.Drawing.Size(147, 13);
            this.flatLabel4.TabIndex = 14;
            this.flatLabel4.Text = "Utilisé la sauvegarde SWF ?";
            // 
            // end
            // 
            this.end.BackColor = System.Drawing.Color.Transparent;
            this.end.BaseColor = System.Drawing.Color.Firebrick;
            this.end.Cursor = System.Windows.Forms.Cursors.Hand;
            this.end.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.end.Location = new System.Drawing.Point(484, 326);
            this.end.Name = "end";
            this.end.Rounded = true;
            this.end.Size = new System.Drawing.Size(88, 23);
            this.end.TabIndex = 13;
            this.end.Text = "Fin";
            this.end.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.end.Click += new System.EventHandler(this.end_Click);
            // 
            // gb1
            // 
            this.gb1.BackColor = System.Drawing.Color.Transparent;
            this.gb1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.gb1.Controls.Add(this.save);
            this.gb1.Controls.Add(this.db);
            this.gb1.Controls.Add(this.pass);
            this.gb1.Controls.Add(this.user);
            this.gb1.Controls.Add(this.host);
            this.gb1.Controls.Add(this.flatLabel3);
            this.gb1.Controls.Add(this.flatLabel2);
            this.gb1.Controls.Add(this.flatLabel1);
            this.gb1.Controls.Add(this.lbl2);
            this.gb1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gb1.Location = new System.Drawing.Point(21, 98);
            this.gb1.Name = "gb1";
            this.gb1.ShowText = true;
            this.gb1.Size = new System.Drawing.Size(217, 207);
            this.gb1.TabIndex = 12;
            this.gb1.Text = "Identifient";
            this.gb1.Visible = false;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Transparent;
            this.save.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.save.Location = new System.Drawing.Point(49, 159);
            this.save.Name = "save";
            this.save.Rounded = true;
            this.save.Size = new System.Drawing.Size(106, 32);
            this.save.TabIndex = 12;
            this.save.Text = "Valider";
            this.save.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // db
            // 
            this.db.BackColor = System.Drawing.Color.Transparent;
            this.db.Location = new System.Drawing.Point(103, 124);
            this.db.MaxLength = 32767;
            this.db.Multiline = false;
            this.db.Name = "db";
            this.db.ReadOnly = false;
            this.db.Size = new System.Drawing.Size(75, 29);
            this.db.TabIndex = 11;
            this.db.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.db.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.db.UseSystemPasswordChar = false;
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.Color.Transparent;
            this.pass.Location = new System.Drawing.Point(103, 95);
            this.pass.MaxLength = 32767;
            this.pass.Multiline = false;
            this.pass.Name = "pass";
            this.pass.ReadOnly = false;
            this.pass.Size = new System.Drawing.Size(75, 29);
            this.pass.TabIndex = 10;
            this.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pass.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pass.UseSystemPasswordChar = true;
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.Color.Transparent;
            this.user.Location = new System.Drawing.Point(103, 66);
            this.user.MaxLength = 32767;
            this.user.Multiline = false;
            this.user.Name = "user";
            this.user.ReadOnly = false;
            this.user.Size = new System.Drawing.Size(75, 29);
            this.user.TabIndex = 9;
            this.user.Text = "root";
            this.user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.user.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.user.UseSystemPasswordChar = false;
            // 
            // host
            // 
            this.host.BackColor = System.Drawing.Color.Transparent;
            this.host.Location = new System.Drawing.Point(103, 37);
            this.host.MaxLength = 32767;
            this.host.Multiline = false;
            this.host.Name = "host";
            this.host.ReadOnly = false;
            this.host.Size = new System.Drawing.Size(75, 29);
            this.host.TabIndex = 8;
            this.host.Text = "127.0.0.1";
            this.host.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.host.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.host.UseSystemPasswordChar = false;
            // 
            // flatLabel3
            // 
            this.flatLabel3.AutoSize = true;
            this.flatLabel3.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel3.ForeColor = System.Drawing.Color.White;
            this.flatLabel3.Location = new System.Drawing.Point(8, 131);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(92, 13);
            this.flatLabel3.TabIndex = 7;
            this.flatLabel3.Text = "Nom de la base :";
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(18, 102);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(82, 13);
            this.flatLabel2.TabIndex = 6;
            this.flatLabel2.Text = "Mot de passe :";
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(34, 75);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(66, 13);
            this.flatLabel1.TabIndex = 5;
            this.flatLabel1.Text = "Utilisateur :";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbl2.ForeColor = System.Drawing.Color.White;
            this.lbl2.Location = new System.Drawing.Point(62, 45);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(38, 13);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Hôte :";
            // 
            // bdd
            // 
            this.bdd.BackColor = System.Drawing.Color.Transparent;
            this.bdd.Checked = false;
            this.bdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bdd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bdd.Location = new System.Drawing.Point(162, 59);
            this.bdd.Name = "bdd";
            this.bdd.Options = theme.FlatToggle._Options.Style3;
            this.bdd.Size = new System.Drawing.Size(76, 33);
            this.bdd.TabIndex = 3;
            this.bdd.Text = "flatToggle1";
            this.bdd.CheckedChanged += new theme.FlatToggle.CheckedChangedEventHandler(this.bdd_CheckedChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(12, 69);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(145, 13);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Utilisé la base de donnée ?";
            // 
            // flatMini1
            // 
            this.flatMini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMini1.BackColor = System.Drawing.Color.White;
            this.flatMini1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMini1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatMini1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMini1.Location = new System.Drawing.Point(530, 12);
            this.flatMini1.Name = "flatMini1";
            this.flatMini1.Size = new System.Drawing.Size(18, 18);
            this.flatMini1.TabIndex = 1;
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
            this.flatClose1.Location = new System.Drawing.Point(554, 12);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 0;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatClose1.Click += new System.EventHandler(this.flatClose1_Click);
            // 
            // win_config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "win_config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.main.ResumeLayout(false);
            this.main.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private theme.FormSkin main;
        private theme.FlatMini flatMini1;
        private theme.FlatClose flatClose1;
        private theme.FlatGroupBox gb1;
        private theme.FlatTextBox db;
        private theme.FlatTextBox pass;
        private theme.FlatTextBox user;
        private theme.FlatTextBox host;
        private theme.FlatLabel flatLabel3;
        private theme.FlatLabel flatLabel2;
        private theme.FlatLabel flatLabel1;
        private theme.FlatLabel lbl2;
        private theme.FlatToggle bdd;
        private theme.FlatLabel lbl1;
        private theme.FlatButton save;
        private theme.FlatButton end;
        private theme.FlatTextBox content;
        private theme.FlatLabel flatLabel5;
        private theme.FlatTextBox url;
        private theme.FlatToggle swf;
        private theme.FlatLabel flatLabel4;
        private theme.FlatGroupBox gb2;
    }
}

