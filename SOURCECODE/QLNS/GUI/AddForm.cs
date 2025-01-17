﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNS.BLL;
using QLNS.DTO;
using QLNS.DAL;
namespace QLNS.GUI
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
            nvbll = new NhanVien_BLL();
        }
        public delegate void Them();// truyen ve mainform       
        public Them them;
        public delegate void maf(NhanVien nv);// truyen ve mainform
        public maf mf;
        NhanVien_BLL nvbll { get; set; }
        private void AddForm_Load(object sender, EventArgs e)
        {
            Loadcbb();
        }
        private void Loadcbb()
        {
            DataTable db = nvbll.LayThongTinChoCBB();
            foreach (DataRow i in db.Rows)
            {
                if (cbbNoiSinh.FindStringExact(i["NoiSinh"].ToString()) < 0
                    && i["NoiSinh"].ToString() != "")
                {
                    cbbNoiSinh.Items.Add(i["NoiSinh"].ToString());
                }

                if (cbbDiaChi.FindStringExact(i["ChoOHienTai"].ToString()) < 0
                    && i["ChoOHienTai"].ToString() != "")
                {
                    cbbDiaChi.Items.Add(i["ChoOHienTai"].ToString());
                }

                if (cbbNgoaiNgu.FindStringExact(i["NgoaiNgu"].ToString()) < 0
                    && i["NgoaiNgu"].ToString() != "")
                {
                    cbbNgoaiNgu.Items.Add(i["NgoaiNgu"].ToString());
                }
                if (cbbTenCV.FindStringExact(i["TenChucVu"].ToString()) < 0
                    && i["TenChucVu"].ToString() != "")
                {
                    cbbTenCV.Items.Add(i["TenChucVu"].ToString());
                }
                if (cbbTenPhBan.FindStringExact(i["TenPhongBan"].ToString()) < 0
                    && i["TenPhongBan"].ToString() != "")
                {
                    cbbTenPhBan.Items.Add(i["TenPhongBan"].ToString());
                }
                if (cbbTenKhoa.FindStringExact(i["TenKhoa"].ToString()) < 0
                    && i["TenKhoa"].ToString() != "")
                {
                    cbbTenKhoa.Items.Add(i["TenKhoa"].ToString());
                }
                if (cbbChuyenNganh.FindStringExact(i["ChuyenNganh"].ToString()) < 0
                    && i["ChuyenNganh"].ToString() != "")
                {
                    cbbChuyenNganh.Items.Add(i["ChuyenNganh"].ToString());
                }
                if (cbbHHam.FindStringExact(i["TenHocHam"].ToString()) < 0
                    && i["TenHocHam"].ToString() != "")
                {
                    cbbHHam.Items.Add(i["TenHocHam"].ToString());
                }
                if (cbbHVi.FindStringExact(i["TenHocVi"].ToString()) < 0
                    && i["TenHocVi"].ToString() != "")
                {
                    cbbHVi.Items.Add(i["TenHocVi"].ToString());
                }
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {

            try
            {
                int mapb = cbbTenPhBan.SelectedItem == null? -1 : nvbll.getma("PhongBan", "MaPhongBan", "TenPhongBan", cbbTenPhBan.SelectedItem.ToString());
                int makhoa = cbbTenKhoa.SelectedItem == null ? -1 : nvbll.getma("Khoa", "MaKhoa", "TenKhoa", cbbTenKhoa.SelectedItem.ToString());
                int mahh = cbbHHam.SelectedItem == null ? -1 : nvbll.getma("HocHam", "MaHocHam", "TenHocHam", cbbHHam.SelectedItem.ToString());
                int mahv = cbbHVi.SelectedItem == null ? -1 : nvbll.getma("HocVi", "MaHocVi", "TenHocVi", cbbHVi.SelectedItem.ToString());
                int macv = cbbTenCV.SelectedItem == null ? -1 : nvbll.getma("ChucVu", "MaChucVu", "TenChucVu", cbbTenCV.SelectedItem.ToString());
                if ((mapb == -1 && makhoa == -1) || mahv == -1
                    || txtMaNV.Text == "" || (radFemale.Checked == false && radMale.Checked == false)
                     || macv == -1)
                {
                    MessageBox.Show("Mời bạn kiểm tra lại thông tin,thông tin bị thiếu");

                }
                else
                {
                    NhanVien nv = new NhanVien();
                    nv.MaNhanVien = Convert.ToInt32(txtMaNV.Text);
                    nv.MaChucVu = macv;
                    nv.MaPhongBan = mapb;
                    nv.MaKhoa = makhoa;
                    nv.MaHocHam = mahh;
                    nv.MaHocVi = mahv;
                    nv.LinhVucNghienCuu = txtLinhVucNC.Text;
                    nv.HoTen = txtTenNV.Text;
                    nv.NgaySinh = dateTimePicker1.Value;
                    nv.GioiTinh = radMale.Checked;
                    nv.ChoOHienTai = cbbDiaChi.SelectedItem == null ? cbbDiaChi.Text : cbbDiaChi.SelectedItem.ToString();//
                    nv.QueQuan = txtQueQuan.Text;
                    nv.DienThoai = txtSDT.Text;
                    nv.ChuyenNganh = cbbChuyenNganh.SelectedItem == null ? cbbChuyenNganh.Text : cbbChuyenNganh.SelectedItem.ToString();//
                    nv.TruongTN = txtTruongTN.Text;
                    nv.NamDatHV = txtNamDatHV.Text;
                    nv.NgoaiNgu = cbbNgoaiNgu.SelectedItem == null ? cbbNgoaiNgu.Text : cbbNgoaiNgu.SelectedItem.ToString();//
                    nv.NoiSinh = cbbNoiSinh.SelectedItem == null ? cbbNoiSinh.Text : cbbNoiSinh.SelectedItem.ToString();//
                    nv.MaHinhAnh = Convert.ToInt32(txtMaNV.Text);
                if (path1.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập chọn hình ảnh");

                }
                else
                {
                        nvbll.ThemHinhAnh(nv.MaHinhAnh, convertimagetobyte());
                        nvbll.ThemNV(nv);
                        them();
                        mf(nv);
                        if (cbbNgoaiNgu.FindStringExact(nv.NgoaiNgu) < 0) cbbNgoaiNgu.Items.Add(nv.NgoaiNgu);
                        if (cbbNoiSinh.FindStringExact(nv.NoiSinh) < 0) cbbNoiSinh.Items.Add(nv.NoiSinh);
                        if (cbbChuyenNganh.FindStringExact(nv.ChuyenNganh) < 0) cbbChuyenNganh.Items.Add(nv.ChuyenNganh);
                        if (cbbDiaChi.FindStringExact(nv.ChoOHienTai) < 0) cbbDiaChi.Items.Add(nv.ChoOHienTai);
                        MessageBox.Show("Thêm nhân viên thành công");
                        this.Close();

                }

            }

        }
            catch (Exception ex)
            {
                MessageBox.Show("Đã tồn tại Nhân viên có Mã Nhân Viên này.Vui lòng kiểm tra lại");
                   
            }


}
       private byte[] convertimagetobyte()
        {
            FileStream fs = new FileStream(path1.Text, FileMode.Open, FileAccess.Read);
            byte[] img = new byte[fs.Length];
            fs.Read(img, 0, (int)(fs.Length));
            return img;
        }
        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Choose Image (*.jpg;*.png;*.gif)|*.jpg;*.png;*gif";
            op.FilterIndex = 1;
            op.RestoreDirectory = true;
            if (op.ShowDialog() == DialogResult.OK)
            {
                image.ImageLocation = op.FileName;
                path1.Text = op.FileName;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btThem2_Click(object sender, EventArgs e)
        {
            AddForm2 ad2 = new AddForm2();
            ad2.a2 = new AddForm2.ad(gan1);
            ad2.Show();
        }
        public void gan1(string k,NhanVien nv)
        {
            this.path1.Text = k;
            txtMaNV.Text =nv.MaNhanVien.ToString();
            txtTenNV.Text = nv.HoTen;
            txtQueQuan.Text = nv.QueQuan;
            txtSDT.Text = nv.DienThoai;
            txtTruongTN.Text = nv.TruongTN;
            string hham = nvbll.getten("HocHam", "TenHocHam", "MaHocHam", nv.MaHocHam);
            string hvi = nvbll.getten("HocVi", "TenHocVi", "MaHocVi", nv.MaHocVi);
            string tencv = nvbll.getten("ChucVu", "TenChucVu", "MaChucVu", nv.MaChucVu);
            string tenkhoa = nvbll.getten("Khoa", "TenKhoa", "MaKhoa", nv.MaKhoa);
            string tenpb = nvbll.getten("PhongBan", "TenPhongBan", "MaPhongBan", nv.MaPhongBan);
            if(cbbHHam.FindStringExact(hham)<0&& hham!="")cbbHHam.Items.Add(hham);
            if(cbbHVi.FindStringExact(hvi)<0&& hvi!="")cbbHVi.Items.Add(hvi);
            if (cbbNgoaiNgu.FindStringExact(nv.NgoaiNgu) < 0&& nv.NgoaiNgu!="") cbbNgoaiNgu.Items.Add(nv.NgoaiNgu);
            if (cbbNoiSinh.FindStringExact(nv.NoiSinh) < 0&& nv.NoiSinh!="") cbbNoiSinh.Items.Add(nv.NoiSinh);
            if (cbbChuyenNganh.FindStringExact(nv.ChuyenNganh) < 0 && nv.ChuyenNganh!="") cbbChuyenNganh.Items.Add(nv.ChuyenNganh);
            if (cbbTenCV.FindStringExact(tencv) < 0&& tencv!="") cbbTenCV.Items.Add(tencv);
            if (cbbTenKhoa.FindStringExact(tenkhoa) < 0&& tenkhoa!="") cbbTenKhoa.Items.Add(tenkhoa);
            if (cbbTenPhBan.FindStringExact(tenpb) < 0&& tenkhoa!="") cbbTenPhBan.Items.Add(tenpb);
            if (cbbDiaChi.FindStringExact(nv.ChoOHienTai) < 0&&nv.ChoOHienTai!="") cbbDiaChi.Items.Add(nv.ChoOHienTai);
            cbbDiaChi.SelectedIndex = cbbDiaChi.FindStringExact(nv.ChoOHienTai);
            cbbHHam.SelectedIndex = cbbHHam.FindStringExact(hham);
            cbbHVi.SelectedIndex = cbbHVi.FindStringExact(hvi);
            cbbTenCV.SelectedIndex = cbbTenCV.FindStringExact(tencv);
            cbbTenKhoa.SelectedIndex = cbbTenKhoa.FindStringExact(tenkhoa);
            cbbTenPhBan.SelectedIndex = cbbTenPhBan.FindStringExact(tenpb);
            cbbChuyenNganh.SelectedIndex = cbbChuyenNganh.FindStringExact(nv.ChuyenNganh);
            cbbNgoaiNgu.SelectedIndex = cbbNgoaiNgu.FindStringExact(nv.NgoaiNgu);
            cbbNoiSinh.SelectedIndex = cbbNoiSinh.FindStringExact(nv.NoiSinh);
            FileStream fs = new FileStream(path1.Text, FileMode.Open, FileAccess.Read);
            byte[] img = new byte[fs.Length];
            fs.Read(img, 0, (int)(fs.Length));
            MemoryStream stream = new MemoryStream(img);
            image.Image = new Bitmap(stream);
            if (nv.GioiTinh)
            {
                radMale.Checked = true;
            }
            else
            {
                radFemale.Checked = true;
            }
            txtNamDatHV.Text = nv.NamDatHV;
            txtLinhVucNC.Text = nv.LinhVucNghienCuu;
            dateTimePicker1.Value = nv.NgaySinh;
        }

    }
}
