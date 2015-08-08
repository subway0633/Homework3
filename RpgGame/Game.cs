using RpgGame.Data;
using RpgGame.ObserverPattern;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RpgGame
{
    public partial class Game : Form, IObserverable
    {
        private Player Zoro, Luffy, Sanji, Nami;

        private List<IObserver> Players = new List<IObserver>();
        private int kingDamage;

        public Game()
        {
            InitializeComponent();

            Zoro = new Player() { Name = "索隆", Health = 15000 };
            Luffy = new Player() { Name = "魯夫", Health = 20000 };
            Sanji = new Player() { Name = "香吉士", Health = 10000 };
            Nami = new Player() { Name = "娜美", Health = 8000 };
        }

        private void Game_Load(object sender, EventArgs e)
        {
            Players.Add(Zoro);
            Players.Add(Luffy);
            Players.Add(Nami);
            Players.Add(Sanji);

            lblNamePlayA.Text = Zoro.Name;
            lblNamePlayB.Text = Luffy.Name;
            lblNamePlayC.Text = Nami.Name;
            lblNamePlayD.Text = Sanji.Name;
            lblHpPlayerA.Text = Zoro.Health.ToString();
            lblHpPlayerB.Text = Luffy.Health.ToString();
            lblHpPlayerC.Text = Nami.Health.ToString();
            lblHpPlayerD.Text = Sanji.Health.ToString();
        }

        public void Help(Player player)
        {
            txtState.Text += string.Format("目標是{0}", player.Name + "!!!\n");
            Notify(player);
            txtState.Text += player.Message + "\n";
            foreach (var play in Players)
                if ((play as Player) != player)
                {
                    txtState.Text += (play as Player).Name + " ";
                }
            txtState.Text += "快來救我!!\n";
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            kingDamage = random.Next(3000, 5000);
            txtState.Text += string.Format("攻擊傷害:{0}\n", kingDamage);
            int randomAttack = random.Next(0, 4);
            switch (randomAttack)
            {
                case 0:
                    Zoro.Health -= kingDamage;

                    if (Zoro.Health > 0)
                    {
                        Help(Zoro);
                        lblHpPlayerA.Text = "HP:" + Zoro.Health;
                    }
                    else
                    {
                        lblHpPlayerA.Text = "HP:" + Zoro.Health;
                        txtState.Text += Zoro.Name + "已死了\n";
                        picPlayerA.Image = RpgGame.Properties.Resources.die;
                        Players.Remove(Zoro);
                    }

                    break;

                case 1:
                    Luffy.Health -= kingDamage;

                    if (Luffy.Health > 0)
                    {
                        Help(Luffy);
                        lblHpPlayerB.Text = "HP:" + Luffy.Health;
                    }
                    else
                    {
                        lblHpPlayerB.Text = "HP:" + Luffy.Health;
                        txtState.Text += Luffy.Name + "已死了\n";
                        picPlayerB.Image = RpgGame.Properties.Resources.die;
                        Players.Remove(Luffy);
                    }

                    break;

                case 2:

                    Nami.Health -= kingDamage;

                    if (Nami.Health > 0)
                    {
                        lblHpPlayerC.Text = "HP:" + Nami.Health;
                        Help(Nami);
                    }
                    else
                    {
                        lblHpPlayerC.Text = "HP:" + Nami.Health;
                        txtState.Text += Nami.Name + "已死了\n";
                        picPlayerC.Image = RpgGame.Properties.Resources.die;

                        Players.Remove(Nami);
                    }

                    break;

                case 3:

                    Sanji.Health -= kingDamage;

                    if (Sanji.Health > 0)
                    {
                        lblHpPlayerD.Text = "HP:" + Sanji.Health;
                        Help(Sanji);
                    }
                    else
                    {
                        lblHpPlayerD.Text = "HP:" + Sanji.Health;
                        txtState.Text += Sanji.Name + "已死了\n";
                        picPlayerD.Image = RpgGame.Properties.Resources.die;
                        Players.Remove(Sanji);
                    }

                    break;

                default:
                    break;
            }
        }

        public void AddObserver(IObserver o)
        {
            Players.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            Players.Remove(o);
        }

        public void Notify(EventArgs e)
        {
            foreach (var o in Players)
                o.UpdataMessage(e);
        }
    }
}