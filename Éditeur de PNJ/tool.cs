using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Éditeur_de_PNJ
{
    public partial class tool : Form
    {
        private config config;
        private MySqlConnection bdd;
        private Dictionary<int, npc> npcs;
        private npc open_pnj;

        public tool(config config)
        {
            this.config = config;
            this.npcs = new Dictionary<int, npc>();
            InitializeComponent();
            this.load_bdd.Visible = this.config.get_bdd();
            this.load_swf.Visible = this.config.get_swf();
        }

        private void ch_config_hover(object sender, EventArgs e)
        {
            Font font = new Font(this.ch_config.Font.FontFamily, this.ch_config.Font.Size, FontStyle.Bold);
            this.ch_config.Font = font;
        }

        private void ch_config_leave(object sender, EventArgs e)
        {
            Font font = new Font(this.ch_config.Font.FontFamily, this.ch_config.Font.Size, FontStyle.Regular);
            this.ch_config.Font = font;
        }

        private void me_close(object sender, FormClosingEventArgs e)
        {
            if (this.bdd != null)
                this.bdd.Close();
        }

        private void flatClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flatMini1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ch_config_Click(object sender, EventArgs e)
        {
            win_config new_config = new win_config(this.config);
            new_config.load(this);
            new_config.Show(this);
            this.AddOwnedForm(new_config);
            this.Enabled = false;
        }

        private void choose_item(object sender, EventArgs e)
        {
            int id;
            ListViewItem elem = this.list.SelectedItems[0];
            npc pnj;
            
            id = int.Parse(elem.SubItems[1].Text);
            if (this.npcs.ContainsKey(id))
            {
                pnj = this.npcs[id];
                this.load_npc(pnj);
                this.open_pnj = pnj;
            }
        }

        private void load_npc(npc pnj)
        {
            this.pnj_name.Text = pnj.Name;
            this.pnj_gfxid.Text = pnj.GfxID.ToString();
            this.pnj_id.Text = pnj.ID.ToString();
            this.pnj_sexe.Text = pnj.Sex == 1 ? "Femelle" : pnj.Sex == 0 ? "Male" : "Unknow";
            this.gb3.Visible = true;
        }

        private void open_bdd()
        {
            if (this.bdd != null)
                return;
            try
            {
                this.bdd = new MySqlConnection("SERVER=" + this.config.get_host() + "; DATABASE=" + this.config.get_db() + "; UID=" + this.config.get_user() + "; PASSWORD=" + this.config.get_pass());
                this.bdd.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur c'est produite lors de la connexion à la base de donnée !", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void load_bdd_Click(object sender, EventArgs e)
        {
            this.load_bdd.Enabled = false;
            this.load_swf.Enabled = false;
            this.list.Enabled = false;
            this.gb3.Visible = false;
            MySqlCommand request;
            MySqlDataReader data;
            npc pnj;

            this.open_bdd();
            if (this.bdd == null || this.bdd.State != ConnectionState.Open)
            {
                this.load_bdd.Enabled = true;
                this.load_swf.Enabled = true;
                this.list.Enabled = true;
                return;
            }
            request = this.bdd.CreateCommand();
            request.CommandText = "SELECT * FROM npc_template ORDER BY id ASC;";
            data = request.ExecuteReader();
            while (data.Read())
            {
                if (this.npcs.ContainsKey(data.GetInt32("id")))
                    pnj = this.npcs[data.GetInt32("id")];
                else
                    pnj = new npc(data.GetInt32("id"));
                if (!this.npcs.ContainsKey(pnj.ID))
                    this.npcs.Add(pnj.ID, pnj);

                pnj.GfxID = data.GetInt32("gfxID");
                pnj.Sex = data.GetInt32("sex");
                pnj.Size = data.GetInt32("scaleX") * data.GetInt32("scaleY") / 100;
                pnj.Colors = new int[] { data.GetInt32("color1"), data.GetInt32("color2"), data.GetInt32("color3") };
            }
            data.Close();
            this.load_npcs();
            this.load_bdd.Enabled = true;
            this.load_swf.Enabled = true;
            this.list.Enabled = true;
        }

        private void load_npcs()
        {
            string flag;
            this.list.Items.Clear();
            foreach (npc pnj in this.npcs.Values)
            {
                flag = "";
                flag += pnj.get_load_swf() ? "S" : "";
                flag += pnj.get_load_bdd() ? flag.Length != 0 ? "/B" : "B" : "";
                ListViewItem item = new ListViewItem(flag);
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, pnj.ID.ToString()));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, pnj.Name));
                this.list.Items.Add(item);
            }
        }

        private void load_swf_Click(object sender, EventArgs e)
        {
            int id;
            string name;
            string action;
            npc pnj;

            this.load_bdd.Enabled = false;
            this.load_swf.Enabled = false;
            this.list.Enabled = false;
            this.gb3.Visible = false;
            foreach (string line in this.config.get_swf_content())
            {
                try
                {
                    name = "";
                    id = -1;
                    action = "";
                    if (!line.StartsWith("N.d["))
                        continue;
                    string[] args = line.Split('=');
                    id = int.Parse(args[0].Substring(args[0].IndexOf('[') + 1, args[0].IndexOf(']') - (args[0].IndexOf('[') + 1)));
                    if (args[1].Contains("a:"))
                        action = args[1].Substring(args[1].IndexOf('[') + 1, args[1].IndexOf(']') - (args[1].IndexOf('[') + 1));
                    name = args[1].Split('"')[1];
                    if (this.npcs.ContainsKey(id))
                    {
                        pnj = this.npcs[id];
                        pnj.set_actions(action);
                        pnj.Name = name;
                        pnj.set_load_swf(true);
                    }
                    else
                        pnj = new npc(id, name, action);
                    if (!this.npcs.ContainsKey(id))
                        this.npcs.Add(pnj.ID, pnj);
                }catch (Exception test)
                {
                    Debug.WriteLine(test.Message);
                }
            }
            this.load_npcs();
            this.load_bdd.Enabled = true;
            this.load_swf.Enabled = true;
            this.list.Enabled = true;
        }

        private bool save_pnj()
        {
            try
            {
                this.open_pnj.Name = this.pnj_name.Text;
                if (this.pnj_name.Text.ToLower() != "unknow")
                    this.open_pnj.set_load_swf(true);
                this.open_pnj.GfxID = int.Parse(this.pnj_gfxid.Text);
                this.open_pnj.Sex = this.pnj_sexe.Text.Equals("Femelle") ? 1 : -1;
                this.open_pnj.Sex = this.pnj_sexe.Text.Equals("Male") ? 0 : this.open_pnj.Sex;
                if (this.open_pnj.Sex < 0)
                {
                    MessageBox.Show("Veuillez choisir le sexe du PNJ !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return (false);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false);
            }
            return (true);
        }

        private void send_Click(object sender, EventArgs e)
        {
            this.send.Enabled = false;
            MySqlCommand request;
            string sql = "", swf = "";

            if (!this.save_pnj())
            {
                this.send.Enabled = true;
                return;
            }
            swf = "N.d[" + this.open_pnj.ID + "] = {";
            if (this.open_pnj.Actions.Length > 0)
                swf += "a: [" + this.open_pnj.get_actions() + "], ";
            swf += "n: \""+ this.open_pnj.Name +"\"};";
            sql = "UPDATE npc_template SET gfxID="+this.open_pnj.GfxID+",sex="+this.open_pnj.Sex+" WHERE id="+this.open_pnj.ID+";";
            if (this.config.get_bdd())
                this.open_bdd();
            //SWF
            if (this.config.get_swf()) //Finir le fichier PHP
            {
                try
                {
                    new WebClient().DownloadString(this.config.get_url() + "?content=" + swf);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.config.save_swf(this.npcs);
            }
            //BDD
            if (this.config.get_bdd())
            {
                request = this.bdd.CreateCommand();
                request.CommandText = sql;
                try
                {
                    request.ExecuteNonQuery();
                }
                catch (Exception error2)
                {
                    MessageBox.Show(error2.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //Local
            if (File.Exists("SWF_" + this.open_pnj.ID + ".txt"))
                File.Delete("SWF_" + this.open_pnj.ID + ".txt");
            if (File.Exists("SQL_" + this.open_pnj.ID + ".sql"))
                File.Delete("SQL_" + this.open_pnj.ID + ".sql");
            File.WriteAllText("SWF_" + this.open_pnj.ID + ".txt", swf);
            File.WriteAllText("SQL_" + this.open_pnj.ID + ".sql", sql);
            this.send.Enabled = true;
        }
    }
}
