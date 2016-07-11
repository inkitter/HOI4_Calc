using System;
using System.Reflection;
using System.Data;
using System.Windows.Forms;

namespace HOI4_Calc
{
    public class Units
    {
        public int UnitID = 0;
        public string UnitName = "NullUnit";
        public double Strength = 0;
        public double Organization = 0;
        public double Soft_attack = 0;
        public double Hard_attack = 0;
        public double Defence = 0;
        public double Breakthrough = 0;
        public double Armor = 0;
        public double AP = 0;
        public double Hardness = 0;
        public double Anti_Air = 0;
        public double Reliability = 0;
        public double IC_cost = 0;
        public bool is_amror = false;

        public Units(int ID)
        {
            UnitID = ID;
        }

        internal void setVal(DataGridViewRow dataGridViewRow)
        {
            try
            {
                UnitName = dataGridViewRow.Cells[1].Value.ToString();
                Strength=double.Parse(dataGridViewRow.Cells[2].Value.ToString());
                Organization = double.Parse(dataGridViewRow.Cells[3].Value.ToString());
                Soft_attack = double.Parse(dataGridViewRow.Cells[4].Value.ToString());
                Hard_attack = double.Parse(dataGridViewRow.Cells[5].Value.ToString());
                Defence = double.Parse(dataGridViewRow.Cells[6].Value.ToString());
                Breakthrough = double.Parse(dataGridViewRow.Cells[7].Value.ToString());
                Armor = double.Parse(dataGridViewRow.Cells[8].Value.ToString());
                AP = double.Parse(dataGridViewRow.Cells[9].Value.ToString());
                Hardness = double.Parse(dataGridViewRow.Cells[10].Value.ToString());
                Anti_Air = double.Parse(dataGridViewRow.Cells[11].Value.ToString());
                Reliability = double.Parse(dataGridViewRow.Cells[12].Value.ToString());
                IC_cost = double.Parse(dataGridViewRow.Cells[13].Value.ToString());
                is_amror = bool.Parse(dataGridViewRow.Cells[14].Value.ToString());
            }
            catch { }

            //throw new NotImplementedException();
        }
    }
    
}
