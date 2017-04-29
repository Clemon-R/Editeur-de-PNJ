using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Éditeur_de_PNJ
{
    public class npc
    {
        //Main information
        private int id;
        private string name;
        private int[] actions = null;
        private int gfdID = -1, size = 100, sex = -1, color1 = -1, color2 = -1, color3 = -1, question;

        #region "Properties"
        public string Name
        {
            get
            {
                return (this.name);
            }
            set
            {
                this.name = value;
            }
        }
        public int ID
        {
            get
            {
                return (this.id);
            }
            set
            {
                this.id = value;
            }
        }
        public int[] Actions
        {
            get
            {
                return (this.actions);
            }
            set
            {
                this.actions = value;
            }
        }
        public int GfxID
        {
            get
            {
                return (this.gfdID);
            }
            set
            {
                this.gfdID = value;
            }
        }
        public int Sex
        {
            get
            {
                return (this.sex);
            }
            set
            {
                this.sex = value;
            }
        }
        public int Size
        {
            get
            {
                return (this.size);
            }
            set
            {
                this.size = value;
            }
        }
        public int[] Colors
        {
            get
            {
                return (new int[] {this.color1, this.color2, this.color3});
            }
            set
            {
                this.color1 = value[0];
                this.color2 = value[1];
                this.color3 = value[2];
            }
        }
        #endregion

        //Tool information
        private bool load_bdd = false;
        private bool load_swf = false;

        public npc(int id)
        {
            this.id = id;
            this.name = "Unknow";
            this.actions = null;
            this.load_bdd = true;
        }

        public npc(int id, string name, string actions)
        {
            string[] args = actions.Split(',');

            this.id = id;
            this.name = name;
            if (actions.Length > 0)
                this.actions = new int[args.Length];
            else
                this.actions = null;
            this.load_swf = true;

            for (int i = 0;actions.Length > 0 && i < args.Length;i++)
            {
                try
                {
                    this.actions[i] = int.Parse(args[i].Replace(" ", ""));
                }catch
                {
                    break;
                }
            }
        }

        public void set_load_swf(bool value)
        {
            this.load_swf = value;
        }

        public bool get_load_swf()
        {
            return (this.load_swf);
        }

        public bool get_load_bdd()
        {
            return (this.load_bdd);
        }

        public string get_actions()
        {
            string args = "";
            foreach (int value in this.actions)
            {
                if (args.Length > 0)
                    args += ",";
                args += value.ToString();
            }
            return (args);
        }

        public void set_actions(string actions)
        {
            string[] args = actions.Split(',');
            this.actions = new int[args.Length];
            for (int i = 0; i < args.Length; i++)
            {
                try
                {
                    this.actions[i] = int.Parse(args[i]);
                }
                catch
                {
                    break;
                }
            }
        }
    }
}
