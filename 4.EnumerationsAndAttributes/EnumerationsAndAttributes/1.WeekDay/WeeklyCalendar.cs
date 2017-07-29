using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class WeeklyCalendar
{
    private IList<WeeklyEntry> data;

    public WeeklyCalendar()
    {
        this.data = new List<WeeklyEntry>();
    }
    public IEnumerable<WeeklyEntry> WeeklySchedule { get { return this.data; } }


    public void AddEntry(string weekday, string notes)
    {
        data.Add(new WeeklyEntry(weekday, notes));
    }

}

