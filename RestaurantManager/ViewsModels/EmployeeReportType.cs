using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.ViewsModels
{
    public enum EmployeeReportType
    {
        None,
        [Description("Profile Report")]
        Profile,
        [Description("Summary Report")]
        Summary,
        [Description("Employees Directory Report")]
        Directory,
        [Description("Task List Report")]
        TaskList
    }
}
