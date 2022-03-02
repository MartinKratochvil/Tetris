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
    public partial class Shop : Form {
        public Shop() {
            InitializeComponent();
        }
        public static int SelectColor = 1;
        private void Shop_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
        private void Shop_Load(object sender, EventArgs e) {
            LabelNickname.Text = Start.nickname;
            LabelCoins.Text = MenuTetris.Progress[0];
            if (MenuTetris.Progress[5] == "true") {
                ButtonBuy2.Visible = false;
                ButtonSelect2.Visible = true;
                LabelCoin2.Visible = false;
                PictureBoxCoin2.Visible = false;
            }
            if (MenuTetris.Progress[6] == "true") {
                ButtonBuy3.Visible = false;
                ButtonSelect3.Visible = true;
                LabelCoin3.Visible = false;
                PictureBoxCoin3.Visible = false;
            }
            if (MenuTetris.Progress[7] == "true") {
                ButtonBuy4.Visible = false;
                ButtonSelect4.Visible = true;
                LabelCoin4.Visible = false;
                PictureBoxCoin4.Visible = false;
            }
            if (MenuTetris.Progress[8] == "true") {
                ButtonBuy5.Visible = false;
                ButtonSelect5.Visible = true;
                LabelCoin5.Visible = false;
                PictureBoxCoin5.Visible = false;
            }
            if (MenuTetris.Progress[9] == "true") {
                ButtonBuy6.Visible = false;
                ButtonSelect6.Visible = true;
                LabelCoin6.Visible = false;
                PictureBoxCoin6.Visible = false;
            }
            if (SelectColor == 1) { ButtonSelect1.Enabled = false; }
            if (SelectColor == 2) { ButtonSelect2.Enabled = false; }
            if (SelectColor == 3) { ButtonSelect3.Enabled = false; }
            if (SelectColor == 4) { ButtonSelect4.Enabled = false; }
            if (SelectColor == 5) { ButtonSelect5.Enabled = false; }
            if (SelectColor == 6) { ButtonSelect6.Enabled = false; }
        }
        private void ButtonMinigames_Click(object sender, EventArgs e) {
            this.Hide();
            MenuTetris form = new MenuTetris();
            form.Show();
        }
        private void ButtonProfile_Click(object sender, EventArgs e) {
            this.Hide();
            Profile form = new Profile();
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
        private void ButtonBuy2_Click(object sender, EventArgs e) {
            if (Int32.Parse(MenuTetris.Progress[0]) >= 50) {
                MenuTetris.Progress[0] = Convert.ToString(Int32.Parse(MenuTetris.Progress[0]) - 50);
                MenuTetris.Progress[5] = "true";
                LabelCoins.Text = MenuTetris.Progress[0];
                ButtonBuy2.Visible = false;
                ButtonSelect2.Visible = true;
                LabelCoin2.Visible = false;
                PictureBoxCoin2.Visible = false;
            }
        }
        private void ButtonBuy3_Click(object sender, EventArgs e) {
            if (Int32.Parse(MenuTetris.Progress[0]) >= 75) { 
                MenuTetris.Progress[0] = Convert.ToString(Int32.Parse(MenuTetris.Progress[0]) - 75);
                MenuTetris.Progress[6] = "true";
                LabelCoins.Text = MenuTetris.Progress[0];
                ButtonBuy3.Visible = false;
                ButtonSelect3.Visible = true;
                LabelCoin3.Visible = false;
                PictureBoxCoin3.Visible = false;
            }
        }
        private void ButtonBuy4_Click(object sender, EventArgs e) {
            if (Int32.Parse(MenuTetris.Progress[0]) >= 100) { 
                MenuTetris.Progress[0] = Convert.ToString(Int32.Parse(MenuTetris.Progress[0]) - 100);
                MenuTetris.Progress[7] = "true";
                LabelCoins.Text = MenuTetris.Progress[0];
                ButtonBuy4.Visible = false;
                ButtonSelect4.Visible = true;
                LabelCoin4.Visible = false;
                PictureBoxCoin4.Visible = false;
            }
        }
        private void ButtonBuy5_Click(object sender, EventArgs e) {
            if (Int32.Parse(MenuTetris.Progress[0]) >= 200) { 
                MenuTetris.Progress[0] = Convert.ToString(Int32.Parse(MenuTetris.Progress[0]) - 200);
                MenuTetris.Progress[8] = "true";
                LabelCoins.Text = MenuTetris.Progress[0];
                ButtonBuy5.Visible = false;
                ButtonSelect5.Visible = true;
                LabelCoin5.Visible = false;
                PictureBoxCoin5.Visible = false;
            }
        }
        private void ButtonBuy6_Click(object sender, EventArgs e) {
            if (Int32.Parse(MenuTetris.Progress[0]) >= 200) { 
                MenuTetris.Progress[0] = Convert.ToString(Int32.Parse(MenuTetris.Progress[0]) - 400);
                MenuTetris.Progress[9] = "true";
                LabelCoins.Text = MenuTetris.Progress[0];
                ButtonBuy6.Visible = false;
                ButtonSelect6.Visible = true;
                LabelCoin6.Visible = false;
                PictureBoxCoin6.Visible = false;
            }
        }
        private void ButtonBuy7_Click(object sender, EventArgs e) {

        }
        private void ButtonBuy8_Click(object sender, EventArgs e) {

        }
        private void ButtonSelect1_Click(object sender, EventArgs e) {
            SelectColor = 1;
            ButtonEnable();
            ButtonSelect1.Enabled = false;
        }
        private void ButtonSelect2_Click(object sender, EventArgs e) {
            SelectColor = 2;
            ButtonEnable();
            ButtonSelect2.Enabled = false;
        }
        private void ButtonSelect3_Click(object sender, EventArgs e) {
            SelectColor = 3;
            ButtonEnable();
            ButtonSelect3.Enabled = false;
        }
        private void ButtonSelect4_Click(object sender, EventArgs e) {
            SelectColor = 4;
            ButtonEnable();
            ButtonSelect4.Enabled = false;
        }
        private void ButtonSelect5_Click(object sender, EventArgs e) {
            SelectColor = 5;
            ButtonEnable();
            ButtonSelect5.Enabled = false;
        }
        private void ButtonSelect6_Click(object sender, EventArgs e) {
            SelectColor = 6;
            ButtonEnable();
            ButtonSelect6.Enabled = false;
        }
        private void ButtonSelect7_Click(object sender, EventArgs e) {

        }
        private void ButtonSelect8_Click(object sender, EventArgs e) {

        }
        private void ButtonEnable() {
            ButtonSelect1.Enabled = true;
            ButtonSelect2.Enabled = true;
            ButtonSelect3.Enabled = true;
            ButtonSelect4.Enabled = true;
            ButtonSelect5.Enabled = true;
            ButtonSelect6.Enabled = true;
        }
    }
}
