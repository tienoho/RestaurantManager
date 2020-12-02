using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using RestaurantManager.Database;
using RestaurantManager.Bussiness;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using RestaurantManager.Model;
using RestaurantManager.Views.Print;

namespace RestaurantManager
{
    public partial class uctWelcome : UserControl
    {
        public uctWelcome()
        {
            InitializeComponent();
        }
        public static uctWelcome uctDL = new uctWelcome();
        
    }
}
