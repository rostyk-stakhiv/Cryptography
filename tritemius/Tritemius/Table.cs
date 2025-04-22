using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CesarCipher
{
    public partial class Table : Form
    {
        Dictionary<char, int> _table;
        public Table(Dictionary<char, int> table)
        {
            InitializeComponent();
            _table = table;
        }

        private void FrequencyTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Table_Load(object sender, EventArgs e)
        {
            foreach (var item in _table)
            {
                DataGridViewRow row = (DataGridViewRow)FrequencyTable.Rows[0].Clone();
                row.Cells[0].Value = item.Key;
                row.Cells[1].Value = item.Value;
                FrequencyTable.Rows.Add(row);
            }
            
        }
    }
}
