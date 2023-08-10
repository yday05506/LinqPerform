using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqPerform
{
    public partial class Form1 : Form
    {
        static private List<VoiceActor> v_actors = new List<VoiceActor>()
        {
            new VoiceActor() { Name="손수호", Affiliation="투니버스", Age=34, Debut=2015},
            new VoiceActor() { Name="김민주", Affiliation="대원", Age=31, Debut=2015},
            new VoiceActor() { Name="이우리", Affiliation="투니버스", Age=24, Debut=2020},
            new VoiceActor() { Name="서반석", Affiliation="대원", Age=37, Debut=2016},
            new VoiceActor() { Name="박성영", Affiliation="대원", Age=34, Debut=2016},
            new VoiceActor() { Name="이창민", Affiliation="대원", Age=39, Debut=2016},
            new VoiceActor() { Name="박요한", Affiliation="대원", Age=39, Debut=2014},
            new VoiceActor() { Name="정의진", Affiliation="KBS", Age=37, Debut=2016},
            new VoiceActor() { Name="권도일", Affiliation="KBS", Age=44, Debut=2011},
            new VoiceActor() { Name="장서화", Affiliation="대원", Age=34, Debut=2018}, // 10
            new VoiceActor() { Name="김다올", Affiliation="투니버스", Age=33, Debut=2018},
            new VoiceActor() { Name="류승곤", Affiliation="MBC", Age=44, Debut=2004},
            new VoiceActor() { Name="신범식", Affiliation="KBS", Age=38, Debut=2013},
            new VoiceActor() { Name="강성우", Affiliation="투니버스", Age=34, Debut=2018},
            new VoiceActor() { Name="김명준", Affiliation="투니버스", Age=44, Debut=2012},
            new VoiceActor() { Name="박민기", Affiliation="대교", Age=34, Debut=2018},
            new VoiceActor() { Name="민승우", Affiliation="대교", Age=38, Debut=2014},
            new VoiceActor() { Name="이경태", Affiliation="대원", Age=38, Debut=2014},
            new VoiceActor() { Name="이주승", Affiliation="대원", Age=30, Debut=2019},
            new VoiceActor() { Name="방성준", Affiliation="MBC", Age=51, Debut=2000},  // 20
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            voiceActorBindingSource.DataSource = v_actors;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            voiceActorBindingSource.DataSource = from v in v_actors
                                                 orderby v.Debut ascending
                                                 select v;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            voiceActorBindingSource.DataSource = from v in v_actors
                                                 where v.Debut >= 2017
                                                 select v;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            voiceActorBindingSource.DataSource = from v in v_actors
                                                 orderby v.Name ascending
                                                 select v;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            voiceActorBindingSource.DataSource = from v in v_actors
                                                 where v.Affiliation.Equals("투니버스")
                                                 select v;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
