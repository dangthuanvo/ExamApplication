using ExamApplication.Sẹrvice;
using System;
using System.Windows.Forms;

namespace ExamApplication.UI.Admin
{
    public partial class StudentHistory : Form
    {
        HistoryService historyservice = new HistoryService();
        ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
        ToolStripMenuItem deleteItem = new ToolStripMenuItem("Xoá lịch sử làm bài sinh viên này");
        public StudentHistory()
        {
            InitializeComponent();
            foreach (var a in historyservice.GetAll())
            {
                dataGridView1.Rows.Add(a.studentid, a.studentname, a.time, TimeSpan.FromSeconds(a.timetake).ToString(@"m\:ss"), a.score);
            }
            deleteItem.Click += deleteToolStripMenuItem_Click;
            contextMenuStrip.Items.Add(deleteItem);
            dataGridView1.ContextMenuStrip = contextMenuStrip;

        }
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Select the row under the mouse
                DataGridView.HitTestInfo hitTestInfo = dataGridView1.HitTest(e.X, e.Y);
                if (hitTestInfo.RowIndex >= 0)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[hitTestInfo.RowIndex].Selected = true;
                    dataGridView1.ContextMenuStrip.Show(dataGridView1, e.Location);
                }

            }
            //DisableContextMenu();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            historyservice.DeleteByName(dataGridView1.SelectedRows[0].Cells["id"].Value.ToString());
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }
            MessageBox.Show("Xoá thành công");
        }

    }
}
