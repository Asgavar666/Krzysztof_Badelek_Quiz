namespace Krzysztof_Badelek_Quiz
{
    public partial class Form1 : Form
    {
        public List<string> Kategorien = new List<string>();
        public Form1()
        {
            InitializeComponent();

            Kategorien.Add("Land");
            Kategorien.Add("Hauptstadt");
            Kategorien.Add("Flagge");

            foreach(string item in Kategorien)
            {
                CbFragen.Items.Add(item);
            }
        }
       
        

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void CbFragen_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Wenn eine Option ausgewählt, blende diese Option in Antworten aus
           if(CbFragen.SelectedIndex != -1)
            {
                CbAntworten.Items.Clear();
                foreach (string item in Kategorien)
                {
                    if(item != CbFragen.Text)
                        CbAntworten.Items.Add(item);
                }
            }

        }

        private void BtnRundeStarten_Click(object sender, EventArgs e)
        {
            if(CbFragen.SelectedIndex != -1 && CbAntworten.SelectedIndex != -1)
            {

                List<string> list = Datenbank.GetFragen();
               
                
            }
        }
    }
}