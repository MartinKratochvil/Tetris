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
    public partial class Start : Form {
        public Start() {
            InitializeComponent();
        }
        public static string nickname;
        private void ButtonNext_Click(object sender, EventArgs e) {
            if (TextBoxNickname.Text.Replace(" ", string.Empty) != "") {
                nickname = TextBoxNickname.Text;
                this.Hide();
                MenuTetris form = new MenuTetris();
                form.Show();
            }
            
        }
    }
}
