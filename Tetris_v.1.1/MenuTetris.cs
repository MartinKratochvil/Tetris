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
    public partial class MenuTetris : Form {
        public MenuTetris() {
            InitializeComponent();
        }
        private void Menu_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
        public static bool bullet;
        public static int MAX = 10;
        public static string[] Progress = new string[MAX];
        public static string SavePath = @"../../Save/" + Start.nickname + ".txt";
        public static bool GameStart = true;
        bool error = false;
        public static string Encr(string text) { return Convert.ToBase64String(Encoding.UTF8.GetBytes(text)); }
        private string Decr(string text) {
            try { return Encoding.UTF8.GetString(Convert.FromBase64String(text)); }
            catch { 
                MessageBox.Show("Save se nepodařilo načíst!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
                ClearProgress();
                return "error";
            }
        }
        private void Menu_Load(object sender, EventArgs e) {
            if (File.Exists(SavePath) && GameStart) {
                bool num = false;
                using (StreamReader read = File.OpenText(SavePath)) {
                    string line = read.ReadLine();
                    for (int i = 0; line != null && !error; ++i) {
                        Progress[i] = Decr(line);
                        line = read.ReadLine();
                        num = true;
                        if ( Progress[i] == "") { error = true; }
                    }
                }
                if (error || !num) {
                    ClearProgress();
                    Save();
                }
            }
            else if (!File.Exists(SavePath)) {
                using (StreamWriter write = File.AppendText(@"../../Save/UsersList.txt")) {
                    write.WriteLine(Start.nickname);
                }
                ClearProgress();
                Save();
            }
            GameStart = false;
            LabelNickname.Text = Start.nickname;
            LabelCoins.Text = Progress[0];
        }
        private void ClearProgress() {
            Progress[0] = "0";
            Progress[1] = "0";
            Progress[2] = "0,0";
            Progress[3] = "0";
            Progress[4] = "0";
            for (int i = 5; i <= 9; i++) {
                Progress[i] = "false";
            }
        }
        private void Save() {
            using (StreamWriter write = File.CreateText(SavePath)) {
                for (int i = 0; i < MAX; ++i) {
                    write.WriteLine(Encr(Progress[i]));
                }
            }
        }
        private void ButtonSave_Click(object sender, EventArgs e) {
            Save();   
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
        private void ButtonLeaderboard_Click(object sender, EventArgs e) {
            this.Hide();
            Leaderboard form = new Leaderboard();
            form.Show();
        }
        private void ButtonExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        private void PictureBoxEndless_Click(object sender, EventArgs e) {
            this.Hide();
            Endless form = new Endless();
            form.Show();
        }
        private void PictureBox40Line_Click(object sender, EventArgs e) {
            this.Hide();
            Line40 form = new Line40();
            form.Show();
        }
        private void PictureBoxTime_Click(object sender, EventArgs e) {
            bullet = false;
            this.Hide();
            Time form = new Time();
            form.Show();
        }
        private void PictureBoxBullet_Click(object sender, EventArgs e) {
            bullet = true;
            this.Hide();
            Time form = new Time();
            form.Show();
        }
        private void PictureBoxEndless_MouseEnter(object sender, EventArgs e) {
            for (int i = 0; i < 5; i++) {
                PictureBoxEndless.Size = new System.Drawing.Size(PictureBoxEndless.Size.Width + 2, PictureBoxEndless.Size.Height + 2);
                PictureBoxEndless.Location = new Point(PictureBoxEndless.Location.X - 1, PictureBoxEndless.Location.Y - 1);
            }
        }
        private void PictureBoxEndless_MouseLeave(object sender, EventArgs e) {
            for (int i = 0; i < 5; i++) {
                PictureBoxEndless.Size = new System.Drawing.Size(PictureBoxEndless.Size.Width - 2, PictureBoxEndless.Size.Height - 2);
                PictureBoxEndless.Location = new Point(PictureBoxEndless.Location.X + 1, PictureBoxEndless.Location.Y + 1);
            }
        }
        private void PictureBox40Line_MouseEnter(object sender, EventArgs e) {
            for (int i = 0; i < 5; i++) {
                PictureBox40Line.Size = new System.Drawing.Size(PictureBox40Line.Size.Width + 2, PictureBox40Line.Size.Height + 2);
                PictureBox40Line.Location = new Point(PictureBox40Line.Location.X - 1, PictureBox40Line.Location.Y - 1);
            }
        }
        private void PictureBox40Line_MouseLeave(object sender, EventArgs e) {
            for (int i = 0; i < 5; i++) {
                PictureBox40Line.Size = new System.Drawing.Size(PictureBox40Line.Size.Width - 2, PictureBox40Line.Size.Height - 2);
                PictureBox40Line.Location = new Point(PictureBox40Line.Location.X + 1, PictureBox40Line.Location.Y + 1);
            }
        }
        private void PictureBoxTime_MouseEnter(object sender, EventArgs e) {
            for (int i = 0; i < 5; i++) {
                PictureBoxTime.Size = new System.Drawing.Size(PictureBoxTime.Size.Width + 2, PictureBoxTime.Size.Height + 2);
                PictureBoxTime.Location = new Point(PictureBoxTime.Location.X - 1, PictureBoxTime.Location.Y - 1);
            }
        }
        private void PictureBoxTime_MouseLeave(object sender, EventArgs e) {
            for (int i = 0; i < 5; i++) {
                PictureBoxTime.Size = new System.Drawing.Size(PictureBoxTime.Size.Width - 2, PictureBoxTime.Size.Height - 2);
                PictureBoxTime.Location = new Point(PictureBoxTime.Location.X + 1, PictureBoxTime.Location.Y + 1);
            }
        }
        private void PictureBoxBullet_MouseEnter(object sender, EventArgs e) {
            for (int i = 0; i < 5; i++) {
                PictureBoxBullet.Size = new System.Drawing.Size(PictureBoxBullet.Size.Width + 2, PictureBoxBullet.Size.Height + 2);
                PictureBoxBullet.Location = new Point(PictureBoxBullet.Location.X - 1, PictureBoxBullet.Location.Y - 1);
            }
        }
        private void PictureBoxBullet_MouseLeave(object sender, EventArgs e) {
            for (int i = 0; i < 5; i++) {
                PictureBoxBullet.Size = new System.Drawing.Size(PictureBoxBullet.Size.Width - 2, PictureBoxBullet.Size.Height - 2);
                PictureBoxBullet.Location = new Point(PictureBoxBullet.Location.X + 1, PictureBoxBullet.Location.Y + 1);
            }
        }
    }
}
