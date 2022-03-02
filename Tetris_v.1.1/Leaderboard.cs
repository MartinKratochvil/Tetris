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
    public partial class Leaderboard : Form {
        public Leaderboard() {
            InitializeComponent();
        }
        string[] nicknames = new string[50];
        double[] scores = new double[50];
        int number = 0, minigame = 1;
        
        private void Leaderboard_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
        private void Leaderboard_Load(object sender, EventArgs e) {
            LabelNickname.Text = Start.nickname;
            LabelCoins.Text = MenuTetris.Progress[0];
            using (StreamReader read = File.OpenText(@"../../Save/UsersList.txt")) {
                string line = read.ReadLine();
                for (int i = 0; line != null; ++i) {
                    nicknames[i] = line;
                    ++number;
                    line = read.ReadLine();
                }
            }
            Sort();
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
        private void ButtonProfile_Click(object sender, EventArgs e) {
            this.Hide();
            Profile form = new Profile();
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
        private string Decr(string text) {
            try { return Encoding.UTF8.GetString(Convert.FromBase64String(text)); }
            catch { MessageBox.Show("Save se nepodařilo načíst!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            return "error";
        }
        private void Sort() {
            for (int i = 0; i < number; ++i) {
                using (StreamReader read = File.OpenText(@"../../Save/" + nicknames[i] + ".txt")) {
                    if (minigame >= 2) { read.ReadLine(); }
                    if (minigame >= 3) { read.ReadLine(); }
                    if (minigame == 4) { read.ReadLine(); }
                    read.ReadLine();
                    try { scores[i] = double.Parse(Decr(read.ReadLine())); }
                    catch {
                        MessageBox.Show("Save se nepodařilo načíst!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        scores[i] = 0;
                    }
                }
            }
            double num = 0;
            string nick = "";
            if (minigame != 2) { 
                for (int i = 0; i < number; i++) {
                    for (int j = i; j < number; j++) {
                        if (scores[i] < scores[j]) {
                            num = scores[j];
                            scores[j] = scores[i];
                            scores[i] = num;
                            nick = nicknames[j];
                            nicknames[j] = nicknames[i];
                            nicknames[i] = nick;
                        }
                    }
                }
            }
            else {
                for (int i = 0; i < number; i++) {
                    for (int j = i; j < number; j++) {
                        if (scores[i] > scores[j] && scores[j] != 0) {
                            num = scores[j];
                            scores[j] = scores[i];
                            scores[i] = num;
                            nick = nicknames[j];
                            nicknames[j] = nicknames[i];
                            nicknames[i] = nick;
                        }
                    }
                }
            }
            if (minigame == 2) {
                if (number >= 1) { LabelNickname1.Text = nicknames[0]; LabelScore1.Text = scores[0].ToString() + " s"; }
                else { LabelScore1.Text = "0 s"; }
            }
            else {
                if (number >= 1) { LabelNickname1.Text = nicknames[0]; LabelScore1.Text = scores[0].ToString(); }
                else { LabelScore1.Text = "0"; }
            }
            if (minigame == 2) {
                if (number >= 2) { LabelNickname2.Text = nicknames[1]; LabelScore2.Text = scores[1].ToString() + " s"; }
                else { LabelScore2.Text = "0 s"; }
            }
            else { 
                if (number >= 2) { LabelNickname2.Text = nicknames[1]; LabelScore2.Text = scores[1].ToString(); }
                else { LabelScore2.Text = "0"; }
            }
            if (minigame == 2) {
                if (number >= 3) { LabelNickname3.Text = nicknames[2]; LabelScore3.Text = scores[2].ToString() + " s"; }
                else { LabelScore3.Text = "0 s"; }
            }
            else { 
                if (number >= 3) { LabelNickname3.Text = nicknames[2]; LabelScore3.Text = scores[2].ToString(); }
                else { LabelScore3.Text = "0"; }
            }
            if (minigame == 2) {
                if (number >= 4) { LabelNickname4.Text = nicknames[3]; LabelScore4.Text = scores[3].ToString() + " s"; }
                else { LabelScore4.Text = "0 s"; }
            }
            else { 
                if (number >= 4) { LabelNickname4.Text = nicknames[3]; LabelScore4.Text = scores[3].ToString(); }
                else { LabelScore4.Text = "0"; }
            }
            if (minigame == 2) {
                if (number >= 5) { LabelNickname5.Text = nicknames[4]; LabelScore5.Text = scores[4].ToString() + " s"; }
                else { LabelScore5.Text = "0 s"; }
            }
            else {
                if (number >= 5) { LabelNickname5.Text = nicknames[4]; LabelScore5.Text = scores[4].ToString(); }
                else { LabelScore5.Text = "0"; }
            }
            if (minigame == 2) {
                if (number >= 6) { LabelNickname6.Text = nicknames[5]; LabelScore6.Text = scores[5].ToString() + " s"; }
                else { LabelScore6.Text = "0 s"; }
            }
            else {
                if (number >= 6) { LabelNickname6.Text = nicknames[5]; LabelScore6.Text = scores[5].ToString(); }
                else { LabelScore6.Text = "0"; }
            }
            if (minigame == 2) {
                if (number >= 7) { LabelNickname7.Text = nicknames[6]; LabelScore7.Text = scores[6].ToString() + " s"; }
                else { LabelScore7.Text = "0 s"; }
            }
            else {
                if (number >= 7) { LabelNickname7.Text = nicknames[6]; LabelScore7.Text = scores[6].ToString(); }
                else { LabelScore7.Text = "0"; }
            }
            if (minigame == 2){
                if (number >= 8) { LabelNickname8.Text = nicknames[7]; LabelScore8.Text = scores[7].ToString() + " s"; }
                else { LabelScore8.Text = "0 s"; }
            }
            else {
                if (number >= 8) { LabelNickname8.Text = nicknames[7]; LabelScore8.Text = scores[7].ToString(); }
                else { LabelScore8.Text = "0"; }
            }
            if (minigame == 2) {
                if (number >= 9) { LabelNickname9.Text = nicknames[8]; LabelScore9.Text = scores[8].ToString() + " s"; }
                else { LabelScore9.Text = "0 s"; }
            }
            else {
                if (number >= 9) { LabelNickname9.Text = nicknames[8]; LabelScore9.Text = scores[8].ToString(); }
                else { LabelScore9.Text = "0"; }
            }
            if (minigame == 2) {
                if (number >= 10) { LabelNickname10.Text = nicknames[9]; LabelScore10.Text = scores[9].ToString() + " s"; }
                else { LabelScore10.Text = "0 s"; }
            }
            else {
                if (number >= 10) { LabelNickname10.Text = nicknames[9]; LabelScore10.Text = scores[9].ToString(); }
                else { LabelScore10.Text = "0"; }
            }
        }
        private void PictureBoxEndless_Click(object sender, EventArgs e) {
            minigame = 1;
            Sort();
        }
        private void PictureBox40Line_Click(object sender, EventArgs e) {
            minigame = 2;
            Sort();
        }
        private void PictureBoxTime_Click(object sender, EventArgs e) {
            minigame = 3;
            Sort();
        }
        private void PictureBoxBullet_Click(object sender, EventArgs e) {
            minigame = 4;
            Sort();
        }
        private void PictureBoxEndless_MouseEnter(object sender, EventArgs e) {
            PictureBoxEndless.Size = new System.Drawing.Size(206, 66);
            PictureBoxEndless.Location = new Point(247, 17);
        }
        private void PictureBoxEndless_MouseLeave(object sender, EventArgs e) {
            PictureBoxEndless.Size = new System.Drawing.Size(200, 60);
            PictureBoxEndless.Location = new Point(250, 20);
        }
        private void PictureBox40Line_MouseEnter(object sender, EventArgs e) {
            PictureBox40Line.Size = new System.Drawing.Size(206, 66);
            PictureBox40Line.Location = new Point(497, 17);
        }
        private void PictureBox40Line_MouseLeave(object sender, EventArgs e) {
            PictureBox40Line.Size = new System.Drawing.Size(200, 60);
            PictureBox40Line.Location = new Point(500, 20);
        }
        private void PictureBoxTime_MouseEnter(object sender, EventArgs e) {
            PictureBoxTime.Size = new System.Drawing.Size(206, 66);
            PictureBoxTime.Location = new Point(247, 102);
        }
        private void PictureBoxTime_MouseLeave(object sender, EventArgs e) {
            PictureBoxTime.Size = new System.Drawing.Size(200, 60);
            PictureBoxTime.Location = new Point(250, 105);
        }
        private void PictureBoxBullet_MouseEnter(object sender, EventArgs e) {
            PictureBoxBullet.Size = new System.Drawing.Size(206, 66);
            PictureBoxBullet.Location = new Point(497, 102);
        }
        private void PictureBoxBullet_MouseLeave(object sender, EventArgs e) {
            PictureBoxBullet.Size = new System.Drawing.Size(200, 60);
            PictureBoxBullet.Location = new Point(500, 105);
        }
    }
}
