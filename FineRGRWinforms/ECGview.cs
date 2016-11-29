using System.Collections.Generic;
namespace FineRGRWinforms
{
    public class ECGview
    {
        public string name { get; set; }

        public double chSS_Before { get; set; }
        public double chSS_Between { get; set; }
        public double chSS_After { get; set; }

        public double symmT_Before { get; set; }
        public double symmT_Between { get; set; }
        public double symmT_After { get; set; }

        public double skoSymmT_Before { get; set; }
        public double skoSymmT_Between { get; set; }
        public double skoSymmT_After { get; set; }

        public double sDNN_Before { get; set; }
        public double sDNN_Between { get; set; }
        public double sDNN_After { get; set; }

        public double index_Before { get; set; }
        public double index_Between { get; set; }
        public double index_After { get; set; }

        public double shiftST_Before { get; set; }
        public double shiftST_Between { get; set; }
        public double shiftST_After { get; set; }

        public double sTR_Before { get; set; }
        public double sTR_Between { get; set; }
        public double sTR_After { get; set; }

        public double intervalPQ_Before { get; set; }
        public double intervalPQ_Between { get; set; }
        public double intervalPQ_After { get; set; }

        public ECGview(ECGstudent s)
        {
            name = s.name;
            chSS_Before = s.chSS[0];
            chSS_Between = s.chSS[1];
            chSS_After = s.chSS[2];

            symmT_Before = s.symmT[0];
            symmT_Between= s.symmT[1];
            symmT_After = s.symmT[2];

            skoSymmT_Before = s.skoSymmT[0];
            skoSymmT_Between = s.skoSymmT[1];
            skoSymmT_After = s.skoSymmT[2];

            sDNN_Before = s.sDNN[0];
            sDNN_Between = s.sDNN[1];
            sDNN_After = s.sDNN[2];

            index_Before = s.index[0];
            index_Between = s.index[1];
            index_After = s.index[2];

            shiftST_Before = s.shiftST[0];
            shiftST_Between = s.shiftST[1];
            shiftST_After = s.shiftST[2];

            sTR_Before = s.sTR[0];
            sTR_Between = s.sTR[1];
            sTR_After = s.sTR[2];

            intervalPQ_Before = s.intervalPQ[0];
            intervalPQ_Between = s.intervalPQ[1];
            intervalPQ_After = s.intervalPQ[2];
        }
    }

    public class ECGviewsComparer : IComparer<ECGview>
    {
        public int Compare(ECGview a, ECGview b)
        {
            return string.Compare(a.name, b.name);
        }
    }
}
