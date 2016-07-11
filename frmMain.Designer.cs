namespace HOI4_Calc
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.dataUnits = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSTR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoftatk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHardatk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDefence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArmor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHardness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReliability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colisArmor = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCalctrue = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnClearResult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDefAvoid = new System.Windows.Forms.TextBox();
            this.txtNoDefAvoid = new System.Windows.Forms.TextBox();
            this.txtATKLossOrg = new System.Windows.Forms.TextBox();
            this.txtOrgDice = new System.Windows.Forms.TextBox();
            this.txtSTRDice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBaseMod = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataUnits)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(660, 1);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(470, 590);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.WordWrap = false;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(232, 572);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(48, 21);
            this.txtA.TabIndex = 1;
            this.txtA.Text = "1";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(286, 572);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(50, 21);
            this.txtB.TabIndex = 2;
            this.txtB.Text = "1";
            // 
            // dataUnits
            // 
            this.dataUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUnits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.colName,
            this.colSTR,
            this.colOrg,
            this.colSoftatk,
            this.colHardatk,
            this.colDefence,
            this.colBKT,
            this.colArmor,
            this.colAP,
            this.colHardness,
            this.colAA,
            this.colReliability,
            this.colIC,
            this.colisArmor});
            this.dataUnits.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataUnits.Location = new System.Drawing.Point(4, 1);
            this.dataUnits.Name = "dataUnits";
            this.dataUnits.RowTemplate.Height = 23;
            this.dataUnits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataUnits.Size = new System.Drawing.Size(652, 549);
            this.dataUnits.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.HeaderText = "ID";
            this.ID.MaxInputLength = 4;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Width = 35;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.Width = 120;
            // 
            // colSTR
            // 
            this.colSTR.HeaderText = "STR";
            this.colSTR.Name = "colSTR";
            this.colSTR.Width = 35;
            // 
            // colOrg
            // 
            this.colOrg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colOrg.HeaderText = "Org";
            this.colOrg.Name = "colOrg";
            this.colOrg.Width = 35;
            // 
            // colSoftatk
            // 
            this.colSoftatk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSoftatk.HeaderText = "Soft Atk";
            this.colSoftatk.Name = "colSoftatk";
            this.colSoftatk.Width = 35;
            // 
            // colHardatk
            // 
            this.colHardatk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colHardatk.HeaderText = "Hard Atk";
            this.colHardatk.Name = "colHardatk";
            this.colHardatk.Width = 35;
            // 
            // colDefence
            // 
            this.colDefence.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDefence.HeaderText = "Def";
            this.colDefence.Name = "colDefence";
            this.colDefence.Width = 35;
            // 
            // colBKT
            // 
            this.colBKT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colBKT.HeaderText = "BrkT";
            this.colBKT.Name = "colBKT";
            this.colBKT.Width = 35;
            // 
            // colArmor
            // 
            this.colArmor.HeaderText = "Armor";
            this.colArmor.Name = "colArmor";
            this.colArmor.Width = 35;
            // 
            // colAP
            // 
            this.colAP.HeaderText = "AP";
            this.colAP.Name = "colAP";
            this.colAP.Width = 35;
            // 
            // colHardness
            // 
            this.colHardness.HeaderText = "Hardness";
            this.colHardness.Name = "colHardness";
            this.colHardness.Width = 35;
            // 
            // colAA
            // 
            this.colAA.HeaderText = "AA";
            this.colAA.Name = "colAA";
            this.colAA.Width = 35;
            // 
            // colReliability
            // 
            this.colReliability.HeaderText = "Reliability";
            this.colReliability.Name = "colReliability";
            this.colReliability.Width = 35;
            // 
            // colIC
            // 
            this.colIC.HeaderText = "IC";
            this.colIC.Name = "colIC";
            this.colIC.Width = 35;
            // 
            // colisArmor
            // 
            this.colisArmor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colisArmor.HeaderText = "Is Armor";
            this.colisArmor.Name = "colisArmor";
            this.colisArmor.Width = 35;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(4, 556);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(95, 26);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Apply";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCalctrue
            // 
            this.btnCalctrue.Location = new System.Drawing.Point(502, 567);
            this.btnCalctrue.Name = "btnCalctrue";
            this.btnCalctrue.Size = new System.Drawing.Size(126, 28);
            this.btnCalctrue.TabIndex = 7;
            this.btnCalctrue.Text = "Calc";
            this.btnCalctrue.UseVisualStyleBackColor = true;
            this.btnCalctrue.Click += new System.EventHandler(this.btnCalctrue_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(1136, 1);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(224, 306);
            this.txtResult.TabIndex = 8;
            // 
            // btnClearResult
            // 
            this.btnClearResult.Location = new System.Drawing.Point(1220, 313);
            this.btnClearResult.Name = "btnClearResult";
            this.btnClearResult.Size = new System.Drawing.Size(64, 28);
            this.btnClearResult.TabIndex = 9;
            this.btnClearResult.Text = "Clear";
            this.btnClearResult.UseVisualStyleBackColor = true;
            this.btnClearResult.Click += new System.EventHandler(this.btnClearResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 557);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "Atk Side";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 557);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "Def Side";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1138, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "攻方组织度衰减";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1138, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "陆战组织度骰子";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1138, 479);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "陆战兵力骰子";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1138, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "防御命中率";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1138, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "破防命中率";
            // 
            // txtDefAvoid
            // 
            this.txtDefAvoid.Location = new System.Drawing.Point(1219, 362);
            this.txtDefAvoid.Name = "txtDefAvoid";
            this.txtDefAvoid.Size = new System.Drawing.Size(65, 21);
            this.txtDefAvoid.TabIndex = 18;
            // 
            // txtNoDefAvoid
            // 
            this.txtNoDefAvoid.Location = new System.Drawing.Point(1220, 392);
            this.txtNoDefAvoid.Name = "txtNoDefAvoid";
            this.txtNoDefAvoid.Size = new System.Drawing.Size(65, 21);
            this.txtNoDefAvoid.TabIndex = 19;
            // 
            // txtATKLossOrg
            // 
            this.txtATKLossOrg.Location = new System.Drawing.Point(1233, 419);
            this.txtATKLossOrg.Name = "txtATKLossOrg";
            this.txtATKLossOrg.Size = new System.Drawing.Size(65, 21);
            this.txtATKLossOrg.TabIndex = 20;
            // 
            // txtOrgDice
            // 
            this.txtOrgDice.Location = new System.Drawing.Point(1233, 446);
            this.txtOrgDice.Name = "txtOrgDice";
            this.txtOrgDice.Size = new System.Drawing.Size(65, 21);
            this.txtOrgDice.TabIndex = 21;
            // 
            // txtSTRDice
            // 
            this.txtSTRDice.Location = new System.Drawing.Point(1233, 476);
            this.txtSTRDice.Name = "txtSTRDice";
            this.txtSTRDice.Size = new System.Drawing.Size(65, 21);
            this.txtSTRDice.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1138, 508);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 23;
            this.label8.Text = "陆战基本系数";
            // 
            // txtBaseMod
            // 
            this.txtBaseMod.Location = new System.Drawing.Point(1233, 503);
            this.txtBaseMod.Name = "txtBaseMod";
            this.txtBaseMod.Size = new System.Drawing.Size(65, 21);
            this.txtBaseMod.TabIndex = 24;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 605);
            this.Controls.Add(this.txtBaseMod);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSTRDice);
            this.Controls.Add(this.txtOrgDice);
            this.Controls.Add(this.txtATKLossOrg);
            this.Controls.Add(this.txtNoDefAvoid);
            this.Controls.Add(this.txtDefAvoid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClearResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnCalctrue);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataUnits);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtOutput);
            this.Name = "frmMain";
            this.Text = "HOI4Calc";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataUnits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.DataGridView dataUnits;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCalctrue;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnClearResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTR;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoftatk;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHardatk;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDefence;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArmor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHardness;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReliability;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIC;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colisArmor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDefAvoid;
        private System.Windows.Forms.TextBox txtNoDefAvoid;
        private System.Windows.Forms.TextBox txtATKLossOrg;
        private System.Windows.Forms.TextBox txtOrgDice;
        private System.Windows.Forms.TextBox txtSTRDice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBaseMod;
    }
}

