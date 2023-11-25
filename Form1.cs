using System.Reflection.Metadata;

namespace Test_PTUDCSDL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Loadcomboboxloaihang()
        {
            comboBox1.ValueMember = "MaLoaiHang";
            comboBox1.DisplayMember = "TenLoaiHang";
            comboBox1.DataSource = Database.Query("select * from LoaiHang");
            comboBox1.SelectedIndex = -1;
        }

        private void Loadcomboboxnsx()
        {
            comboBox2.ValueMember = "MaNhaSanXuat";
            comboBox2.DisplayMember = "TenNhaSanXuat";
            comboBox2.DataSource = Database.Query("select * from NhaSanXuat");
            comboBox2.SelectedIndex = -1;
        }

        private void Loaddatagridview()
        {
            dataGridView1.DataSource = Database.Query("select * from vHangHoa");
        }

        private bool Checkerror()
        {
            errorProvider1.Clear();
            bool result = true;
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Thiếu");
                result = false;
            }
            if (textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, "Thiếu");
                result = false;
            }
            if (textBox3.Text == "")
            {
                errorProvider1.SetError(textBox3, "Thiếu");
                result = false;
            }
            if (comboBox1.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBox1, "Thiếu");
                result = false;
            }
            if (comboBox2.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBox2, "Thiếu");
                result = false;
            }
            return result;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Loaddatagridview();
            Loadcomboboxloaihang();
            Loadcomboboxnsx();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Checkerror() == false) return;
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@MaHangHoa", textBox1.Text);
                parameters.Add("@TenHangHoa", textBox2.Text);
                parameters.Add("@SoLuong", textBox3.Text);
                parameters.Add("@MaLoaiHang", comboBox1.SelectedValue);
                parameters.Add("@MaNhaSanXuat", comboBox2.SelectedValue);
                Database.Execute("insert into HangHoa values (@MaHangHoa,@TenHangHoa,@SoLuong,@MaLoaiHang,@MaNhaSanXuat)", parameters);
                Loaddatagridview();
            }
            catch
            {
                MessageBox.Show("Lỗi", "Thông báo");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@MaHangHoa", int.Parse(textBox1.Text));
                Database.Execute("delete from HangHoa where MaHangHoa=" + "@MaHangHoa", parameters);
                Loaddatagridview();
            }
            catch
            {
                MessageBox.Show("Lỗi", "Thông báo");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.ReadOnly = true;
            button2.Enabled = true;
            button3.Enabled = true;
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox1.SelectedIndex = comboBox1.FindString(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            comboBox2.SelectedIndex = comboBox2.FindString(dataGridView1.CurrentRow.Cells[4].Value.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            textBox1.ReadOnly = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cmd = "select * from vHangHoa where 1=1";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            if (checkBox1.Checked == true)
            {
                cmd = cmd + " and MaHangHoa=@MaHangHoa";
                parameters.Add("@MaHangHoa", textBox1.Text);
            }
            if (checkBox2.Checked == true)
            {
                cmd = cmd + " and TenHangHoa like '%'+@TenHangHoa+'%'";
                parameters.Add("@TenHangHoa", textBox2.Text);
            }
            if (checkBox3.Checked == true)
            {
                cmd = cmd + " and SoLuong=@SoLuong";
                parameters.Add("@SoLuong", textBox3.Text);
            }
            if (checkBox4.Checked == true)
            {
                cmd = cmd + " and TenLoaiHang like '%'+@TenLoaiHang+'%'";
                parameters.Add("@TenLoaiHang", comboBox1.Text);
            }
            if (checkBox5.Checked == true)
            {
                cmd = cmd + " and TenNhaSanXuat like '%'+@TenNhaSanXuat+'%'";
                parameters.Add("@TenNhaSanXuat", comboBox2.Text);
            }
            dataGridView1.DataSource = Database.Query(cmd, parameters);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@MaHangHoa", textBox1.Text);
                parameters.Add("@TenHangHoa", textBox2.Text);
                parameters.Add("@SoLuong", textBox3.Text);
                parameters.Add("@MaLoaiHang", comboBox1.SelectedValue);
                parameters.Add("@MaNhaSanXuat", comboBox2.SelectedValue);
                Database.Query("update HangHoa set TenHangHoa=@TenHangHoa,SoLuong=@SoLuong,MaLoaiHang=@MaloaiHang,MaNhaSanXuat=@MaNhaSanXuat where MaHangHoa=@MaHangHoa", parameters);
                Loaddatagridview();
            }
            catch
            {
                MessageBox.Show("Lỗi", "Thông báo");
            }
        }
    }
}
