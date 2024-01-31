using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Krzysztof_Badelek_Quiz
{
    public partial class Form1 : Form
    {
        public List<string> Kategorien = new List<string>();
        public List<string> listRandomFragen = new List<string>();
        public string richtigeAntwort = "";
        public List<string> falscheAntworten = new List<string>();
        public List<string> listRandomAntworten = new List<string>();
        public Form1()
        {
            InitializeComponent();

            Kategorien.Add("Land");
            Kategorien.Add("Hauptstadt");
            Kategorien.Add("Flagge");

            foreach (string item in Kategorien)
            {
                CbFragen.Items.Add(item);
            }
            RadioButton[] radioButtons = new RadioButton[4] { RbAntwort1, RbAntwort2, RbAntwort3, RbAntwort4 };
            AssignImagesToRadioButtons(radioButtons);
        }


        public void AssignImagesToRadioButtons(RadioButton[] radioButtons)
        {
            foreach (RadioButton rb in radioButtons)
            {
                if (rb.Text.Length == 2)
                {
                    string imagePath = Path.Combine("Resources/16", rb.Text + ".jpg");
                    if (File.Exists(imagePath))
                    {
                        rb.Image = Image.FromFile(imagePath);
                    }
                }
            }
        }
        public void AssignStringsToRadioButtons(string correctAnswer, List<string> wrongAnswers, params RadioButton[] radioButtons)
        {
            listRandomAntworten = falscheAntworten;
            listRandomAntworten.Insert(0, richtigeAntwort);

            // Shuffle the list of answers
            var rng = new Random();
            int n = listRandomAntworten.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                string temp = listRandomAntworten[k];
                listRandomAntworten[k] = listRandomAntworten[n];
                listRandomAntworten[n] = temp;
            }

            // Assign each string to a RadioButton
            for (int i = 0; i < radioButtons.Length; i++)
            {
                radioButtons[i].Text = listRandomAntworten[i];

            }
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void CbFragen_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Wenn eine Option ausgewählt, blende diese Option in Antworten aus
            if (CbFragen.SelectedIndex != -1)
            {
                CbAntworten.Items.Clear();
                foreach (string item in Kategorien)
                {
                    if (item != CbFragen.Text)
                        CbAntworten.Items.Add(item);
                }
            }

        }

        private void BtnRundeStarten_Click(object sender, EventArgs e)
        {
            Datenbank datenbank = new Datenbank();

            if (CbFragen.SelectedIndex != -1 && CbAntworten.SelectedIndex != -1)
            {

                string frage = CbFragen.Text.ToUpper();
                // string antwort = CbAntworten.Text.ToUpper();
                listRandomFragen = datenbank.GetRandomFragen(frage);
                // listRandomAntworten = datenbank.GetRandomAntwort(antwort, frage);
            }
        }


        private void BtnNeueFrage_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Datenbank datenbank = new Datenbank();
            if (listRandomFragen.Count > 0)
            {
                int index = random.Next(listRandomFragen.Count);
                string randomFrage = listRandomFragen[index];


                LbFrage.Text = randomFrage;

                listRandomFragen.RemoveAt(index);
            }

            else
            {
                LbFrage.Text = "Diese Runde ist beendet";
            }


        }

        private void LbFrage_TextChanged(object sender, EventArgs e)
        {
            Datenbank datenbank = new Datenbank();
            string frage = CbFragen.Text.ToUpper();
            string antwort = CbAntworten.Text.ToUpper();
            string frageValue = LbFrage.Text;
            richtigeAntwort = datenbank.GetRichtigeAntwort(frage, antwort, frageValue);
            falscheAntworten = datenbank.GetRandomAntwort(frage, antwort, frageValue);
            string correctAnswer = richtigeAntwort;

            var wrongAnswers = falscheAntworten;
            AssignStringsToRadioButtons(correctAnswer, wrongAnswers, RbAntwort1, RbAntwort2, RbAntwort3, RbAntwort4);

            if (LbFrage.Text.Length == 2)
            {
                string imageName = LbFrage.Text;
                string completeImageName = $"{imageName}.png";


                

                Image myImage = null;

                string resourceName = "Krzysztof_Badelek_Quiz.Resources." + completeImageName;

                using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
                {
                    if (stream != null)
                    {
                        myImage = Image.FromStream(stream);
                        PbFlagge.Image = myImage;
                        LbFrage.Text = "";
                        
                    }
                }



            }
        }

        
        private void RbAntwort1_TextChanged(object sender, EventArgs e)
        {
            if (RbAntwort1.Text.Length == 2)
            {
                string imageName = RbAntwort1.Text;
                string completeImageName = $"{imageName}.png";


                // string resourceName = $"{completeImageName}";

                Image myImage = null;

                string resourceName = "Krzysztof_Badelek_Quiz.Resources." + completeImageName;

                using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
                {
                    if (stream != null)
                    {
                        myImage = Image.FromStream(stream);
                        RbAntwort1.Image = myImage;
                        RbAntwort1.Text = "";
                    }
                }



            }
        }

        private void RbAntwort2_TextChanged(object sender, EventArgs e)
        {
            if (RbAntwort2.Text.Length == 2)
            {
                string imageName = RbAntwort2.Text;
                string completeImageName = $"{imageName}.png";


                // string resourceName = $"{completeImageName}";

                Image myImage = null;

                string resourceName = "Krzysztof_Badelek_Quiz.Resources." + completeImageName;

                using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
                {
                    if (stream != null)
                    {
                        myImage = Image.FromStream(stream);
                        RbAntwort2.Image = myImage;
                        RbAntwort2.Text = "";
                    }
                }



            }
        }

        private void RbAntwort3_TextChanged(object sender, EventArgs e)
        {
            if (RbAntwort3.Text.Length == 2)
            {
                string imageName = RbAntwort3.Text;
                string completeImageName = $"{imageName}.png";


                // string resourceName = $"{completeImageName}";

                Image myImage = null;

                string resourceName = "Krzysztof_Badelek_Quiz.Resources." + completeImageName;

                using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
                {
                    if (stream != null)
                    {
                        myImage = Image.FromStream(stream);
                        RbAntwort3.Image = myImage;
                        RbAntwort3.Text = "";
                    }
                }



            }
        }

        private void RbAntwort4_TextChanged(object sender, EventArgs e)
        {
            if (RbAntwort4.Text.Length == 2)
            {
                string imageName = RbAntwort4.Text;
                string completeImageName = $"{imageName}.png";


                // string resourceName = $"{completeImageName}";

                Image myImage = null;

                string resourceName = "Krzysztof_Badelek_Quiz.Resources." + completeImageName;

                using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
                {
                    if (stream != null)
                    {
                        myImage = Image.FromStream(stream);
                        RbAntwort4.Image = myImage;
                        RbAntwort4.Text = "";
                    }
                }



            }
        }
    }
}