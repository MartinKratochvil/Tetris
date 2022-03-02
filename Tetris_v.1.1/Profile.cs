using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tetris_v._1._1 {
    public partial class Profile : Form {
        public Profile() {
            InitializeComponent();
        }
        private void Profil_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
        private void Profil_Load(object sender, EventArgs e) {
            LabelNickname.Text = Start.nickname;
            LabelCoins.Text = MenuTetris.Progress[0];
            label3.Text = MenuTetris.Progress[1];
            label4.Text = Math.Round(double.Parse(MenuTetris.Progress[2]), 2).ToString() + " s";
            label6.Text = MenuTetris.Progress[3];
            label8.Text = MenuTetris.Progress[4];
        }
        private void ButtonMinigames_Click(object sender, EventArgs e) {
            this.Hide();
            MenuTetris form = new MenuTetris();
            form.Show();
        }
        private void ButtonShop_Click(object sender, EventArgs e) {
            this.Hide();
            Shop form = new Shop();
            form.Show();
        }
        private void ButtonLeaderboard_Click(object sender, EventArgs e) {
            this.Hide();
            Leaderboard form = new Leaderboard();
            form.Show();
        }
        private void ButtonSave_Click(object sender, EventArgs e) {
            using (StreamWriter write = File.CreateText(MenuTetris.SavePath)) {
                for (int i = 0; i < MenuTetris.MAX; ++i) {
                    write.WriteLine(MenuTetris.Encr(MenuTetris.Progress[i]));
                }
            }
        }
        private void ButtonExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
