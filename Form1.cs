using Project_XT_v1_0_0.Forms;
using Project_XT_v1_0_0.Styles;
using System.Data;

namespace Project_XT_v1_0_0
{
    public partial class Form1 : Form
    {
        readonly Database db;
        string currentDataGridView = "";
        public Form1()
        {
            InitializeComponent();

            db = new Database("C:\\Users\\alber\\Desktop\\Project XT DB\\projext_xt.db");

            MyDataGridViewStyle.Init(ref dataGridView1);
        }

        private void Show_orgs_Click(object sender, EventArgs e)
        {
            currentDataGridView = "Organizations";
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = db.GetData("SELECT * FROM Organizations ORDER BY Name");

            int dgvWidth = dataGridView1.Width;

            dataGridView1.Columns[0].Width = (int)((double)dgvWidth * 0.3);
            dataGridView1.Columns[1].Width = (int)((double)dgvWidth * 0.09);
            dataGridView1.Columns[2].Width = (int)((double)dgvWidth * 0.125);
            dataGridView1.Columns[3].Width = (int)((double)dgvWidth * 0.25);
            dataGridView1.Columns[4].Width = (int)((double)dgvWidth * 0.235);
        }

        private void Show_dists_Click(object sender, EventArgs e)
        {
            currentDataGridView = "Distributors";
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = db.GetData("SELECT * FROM Distributors ORDER BY Name");

            int dgvWidth = dataGridView1.Width;

            dataGridView1.Columns[0].Width = (int)((double)dgvWidth * 0.275);
            dataGridView1.Columns[1].Width = (int)((double)dgvWidth * 0.125);
            dataGridView1.Columns[2].Width = (int)((double)dgvWidth * 0.3);
            dataGridView1.Columns[3].Width = (int)((double)dgvWidth * 0.09);
            dataGridView1.Columns[4].Width = (int)((double)dgvWidth * 0.21);
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0) return;

            string name = dataGridView1!.CurrentRow!.Cells[0]!.Value!.ToString() ?? "";

            if (dataGridView1 is not null && currentDataGridView == "Organizations")
                new EditOrganization(name).ShowDialog(this);
            else if (currentDataGridView == "Distributors")
                new EditDistributor(name).ShowDialog(this);

            dataGridView1!.Focus();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            if (currentDataGridView == "Organizations") new AddOrganization().ShowDialog(this);
            else if (currentDataGridView == "Distributors") new AddDistributor().ShowDialog(this);

            dataGridView1!.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Width = (int)((double)Width * 0.978);
            dataGridView1.Height = (int)((double)Height * 0.825);
        }

        private void Show_goods_button_Click(object sender, EventArgs e)
        {
			currentDataGridView = "Goods";
			dataGridView1.Columns.Clear();
			dataGridView1.DataSource = db.GetData("SELECT Name, Quantity, SellingPrice, Price, Difference, ATGAA FROM Goods ORDER BY Name");

			int dgvWidth = dataGridView1.Width;

			dataGridView1.Columns[0].Width = (int)((double)dgvWidth * 0.54);
			dataGridView1.Columns[1].Width = (int)((double)dgvWidth * 0.085);
            dataGridView1.Columns[2].Width = (int)((double)dgvWidth * 0.085);
            dataGridView1.Columns[3].Width = (int)((double)dgvWidth * 0.085);
            dataGridView1.Columns[4].Width = (int)((double)dgvWidth * 0.085);
            dataGridView1.Columns[5].Width = (int)((double)dgvWidth * 0.12);
            //hello
        }

		private void Remove_button_Click(object sender, EventArgs e)
        {
			if (currentDataGridView == "Organizations")
            {
                if (dataGridView1.SelectedCells[2].Value!.ToString() != "0") MessageBox.Show("Դուք չեք կարոհ հեռացնել այս կազմակերպությունը, քանի որ պարտքի չափը տարբեր է 0-ից:");
                else
                {
                    if (MessageBox.Show($"Դուք պատրաստվում եք հեռացնել '{dataGridView1.SelectedCells[0].Value!}' կազմակերպությունը:", "Կազմակերպության հեռացում", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        MessageBox.Show("Հեռացված է:");
                    }
                }
			}
			else if (currentDataGridView == "Distributors")
            {
				if (dataGridView1.SelectedCells[1].Value!.ToString() != "0") MessageBox.Show("Դուք չեք կարոհ հեռացնել այս դիստրիբյուտորին, քանի որ պարտքի չափը տարբեր է 0-ից:");
				else
				{
					if (MessageBox.Show($"Դուք պատրաստվում եք հեռացնել '{dataGridView1.SelectedCells[0].Value!}' դիստրիբյուտորին:", "Դիստրիբյուտորտ հեռացում", MessageBoxButtons.YesNo) == DialogResult.Yes)
					{
						MessageBox.Show("Հեռացված է:");
					}
				}
			}
            else if (currentDataGridView == "Goods")
            {
				if (dataGridView1.SelectedCells[1].Value!.ToString() != "0") MessageBox.Show("Դուք չեք կարոհ հեռացնել այս ap8anqy, քանի որ քանակությունը տարբեր է 0-ից:");
				else
				{
					if (MessageBox.Show($"Դուք պատրաստվում եք հեռացնել '{dataGridView1.SelectedCells[0].Value!}' ապրանքը:", "Ապրանքի հեռացում", MessageBoxButtons.YesNo) == DialogResult.Yes)
					{
						MessageBox.Show("Հեռացված է:");
					}
				}
			}

            dataGridView1.Focus();
		}
    }
}
