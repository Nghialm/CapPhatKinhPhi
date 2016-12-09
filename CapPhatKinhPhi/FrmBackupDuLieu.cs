using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CapPhatKinhPhi 
{
    public partial class FrmBackupDuLieu : Form
    {
        String _ThuMucBackup = "";
        string _FileBackup = "";
        string _FileBackupFull = "";

        public FrmBackupDuLieu()
        {
            InitializeComponent();
        }

        private void btnBrower_Click(object sender, EventArgs e)
        {
            string filebackup = "";
            string[] temp;

            saveFileDialog1.AddExtension = true;
            saveFileDialog1.DefaultExt = "db";
            saveFileDialog1.FileName = string.Format("CPKP_{0}.db", DateTime.Now.ToString("ddMMyyyy"));
            // saveFileDialog1.ShowDialog();


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filebackup = saveFileDialog1.FileName;
                temp = filebackup.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
                _FileBackup = temp[temp.Length - 1];
                _ThuMucBackup = filebackup.Replace(_FileBackup, "");
                _FileBackupFull = saveFileDialog1.FileName;
                txtDuongDan.Text = saveFileDialog1.FileName;

            }
            else
            {
                MessageBox.Show("Bạn chưa chọn đường dẫn để sao lưu dữ liệu", "Thông báo");
                return;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                String file = Application.StartupPath + "\\App_Data\\CPNganSach.db";
                if (File.Exists(file))
                {
                    File.Copy(file, _FileBackupFull, true);
                    MessageBox.Show("Quá trình sao lưu thành công.", "Thông báo");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy file dữ liệu");
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi trong quá trình thực hiện. Kiểm tra thư mục sao lưu.", "Thông báo");
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

