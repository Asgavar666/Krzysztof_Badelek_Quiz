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
        }
    }
}