using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.OleDb;


namespace FineRGRWinforms
{
    class DAL
    {
        static public List<ECGstudent> MakeList()
        {
            List<ECGstudent> studlist = new List<ECGstudent>();
            string query = "SELECT * FROM dbo.EXP_ATTRIBUTES";
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ECGfile.mdb");

            ECGfileDataSet students = new ECGfileDataSet();
            adapter.Fill(students, "EXP_ATTRIBUTES");

            var attributes = students.Tables["EXP_ATTRIBUTES"];

            IEnumerable<DataRow> q = from s in attributes.AsEnumerable()
                                     select s;

            List<string> usedstudents = new List<string>();
            string currentstudent = "";
            foreach (var s in q)
            {
                if (usedstudents.Contains(Convert.ToString(s["PATNAME"])) == false)
                {
                    currentstudent = Convert.ToString(s["PATNAME"]);
                }
                else
                {
                    currentstudent = "";
                    continue;
                }
                if (Convert.ToString(s["PATNAME"]) != "Міхо Іван Іванович" && Convert.ToString(s["PATNAME"]) != "Ковба Владислав Олексійович")
                {
                    double[] atr1 = new double[3];
                    double[] atr2 = new double[3];
                    double[] atr3 = new double[3];
                    double[] atr4 = new double[3];
                    double[] atr5 = new double[3];
                    double[] atr6 = new double[3];
                    double[] atr7 = new double[3];
                    double[] atr8 = new double[3];
                    foreach (var student in q)
                    {
                        if (Convert.ToString(student["PATNAME"]) == currentstudent)
                        {
                            int i;
                            if (Convert.ToInt32(student["STRESS"]) == 0) i = 0;
                            else if (Convert.ToInt32(student["STRESS"]) == 1) i = 1;
                            else i = 2;
                            atr1[i] = Convert.ToDouble(student["attr1"]);
                            atr2[i] = Convert.ToDouble(student["attr3"]);
                            atr3[i] = Convert.ToDouble(student["attr4"]);
                            atr4[i] = Convert.ToDouble(student["attr9"]);
                            atr5[i] = Convert.ToDouble(student["attr17"]);
                            atr6[i] = Convert.ToDouble(student["attr21"]);
                            atr7[i] = Convert.ToDouble(student["attr37"]);
                            atr8[i] = Convert.ToDouble(student["attr32"]);
                        }
                    }
                    
                    var stud = new ECGstudent()
                    {
                        name = Convert.ToString(s["PATNAME"]),
                        chSS = atr1,
                        symmT = atr2,
                        skoSymmT = atr3,
                        sDNN = atr4,
                        index = atr5,
                        shiftST = atr6,
                        sTR = atr7,
                        intervalPQ = atr8
                    };
                    usedstudents.Add(stud.name);
                    studlist.Add(stud);
                }
            }
            return studlist;
        }
    }
}
