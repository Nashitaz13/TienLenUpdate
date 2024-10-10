using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TienLenDoAn
{
    public partial class Option : Form
    {
        public Option(Form frm)
        {
            InitializeComponent();
        }
        private string avatarpath;
        private string playername;

        private void focusTxtBox()
        {
            this.txtPlyerName.Focus();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPlyerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Option_Load(object sender, EventArgs e)
        {
            string configPath = ".\\Config.config";

            if (!File.Exists(configPath))
            {
                MessageBox.Show("Tệp cấu hình không tồn tại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StreamReader streamReader = new StreamReader(configPath);
            this.playername = streamReader.ReadLine();
            this.txtPlyerName.Text = this.playername;
            this.avatarpath = streamReader.ReadLine();
            streamReader.Close();

            Image backgroundImage;
            try
            {
                // Đảm bảo avatarpath là đường dẫn chính xác
                if (!File.Exists(this.avatarpath))
                {
                    throw new FileNotFoundException();
                }

                backgroundImage = Image.FromFile(this.avatarpath);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Avatar không tồn tại. Sẽ thay thế bằng avatar mặc định!", "File not found", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                // Sử dụng ảnh avatar mặc định
                this.avatarpath = ".\\Emo\\Avatar\\9.jpg";
                backgroundImage = Image.FromFile(this.avatarpath);

                // Cập nhật lại tệp cấu hình với avatar mới
                using (StreamWriter streamWriter = new StreamWriter(configPath))
                {
                    streamWriter.Write(this.txtPlyerName.Text + "\r\n");
                    streamWriter.Write(this.avatarpath);
                }
            }

            // Đặt ảnh nền cho pbxAvatar
            this.pbxAvatar.BackgroundImage = backgroundImage;

            // Đảm bảo textbox được focus
            base.BeginInvoke(new MethodInvoker(this.focusTxtBox));
        }

        private void cmdCancel_Click_1(object sender, EventArgs e)
        {
            base.Close();
        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            // Thiết lập OpenFileDialog cho việc chọn ảnh
            this.odlAvatar.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            this.odlAvatar.Title = "Chọn Avatar";

            if (this.odlAvatar.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn ảnh đã chọn
                this.avatarpath = this.odlAvatar.FileName;

                // Cập nhật ảnh trên PictureBox
                Image backgroundImage = Image.FromFile(this.avatarpath);
                this.pbxAvatar.BackgroundImage = backgroundImage;
            }
        }


        private void cmdOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtPlyerName.Text))
            {
                this.playername = this.txtPlyerName.Text;
            }

            // Lưu thông tin vào tệp Config.config
            using (StreamWriter streamWriter = new StreamWriter(".\\Config.config"))
            {
                streamWriter.WriteLine(this.playername); // Lưu tên người chơi
                streamWriter.WriteLine(this.avatarpath); // Lưu đường dẫn avatar mới
            }

            // Đóng form sau khi lưu
            base.Close();
        }


        private void pbxAvatar_Click(object sender, EventArgs e)
        {

        }
    }
}
