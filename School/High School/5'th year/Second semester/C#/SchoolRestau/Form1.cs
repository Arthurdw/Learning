using System;
using System.Collections;
using System.Windows.Forms;

namespace SchoolRestau
{
    public partial class Form1 : Form
    {

        private readonly string[] values = new string[] { "Spaghetti", "Biefstuk", "Frietjes", "Gehaktbroodje", "Krieken", "Witloofrolletjes", "Gebakken Zalm", "Brocolli", "Macaroni", "Noedels met kip en paprika", "Gevulde groentjes", "Hachis Parmentier", "Noors Visbordje", "rauwkost", "Spiegelei met rijst en spinazie", "Gehaktballetjes in tomatensaus en puree", "Stoofvlees met frietjes", "Lasagne", "Risotto met scampi's", "Gevulde avocado met garnalen", "Veggie/Notenburger met schorseneren", "Braadstuk met kroketjes en worteltjes", "Pastasalade met tonijn en erwtjes", "Gevulde", "caneloni's", "Moussaka", "Vitello", "Tonato met sla", "Kaasburger met gebakken patatjes en witloofsalade", "Gevulde Ravioli met kalfslapjes Worst en rode kool", "Blinde vinken met prinsesseboontjes op zijn frans", "Brochette met groentjes en couscous", "Vispannetje", "Chili", "sin", "carne", "Vol-au-vent met puree", "Kipcurry met rijst en champignons", "Kippeballetjes met rijst, paprika en ananas", "Gevulde gourgettes met feta en tomaat", "Gevulde inktvis", "Gehaktbrood met prei en patatjes", "Goulash met linguine", "Kabeljauw met peterseliepuree", "Kip met kruidenkaas", "Kalkoenlapjes met groentenmix", "Lasagne met gerookte zalm en spinazie", "Mosselen", "Noedelwok met zoetzure varkensreepjes", "Paella", "Pladijs met tartaarpuree en gestoofd witloof", "Paprika's met Griekse rijst en feta", "Ramen", "Vegetarische", "curryschotel", "Vogelnestjes met puree", "Gevulde taco's", "Omelet met spekjes, champignons en kaas" };
        private readonly Random rn = new Random();
        private ArrayList selected = new ArrayList();

        public Form1() { InitializeComponent(); }

        private void BtnGen_Click(object sender, EventArgs e)
        {
            GenRandomMenu(new Label[] { lblFood1, lblFood2, lblFood3, lblFood4 });
            GenRandomMenu(new Label[] { lblFood5, lblFood6, lblFood7, lblFood8 });
            GenRandomMenu(new Label[] { lblFood9, lblFood10, lblFood11, lblFood12 });
            GenRandomMenu(new Label[] { lblFood13, lblFood14, lblFood15, lblFood16 });
        }

        private void GenRandomMenu(Label[] lblList)
        {
            selected = new ArrayList();
            foreach (Label lbl in lblList) lbl.Text = GenMenuPiece(lbl.Text);
        }

        private string GenMenuPiece(string text)
        {
            string sel = values[rn.Next(1, values.Length) - 1];
            if (selected.Contains(sel)) return GenMenuPiece(text);
            selected.Add(sel);
            return sel;
        }
    }
}
