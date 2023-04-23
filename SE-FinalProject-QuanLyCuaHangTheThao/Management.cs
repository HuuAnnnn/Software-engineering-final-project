using BUS;
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

namespace SE_FinalProject_QuanLyCuaHangTheThao
{
    public partial class Management : Form
    {
        private ManagerBUS managerBUS;
        public Management()
        {
            InitializeComponent();
            managerBUS = new ManagerBUS();
            DataTable tableReceipt = managerBUS.selectAllReceipt();
            loadAllRecipt(tableReceipt);
            loadAllEployee();
        }

        // Page Employee
        public byte[] convertImageToByteArray(string fileName)
        {
            FileStream fileStream;
            BinaryReader binaryReader;
            byte[] byteArray;

            if (!File.Exists(fileName))
            {
                return null;
            }

            fileStream = new FileStream(fileName, FileMode.Open);
            binaryReader = new BinaryReader(fileStream);
            byteArray = new byte[fileStream.Length];
            byteArray = binaryReader.ReadBytes(Convert.ToInt32((fileStream.Length)));

            binaryReader.Close();
            fileStream.Close();
            return byteArray;
        }

        public Image convertByteArrayToImage(byte[] byteArray)
        {
            return (Bitmap)((new ImageConverter()).ConvertFrom(byteArray));
        }

        public string checkDepartment(int department)
        {
            if (department == 1)
            {
                return "Kinh Doanh";
            }
            if (department == 2)
            {
                return "Kho";
            }

            return "Thu Ngân";
        }
        public void loadAllEployee()
        {
            DataTable tableEmployee = managerBUS.selectAllEmployee();
            dgvEmployee.Rows.Clear();
            foreach (DataRow row in tableEmployee.Select())
            {
                int index = dgvEmployee.Rows.Add();
                dgvEmployee.Rows[index].Cells[0].Value = row["employeeID"];
                dgvEmployee.Rows[index].Cells[1].Value = row["fullName"];
                dgvEmployee.Rows[index].Cells[2].Value = row["sex"];
                dgvEmployee.Rows[index].Cells[3].Value = row["birthday"];
                dgvEmployee.Rows[index].Cells[4].Value = row["address"];
                dgvEmployee.Rows[index].Cells[5].Value = row["phone"];
                dgvEmployee.Rows[index].Cells[6].Value = convertByteArrayToImage((byte[])row["avatar"]);
                dgvEmployee.Rows[index].Cells[7].Value = checkDepartment(Convert.ToInt32(row["department"].ToString()));
            }
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvEmployee.Rows[e.RowIndex];
            string id = Convert.ToString(row.Cells[0].Value);
            tbId.Text = id;
            string fullName = Convert.ToString(row.Cells[1].Value);
            tbName.Text = fullName;
            string sex = Convert.ToString(row.Cells[2].Value);
            tbSex.Text = sex;
            DateTime birthday = Convert.ToDateTime(row.Cells[3].Value);
            dtpBirthday.Value = birthday;
            string address = Convert.ToString(row.Cells[4].Value);
            tbAddress.Text = address;
            string phone = Convert.ToString(row.Cells[5].Value);
            tbPhone.Text = phone;
            pbAvatar.Image = (Bitmap)row.Cells[6].Value;
            string department = Convert.ToString(row.Cells[7].Value);
            cbDepartment.Text = department;
        }

        public void clearInfor()
        {
            tbId.Clear();
            tbName.Clear();
            tbSex.Clear();
            dtpBirthday.Value = DateTime.Now;
            tbAddress.Clear();
            tbPhone.Clear();
            pbAvatar.Image = Properties.Resources.mockup_image;
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            clearInfor();
        }

        private void btnInsertAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Picture file .jpeg|*.jpeg";
            openFile.Title = "Choose Picture";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pbAvatar.Image = Image.FromFile(openFile.FileName);
                pbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string employeeID = tbId.Text.Trim();
            managerBUS.deleteEmployee(employeeID);
            loadAllEployee();
        }

        public string generateEmployeeID()
        {
            DataTable tableEmployeeID = managerBUS.selectEmployeeDesc();
            DataRow row = tableEmployeeID.Select()[0];
            string employeeIDMax = row["employeeID"].ToString();
            int id = Convert.ToInt32(employeeIDMax.Substring(2));
            id += 1;
            if (id < 10) 
            {
                return "NV0" + id.ToString();
            }
            return "NV" + id.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clearInfor();
            tbId.Enabled = true;
            tbId.Text = generateEmployeeID();
        }

        public int generatePassword()
        {
            Random random = new Random();
            int randomPassword = random.Next(100000, 999999);
            return randomPassword;
        }

        public void addAccount(string username, int password, int timeChangePassword, string role)
        {
            MessageBox.Show("Username = " + username + "\nPassword = " + password + "\n" + Configuration.Config.hash(password.ToString()), "Tài khoản");
            managerBUS.insertAccount(username, Configuration.Config.hash(password.ToString()), timeChangePassword, role);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbId.Enabled == true)
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn thêm", "Thông báo", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    string employeeID = tbId.Text;
                    string fullName = tbName.Text;
                    string sex = tbSex.Text;
                    DateTime birthday = dtpBirthday.Value;
                    string address = tbAddress.Text;
                    string phone = tbPhone.Text;
                    ImageConverter converter = new ImageConverter();
                    byte[] arrayImage = (byte[])converter.ConvertTo(pbAvatar.Image, typeof(byte[]));
                    int department = cbDepartment.SelectedIndex + 1;
                    managerBUS.insertEmployeeQuery(employeeID, fullName, 2000000 , birthday, sex, phone, address, arrayImage, department, 1);
                    loadAllEployee();
                    tbId.Enabled = false;

                    string username = employeeID;
                    int password = generatePassword();
                    addAccount(username, password, 0, "Staff");
                }
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn lưu", "Thông báo", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    string employeeID = tbId.Text;
                    string fullName = tbName.Text;
                    string sex = tbSex.Text;
                    DateTime birthday = dtpBirthday.Value;
                    string address = tbAddress.Text;
                    string phone = tbPhone.Text;
                    ImageConverter converter = new ImageConverter();
                    byte[] arrayImage = (byte[])converter.ConvertTo(pbAvatar.Image, typeof(byte[]));
                    int department = cbDepartment.SelectedIndex;
                    managerBUS.updateEmployeeQuery(employeeID, fullName, birthday, sex, phone, address, arrayImage, department + 1);
                    loadAllEployee();
                }
            }
        }
        // Page Receipt
        public void loadAllRecipt(DataTable tableReceipt)
        {
            dgvReceipt.Rows.Clear();
            foreach (DataRow row in tableReceipt.Select())
            {
                int index = dgvReceipt.Rows.Add();
                dgvReceipt.Rows[index].Cells[0].Value = row["id"];
                dgvReceipt.Rows[index].Cells[1].Value = row["dateCreate"];
                dgvReceipt.Rows[index].Cells[2].Value = row["employeeName"];
                dgvReceipt.Rows[index].Cells[3].Value = row["fullName"];
                dgvReceipt.Rows[index].Cells[4].Value = row["total"];
            }
        }

        public void chooserSortType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chooserSortType.SelectedIndex.ToString() == "0")
            {
                DataTable tableReceipt = managerBUS.selectReceiptSortTotalDesc();
                loadAllRecipt(tableReceipt);
            }
            else if (chooserSortType.SelectedIndex.ToString() == "1")
            {
                DataTable tableReceipt = managerBUS.selectReceiptSortTotal();
                loadAllRecipt(tableReceipt);
            }
            else if (chooserSortType.SelectedIndex.ToString() == "2")
            {
                DataTable tableReceipt = managerBUS.selectReceiptSortDateCreatedDesc();
                loadAllRecipt(tableReceipt);
            }
            else
            {
                DataTable tableReceipt = managerBUS.selectReceiptSortDateCreated();
                loadAllRecipt(tableReceipt);
            }
        }
        public string formatDate(string date)
        {
            string[] timeArray = date.Split(' ');
            string[] dateArray = timeArray[0].Split('/');
            string day = dateArray[1];
            string month = dateArray[0];
            string year = dateArray[2];
            return year + "-" + month + "-" + day;
        }

        private void btnSearchReceipt_Click(object sender, EventArgs e)
        {
            string startDate = formatDate(dtpStart.Value.ToString());
            string endDate = formatDate(dtpEnd.Value.ToString());
            MessageBox.Show(startDate);
            MessageBox.Show(endDate);
            DataTable tableReceipt = managerBUS.selectReceiptInRangeDay(startDate, endDate);
            loadAllRecipt(tableReceipt);
        }
    }
}
