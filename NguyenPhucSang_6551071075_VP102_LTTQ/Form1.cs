
using Microsoft.EntityFrameworkCore;
using NguyenPhucSang_6551071075_VP102_LTTQ.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLDuLieu
{
    public partial class Form1 : Form
    {
        private readonly DuLieuContext db;

        public Form1()
        {
            InitializeComponent();

            var options = new DbContextOptionsBuilder<DuLieuContext>()
                .UseSqlServer(
                    "Server=DESKTOP-MAETIJA\\SQLEXPRESS;Database=DuLieu;Trusted_Connection=True;TrustServerCertificate=True;")
                .Options;

            db = new DuLieuContext(options);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSinhVien.MultiSelect = false;
            dgvSinhVien.ReadOnly = true;
            dgvSinhVien.AllowUserToAddRows = false;
            dgvSinhVien.AutoGenerateColumns = true;

            TaiDuLieu();
            XoaTrang();
        }

        private void TaiDuLieu()
        {
            dgvSinhVien.DataSource = db.SinhViens
                .AsNoTracking()
                .ToList();

            dgvSinhVien.ClearSelection();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void XoaTrang()
        {
            txtMaSinhVien.Clear();
            txtTenSinhVien.Clear();
            txtDiemTrungBinh.Clear();

            txtMaSinhVien.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            dgvSinhVien.ClearSelection();
        }

        private bool KiemTraDuLieu()
        {
            if (string.IsNullOrWhiteSpace(txtMaSinhVien.Text) ||
                string.IsNullOrWhiteSpace(txtTenSinhVien.Text) ||
                string.IsNullOrWhiteSpace(txtDiemTrungBinh.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return false;
            }

            if (!decimal.TryParse(txtDiemTrungBinh.Text.Trim(), out decimal diem))
            {
                MessageBox.Show("Điểm trung bình phải là số.");
                return false;
            }

            if (diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm trung bình phải từ 0 đến 10.");
                return false;
            }

            return true;
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];

            txtMaSinhVien.Text = row.Cells["MaSinhVien"].Value?.ToString() ?? "";
            txtTenSinhVien.Text = row.Cells["TenSinhVien"].Value?.ToString() ?? "";
            txtDiemTrungBinh.Text = row.Cells["DiemTrungBinh"].Value?.ToString() ?? "";

            txtMaSinhVien.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu())
                return;

            string ma = txtMaSinhVien.Text.Trim();

            if (db.SinhViens.Any(x => x.MaSinhVien == ma))
            {
                MessageBox.Show("Mã sinh viên đã tồn tại.");
                return;
            }

            SinhVien sv = new SinhVien
            {
                MaSinhVien = ma,
                TenSinhVien = txtTenSinhVien.Text.Trim(),
                DiemTrungBinh = txtDiemTrungBinh.Text.Trim()
            };

            db.SinhViens.Add(sv);
            db.SaveChanges();

            MessageBox.Show("Thêm sinh viên thành công.");
            TaiDuLieu();
            XoaTrang();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu())
                return;

            string ma = txtMaSinhVien.Text.Trim();
            SinhVien sv = db.SinhViens.Find(ma);

            if (sv == null)
            {
                MessageBox.Show("Không tìm thấy sinh viên.");
                return;
            }

            sv.TenSinhVien = txtTenSinhVien.Text.Trim();
            sv.DiemTrungBinh = txtDiemTrungBinh.Text.Trim();

            db.SaveChanges();

            MessageBox.Show("Cập nhật sinh viên thành công.");
            TaiDuLieu();
            XoaTrang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaSinhVien.Text.Trim();

            if (string.IsNullOrWhiteSpace(ma))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa.");
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc muốn xóa sinh viên này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua != DialogResult.Yes)
                return;

            SinhVien sv = db.SinhViens.Find(ma);

            if (sv != null)
            {
                db.SinhViens.Remove(sv);
                db.SaveChanges();
                MessageBox.Show("Xóa sinh viên thành công.");
            }

            TaiDuLieu();
            XoaTrang();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show(
                "Bạn có muốn thoát chương trình?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua == DialogResult.Yes)
                Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            db.Dispose();
            base.OnFormClosed(e);
        }
    }
}
