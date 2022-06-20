using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace Names
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Brush defaultBackground = Brushes.Orange;

        private PlanNaam planNaam = new PlanNaam();

        public ObservableCollection<DoelGebied1> TestItems { get; private set; }

        public MainWindow()
        {


            TestItems = new ObservableCollection<DoelGebied1>();
            InitializeComponent();



            List<string> doelgroepgebieden = new List<string>(){"Hoofdhals",
                "Bovenste Lichaamshelft", "Onderste Lichaamshelft", "Extremiteiten", "Wervels"};


            foreach (var d in doelgroepgebieden)
            {
                TestItems.Add(InitDoelGebied(d));
            }
        }


        private DoelGebied1 InitDoelGebied(string groep)
        {
            DoelGebied1 doelgebied1 = new DoelGebied1();
            doelgebied1.Name = groep.ToString();
            doelgebied1.Test2Items = new ObservableCollection<DoelGebied2>();

            List<string> hoofdHals = new List<string>(){"Oor",
                    "Oog", "Neus"};
            List<string> bovensteLichaamshelft = new List<string>(){"Mamma",
                    "Long", "Axilla"};
            List<string> ondersteLichaamshelft = new List<string>(){"Prostaat",
                    "Bekken", "Blaas"};
            List<string> extremiteiten = new List<string>(){"Been",
                    "Arm", "Hand"};

            List<string> ditDoelgebied = new List<string>();
            switch (doelgebied1.Name)
            {
                case ("Hoofdhals"):
                    ditDoelgebied = hoofdHals;
                    break;
                case ("Bovenste Lichaamshelft"):
                    ditDoelgebied = bovensteLichaamshelft;
                    break;
                case ("Onderste Lichaamshelft"):
                    ditDoelgebied = ondersteLichaamshelft;
                    break;
                case ("Extremiteiten"):
                    ditDoelgebied = extremiteiten;
                    break;
                default:
                    break;
            }


            foreach (var item in ditDoelgebied)
            {
                DoelGebied2 doelgebied2 = new DoelGebied2();
                doelgebied2.Label = item.ToString();
                doelgebied1.Test2Items.Add(doelgebied2);
            }

            return doelgebied1;
        }


        private void PlanSoort_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            planNaam.Soort = Convert.ToString(rb.Content);
            AllChecked();

            colorPlanSoort.Background = CheckColor(planNaam.Soort);

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

        private void Klieren_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            switch (Convert.ToString(rb.Content))
            {
                case "Ja":
                    planNaam.Klieren = "K";
                    break;
                default:
                    planNaam.Klieren = "";
                    break;
            }
            AllChecked();
            colorKlieren.Background = CheckColor(planNaam.Klieren);
        }

        private void Stereo_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            switch (Convert.ToString(rb.Content))
            {
                case "Ja":
                    planNaam.Stereo = "S";
                    break;
                case "HD":
                    planNaam.Stereo = "HD";
                    break;
                default:
                    planNaam.Stereo = "";
                    break;
            }
            AllChecked();
            colorStereo.Background = CheckColor(planNaam.Stereo);
        }

        private void Breathold_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            switch (Convert.ToString(rb.Content))
            {
                case "Ja":
                    planNaam.BreathHold = "B";
                    break;
                default:
                    planNaam.BreathHold = "";
                    break;
            }
            AllChecked();
            colorBreathhold.Background = CheckColor(planNaam.BreathHold);
        }

        private void LR_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (Convert.ToString(rb.Content) != "n.v.t.")
                planNaam.LinksRechts = Convert.ToString(rb.Content);
            else
                planNaam.LinksRechts = "";
            AllChecked();
            colorLR.Background = CheckColor(planNaam.LinksRechts);
        }

        private void PlanNummer_Loaded(object sender, RoutedEventArgs e)
        {
            var combo = sender as ComboBox;
            combo.ItemsSource = InhoudComboBox();
            combo.SelectedIndex = 0;
        }

        private void PlanNummer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedcomboitem = sender as ComboBox;
            planNaam.PlanNummer = selectedcomboitem.SelectedItem as string;
            AllChecked();
            colorPlanNummer.Background = CheckColor(planNaam.PlanNummer);
        }
        private void MQCourse_Loaded(object sender, RoutedEventArgs e)
        {
            var combo = sender as ComboBox;
            combo.ItemsSource = InhoudComboBox();
            combo.SelectedIndex = 0;
        }

        private void MQCourse_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedcomboitem = sender as ComboBox;
            planNaam.MQCourse = selectedcomboitem.SelectedItem as string;
            AllChecked();

            colorMQCourse.Background = CheckColor(planNaam.MQCourse);

                
        }

        private void AllChecked()
        {
            choiseTextBlock.Text = planNaam.AllChecked();
        }

        //Comboxinhoud van 1 tot 9 en van A tot Z
        private List<string> InhoudComboBox()
        {
            //list 
            List<string> comboBoxRange = new List<string>();
            comboBoxRange.Add("--");

            //list met 1 tot 9 
            List<int> range = Enumerable.Range(1, 9).ToList();
            foreach (var r in range)
            {
                comboBoxRange.Add(Convert.ToString(r));
            }

            //List met range list + async tot z
            comboBoxRange.AddRange(Enumerable.Range('A', 26)
                .Select(x => (char)x + "")
                .ToList());

            return comboBoxRange;
        }

        private void Doel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (listBox2.SelectedValue != null)
                planNaam.Doel = listBox2.SelectedValue.ToString();

            AllChecked();
            colorDoel.Background = CheckColor(planNaam.Doel);
        }

        private void MainWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            myCanvas.Width = e.NewSize.Width;
            myCanvas.Height = e.NewSize.Height;

            double xChange = 1, yChange = 1;

            if (e.PreviousSize.Width != 0)
                xChange = (e.NewSize.Width / e.PreviousSize.Width);

            if (e.PreviousSize.Height != 0)
                yChange = (e.NewSize.Height / e.PreviousSize.Height);


            ScaleTransform scale = new ScaleTransform(myCanvas.LayoutTransform.Value.M11 * xChange, myCanvas.LayoutTransform.Value.M22 * yChange);
            myCanvas.LayoutTransform = scale;
            myCanvas.UpdateLayout();
        }
    }



}
