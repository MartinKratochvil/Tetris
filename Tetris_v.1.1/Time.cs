using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris_v._1._1 {
    public partial class Time : Form {
        public Time() {
            InitializeComponent();
        }
        PictureBox[,] pole = new PictureBox[10, 20];
        PictureBox[,] pole2 = new PictureBox[4, 4];
        int[,,,] rotations = { { { { -2, -1 }, { -1, 0 }, { 0, 1 }, { 1, 2 } }, { { 1, -2 }, { 0, -1 }, { -1, 0 }, { -2, 1 } }, { { 2, 1 }, { 1, 0 }, { 0, -1 }, { -1, -2 } }, { { -1, 2 }, { 0, 1 }, { 1, 0 }, { 2, -1 } } }, { { { 2, -1 }, { 1, 0 }, { 0, 1 }, { -1, 0 } }, { { 1, 2 }, { 0, 1 }, { -1, 0 }, { 0, -1 } }, { { -2, 1 }, { -1, 0 }, { 0, -1 }, { 1, 0 } }, { { -1, -2 }, { 0, -1 }, { 1, 0 }, { 0, 1 } } }, { { { 1, -2 }, { 0, -1 }, { -1, 0 }, { 0, 1 } }, { { 2, 1 }, { 1, 0 }, { 0, -1 }, { -1, 0 } }, { { -1, 2 }, { 0, 1 }, { 1, 0 }, { 0, -1 } }, { { -2, -1 }, { -1, 0 }, { 0, 1 }, { 1, 0 } } }, { { { 0, -1 }, { -1, 0 }, { 0, 1 }, { -1, 2 } }, { { 1, 0 }, { 0, -1 }, { -1, 0 }, { -2, -1 } }, { { 0, 1 }, { 1, 0 }, { 0, -1 }, { 1, -2 } }, { { -1, 0 }, { 0, 1 }, { 1, 0 }, { 2, 1 } } }, { { { 1, 0 }, { 0, 1 }, { -1, 0 }, { -2, 1 } }, { { 0, 1 }, { -1, 0 }, { 0, -1 }, { -1, -2 } }, { { -1, 0 }, { 0, -1 }, { 1, 0 }, { 2, -1 } }, { { 0, -1 }, { 1, 0 }, { 0, 1 }, { 1, 2 } } }, { { { 1, -1 }, { -1, -1 }, { 0, 0 }, { 1, 1 } }, { { 1, 1 }, { 1, -1 }, { 0, 0 }, { -1, 1 } }, { { -1, 1 }, { 1, 1 }, { 0, 0 }, { -1, -1 } }, { { -1, -1 }, { -1, 1 }, { 0, 0 }, { 1, -1 } } }, { { { 0, 0 }, { 0, 0 }, { 0, 0 }, { 0, 0 } }, { { 0, 0 }, { 0, 0 }, { 0, 0 }, { 0, 0 } }, { { 0, 0 }, { 0, 0 }, { 0, 0 }, { 0, 0 } }, { { 0, 0 }, { 0, 0 }, { 0, 0 }, { 0, 0 } } } };
        int[,,] block = { { { 3, 0 }, { 4, 0 }, { 5, 0 }, { 6, 0 } }, { { 5, 0 }, { 5, 1 }, { 5, 2 }, { 4, 2 } }, { { 4, 0 }, { 4, 1 }, { 4, 2 }, { 5, 2 } }, { { 4, 0 }, { 4, 1 }, { 5, 1 }, { 5, 2 } }, { { 5, 0 }, { 5, 1 }, { 4, 1 }, { 4, 2 } }, { { 4, 0 }, { 3, 1 }, { 4, 1 }, { 5, 1 } }, { { 4, 0 }, { 5, 0 }, { 4, 1 }, { 5, 1 } } };
        int[,] shape = new int[4, 2];
        string[] color = { @"../../Pictures/PurpleBlock" + Shop.SelectColor + ".png", @"../../Pictures/BlueBlock" + Shop.SelectColor + ".png", @"../../Pictures/OrangeBlock" + Shop.SelectColor + ".png", @"../../Pictures/GreenBlock" + Shop.SelectColor + ".png", @"../../Pictures/RedBlock" + Shop.SelectColor + ".png", @"../../Pictures/PinkBlock" + Shop.SelectColor + ".png", @"../../Pictures/YellowBlock" + Shop.SelectColor + ".png" };
        int shapeRand, lastShape = -1, nextShape, nextColor, rotation, score = 0;
        bool EndGame = false, load = false, TimeRunOut = true;
        string path = @"../../Pictures/clear.png";
        double time_left_sec; 

        private void Time_FormClosed(object sender, FormClosedEventArgs e) { 
            Application.Exit();
        }
        private void Time_Load(object sender, EventArgs e) {
            LabelNickname.Text = Start.nickname;
            LabelCoins.Text = Convert.ToString(MenuTetris.Progress[0]);
            DoubleBuffered = true;
            if (MenuTetris.bullet) { time_left_sec = 60; }
            else { time_left_sec = 180; }
            for (int i = 0; i < 10; i++) {
                for (int j = 0; j < 20; j++) {
                    pole[i, j] = new PictureBox {
                        Name = "pictureBox" + i + j,
                        Size = new Size(30, 30),
                        Location = new Point(30 * i + 350, 30 * j + 40),
                        ImageLocation = path,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        BackColor = Color.Transparent
                    };
                    this.Controls.Add(pole[i, j]);
                }
            }
            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < 4; j++) {
                    pole2[i, j] = new PictureBox {
                        Name = "pictureBox2" + i + j,
                        Size = new Size(30, 30),
                        Location = new Point(30 * i + 720, 30 * j + 80),
                        ImageLocation = path,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        BackColor = Color.Transparent
                    };
                    this.Controls.Add(pole2[i, j]);
                }
            }
            Random rand = new Random();
            nextShape = rand.Next(0, 7);
            Grid.SendToBack();
            GridPiece.SendToBack();
            spawn();
            Clock.Start();
        }
        private void spawn() {
            rotation = 0;
            Random rand = new Random();
            shapeRand = nextShape;
            nextShape = rand.Next(0, 7);
            while (shapeRand == nextShape) { nextShape = rand.Next(0, 7); }
            nextColor = nextShape;
            lastShape = shapeRand;
            load = true;
            for (int i = 0; i < 4 && !EndGame; ++i) {
                if (pole[block[shapeRand, i, 0], block[shapeRand, i, 1]].ImageLocation != path) {
                    EndGame = true;
                    GameEnd();
                }
            }
            for (int i = 0; i < 4 && !EndGame; ++i) {
                shape[i, 0] = block[shapeRand, i, 0];
                shape[i, 1] = block[shapeRand, i, 1];
                pole[shape[i, 0], shape[i, 1]].ImageLocation = color[shapeRand];
            }
            for (int i = 0; i < 4; i++) { 
                for (int j = 0; j < 4; j++) { pole2[i, j].ImageLocation = path; } 
            }
            string path_next = color[nextColor];
            switch (nextShape) {
                case 0: { pole2[1, 0].ImageLocation = path_next; pole2[1, 1].ImageLocation = path_next; pole2[1, 2].ImageLocation = path_next; pole2[1, 3].ImageLocation = path_next; break; }
                case 1: { pole2[2, 0].ImageLocation = path_next; pole2[2, 1].ImageLocation = path_next; pole2[2, 2].ImageLocation = path_next; pole2[1, 2].ImageLocation = path_next; break; }
                case 2: { pole2[1, 0].ImageLocation = path_next; pole2[1, 1].ImageLocation = path_next; pole2[1, 2].ImageLocation = path_next; pole2[2, 2].ImageLocation = path_next; break; }
                case 3: { pole2[1, 0].ImageLocation = path_next; pole2[1, 1].ImageLocation = path_next; pole2[2, 1].ImageLocation = path_next; pole2[2, 2].ImageLocation = path_next; break; }
                case 4: { pole2[2, 0].ImageLocation = path_next; pole2[2, 1].ImageLocation = path_next; pole2[1, 1].ImageLocation = path_next; pole2[1, 2].ImageLocation = path_next; break; }
                case 5: { pole2[1, 2].ImageLocation = path_next; pole2[0, 2].ImageLocation = path_next; pole2[1, 1].ImageLocation = path_next; pole2[2, 2].ImageLocation = path_next; break; }
                case 6: { pole2[1, 1].ImageLocation = path_next; pole2[2, 1].ImageLocation = path_next; pole2[1, 2].ImageLocation = path_next; pole2[2, 2].ImageLocation = path_next; break; }
            }
            load = false;
            Gravity.Start();
        }
        private void check() {
            Gravity.Stop();
            int checkNum = 0;
            for (int i = 0; i < 20; ++i) {
                bool endCheck = false;
                for (int j = 0; j < 10 && !endCheck; ++j) {
                    if (pole[j, i].ImageLocation == path) { endCheck = true; }
                }
                if (!endCheck) {
                    for (int j = i; j > 0; --j) {
                        for (int k = 0; k < 10; ++k) {
                            pole[k, j].ImageLocation = pole[k, j - 1].ImageLocation;
                        }
                    }
                    ++checkNum;
                }
            }
            if (checkNum > 0) {
                bool clear = true;
                for (int i = 0; i < 10; ++i) {
                    if (pole[i, 19].ImageLocation != path) { clear = false; }
                }
                if (clear) { score += 800; if (MenuTetris.bullet) { time_left_sec += 24; } }
                if (checkNum == 1) { score += 100; if (MenuTetris.bullet) { time_left_sec += 5; } }
                else if (checkNum == 2) { score += 250; if (MenuTetris.bullet) { time_left_sec += 7.5; } }
                else if (checkNum == 3) { score += 500; if (MenuTetris.bullet) { time_left_sec += 15; } }
                else { score += 1000; if (MenuTetris.bullet) { time_left_sec += 30; } }
                LabelScore.Text = score.ToString();
            }
        }
        private void GravityUpdate() {
            while(load) { };
            bool end = false;
            for (int i = 0; i < 4 && !end; ++i) {
                bool same = false;
                for (int j = 0; j < 4; ++j) {
                    if (shape[i, 0] == shape[j, 0] && shape[i, 1] + 1 == shape[j, 1]) { same = true; }
                }
                if (shape[i, 1] + 1 >= 20) { end = true; }
                else if (!same && pole[shape[i, 0], shape[i, 1] + 1].ImageLocation != path) { end = true; }
            }
            if (!end) {
                for (int i = 0; i < 4; ++i) {
                    pole[shape[i, 0], shape[i, 1]].ImageLocation = path;
                }
                for (int i = 0; i < 4; ++i) {
                    ++shape[i, 1];
                    pole[shape[i, 0], shape[i, 1]].ImageLocation = color[shapeRand];
                }
            }
            else {
                check();
                spawn();
            }
        }
        private void Clock_Tick(object sender, EventArgs e) {
            if (TimeRunOut) {
                if (time_left_sec < 0) {
                    Clock.Stop();
                    label3.Text = "0.0 s";
                    GameEnd();
                }
                time_left_sec -= 0.1;
                label3.Text = Math.Round(time_left_sec, 2).ToString() + " s";
            }
        }
        private void Time_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 'a' || e.KeyChar == 'A' && !EndGame) {
                bool end = false;
                for (int i = 0; i < 4 && !end; ++i) {
                    bool same = false;
                    for (int j = 0; j < 4; ++j) {
                        if (shape[i, 0] - 1 == shape[j, 0] && shape[i, 1] == shape[j, 1]) {
                            same = true;
                        }
                    }
                    if (shape[i, 0] - 1 < 0) { end = true; }
                    else if (!same && pole[shape[i, 0] - 1, shape[i, 1]].ImageLocation != path) { end = true; }
                }
                if (!end) {
                    for (int i = 0; i < 4; ++i) {
                        pole[shape[i, 0], shape[i, 1]].ImageLocation = path;
                    }
                    for (int i = 0; i < 4; ++i) {
                        --shape[i, 0];
                        pole[shape[i, 0], shape[i, 1]].ImageLocation = color[shapeRand];
                    }
                }
            }
            if (e.KeyChar == 'd' || e.KeyChar == 'D' && !EndGame) {
                bool end = false;
                for (int i = 0; i < 4 && !end; ++i) {
                    bool same = false;
                    for (int j = 0; j < 4; ++j) {
                        if (shape[i, 0] + 1 == shape[j, 0] && shape[i, 1] == shape[j, 1]) { same = true; }
                    }
                    if (shape[i, 0] + 1 >= 10) { end = true; }
                    else if (!same && pole[shape[i, 0] + 1, shape[i, 1]].ImageLocation != path) { end = true; }
                }
                if (!end) {
                    for (int i = 0; i < 4; ++i) {
                        pole[shape[i, 0], shape[i, 1]].ImageLocation = path;
                    }
                    for (int i = 0; i < 4; ++i) {
                        ++shape[i, 0];
                        pole[shape[i, 0], shape[i, 1]].ImageLocation = color[shapeRand];
                    }
                }
            }
            if (e.KeyChar == 's' || e.KeyChar == 'S' && !EndGame) {
                GravityUpdate();
            }
            if (e.KeyChar == 'w' || e.KeyChar == 'W' && !EndGame) {
                ++rotation;
                if (rotation > 3) { rotation = 0; }
                bool end = false;
                for (int i = 0; i < 4 && !end; ++i) {
                    bool same = false;
                    if (shape[i, 0] + rotations[shapeRand, rotation, i, 0] >= 10 || shape[i, 0] + rotations[shapeRand, rotation, i, 0] < 0 || shape[i, 1] + rotations[shapeRand, rotation, i, 1] >= 20 || shape[i, 1] + rotations[shapeRand, rotation, i, 1] < 0) { end = true; }
                    for (int j = 0; j < 4 && !end; ++j) {
                        if (shape[i, 0] + rotations[shapeRand, rotation, i, 0] == shape[j, 0] && shape[i, 1] + rotations[shapeRand, rotation, i, 1] == shape[j, 1]) { same = true; }
                    }
                    if (!end && !same && pole[shape[i, 0] + rotations[shapeRand, rotation, i, 0], shape[i, 1] + rotations[shapeRand, rotation, i, 1]].ImageLocation != path) { end = true; }
                }
                if (!end) {
                    for (int i = 0; i < 4; ++i) { 
                        pole[shape[i, 0], shape[i, 1]].ImageLocation = path;
                    }
                    for (int i = 0; i < 4; ++i) {
                        shape[i, 0] += rotations[shapeRand, rotation, i, 0];
                        shape[i, 1] += rotations[shapeRand, rotation, i, 1];
                        pole[shape[i, 0], shape[i, 1]].ImageLocation = color[shapeRand];
                    }
                }
                else {
                    --rotation;
                    if (rotation < 0) { rotation = 3; }
                }
            }
        }
        private void Gravity_Tick(object sender, EventArgs e) {
            GravityUpdate();
        }
        private void GameEnd() {
            Gravity.Stop();
            TimeRunOut = false;
            MenuTetris.Progress[0] = Convert.ToString(Int32.Parse(MenuTetris.Progress[0]) + (score / 100));
            LabelCoins.Text = MenuTetris.Progress[0];
            if (score > Int32.Parse(MenuTetris.Progress[3]) && !MenuTetris.bullet) { MenuTetris.Progress[3] = Convert.ToString(score); }
            else if (score > Int32.Parse(MenuTetris.Progress[4]) && MenuTetris.bullet) { MenuTetris.Progress[4] = Convert.ToString(score); }
            MessageBox.Show("Konec hry!!");
            this.Hide();
            MenuTetris frame = new MenuTetris();
            frame.Show();
        }
    }
}
