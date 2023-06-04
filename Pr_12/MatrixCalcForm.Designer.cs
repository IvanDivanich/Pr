namespace SimpleMatrixCalc
{
    partial class MatrixCalcForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel_MatrixForm = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_ColumnsMatrixA = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_RowsMatrixA = new System.Windows.Forms.NumericUpDown();
            this.button_MatrixAFillIn = new System.Windows.Forms.Button();
            this.dataGridView_MatrixA = new System.Windows.Forms.DataGridView();
            this.button_CopyDown = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_MatrixMinors = new System.Windows.Forms.Button();
            this.button_MultiplyWithScalar = new System.Windows.Forms.Button();
            this.button_Transpose = new System.Windows.Forms.Button();
            this.button_MatrixDeterminant = new System.Windows.Forms.Button();
            this.button_MatrixRank = new System.Windows.Forms.Button();
            this.button_InverseMatrix = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_Summ = new System.Windows.Forms.Button();
            this.button_Subtraction = new System.Windows.Forms.Button();
            this.button_Multiply = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_MatrixB = new System.Windows.Forms.DataGridView();
            this.numericUpDown_ColumnsMatrixB = new System.Windows.Forms.NumericUpDown();
            this.button_MatrixBFillIn = new System.Windows.Forms.Button();
            this.numericUpDown_RowsMatrixB = new System.Windows.Forms.NumericUpDown();
            this.button_CopyUp = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView_MatrixResult = new System.Windows.Forms.DataGridView();
            this.button_CopyLeft = new System.Windows.Forms.Button();
            this.tableLayoutPanel_MatrixForm.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ColumnsMatrixA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RowsMatrixA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MatrixA)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MatrixB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ColumnsMatrixB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RowsMatrixB)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MatrixResult)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_MatrixForm
            // 
            this.tableLayoutPanel_MatrixForm.ColumnCount = 2;
            this.tableLayoutPanel_MatrixForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_MatrixForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_MatrixForm.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel_MatrixForm.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel_MatrixForm.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel_MatrixForm.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel_MatrixForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_MatrixForm.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_MatrixForm.Name = "tableLayoutPanel_MatrixForm";
            this.tableLayoutPanel_MatrixForm.RowCount = 2;
            this.tableLayoutPanel_MatrixForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_MatrixForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_MatrixForm.Size = new System.Drawing.Size(811, 609);
            this.tableLayoutPanel_MatrixForm.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.button_CopyDown);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 304);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown_ColumnsMatrixA);
            this.groupBox1.Controls.Add(this.numericUpDown_RowsMatrixA);
            this.groupBox1.Controls.Add(this.button_MatrixAFillIn);
            this.groupBox1.Controls.Add(this.dataGridView_MatrixA);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matrix A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Columns:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rows:";
            // 
            // numericUpDown_ColumnsMatrixA
            // 
            this.numericUpDown_ColumnsMatrixA.Location = new System.Drawing.Point(262, 20);
            this.numericUpDown_ColumnsMatrixA.Name = "numericUpDown_ColumnsMatrixA";
            this.numericUpDown_ColumnsMatrixA.Size = new System.Drawing.Size(36, 25);
            this.numericUpDown_ColumnsMatrixA.TabIndex = 1;
            // 
            // numericUpDown_RowsMatrixA
            // 
            this.numericUpDown_RowsMatrixA.Location = new System.Drawing.Point(144, 20);
            this.numericUpDown_RowsMatrixA.Name = "numericUpDown_RowsMatrixA";
            this.numericUpDown_RowsMatrixA.Size = new System.Drawing.Size(36, 25);
            this.numericUpDown_RowsMatrixA.TabIndex = 1;
            // 
            // button_MatrixAFillIn
            // 
            this.button_MatrixAFillIn.AutoSize = true;
            this.button_MatrixAFillIn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_MatrixAFillIn.Location = new System.Drawing.Point(304, 17);
            this.button_MatrixAFillIn.Name = "button_MatrixAFillIn";
            this.button_MatrixAFillIn.Size = new System.Drawing.Size(71, 29);
            this.button_MatrixAFillIn.TabIndex = 0;
            this.button_MatrixAFillIn.Text = "Fill in";
            this.button_MatrixAFillIn.UseVisualStyleBackColor = false;
            this.button_MatrixAFillIn.Click += new System.EventHandler(this.button_MatrixAFillIn_Click);
            // 
            // dataGridView_MatrixA
            // 
            this.dataGridView_MatrixA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MatrixA.Location = new System.Drawing.Point(6, 52);
            this.dataGridView_MatrixA.Name = "dataGridView_MatrixA";
            this.dataGridView_MatrixA.Size = new System.Drawing.Size(369, 182);
            this.dataGridView_MatrixA.TabIndex = 0;
            // 
            // button_CopyDown
            // 
            this.button_CopyDown.AutoSize = true;
            this.button_CopyDown.BackColor = System.Drawing.Color.Aqua;
            this.button_CopyDown.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_CopyDown.Location = new System.Drawing.Point(141, 258);
            this.button_CopyDown.Name = "button_CopyDown";
            this.button_CopyDown.Size = new System.Drawing.Size(106, 28);
            this.button_CopyDown.TabIndex = 0;
            this.button_CopyDown.Text = "Перенести вниз";
            this.button_CopyDown.UseVisualStyleBackColor = false;
            this.button_CopyDown.Click += new System.EventHandler(this.button_CopyDown_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(405, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 304);
            this.panel2.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LightGray;
            this.groupBox4.Controls.Add(this.button_MatrixMinors);
            this.groupBox4.Controls.Add(this.button_MultiplyWithScalar);
            this.groupBox4.Controls.Add(this.button_Transpose);
            this.groupBox4.Controls.Add(this.button_MatrixDeterminant);
            this.groupBox4.Controls.Add(this.button_MatrixRank);
            this.groupBox4.Controls.Add(this.button_InverseMatrix);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(13, 80);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(381, 94);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "A Matrix operations";
            // 
            // button_MatrixMinors
            // 
            this.button_MatrixMinors.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_MatrixMinors.Location = new System.Drawing.Point(137, 58);
            this.button_MatrixMinors.Name = "button_MatrixMinors";
            this.button_MatrixMinors.Size = new System.Drawing.Size(111, 28);
            this.button_MatrixMinors.TabIndex = 0;
            this.button_MatrixMinors.Text = "Minors";
            this.button_MatrixMinors.UseVisualStyleBackColor = false;
            this.button_MatrixMinors.Click += new System.EventHandler(this.button_MatrixMinors_Click);
            // 
            // button_MultiplyWithScalar
            // 
            this.button_MultiplyWithScalar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_MultiplyWithScalar.Location = new System.Drawing.Point(264, 58);
            this.button_MultiplyWithScalar.Name = "button_MultiplyWithScalar";
            this.button_MultiplyWithScalar.Size = new System.Drawing.Size(111, 28);
            this.button_MultiplyWithScalar.TabIndex = 0;
            this.button_MultiplyWithScalar.Text = "Scalar";
            this.button_MultiplyWithScalar.UseVisualStyleBackColor = false;
            this.button_MultiplyWithScalar.Click += new System.EventHandler(this.button_MultiplyWithScalar_Click);
            // 
            // button_Transpose
            // 
            this.button_Transpose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Transpose.Location = new System.Drawing.Point(137, 24);
            this.button_Transpose.Name = "button_Transpose";
            this.button_Transpose.Size = new System.Drawing.Size(111, 28);
            this.button_Transpose.TabIndex = 0;
            this.button_Transpose.Text = "Transpose";
            this.button_Transpose.UseVisualStyleBackColor = false;
            this.button_Transpose.Click += new System.EventHandler(this.button_Transpose_Click);
            // 
            // button_MatrixDeterminant
            // 
            this.button_MatrixDeterminant.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_MatrixDeterminant.Location = new System.Drawing.Point(7, 58);
            this.button_MatrixDeterminant.Name = "button_MatrixDeterminant";
            this.button_MatrixDeterminant.Size = new System.Drawing.Size(111, 28);
            this.button_MatrixDeterminant.TabIndex = 0;
            this.button_MatrixDeterminant.Text = "Determinant";
            this.button_MatrixDeterminant.UseVisualStyleBackColor = false;
            this.button_MatrixDeterminant.Click += new System.EventHandler(this.button_MatrixDeterminant_Click);
            // 
            // button_MatrixRank
            // 
            this.button_MatrixRank.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_MatrixRank.Location = new System.Drawing.Point(264, 24);
            this.button_MatrixRank.Name = "button_MatrixRank";
            this.button_MatrixRank.Size = new System.Drawing.Size(111, 28);
            this.button_MatrixRank.TabIndex = 0;
            this.button_MatrixRank.Text = "Rank";
            this.button_MatrixRank.UseVisualStyleBackColor = false;
            this.button_MatrixRank.Click += new System.EventHandler(this.button_MatrixRank_Click);
            // 
            // button_InverseMatrix
            // 
            this.button_InverseMatrix.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_InverseMatrix.Location = new System.Drawing.Point(7, 24);
            this.button_InverseMatrix.Name = "button_InverseMatrix";
            this.button_InverseMatrix.Size = new System.Drawing.Size(111, 28);
            this.button_InverseMatrix.TabIndex = 0;
            this.button_InverseMatrix.Text = "Inverse";
            this.button_InverseMatrix.UseVisualStyleBackColor = false;
            this.button_InverseMatrix.Click += new System.EventHandler(this.button_InverseMatrix_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.button_Summ);
            this.groupBox2.Controls.Add(this.button_Subtraction);
            this.groupBox2.Controls.Add(this.button_Multiply);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 62);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "A, B Matrix operations";
            // 
            // button_Summ
            // 
            this.button_Summ.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Summ.Location = new System.Drawing.Point(137, 24);
            this.button_Summ.Name = "button_Summ";
            this.button_Summ.Size = new System.Drawing.Size(111, 28);
            this.button_Summ.TabIndex = 0;
            this.button_Summ.Text = "Summ";
            this.button_Summ.UseVisualStyleBackColor = false;
            this.button_Summ.Click += new System.EventHandler(this.button_Summ_Click);
            // 
            // button_Subtraction
            // 
            this.button_Subtraction.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Subtraction.Location = new System.Drawing.Point(264, 24);
            this.button_Subtraction.Name = "button_Subtraction";
            this.button_Subtraction.Size = new System.Drawing.Size(111, 28);
            this.button_Subtraction.TabIndex = 0;
            this.button_Subtraction.Text = "Subtraction";
            this.button_Subtraction.UseVisualStyleBackColor = false;
            this.button_Subtraction.Click += new System.EventHandler(this.button_Subtraction_Click);
            // 
            // button_Multiply
            // 
            this.button_Multiply.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Multiply.Location = new System.Drawing.Point(7, 24);
            this.button_Multiply.Name = "button_Multiply";
            this.button_Multiply.Size = new System.Drawing.Size(111, 28);
            this.button_Multiply.TabIndex = 0;
            this.button_Multiply.Text = "Multiply";
            this.button_Multiply.UseVisualStyleBackColor = false;
            this.button_Multiply.Click += new System.EventHandler(this.button_Multiply_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.button_CopyUp);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 304);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(405, 305);
            this.panel3.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightGray;
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dataGridView_MatrixB);
            this.groupBox3.Controls.Add(this.numericUpDown_ColumnsMatrixB);
            this.groupBox3.Controls.Add(this.button_MatrixBFillIn);
            this.groupBox3.Controls.Add(this.numericUpDown_RowsMatrixB);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(12, 50);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(381, 243);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Matrix B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Columns:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rows:";
            // 
            // dataGridView_MatrixB
            // 
            this.dataGridView_MatrixB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MatrixB.Location = new System.Drawing.Point(6, 55);
            this.dataGridView_MatrixB.Name = "dataGridView_MatrixB";
            this.dataGridView_MatrixB.Size = new System.Drawing.Size(369, 182);
            this.dataGridView_MatrixB.TabIndex = 0;
            // 
            // numericUpDown_ColumnsMatrixB
            // 
            this.numericUpDown_ColumnsMatrixB.Location = new System.Drawing.Point(262, 19);
            this.numericUpDown_ColumnsMatrixB.Name = "numericUpDown_ColumnsMatrixB";
            this.numericUpDown_ColumnsMatrixB.Size = new System.Drawing.Size(36, 25);
            this.numericUpDown_ColumnsMatrixB.TabIndex = 1;
            // 
            // button_MatrixBFillIn
            // 
            this.button_MatrixBFillIn.AutoSize = true;
            this.button_MatrixBFillIn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_MatrixBFillIn.Location = new System.Drawing.Point(304, 16);
            this.button_MatrixBFillIn.Name = "button_MatrixBFillIn";
            this.button_MatrixBFillIn.Size = new System.Drawing.Size(71, 29);
            this.button_MatrixBFillIn.TabIndex = 0;
            this.button_MatrixBFillIn.Text = "Fill in";
            this.button_MatrixBFillIn.UseVisualStyleBackColor = false;
            this.button_MatrixBFillIn.Click += new System.EventHandler(this.button_MatrixBFillIn_Click);
            // 
            // numericUpDown_RowsMatrixB
            // 
            this.numericUpDown_RowsMatrixB.Location = new System.Drawing.Point(144, 19);
            this.numericUpDown_RowsMatrixB.Name = "numericUpDown_RowsMatrixB";
            this.numericUpDown_RowsMatrixB.Size = new System.Drawing.Size(36, 25);
            this.numericUpDown_RowsMatrixB.TabIndex = 1;
            // 
            // button_CopyUp
            // 
            this.button_CopyUp.AutoSize = true;
            this.button_CopyUp.BackColor = System.Drawing.Color.Aqua;
            this.button_CopyUp.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_CopyUp.Location = new System.Drawing.Point(135, 16);
            this.button_CopyUp.Name = "button_CopyUp";
            this.button_CopyUp.Size = new System.Drawing.Size(112, 28);
            this.button_CopyUp.TabIndex = 0;
            this.button_CopyUp.Text = "Перенести вверх";
            this.button_CopyUp.UseVisualStyleBackColor = false;
            this.button_CopyUp.Click += new System.EventHandler(this.button_CopyUp_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.groupBox5);
            this.panel4.Controls.Add(this.button_CopyLeft);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(405, 304);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(406, 305);
            this.panel4.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.LightGray;
            this.groupBox5.Controls.Add(this.dataGridView_MatrixResult);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(51, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(343, 274);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Result ";
            // 
            // dataGridView_MatrixResult
            // 
            this.dataGridView_MatrixResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MatrixResult.Location = new System.Drawing.Point(6, 24);
            this.dataGridView_MatrixResult.Name = "dataGridView_MatrixResult";
            this.dataGridView_MatrixResult.Size = new System.Drawing.Size(331, 244);
            this.dataGridView_MatrixResult.TabIndex = 0;
            // 
            // button_CopyLeft
            // 
            this.button_CopyLeft.BackColor = System.Drawing.Color.Aqua;
            this.button_CopyLeft.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_CopyLeft.Location = new System.Drawing.Point(20, 117);
            this.button_CopyLeft.Name = "button_CopyLeft";
            this.button_CopyLeft.Size = new System.Drawing.Size(25, 106);
            this.button_CopyLeft.TabIndex = 0;
            this.button_CopyLeft.Text = "Влево ";
            this.button_CopyLeft.UseVisualStyleBackColor = false;
            this.button_CopyLeft.Click += new System.EventHandler(this.button_CopyLeft_Click);
            // 
            // MatrixCalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(811, 609);
            this.Controls.Add(this.tableLayoutPanel_MatrixForm);
            this.Name = "MatrixCalcForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Matrix Calculator";
            this.tableLayoutPanel_MatrixForm.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ColumnsMatrixA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RowsMatrixA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MatrixA)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MatrixB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ColumnsMatrixB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RowsMatrixB)).EndInit();
            this.panel4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MatrixResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_MatrixForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_ColumnsMatrixA;
        private System.Windows.Forms.NumericUpDown numericUpDown_RowsMatrixA;
        private System.Windows.Forms.Button button_MatrixAFillIn;
        private System.Windows.Forms.DataGridView dataGridView_MatrixA;
        private System.Windows.Forms.Button button_CopyDown;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_MatrixMinors;
        private System.Windows.Forms.Button button_MultiplyWithScalar;
        private System.Windows.Forms.Button button_Transpose;
        private System.Windows.Forms.Button button_MatrixDeterminant;
        private System.Windows.Forms.Button button_MatrixRank;
        private System.Windows.Forms.Button button_InverseMatrix;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_Summ;
        private System.Windows.Forms.Button button_Subtraction;
        private System.Windows.Forms.Button button_Multiply;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_MatrixB;
        private System.Windows.Forms.NumericUpDown numericUpDown_ColumnsMatrixB;
        private System.Windows.Forms.Button button_MatrixBFillIn;
        private System.Windows.Forms.NumericUpDown numericUpDown_RowsMatrixB;
        private System.Windows.Forms.Button button_CopyUp;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView_MatrixResult;
        private System.Windows.Forms.Button button_CopyLeft;
    }
}

