using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolitaireHuntForm
{
    public partial class RulesForm : Form
    {
        public RulesForm()
        {
            InitializeComponent();
            label1.Text = "На игровом столе расположено девять стопок игровых карт, котрые в них лежат лицевой стороной к игроку.\nЦель игры состоит в том, чтобы попарно убрать все карты с игрового стола. \nНа карту в стопке можно положить карту того же достоинства независимо от цвета масти. \nНапример, на даму крестей можно положить любую другую даму.\n\nПри этом представлены следующие масти:\nбуби,\nкрести,\nвини,\nчерви.";
        }
    


        private void RulesForm_Load(object sender, EventArgs e)
        {
        }
    }
}
