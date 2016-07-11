using System;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace HOI4_Calc
{
    public partial class frmMain : Form
    {
        

        public frmMain()
        {
            InitializeComponent();
        }

        int LAND_COMBAT_ORG_DICE_SIZE = 4;
        int LAND_COMBAT_STR_DICE_SIZE = 2;
        double LAND_COMBAT_ORG_DAMAGE_MODIFIER = 0.05;
        double ORG_LOSS_ONATTACK = 0.2;
        int BASE_CHANCE_TO_AVOID_HIT = 90;
        int CHANCE_TO_AVOID_HIT_AT_NO_DEF = 60;
        static int MAXLINES = 100;

        Units[] Unit = new Units[1000];
        // DataTable Unittable = new DataTable();
        static string CsvFpath = @"Unitdata.csv";
        static string CsvFpath2 = @"Unitdata.csv";
        int RealhitsDEF = 0;
        int atktimescountA = 0;
        int atktimescountB = 0;
        int atktimescount = 0; 
        int calctimes=0;
        double dmgtotal = 0;
        
        string cmp="";

        double dms = 0;
        double effA = 1;
        double effB = 1;

        public int rnd(int k)
        {
            Random r = new Random(Guid.NewGuid().GetHashCode());
            return r.Next(1,k);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < MAXLINES+1; i++)
            {
                Unit[i] = new Units(i);
            }
            loadData();
        }

        private void loadData()
        {
            txtBaseMod.Text = LAND_COMBAT_ORG_DAMAGE_MODIFIER.ToString();
            txtATKLossOrg.Text = ORG_LOSS_ONATTACK.ToString();
            txtDefAvoid.Text = BASE_CHANCE_TO_AVOID_HIT.ToString();
            txtNoDefAvoid.Text = CHANCE_TO_AVOID_HIT_AT_NO_DEF.ToString();
            txtOrgDice.Text = LAND_COMBAT_ORG_DICE_SIZE.ToString();
            txtSTRDice.Text = LAND_COMBAT_STR_DICE_SIZE.ToString();

            StreamReader csvFileReader = new StreamReader(CsvFpath2, false);
            try
            {
                
                string textLine = string.Empty;
                string[] splitLine;

                dataUnits.Rows.Clear();
                textLine = csvFileReader.ReadLine();
                do
                {
                    textLine = csvFileReader.ReadLine();
                    if (textLine != "")
                    {
                        splitLine = textLine.Split(',');
                        if (splitLine[0] != "" || splitLine[1] != "")
                        {
                            dataUnits.Rows.Add(splitLine);
                        }
                    }
                } while (csvFileReader.Peek() != -1);
                
            }
            catch
            {
                for (int i = 1; i < MAXLINES + 1; i++)
                {
                    dataUnits.Rows.Add(Unit[i].UnitID, Unit[i].UnitName, Unit[i].Strength,Unit[i].Organization, Unit[i].Soft_attack, Unit[i].Hard_attack, Unit[i].Defence, Unit[i].Breakthrough, Unit[i].Armor, Unit[i].AP, Unit[i].Hardness, Unit[i].Anti_Air, Unit[i].Reliability, Unit[i].IC_cost, Unit[i].is_amror);
                }
            }
            finally
            {

            }
            csvFileReader.Close();
            refData();

        }
        private void refData()
        {
            for (int i = 1; i < MAXLINES + 1; i++)
            {
                Unit[i].setVal(dataUnits.Rows[i - 1]);
            }
            for (int i =1; i < MAXLINES + 1; i++)
            {
                dataUnits.Rows[i-1].SetValues(Unit[i].UnitID, Unit[i].UnitName, Unit[i].Strength, Unit[i].Organization, Unit[i].Soft_attack, Unit[i].Hard_attack, Unit[i].Defence, Unit[i].Breakthrough, Unit[i].Armor, Unit[i].AP, Unit[i].Hardness, Unit[i].Anti_Air, Unit[i].Reliability, Unit[i].IC_cost, Unit[i].is_amror);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
            refData();
            
            try
            {
                StreamWriter csvFileWriter = new StreamWriter(CsvFpath, false);
                string columnHeaderText = "";

                int countColumn = dataUnits.ColumnCount - 1;

                if (countColumn >= 0)
                {
                    columnHeaderText = dataUnits.Columns[0].HeaderText;
                }

                for (int i = 1; i <= countColumn; i++)
                {
                    columnHeaderText = columnHeaderText + ',' + dataUnits.Columns[i].HeaderText;
                }


                csvFileWriter.WriteLine(columnHeaderText);

                foreach (DataGridViewRow dataRowObject in dataUnits.Rows)
                {
                    if (!dataRowObject.IsNewRow)
                    {
                        string dataFromGrid = "";

                        dataFromGrid = dataRowObject.Cells[0].Value.ToString();

                        for (int i = 1; i <= countColumn; i++)
                        {
                            dataFromGrid = dataFromGrid + ',' + dataRowObject.Cells[i].Value.ToString();
                        }
                        csvFileWriter.WriteLine(dataFromGrid);
                    }
                }
                csvFileWriter.Flush();
                csvFileWriter.Close();
            }
            catch (Exception exceptionObject)
            {
                MessageBox.Show(exceptionObject.ToString());
            }
        }

        public void Results(Units A, Units B,bool is_slow)
        {
            ORG_LOSS_ONATTACK = double.Parse(txtATKLossOrg.Text);
            LAND_COMBAT_ORG_DICE_SIZE = int.Parse(txtOrgDice.Text);
            LAND_COMBAT_STR_DICE_SIZE = int.Parse(txtSTRDice.Text);
            LAND_COMBAT_ORG_DAMAGE_MODIFIER = double.Parse(txtBaseMod.Text);
            BASE_CHANCE_TO_AVOID_HIT = int.Parse(txtDefAvoid.Text);
            CHANCE_TO_AVOID_HIT_AT_NO_DEF = int.Parse(txtNoDefAvoid.Text);

            double AtoB, BtoA;
            double Aorg = A.Organization;
            double Borg = B.Organization;
            double Astr = A.Strength;
            double Bstr = B.Strength;
            string DmgResult = "开战前(强度)组织度：A:("+ Astr + ")" + Aorg + " B:(" + Bstr + ")" + Borg + "\r\n";

            int i = 0;
            int hitB;
            int hitA;

            if (is_slow == true)
            {
                //while (Aorg > 0 && Borg > 0 && Astr > 0 && Bstr > 0)
                for (int z=0; z<10000; z++)
                {
                    i++;

                    AtoB = DmgCalc(A, B, false);
                    hitB = RealhitsDEF;
                    atktimescountA = atktimescount;
                    Borg = Borg - AtoB;
                    Bstr = Bstr - dms;
                    if (Bstr <= 0) { Bstr = 0.1; }
                    effB = Bstr / B.Strength;

                    BtoA = DmgCalc(B, A, true);
                    hitA = RealhitsDEF;
                    atktimescountB = atktimescount;
                    Aorg = Aorg - BtoA-ORG_LOSS_ONATTACK;
                    Astr = Astr - dms;
                    if (Astr <= 0) { Astr = 0.1; }
                    effA = Astr / A.Strength;
                    
                    DmgResult = DmgResult + DmgResultstring(i, Aorg, BtoA, Borg, AtoB, hitA, hitB,Astr,Bstr);
                    if (Aorg < 0 || Borg < 0 || Astr < 0 || Bstr < 0) { break; }
                } 
                
                txtOutput.Text = DmgResult;
                DmgCompare(i, A.Organization, Aorg, B.Organization, Borg);
            }
            
        }
        public string DmgResultstring(int turn,double Aorg,double BtoA,double Borg,double AtoB,int hitA,int hitB,double Astr,double Bstr)
        {
            string DmgResult;
            DmgResult= turn + "： A:("+ (effA*100).ToString("f0")+"%)" + Aorg.ToString("f2") + " (-" + BtoA.ToString("f2") + "," + hitA+"/"+atktimescountB + "hits）|" + "B:(" + (effB*100).ToString("f0") + "%)" + Borg.ToString("f2") + " (-" + AtoB.ToString("f2") + "," + hitB + "/" + atktimescountA + "hits)\r\n";
            return DmgResult;
        }
        public void DmgCompare(int turns,double Aorg,double Alast,double Borg,double Blast)
        {
            calctimes++;
            dmgtotal = dmgtotal + ((Borg - Blast) / (Aorg - Alast));
            string lscmp = "共"+turns+"回合，"+"伤害比A:B= " + ((Borg-Blast) / (Aorg-Alast)).ToString("f2") + "\r\n";
            cmp = cmp + lscmp;
            txtResult.Text = cmp;
            txtResult.AppendText("平均比："+(dmgtotal / calctimes).ToString("f2")+" "+atktimescount);
            txtOutput.AppendText(lscmp);
        }

        private double DmgCalc(Units Ac,Units Bc,bool Bis_attacker)
        {
            double dmg=0;
            dms = 0;
            RealhitsDEF = 0;
            atktimescount = 0;
            double sAttack = Ac.Soft_attack * (1 - (Bc.Hardness / 100))*effA;
            double hAttack = Ac.Hard_attack * Bc.Hardness / 100*effA;
            
            double Attack = sAttack + hAttack;
            double DEF;

            if (Bis_attacker == true)
            {
                DEF = Bc.Breakthrough*effB;
            }
            else
            {
                DEF = Bc.Defence*effB;
            }

            if (Attack > DEF)
            {
                for (int i = 1; i <= DEF; i++)
                {
                    if (rnd(100) > BASE_CHANCE_TO_AVOID_HIT)
                    {
                        dmg=dmg+ rnd(LAND_COMBAT_ORG_DICE_SIZE);
                        dms = dms + rnd(LAND_COMBAT_STR_DICE_SIZE);
                        RealhitsDEF++;
                    }
                    atktimescount++;
                }
                for (int i=1;i<=(Attack-DEF);i++)
                {
                    if (rnd(100) > CHANCE_TO_AVOID_HIT_AT_NO_DEF)
                    {
                        dmg = dmg + rnd(LAND_COMBAT_ORG_DICE_SIZE);
                        dms = dms + rnd(LAND_COMBAT_STR_DICE_SIZE);
                        RealhitsDEF++;
                    }
                    atktimescount++;
                }
            }
            else
            {
                for (int i = 1; i <= Attack; i++)
                {
                    if (rnd(100) > BASE_CHANCE_TO_AVOID_HIT)
                    {
                        dmg = dmg + rnd(LAND_COMBAT_ORG_DICE_SIZE);
                        dms = dms + rnd(LAND_COMBAT_STR_DICE_SIZE);
                        RealhitsDEF++;
                    }
                    atktimescount++;
                }
            }

            if (Ac.is_amror == true && Bc.AP>Ac.Armor)
            {
                dmg = dmg * sAttack / Attack * 3.5/2.5 + dmg * hAttack / Attack;
            }
            dmg = dmg * LAND_COMBAT_ORG_DAMAGE_MODIFIER;
            dms = dms * LAND_COMBAT_ORG_DAMAGE_MODIFIER;
            if (Ac.AP<Bc.Armor)
            {
                dmg = dmg / 2;
                dms = dms / 2;
            }
            return dmg;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int iA, iB;
            iA = int.Parse(txtA.Text);
            iB = int.Parse(txtB.Text);
            Results(Unit[iA], Unit[iB],false);
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnCalctrue_Click(object sender, EventArgs e)
        {
            int iA, iB;
            iA = int.Parse(txtA.Text);
            iB = int.Parse(txtB.Text);
            Results(Unit[iA], Unit[iB],true);
        }

        private void btnClearResult_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            RealhitsDEF = 0;
            atktimescountA = 0;
            atktimescountB = 0;
            atktimescount = 0;
            calctimes = 0;
            dmgtotal = 0;
            cmp = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        //private double DmgCalcquick(Units Ac, Units Bc, bool Bis_attacker)
        //{
        //    double dmg = 0;

        //    double sAttack = Ac.Soft_attack * (1 - (Bc.Hardness / 100));
        //    double hAttack = Ac.Hard_attack * Bc.Hardness / 100;

        //    double Attack = sAttack + hAttack;
        //    double DEF = 0;

        //    if (Bis_attacker == true)
        //    {
        //        DEF = Bc.Breakthrough;
        //    }
        //    else
        //    {
        //        DEF = Bc.Defence;
        //    }

        //    if (Attack > DEF)
        //    {
        //        dmg = DEF * (1 - (BASE_CHANCE_TO_AVOID_HIT / 100)) + (Attack - DEF) * (1 - (CHANCE_TO_AVOID_HIT_AT_NO_DEF / 100));
        //    }
        //    else
        //    {
        //        dmg = Attack * (1 - (BASE_CHANCE_TO_AVOID_HIT / 100));
        //    }

        //    if (Ac.is_amror == true && Bc.AP > Ac.Armor)
        //    {
        //        dmg = dmg * sAttack / Attack * rnd(LAND_COMBAT_ORG_ARMOR_ON_SOFT_DICE_SIZE) + dmg * hAttack / Attack * rnd(LAND_COMBAT_ORG_DICE_SIZE);
        //    }
        //    else
        //    {
        //        dmg = dmg * rnd(LAND_COMBAT_ORG_DICE_SIZE);
        //    }
        //    dmg = dmg * LAND_COMBAT_ORG_DAMAGE_MODIFIER;
        //    return dmg;
        //}
        //else
        //{
        //    do
        //    {
        //        i++;

        //        AtoB = DmgCalcquick(A, B, false);
        //        Borg = Borg - AtoB;
        //        hitB = 1;

        //        BtoA = DmgCalcquick(B, A, true);
        //        Aorg = Aorg - BtoA;
        //        hitA = 1;

        //        DmgResult = DmgResult + DmgResultstring(i, Aorg, BtoA, Borg, AtoB, hitA, hitB, 2, 2);
        //    } while (Aorg > 0 && Borg > 0);

        //    txtOutput.Text = DmgResult;
        //    DmgCompare(i, A.Organization, Aorg, B.Organization, Borg);
        //}
    }
}
