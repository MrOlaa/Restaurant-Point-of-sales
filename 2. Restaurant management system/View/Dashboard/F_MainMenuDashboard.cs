using _2.Restaurant_management_system.View.Dashboard.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.Restaurant_management_system.View.Dashboard
{
    public partial class F_MainMenuDashboard : Form
    {
        public F_MainMenuDashboard()
        {
            InitializeComponent();
        }
        static F_MainMenuDashboard _obj;
        public static F_MainMenuDashboard Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new F_MainMenuDashboard();
                }
                return _obj;
            }
        }
        public Panel PannelContainer
        {
            get
            {
                return panel_Container;
            }
            set
            {
                panel_Container = (Guna.UI2.WinForms.Guna2GradientPanel)value;
            }
        }
        private void F_MainMenuDashboard_Load(object sender, EventArgs e)
        {
            _obj = this;
            PageDashboard uc = new PageDashboard();
            uc.Dock = DockStyle.Fill;
            panel_Container.Controls.Add(uc);
        }
        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            if (!panel_Container.Controls.ContainsKey("PageDashboard"))
            {
                PageDashboard uc = new PageDashboard();
                uc.Dock = DockStyle.Fill;
                panel_Container.Controls.Add(uc);
            }
            panel_Container.Controls["PageDashboard"].BringToFront();
            resertColor();
            btn_dashboard.FillColor = Color.FromArgb(49, 54, 96);
            btn_dashboard.ForeColor = Color.White;
        }
        private void btn_categories_Click(object sender, EventArgs e)
        {
            if (!panel_Container.Controls.ContainsKey("PageManageCategories"))
            {
                PageManageCategories uc = new PageManageCategories();
                uc.Dock = DockStyle.Fill;
                panel_Container.Controls.Add(uc);
            }
            panel_Container.Controls["PageManageCategories"].BringToFront();
            resertColor();
            btn_categories.FillColor = Color.FromArgb(49, 54, 96);
            btn_categories.ForeColor = Color.White;

        }
        private void resertColor()
        {
            //Resert Color Fill
            btn_dashboard.FillColor = Color.FromArgb(29, 34, 76);
            btn_categories.FillColor = Color.FromArgb(29, 34, 76);
            //Resert Color Text
            btn_dashboard.ForeColor = Color.Gray;
            btn_categories.ForeColor = Color.Gray;
        }
        
    }
}
