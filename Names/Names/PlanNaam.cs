using System.Windows.Media;

namespace Names
{
    public class PlanNaam
    {
        private string mQCourse;
        private string soort;
        private string planNummer;
        private string doel;
        private string klieren;
        private string stereo;
        private string breathHold;
        private string linksRechts;
        Brush defaultBackground = Brushes.Orange;

        public string MQCourse { get => mQCourse; set => mQCourse = value; }
        public string Soort { get => soort; set => soort = value; }
        public string PlanNummer { get => planNummer; set => planNummer = value; }
        public string Doel { get => doel; set => doel = value; }
        public string Klieren { get => klieren; set => klieren = value; }
        public string Stereo { get => stereo; set => stereo = value; }
        public string BreathHold { get => breathHold; set => breathHold = value; }
        public string LinksRechts { get => linksRechts; set => linksRechts = value; }


        public string AllChecked()
        {
            return mQCourse + soort + planNummer + " " + doel + klieren + stereo +
                breathHold + linksRechts;

        }

        private Brush CheckColor(string check)
        {
            Brush setColor;

            //Changes colorstatus
            if (check == null || check == "--")
                setColor = defaultBackground;
            else
                setColor = Brushes.Green;

            return setColor;
        }
    }



}
