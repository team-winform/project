using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTOs;
using BLLs;

namespace main_GUI
{
    public partial class GiangVienDialog_chiTiet : Form
    {
        private GiangVienDTO gv;
        public GiangVienDialog_chiTiet(GiangVienDTO g)
        {
            gv = g;
            InitializeComponent();
        }

        private void GiangVienDialog_chiTiet_Load(object sender, EventArgs e)
        {
            hienThiGrid();
            loadDataForTextBox();
        }

        private void loadDataForTextBox()
        {
            tb_address.Text = gv.Address;
            tb_date.Text = gv.DayOfBirth.ToString();
            tb_ma.Text = gv.Id;
            tb_note.Text = gv.Note;
            tb_sdt.Text = gv.Phone;
            tb_ten.Text = gv.Name;
        }

        private void hienThiGrid()
        {
            dgv_classList.DataSource = GiangVienBLL.Instance.getClassList(gv);
        }
    }
}
