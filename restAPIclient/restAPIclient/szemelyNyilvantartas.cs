using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace restAPIclient
{
    public partial class Form1 : Form
    {
        WebClient wc = new WebClient();
        NameValueCollection dataToSend = new NameValueCollection();

        String URL = "http://localhost/felhasznalokPHPrestAPI/index.php";
        String ROUTE = "index.php";

        bool loggedIn = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBelep_Click(object sender, EventArgs e)
        {
            dataToSend["felhasznalonev"] = tbFnev.Text;
            dataToSend["jelszo"] = tbJelszo.Text;

            string valasz = Encoding.UTF8.GetString(wc.UploadValues(@"http://localhost/felhasznalokPHPrestAPI/belep.php", dataToSend));


            switch (valasz)
            {
                case "nodata": MessageBox.Show("Üres a mező", "Üres a mező", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
                case "dataerror": MessageBox.Show("Valami nem jött össze", "Valami nem jött össze", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                case "usernotfound": MessageBox.Show("A felhasználó nem található", "A felhasználó nem található", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                case "userwrongpass": MessageBox.Show("Helytelen jelszó", "Helytelen jelszó", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                case "siker": MessageBox.Show("Bejelentkezés sikeres volt!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information); loggedIn = true; break;
            }
        }

        private void btnLekerdez_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var client = new RestClient(URL);
            var request = new RestRequest(ROUTE, Method.Get);

            RestResponse<List<Felhasznalok>> response = client.Execute<List<Felhasznalok>>(request);
            foreach (Felhasznalok f in response.Data)
            {
                listBox1.Items.Add(f.Id + " " + f.vezeteknev + " " + f.keresztnev + " " + f.eletkor + " " + f.lakhely);
            }
        }

        private void btnKivalaszt_Click(object sender, EventArgs e)
        {
            string selectedUntruncked = listBox1.GetItemText(listBox1.SelectedItem);
            string selectedID = new string(selectedUntruncked.TakeWhile(c => c != ' ').ToArray());
            tb1ID.Text = selectedID;

            var client = new RestClient(URL);
            var request = new RestRequest(ROUTE, Method.Get);

            RestResponse<List<Felhasznalok>> response = client.Execute<List<Felhasznalok>>(request);
            foreach (Felhasznalok f in response.Data)
            {
                if (f.Id == selectedID)
                {
                    tb2Vezeteknev.Text = f.vezeteknev;
                    tb3Keresztnev.Text = f.keresztnev;
                    tb4Eletkor.Text = f.eletkor.ToString();
                    tb5Lakhely.Text = f.lakhely;
                }
            }
        }

        private void btnHozzaad_Click(object sender, EventArgs e)
        {
            if (loggedIn == true)
            {
                if(tb2Vezeteknev.Text == "" || tb3Keresztnev.Text == "" || tb4Eletkor.Text == "" || tb5Lakhely.Text == "")
                {
                    MessageBox.Show("Egyik mező sem lehet üres!", "Üres mezők!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else 
                {
                    var client = new RestClient(URL);
                    var request = new RestRequest(ROUTE, Method.Post);

                    request.RequestFormat = DataFormat.Json;
                    request.AddBody(new Felhasznalok
                    {
                        vezeteknev = tb2Vezeteknev.Text,
                        keresztnev = tb3Keresztnev.Text,
                        eletkor = int.Parse(tb4Eletkor.Text),
                        lakhely = tb5Lakhely.Text
                    });
                    RestResponse response = client.Execute(request);

                    btnLekerdez.PerformClick();  
                }
            }
            else { MessageBox.Show("Ehhez a funkcióhoz be kell lépned!", "Lépj be!",MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void btnModosit_Click(object sender, EventArgs e)
        {
            if (loggedIn == true)
            {
                if(tb1ID.Text != "")
                {
                    var client = new RestClient(URL);
                    String ROUTE = "index.php" + "?id=" + tb1ID.Text;
                    var request = new RestRequest(ROUTE, Method.Put);
                    request.RequestFormat = DataFormat.Json;
                    request.AddBody(new Felhasznalok
                    {
                        vezeteknev = tb2Vezeteknev.Text,
                        keresztnev = tb3Keresztnev.Text,
                        eletkor = int.Parse(tb4Eletkor.Text),
                        lakhely = tb5Lakhely.Text
                    });
                    RestResponse response = client.Execute(request);

                    btnLekerdez.PerformClick();
                }
                else { MessageBox.Show("ID mező üres!", "Üres mező!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            else { MessageBox.Show("Ehhez a funkcióhoz be kell lépned!", "Lépj be!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            if (loggedIn == true)
            {
                if (tb1ID.Text != "")
                {
                    var client = new RestClient(URL);
                    String ROUTE = "index.php/{id}";
                    var request = new RestRequest(ROUTE, Method.Delete);
                    request.AddParameter("id", tb1ID.Text);
                    RestResponse response = client.Execute(request);

                    btnLekerdez.PerformClick();
                }
                else { MessageBox.Show("ID mező üres!", "Üres mező!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            else { MessageBox.Show("Ehhez a funkcióhoz be kell lépned!", "Lépj be!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void btnUrites_Click(object sender, EventArgs e)
        {
            tb1ID.Text = string.Empty;
            tb2Vezeteknev.Text= string.Empty;
            tb3Keresztnev.Text= string.Empty;
            tb4Eletkor.Text= string.Empty;
            tb5Lakhely.Text= string.Empty;
        }
    }

    public class Felhasznalok
    {
        public String Id { get; set; }
        public string vezeteknev { get; set; }
        public string keresztnev { get; set; }
        public decimal eletkor { get; set; }
        public string lakhely { get; set; }
    }
}
