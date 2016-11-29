namespace FineRGRWinforms
{
    public class ECGstudent
    {
        public string name { get; set; }
        public double[] chSS { get; set; }
        public double[] symmT { get; set; }
        public double[] skoSymmT { get; set; }
        public double[] sDNN { get; set; }
        public double[] index { get; set; }
        public double[] shiftST { get; set; }
        public double[] sTR { get; set; }
        public double[] intervalPQ { get; set; }

        public ECGstudent()
        {
            chSS = new double[3];
            symmT = new double[3];
            skoSymmT = new double[3];
            sDNN = new double[3];
            index = new double[3];
            shiftST = new double[3];
            sTR = new double[3];
            intervalPQ = new double[3];
        }
    }
}
