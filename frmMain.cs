using System;
using System.IO;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace PES5_WE9_LE_BannerRelinker
{
    public partial class frmMain : Form
    {
        string TeamDBFilePath = "";
        List<string> TeamList = new List<string>
        {
            "Austria",
            "Belgium",
            "Bulgaria",
            "Croatia",
            "Czech",
            "Denmark",
            "England",
            "Finland",
            "France",
            "Germany",
            "Greece",
            "Hungary",
            "Ireland",
            "Italy",
            "Latvia",
            "Netherlands",
            "Northern Ireland",
            "Norway",
            "Poland",
            "Portugal",
            "Romania",
            "Russia",
            "Scotland",
            "Serbia and Montenegro",
            "Slovakia",
            "Slovenia",
            "Spain",
            "Sweden",
            "Switzerland",
            "Turkey",
            "Ukraine",
            "Wales",
            "Cameroon",
            "Cote d'Ivoire",
            "Morocco",
            "Nigeria",
            "Senegal",
            "South Africa",
            "Tunisia",
            "Costa Rica",
            "Mexico",
            "United States",
            "Argentina",
            "Brazil",
            "Chile",
            "Colombia",
            "Ecuador",
            "Paraguay",
            "Peru",
            "Uruguay",
            "Venezuela",
            "China",
            "Iran",
            "Japan",
            "Saudi Arabia",
            "South Korea",
            "Australia",
            "Classic Argentina",
            "Classic Brazil",
            "Classic England",
            "Classic France",
            "Classic Germany",
            "Classic Italy",
            "Classic Netherlands",
            "Arsenal",
            "West Midlands Village",
            "West Midlands City",
            "Lancashire",
            "Middlebrook",
            "South East London Reds",
            "Chelsea",
            "Merseyside Blue",
            "West London White",
            "Merseyside Red",
            "Man Blue",
            "Man Red",
            "Teesside",
            "Tyneside",
            "Pompy",
            "Wearside",
            "North East London",
            "West Midlands Stripes",
            "East London",
            "Lancashire Athletic",
            "Corse Sud",
            "Azur",
            "Bourgogne",
            "Aquitaine",
            "Sarthe",
            "Pas de Calais",
            "Rhone",
            "Moselle",
            "Meurthe-et-Moselle",
            "Loire Océan",
            "Alpes Maritimes",
            "Bouches du Rhone",
            "Ile De France",
            "Nord",
            "Bretagne",
            "Somesterrine",
            "Franche-Comté",
            "Alsace",
            "Garonne",
            "Aube",
            "Domstadt",
            "Alm",
            "Rhein",
            "Isar",
            "Westfalen",
            "Fohlen",
            "Stahlstadt",
            "Rhein-Main",
            "Hanseaten",
            "Niedersachsen",
            "Hauptstadt",
            "Pfalz",
            "Karneval",
            "Franken",
            "Ruhr",
            "Neckar",
            "Autostadt",
            "Weser",
            "A.C. Milan",
            "A.S. Roma",
            "Ascoli",
            "Teste Di Moro",
            "Chievo Verona",
            "Empoli",
            "Fiorentina",
            "Inter",
            "Juventus",
            "Lazio",
            "Lecce",
            "Livorno",
            "Messina",
            "Palermo",
            "Parma",
            "Reggina",
            "Sampdoria",
            "Siena",
            "Treviso",
            "Udinese",
            "ADO Den Haag",
            "Ajax",
            "AZ",
            "FC Groningen",
            "FC Twente",
            "FC Utrecht",
            "Feyenoord",
            "Heracles Almelo",
            "NAC Breda",
            "NEC Nijmegen",
            "PSV Eindhoven",
            "RBC Roosendaal",
            "RKC Waalwijk",
            "Roda JC",
            "SC Heerenveen",
            "Sparta Rotterdam",
            "Vitesse",
            "Willem II",
            "Alaves",
            "At. Osasuna",
            "Athletic Club",
            "C. Atlético Madrid",
            "Cadiz",
            "Celta",
            "F.C. Barcelona",
            "Getafe C.F.",
            "Málaga C.F.",
            "R. Betis",
            "R. Madrid",
            "R. Racing C.",
            "R. Sociedad",
            "R. Zaragoza",
            "R.C. Deportivo",
            "R.C.D. Espanyol",
            "R.C.D. Mallorca",
            "Sevilla F.C.",
            "Valencia C.F.",
            "Villarreal C.F.",
            "Lisbonera",
            "FC Bosphorus",
            "Celtic",
            "Djurgardens IF",
            "Dynamo Kiev",
            "FC Belgium",
            "FC Kopenhagen",
            "FC Porto",
            "Constanti",
            "Galatasaray",
            "Russia Rail FC",
            "Peloponnisos",
            "Athenakos FC",
            "Rangers",
            "Rosenborg BK",
            "Bruxelles",
            "Sheffcor Domake",
            "AC Czech",
            "Esportiva",
            "Caopolo",
            "PES United",
            "WE United",
            "World All-Stars",
            "European All-Stars",
            "North American All-Stars",
            "South American All-Stars",
            "Asia Oceanian All-Stars",
            "African All-Stars",
            "Master League Youth Squad",
            "Master League Veterans",
            "Galacticos",
            "The Jaguars",
            "The Oxen",
            "The Goliaths",
            "Little Rascals",
            "The Lefties",
            "Gli Pelati",
            "Goalies",
            "ML United",
            "Canuch",
            "Rawore"
        };
        List<string> Stadiums = new List<string> 
        {
            "Club House", 
            "San Siro", 
            "Catalonia Stadium", 
            "Highbury", 
            "Orange Arena", 
            "Isar Stadion", 
            "Monaco Stadium", 
            "Trad Brick Stadium", 
            "Nakhon Ratchasima", 
            "Estadio Gran Chaco", 
            "Cuito Cuanavale", 
            "Amerigo Atlantis", 
            "Delle Alpi", 
            "Stadio Olimpico", 
            "Stadio Ennio Tardini", 
            "Stamford Bridge", 
            "Red Cauldron", 
            "Lutecia Park", 
            "Massilia Stadium", 
            "Borussia Stadion", 
            "Stockholm Arena", 
            "Magpie Park", 
            "Rotterdam Stadion", 
            "Blautraum Stadion", 
            "Diamond Stadium", 
            "Hauptstadtstadion", 
            "Finis Terrae", 
            "Estadio Palo", 
            "Kanji Dome", 
            "Dietro Monte Stadium", 
            "Porto Folio", 
            "Queens land Park", 
            "Haze Hills", 
            "Occhio Del Mar", 
            "Ayase-Nakano Stadium"
        };
        List<Team> teams = new List<Team> { };
        const int SUPP_COL_FILE_INDEX = 1;
        const int STAD_FILE_INDEX = 2;
        const int BANNER_FILE_INDEX = 4;
        PESFolder pesFolder;
        public frmMain()
        {
            InitializeComponent();
            ReadingCSVFile();
        }
        private string IntToBinId(ushort binId)
        {
            switch(binId)
            {
                case 0:
                    return "unknow_11412.bin";
                case 1:
                    return "unknow_11413.bin";
                case 2:
                    return "unknow_11414.bin";
                case 3:
                    return "unknow_11415.bin";
                case 256:
                    return "unknow_11404.bin";
                case 257:
                    return "unknow_11405.bin";
                case 258:
                    return "unknow_11406.bin";
                case 259:
                    return "unknow_11407.bin";
                case 260:
                    return "unknow_11408.bin";
                case 512:
                    return "unknow_11409.bin";
                case 513:
                    return "unknow_11410.bin";
                case 514:
                    return "unknow_11411.bin";
                default:
                    return "unknow_?????.bin";
            }
        }
        private ushort BinIdToInt(string binName)
        {
            switch (binName)
            {
                case "unknow_11412.bin":
                    return 0;
                case "unknow_11413.bin":
                    return 1;
                case "unknow_11414.bin":
                    return 2;
                case "unknow_11415.bin":
                    return 3;
                case "unknow_11404.bin":
                    return 256;
                case "unknow_11405.bin":
                    return 257;
                case "unknow_11406.bin":
                    return 258;
                case "unknow_11407.bin":
                    return 259;
                case "unknow_11408.bin":
                    return 260;
                case "unknow_11409.bin":
                    return 512;
                case "unknow_11410.bin":
                    return 513;
                case "unknow_11411.bin":
                    return 514;
                default:
                    return 0;
            }
        }

        private void ChangeTexturesIdsByFileId(string fileId)
        {
            switch (fileId)
            {
                case "unknow_11408.bin":
                    this.cboBannerTextureId.Items.Clear();

                    this.cboBannerTextureId.Items.AddRange(Enumerable.Range(1, 18).Cast<object>().ToArray());
                    break;
                case "unknow_11411.bin":
                    this.cboBannerTextureId.Items.Clear();
                    this.cboBannerTextureId.Items.AddRange(Enumerable.Range(1, 10).Cast<object>().ToArray());
                    break;
                case "unknow_11414.bin":
                    this.cboBannerTextureId.Items.Clear();
                    this.cboBannerTextureId.Items.AddRange(Enumerable.Range(1, 16).Cast<object>().ToArray());
                    break;
                case "unknow_11415.bin":
                    this.cboBannerTextureId.Items.Clear();
                    this.cboBannerTextureId.Items.AddRange(Enumerable.Range(1, 8).Cast<object>().ToArray());
                    break;
                default:
                    this.cboBannerTextureId.Items.Clear();
                    this.cboBannerTextureId.Items.AddRange(Enumerable.Range(1, 40).Cast<object>().ToArray());
                    break;
            }
        }
        private void ReadingCSVFile()
        {
            string teamlistFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "teamlist.csv");
            // First we try to load from the csv file the teamnames
            if (File.Exists(teamlistFilePath))
            {
                using (FileStream fs = new FileStream(teamlistFilePath, FileMode.Open, FileAccess.Read)) 
                using (StreamReader sr = new StreamReader(fs))
                {
                    int i = 0;
                    while (!sr.EndOfStream)
                    {
                        if (i<TeamList.Count)
                        {
                            TeamList[i] = sr.ReadLine();
                        }
                        i++;
                    }
                }
            }
            teams.Clear();
            lstTeams.Items.Clear();

            for (ushort i = 0; i < TeamList.Count; i++)
            {
                string teamName = TeamList[i];
                teams.Add(new Team(i, teamName));
            }

            lstTeams.Items.AddRange(teams.ToArray());

            string stadiumsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "stadiums.csv");
            if (File.Exists(stadiumsFilePath))
            {
                using (FileStream fs = new FileStream(stadiumsFilePath, FileMode.Open, FileAccess.Read))
                using (StreamReader sr = new StreamReader(fs))
                {
                    int i = 0;
                    while (!sr.EndOfStream)
                    {
                        if (i < Stadiums.Count)
                        {
                            Stadiums[i] = sr.ReadLine();
                        }
                        i++;
                    }
                }
            }
            cboStadium.Items.AddRange(Stadiums.ToArray());
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = this.Text;
                ofd.Filter = "All Files (*.*)|*.*";
                ofd.CheckFileExists = true;
                if (ofd.ShowDialog() != DialogResult.OK) return;
                TeamDBFilePath = ofd.FileName;
            }
            try
            {
                pesFolder = new PESFolder(TeamDBFilePath);
                byte[] bannerFileBytes = Utils.Unzlib(pesFolder.Files[BANNER_FILE_INDEX]);
                byte[] stadFileBytes = Utils.Unzlib(pesFolder.Files[STAD_FILE_INDEX]);
                byte[] suppColFileBytes = Utils.Unzlib(pesFolder.Files[SUPP_COL_FILE_INDEX]);
                using (MemoryStream ms = new MemoryStream(bannerFileBytes))
                using (BinaryReader br = new BinaryReader(ms))
                {
                    foreach (Team team in teams)
                    {
                        team.BannerTextureId = br.ReadUInt16();
                        team.BannerFile = br.ReadUInt16();
                    }
                }
                using (MemoryStream ms = new MemoryStream(stadFileBytes))
                using (BinaryReader br = new BinaryReader(ms))
                {
                    foreach (Team team in teams)
                    {
                        team.stadId = br.ReadByte();
                    }
                }
                using (MemoryStream ms = new MemoryStream(suppColFileBytes))
                using (BinaryReader br = new BinaryReader(ms))
                {
                    foreach (Team team in teams)
                    {
                        byte val = br.ReadByte();
                        team.SuppColourMain = (byte)(val & 0x0f);
                        team.SuppColourSec = (byte)(val >> 4 & 0x0f);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cboBannerBin.Enabled = true;
            cboBannerTextureId.Enabled = true;
            cboSuppColMain.Enabled = true;
            cboSuppColSec.Enabled = true;
            cboStadium.Enabled = true;
            LoadSupportersColoursList();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TeamDBFilePath)) return;

            byte[] bannerFileBytes = Utils.Unzlib(pesFolder.Files[BANNER_FILE_INDEX]);
            byte[] stadFileBytes = Utils.Unzlib(pesFolder.Files[STAD_FILE_INDEX]);
            byte[] suppColFileBytes = Utils.Unzlib(pesFolder.Files[SUPP_COL_FILE_INDEX]);

            foreach (Team team in teams)
            {
                Utils.WriteUInt16(bannerFileBytes, team.Id * 4, team.BannerTextureId);
                Utils.WriteUInt16(bannerFileBytes, team.Id * 4 + 2, team.BannerFile);
                stadFileBytes[team.Id] = team.stadId;
                suppColFileBytes[team.Id] = (byte)((team.SuppColourSec << 4) | team.SuppColourMain);
            }

            pesFolder.Files[BANNER_FILE_INDEX] = Utils.PESZlib(bannerFileBytes, 0x00010000);
            pesFolder.Files[STAD_FILE_INDEX] = Utils.PESZlib(stadFileBytes, 0x00010000);
            pesFolder.Files[SUPP_COL_FILE_INDEX] = Utils.PESZlib(suppColFileBytes, 0x00010000);

            try
            {
                pesFolder.ToFile(TeamDBFilePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("File save successfully!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "All Files (*.*)|*.*";
                sfd.Title = "Save as";
                sfd.DefaultExt = "bin";
                sfd.AddExtension = true;

                if (sfd.ShowDialog() != DialogResult.OK) return;
                string filePath = sfd.FileName;

                byte[] bannerFileBytes = Utils.Unzlib(pesFolder.Files[BANNER_FILE_INDEX]);
                byte[] stadFileBytes = Utils.Unzlib(pesFolder.Files[STAD_FILE_INDEX]);
                byte[] suppColFileBytes = Utils.Unzlib(pesFolder.Files[SUPP_COL_FILE_INDEX]);

                foreach (Team team in teams)
                {
                    Utils.WriteUInt16(bannerFileBytes, team.Id * 4, team.BannerTextureId);
                    Utils.WriteUInt16(bannerFileBytes, team.Id * 4 + 2, team.BannerFile);
                    stadFileBytes[team.Id] = team.stadId;
                    suppColFileBytes[team.Id] = (byte)((team.SuppColourSec << 4) | team.SuppColourMain);
                }

                pesFolder.Files[BANNER_FILE_INDEX] = Utils.PESZlib(bannerFileBytes, 0x00010000);
                pesFolder.Files[STAD_FILE_INDEX] = Utils.PESZlib(stadFileBytes, 0x00010000);
                pesFolder.Files[SUPP_COL_FILE_INDEX] = Utils.PESZlib(suppColFileBytes, 0x00010000);

                try
                {
                    pesFolder.ToFile(filePath);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("File save successfully!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Team GetTeam()
        {
            if (lstTeams.SelectedItem == null) return null;
            return (Team)lstTeams.SelectedItem;
        }

        private void lstTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            Team team = GetTeam();
            if (team == null || string.IsNullOrEmpty(TeamDBFilePath)) return;
            //Console.WriteLine(team);
            //Console.WriteLine(IntToBinId(team.BannerFile));
            //Console.WriteLine(team.BannerTextureId);
            //Console.WriteLine(team.stadId);
            //Console.WriteLine(team.SuppColourMain);
            //Console.WriteLine(team.SuppColourSec);

            cboBannerBin.SelectedItem = IntToBinId(team.BannerFile);
            ChangeTexturesIdsByFileId((string)cboBannerBin.SelectedItem);

            cboBannerTextureId.SelectedIndex = team.BannerTextureId;
            cboSuppColMain.SelectedIndex = team.SuppColourMain;
            cboSuppColSec.SelectedIndex = team.SuppColourSec;
            cboStadium.SelectedIndex = team.stadId;
        }

        private void cboBannerBin_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Team team = GetTeam();
            if (team == null || string.IsNullOrEmpty(TeamDBFilePath)) return;

            ComboBox cbo = (ComboBox)sender;
            ChangeTexturesIdsByFileId((string)cbo.SelectedItem);
            cboBannerTextureId.SelectedItem = null;
            team.BannerFile = BinIdToInt(cbo.SelectedItem.ToString());
        }

        private void cboBannerTextureId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Team team = GetTeam();
            if (team == null || string.IsNullOrEmpty(TeamDBFilePath)) return;
            ComboBox cbo = (ComboBox)sender;
            team.BannerTextureId = (ushort)cbo.SelectedIndex;
        }
        private void CboTeamSuppMainColour_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Team team = GetTeam();
            if (team == null || cboSuppColMain.SelectedItem == null) return;
            team.SuppColourMain = (byte)cboSuppColMain.SelectedIndex;
        }
        private void CboTeamSuppSecColour_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Team team = GetTeam();
            if (team == null || cboSuppColSec.SelectedItem == null) return;
            team.SuppColourSec = (byte)cboSuppColSec.SelectedIndex;
        }

        private void cboTeamSuppColour_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            if (e.Index >= 0)
            {
                ComboBox cbo = (ComboBox)sender;
                string txt = cbo.GetItemText(cbo.Items[e.Index]);
                Color color = (Color)cbo.Items[e.Index];
                Rectangle r1 = new Rectangle(e.Bounds.Left + 1, e.Bounds.Top + 1,
                    2 * (e.Bounds.Height - 2), e.Bounds.Height - 2);
                Rectangle r2 = Rectangle.FromLTRB(r1.Right + 2, e.Bounds.Top,
                    e.Bounds.Right, e.Bounds.Bottom);
                using (SolidBrush b = new SolidBrush(color))
                    e.Graphics.FillRectangle(b, r1);
                e.Graphics.DrawRectangle(Pens.Black, r1);
                TextRenderer.DrawText(e.Graphics, txt, cbo.Font, r2,
                    cbo.ForeColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
            }
        }
        private void LoadSupportersColoursList()
        {
            List<Color> mainSupporterColors = Utils.GetSupporterColours();
            cboSuppColMain.DataSource = null;
            cboSuppColMain.Items.Clear();
            cboSuppColMain.DataSource = mainSupporterColors;
            cboSuppColMain.SelectedItem = null;

            List<Color> secSupporterColors = Utils.GetSupporterColours();
            cboSuppColSec.DataSource = null;
            cboSuppColSec.Items.Clear();
            cboSuppColSec.DataSource = secSupporterColors;
            cboSuppColSec.SelectedItem = null;
        }

        private void cboStadium_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Team team = GetTeam();
            if (team == null || cboStadium.SelectedItem == null) return;
            team.stadId = (byte)cboStadium.SelectedIndex;
        }
    }
}