using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using theme;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Éditeur_de_PNJ
{
    public partial class win_config : Form
    {
        private config config;
        private tool tool;
        private bool reload;

        public win_config(config config)
        {
            this.reload = false;
            this.config = config;
            InitializeComponent();
        }

        public void load(tool tool)
        {
            this.tool = tool;
            this.reload = true;
            this.bdd.Checked = config.get_bdd();
            this.gb1.Visible = config.get_bdd();
            this.swf.Checked = config.get_swf();
            this.gb2.Visible = config.get_swf();
            if (this.gb2.Visible)
            {
                this.host.Text = config.get_host();
                this.user.Text = config.get_user();
                this.pass.Text = config.get_pass();
                this.db.Text = config.get_db();
            }
            this.url.Text = config.get_url();
            this.content.Text = config.get_swf_content().Length != 0 ? "" : this.content.Text;
            foreach (string line in config.get_swf_content())
            {
                this.content.Text += line + Environment.NewLine;
            }
        }

        private void flatClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flatMini1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bdd_CheckedChanged(object sender)
        {
            this.gb1.Visible = this.bdd.Checked;
        }

        private void save_Click(object sender, EventArgs e)
        {
            FlatTextBox[] list = new FlatTextBox[] {this.host, this.user, this.db};
            MySqlConnection con;

            foreach (FlatTextBox text in list)
            {
                if (text.Text.Length <= 0 || text.Text.Length > 255)
                {
                    MessageBox.Show("Un champ est invalide car sa taille dépasse 255 caractères ou est vide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            try
            {
                con = new MySqlConnection("SERVER=" + this.host.Text + "; DATABASE=" + this.db.Text + "; UID=" + this.user.Text + "; PASSWORD=" + this.pass.Text);
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Un problème est survenu lors de la connexion à la base de donnée !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (con.State == ConnectionState.Open)
            {
                this.config.set_bdd(this.host.Text, this.user.Text, this.pass.Text, this.db.Text);
                con.Close();
                MessageBox.Show("Vos identifient ont bien été enregister !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.bdd.Enabled = false;
                this.gb1.Enabled = false;
            }
            else
                MessageBox.Show("Un problème est survenu lors de la connexion à la base de donnée !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void end_Click(object sender, EventArgs e)
        {
            if (this.swf.Checked)
            {
                Uri create;                
                if (this.url.Text.Length == 0 || !Uri.TryCreate(this.url.Text, UriKind.Absolute, out create) || !this.url.Text.Contains("npc.php"))
                {
                    MessageBox.Show("Url incorrecte, veuillez entrer une url valide !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (this.content.Text.Length == 0 || this.content.Text.Equals("Contenu de votre fichier npc_fr_x.swf"))
                {
                    MessageBox.Show("Veuillez entrer le contenu de votre dossier npc_fr_x.swf !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                this.config.set_swf(this.url.Text, this.content.Text);
            }
            this.config.save();
            MessageBox.Show("L'application va maintenant redémarrer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Process.Start(Assembly.GetExecutingAssembly().GetName().Name + ".exe");
            if (this.Owner != null)
                this.Owner.Close();
            this.Close();
        }

        private void swf_CheckedChanged(object sender)
        {
            this.gb2.Visible = this.swf.Checked;
        }
    }
}
