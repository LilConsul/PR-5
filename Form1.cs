using System;
using System.Windows.Forms;

namespace PR_5 {
    public partial class Form1 : Form {
        private ListStudents list = new ListStudents();
        private ListStudents winner = new ListStudents();
        private ListStudents filtered = new ListStudents();
        private File file = new File("test.xml", "test.xml");

        public Form1() {
            InitializeComponent();
        }

        private void Update_table() {
            try {
                data_list.Rows.Clear();
                foreach (var student in list) {
                    data_list.Rows.Add(student.FullName, student.Course, student.Group, student.Score);
                }
            }
            catch (Exception exception) {
                MessageBox.Show(exception.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Update_winner() {
            try {
                additional_label.Text = "Виграли";
                winner_list.Rows.Clear();
                foreach (var student in winner) {
                    winner_list.Rows.Add(student.FullName, student.Course, student.Group, student.Score);
                }
            }
            catch (Exception exception) {
                MessageBox.Show(exception.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void Update_filter() {
            try {
                additional_label.Text = "Фільтр";
                winner_list.Rows.Clear();
                foreach (var student in filtered) {
                    winner_list.Rows.Add(student.FullName, student.Course, student.Group, student.Score);
                }
            }
            catch (Exception exception) {
                MessageBox.Show(exception.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void add_button_Click(object sender, EventArgs e) {
            try {
                var name = Convert.ToString(name_box.Text);
                var group = Convert.ToInt32(group_box.Text);
                var course = Convert.ToInt32(course_box.Text);
                var score = Convert.ToInt32(score_box.Text);

                list.Add(new Student(name, course, group, score));
                Update_table();
            }
            catch (Exception exception) {
                MessageBox.Show(exception.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void read_Click(object sender, EventArgs e) {
            try {
                file.Read(ref list);
                Update_table();
            }
            catch (Exception exception) {
                MessageBox.Show(exception.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete_Click(object sender, EventArgs e) {
            try {
                var rm = Convert.ToString(name_del.Text);
                list.Remove(rm);
                Update_table();
            }
            catch (Exception exception) {
                MessageBox.Show(exception.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void write_Click(object sender, EventArgs e) {
            try {
                file.Write(ref list);
                Update_table();
            }
            catch (Exception exception) {
                MessageBox.Show(exception.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sort_button_Click(object sender, EventArgs e) {
            try {
                list.QuickSortByScore();
                Update_table();
            }
            catch (Exception exception) {
                MessageBox.Show(exception.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void filter_Click(object sender, EventArgs e) {
            try {
                var cr = Convert.ToInt32(course_filter.Text);
                filtered = list.filterByCourse(cr);
                Update_filter();
            }
            catch (Exception exception) {
                MessageBox.Show(exception.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void winners_Click(object sender, EventArgs e) {
            winner = list.findWinner();
            Update_winner();
        }
    }
}