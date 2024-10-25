using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TienLenDoAn
{
    public partial class Multiplayer : Form
    {
        public Multiplayer()
        {
            InitializeComponent();
        }

        private void Multiplayer_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }


        private void btnCreateRoom_Click(object sender, EventArgs e)
        {

        }

        private void btnJoinRoom_Click(object sender, EventArgs e)
        {
            this.CodeRoom.Visible = true;
            this.CodeRoom.Visible = true;

            // Thay đổi hình nền của form bằng hình ảnh từ Resources
            this.BackgroundImage = Properties.Resources._201;
            this.BackgroundImageLayout = ImageLayout.Stretch; // Điều chỉnh cách hiển thị hình ảnh
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        private void CodeRoom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
