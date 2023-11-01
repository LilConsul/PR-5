namespace PR_5
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.label1 = new System.Windows.Forms.Label();
      this.name_box = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.course_box = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.group_box = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.score_box = new System.Windows.Forms.TextBox();
      this.add_button = new System.Windows.Forms.Button();
      this.data_list = new System.Windows.Forms.DataGridView();
      this.name_field = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.course_field = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.group_field = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.score_field = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.read = new System.Windows.Forms.Button();
      this.write = new System.Windows.Forms.Button();
      this.sort_button = new System.Windows.Forms.Button();
      this.winners = new System.Windows.Forms.Button();
      this.winner_list = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.data_list)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.winner_list)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(12, 23);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(161, 33);
      this.label1.TabIndex = 0;
      this.label1.Text = "Повне ім\'я";
      // 
      // name_box
      // 
      this.name_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.name_box.Location = new System.Drawing.Point(15, 59);
      this.name_box.Name = "name_box";
      this.name_box.Size = new System.Drawing.Size(158, 31);
      this.name_box.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(12, 93);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(161, 33);
      this.label2.TabIndex = 0;
      this.label2.Text = "Курс";
      // 
      // course_box
      // 
      this.course_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.course_box.Location = new System.Drawing.Point(15, 129);
      this.course_box.Name = "course_box";
      this.course_box.Size = new System.Drawing.Size(158, 31);
      this.course_box.TabIndex = 1;
      // 
      // label3
      // 
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(12, 163);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(161, 33);
      this.label3.TabIndex = 0;
      this.label3.Text = "Группа";
      // 
      // group_box
      // 
      this.group_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.group_box.Location = new System.Drawing.Point(15, 199);
      this.group_box.Name = "group_box";
      this.group_box.Size = new System.Drawing.Size(158, 31);
      this.group_box.TabIndex = 1;
      // 
      // label4
      // 
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label4.Location = new System.Drawing.Point(12, 233);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(161, 33);
      this.label4.TabIndex = 0;
      this.label4.Text = "Результат";
      // 
      // score_box
      // 
      this.score_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.score_box.Location = new System.Drawing.Point(15, 269);
      this.score_box.Name = "score_box";
      this.score_box.Size = new System.Drawing.Size(158, 31);
      this.score_box.TabIndex = 1;
      // 
      // add_button
      // 
      this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.add_button.Location = new System.Drawing.Point(15, 336);
      this.add_button.Name = "add_button";
      this.add_button.Size = new System.Drawing.Size(158, 45);
      this.add_button.TabIndex = 2;
      this.add_button.Text = "Додати";
      this.add_button.UseVisualStyleBackColor = true;
      this.add_button.Click += new System.EventHandler(this.add_button_Click);
      // 
      // data_list
      // 
      this.data_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
      this.data_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.data_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.name_field, this.course_field, this.group_field, this.score_field });
      this.data_list.Location = new System.Drawing.Point(219, 56);
      this.data_list.Name = "data_list";
      this.data_list.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      this.data_list.Size = new System.Drawing.Size(321, 325);
      this.data_list.TabIndex = 3;
      // 
      // name_field
      // 
      this.name_field.HeaderText = "Ім\'я";
      this.name_field.Name = "name_field";
      this.name_field.ReadOnly = true;
      this.name_field.Width = 51;
      // 
      // course_field
      // 
      this.course_field.HeaderText = "Курс";
      this.course_field.Name = "course_field";
      this.course_field.ReadOnly = true;
      this.course_field.Width = 56;
      // 
      // group_field
      // 
      this.group_field.HeaderText = "Група";
      this.group_field.Name = "group_field";
      this.group_field.ReadOnly = true;
      this.group_field.Width = 61;
      // 
      // score_field
      // 
      this.score_field.HeaderText = "Результат";
      this.score_field.Name = "score_field";
      this.score_field.ReadOnly = true;
      this.score_field.Width = 84;
      // 
      // label5
      // 
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label5.Location = new System.Drawing.Point(219, 23);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(161, 33);
      this.label5.TabIndex = 0;
      this.label5.Text = "Список";
      // 
      // label6
      // 
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label6.Location = new System.Drawing.Point(561, 23);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(161, 33);
      this.label6.TabIndex = 0;
      this.label6.Text = "Виграли";
      // 
      // read
      // 
      this.read.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.read.Location = new System.Drawing.Point(219, 409);
      this.read.Name = "read";
      this.read.Size = new System.Drawing.Size(181, 45);
      this.read.TabIndex = 2;
      this.read.Text = "Прочитати";
      this.read.UseVisualStyleBackColor = true;
      this.read.Click += new System.EventHandler(this.read_Click);
      // 
      // write
      // 
      this.write.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.write.Location = new System.Drawing.Point(406, 409);
      this.write.Name = "write";
      this.write.Size = new System.Drawing.Size(181, 45);
      this.write.TabIndex = 2;
      this.write.Text = "Записати";
      this.write.UseVisualStyleBackColor = true;
      this.write.Click += new System.EventHandler(this.write_Click);
      // 
      // sort_button
      // 
      this.sort_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.sort_button.Location = new System.Drawing.Point(15, 409);
      this.sort_button.Name = "sort_button";
      this.sort_button.Size = new System.Drawing.Size(158, 45);
      this.sort_button.TabIndex = 2;
      this.sort_button.Text = "Відсортувати";
      this.sort_button.UseVisualStyleBackColor = true;
      this.sort_button.Click += new System.EventHandler(this.sort_button_Click);
      // 
      // winners
      // 
      this.winners.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.winners.Location = new System.Drawing.Point(601, 409);
      this.winners.Name = "winners";
      this.winners.Size = new System.Drawing.Size(242, 45);
      this.winners.TabIndex = 2;
      this.winners.Text = "Знайти переможців";
      this.winners.UseVisualStyleBackColor = true;
      this.winners.Click += new System.EventHandler(this.winners_Click);
      // 
      // winner_list
      // 
      this.winner_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
      this.winner_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.winner_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dataGridViewTextBoxColumn1, this.dataGridViewTextBoxColumn2, this.dataGridViewTextBoxColumn3, this.dataGridViewTextBoxColumn4 });
      this.winner_list.Location = new System.Drawing.Point(561, 56);
      this.winner_list.Name = "winner_list";
      this.winner_list.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      this.winner_list.Size = new System.Drawing.Size(321, 325);
      this.winner_list.TabIndex = 3;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.HeaderText = "Ім\'я";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      this.dataGridViewTextBoxColumn1.Width = 51;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.HeaderText = "Курс";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.ReadOnly = true;
      this.dataGridViewTextBoxColumn2.Width = 56;
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.HeaderText = "Група";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      this.dataGridViewTextBoxColumn3.ReadOnly = true;
      this.dataGridViewTextBoxColumn3.Width = 61;
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.HeaderText = "Результат";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      this.dataGridViewTextBoxColumn4.ReadOnly = true;
      this.dataGridViewTextBoxColumn4.Width = 84;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.ClientSize = new System.Drawing.Size(879, 466);
      this.Controls.Add(this.winner_list);
      this.Controls.Add(this.data_list);
      this.Controls.Add(this.winners);
      this.Controls.Add(this.sort_button);
      this.Controls.Add(this.write);
      this.Controls.Add(this.read);
      this.Controls.Add(this.add_button);
      this.Controls.Add(this.score_box);
      this.Controls.Add(this.group_box);
      this.Controls.Add(this.course_box);
      this.Controls.Add(this.name_box);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label1);
      this.Location = new System.Drawing.Point(15, 15);
      this.Name = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.data_list)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.winner_list)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private System.Windows.Forms.DataGridView winner_list;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

    private System.Windows.Forms.DataGridViewTextBoxColumn name_field;
    private System.Windows.Forms.DataGridViewTextBoxColumn course_field;
    private System.Windows.Forms.DataGridViewTextBoxColumn group_field;
    private System.Windows.Forms.DataGridViewTextBoxColumn score_field;

    private System.Windows.Forms.Button winners;

    private System.Windows.Forms.Button sort_button;

    private System.Windows.Forms.Button read;
    private System.Windows.Forms.Button write;

    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.DataGridView data_list;

    private System.Windows.Forms.Button add_button;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox course_box;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox group_box;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox score_box;

    private System.Windows.Forms.TextBox name_box;

    private System.Windows.Forms.Label label1;

    #endregion
  }
}

