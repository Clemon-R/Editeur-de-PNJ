using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace Éditeur_de_PNJ
{
    public class config
    {
        private string[] allVars = new string[] {"BDD", "SWF"};
        private string file;
        private bool bdd;
        private string host;
        private string user;
        private string pass;
        private string db;
        private bool swf;
        private string[] swf_content;
        private string url;

        public config()
        {
            this.bdd = false;
            this.swf = false;
        }

        public void set_bdd(string host, string user, string pass, string db)
        {
            this.bdd = true;
            this.host = host;
            this.user = user;
            this.pass = pass;
            this.db = db;
        }

        public bool load(string file_name)
        {
            this.file = file_name;
            if (File.Exists(this.file))
            {
                string content = File.ReadAllText(this.file);
                foreach (string param in this.allVars)
                {
                    if (!content.Contains(param + "="))
                    {
                        File.Delete(this.file);
                        MessageBox.Show("Votre config est érroné !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                foreach (string param in content.Split('\n'))
                {
                    if (!param.Contains('='))
                        continue;
                    string[] arg = param.Split('=');
                    switch (arg[0])
                    {
                        case "BDD":
                            this.bdd = arg[1].ToLower().Equals("true");
                            break;
                        case "HOST":
                            this.host = arg[1];
                            break;
                        case "USER":
                            this.user = arg[1];
                            break;
                        case "PASS":
                            this.pass = arg[1];
                            break;
                        case "DB":
                            this.db = arg[1];
                            break;
                        case "SWF":
                            this.swf = arg[1].ToLower().Equals("true");
                            break;
                        case "URL":
                            this.url = arg[1];
                            if (!this.url.Contains("npc.php"))
                                return false;
                            break;
                    }
                }
                if (this.swf && File.Exists("npc_fr_x.txt"))
                {
                    this.swf_content = File.ReadAllLines("npc_fr_x.txt");
                }
                else if (this.swf)
                {
                    MessageBox.Show("Fichier npc_fr_x.txt non trouvable !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }
            return false;
        }

        public void set_swf(string url, string content)
        {
            this.swf = true;
            this.swf_content = content.Replace(Environment.NewLine, "\n").Split('\n');
            this.url = url;
        }

        public void save()
        {
            string content = "";

            if (this.bdd)
            {
                content += "BDD=true" + "\n";
                content += "HOST=" + this.host + "\n";
                content += "USER=" + this.user + "\n";
                content += "PASS=" + this.pass + "\n";
                content += "DB=" + this.db + "\n";
            }
            else
                content += "BDD=false\n";

            if (this.swf)
            {
                content += "SWF=true\n";
                content += "URL=" + this.url + "\n";
            }
            else
                content += "SWF=false\n";

            if (File.Exists("npc_fr_x.txt"))
                File.Delete("npc_fr_x.txt");
            if (File.Exists("config.conf"))
                File.Delete("config.conf");
            File.WriteAllText("config.conf", content);
            File.WriteAllLines("npc_fr_x.txt", this.swf_content);
        }

        public void save_swf(Dictionary<int, npc> list)
        {
            string new_content = "";

            foreach (string line in this.swf_content)
                if (!line.Contains("N.d[") && !line.Contains("FILE_END"))
                    new_content += line + Environment.NewLine;
            foreach (npc pnj in list.Values)
                if (pnj.get_load_swf())
                {
                    new_content += "N.d[" + pnj.ID + "] = {";
                    if (pnj.Actions != null  && pnj.Actions.Length > 0)
                        new_content += "a: [" + pnj.get_actions() + "], ";
                    new_content += "n: \"" + pnj.Name + "\"};" + Environment.NewLine;
                }
            new_content += "FILE_END = true;";
            if (File.Exists("npc_fr_x.txt"))
                File.Delete("npc_fr_x.txt");
            File.WriteAllText("npc_fr_x.txt", new_content);
        }

        public string get_file_name()
        {
            return (this.file);
        }

        public bool get_swf()
        {
            return this.swf;
        }

        public bool get_bdd()
        {
            return this.bdd;
        }

        public string get_url()
        {
            return (this.url);
        }

        public string[] get_swf_content()
        {
            return (this.swf_content);
        }

        public string get_host()
        {
            return (this.host);
        }

        public string get_user()
        {
            return (this.user);
        }

        public string get_pass()
        {
            return (this.pass);
        }

        public string get_db()
        {
            return (this.db);
        }
    }
}
