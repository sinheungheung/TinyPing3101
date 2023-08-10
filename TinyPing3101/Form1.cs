using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinyPing3101
{
    public partial class Form1 : Form
    {
        static private List<Character> characterList = new List<Character>()
            {
                new Character(){Name="하츄핑", Price= 80000,  Popular=5},
                new Character(){Name="바로핑", Price= 81000 , Popular=5},
                new Character(){Name="아자핑", Price= 89000,  Popular=5},
                new Character(){Name="차차핑", Price= 30000,  Popular=5},
                new Character(){Name="라라핑", Price= 45000,  Popular=4},
                new Character(){Name="해핑",   Price= 67000 , Popular=1},
                new Character(){Name="키키핑", Price= 61000,  Popular=3},
                new Character(){Name="아잉핑", Price= 58000,  Popular=2},
                new Character(){Name="덜덜핑", Price= 12000,  Popular=2},
                new Character(){Name="씽씽핑", Price= 10000,  Popular=2},

                new Character(){Name="투투핑", Price= 72000, Popular=3},
                new Character(){Name="가면핑", Price= 5000,  Popular=3},
                new Character(){Name="앙대핑", Price= 2500,  Popular=4},
                new Character(){Name="조아핑", Price= 56000, Popular=4},
                new Character(){Name="방글핑", Price= 90000, Popular=1},
                new Character(){Name="쪼꼼핑", Price= 92000, Popular=1},
                new Character(){Name="싹싹핑", Price= 23000, Popular=3},
                new Character(){Name="주네핑", Price= 17000, Popular=2},
                new Character(){Name="원더핑", Price= 49000, Popular=3},
                new Character(){Name="발레핑", Price= 50000, Popular=4}

            };
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            characterBindingSource.DataSource = characterList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            characterBindingSource.DataSource = (from item in characterList
                                                 where item.Price >= 10000
                                                 orderby item.Price descending
                                                 select item).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            characterBindingSource.DataSource = (from item in characterList
                                                 orderby item.Name descending
                                                 select item).ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            characterBindingSource.DataSource = (from item in characterList
                                                 where item.Popular >= 3
                                                 orderby item.Popular descending
                                                 select item).ToList();
        }
    }
}
