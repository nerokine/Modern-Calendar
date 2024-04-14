using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Modern_Calendar
{
    public partial class EventForm : Form
    {
        String connString = "server=localhost;user id = root;database=db_calendar;ssslmode=none";
        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {

        }
    }
}
