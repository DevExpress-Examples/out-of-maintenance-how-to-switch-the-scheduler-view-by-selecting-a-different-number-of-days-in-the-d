#region #usings
using DevExpress.XtraScheduler;
using System.Windows.Forms;
#endregion #usings

namespace DXApplication201
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            schedulerControl1.OptionsView.FirstDayOfWeek = DevExpress.XtraScheduler.FirstDayOfWeek.Monday;
            schedulerControl1.DateNavigatorQueryActiveViewType += schedulerControl1_DateNavigatorQueryActiveViewType;
        }
        #region #DateNavigatorQueryActiveViewType
        void schedulerControl1_DateNavigatorQueryActiveViewType(object sender, DateNavigatorQueryActiveViewTypeEventArgs e)
        {
            if ((e.SelectedDays.Count == 7) && (e.SelectedDays.Start.DayOfWeek == schedulerControl1.FirstDayOfWeek))
            {
                e.NewViewType = SchedulerViewType.Week;
            }
        }
        #endregion #DateNavigatorQueryActiveViewType
    }
}
