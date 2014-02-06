using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Call
{
    private DateTime date;
    private string time;
    private string dialedPhone;
    private long durationInSeconds;
   
    public Call(DateTime date, string time, string dialedPhone, long durationInSeconds)
    {
        this.date = date;
        this.time = time;
        this.dialedPhone = dialedPhone;
        this.durationInSeconds = durationInSeconds;
    }

    public long DurationInSeconds
    {
        get { return durationInSeconds; }
    }

    public void PrintCall()
    {
        Console.WriteLine("Date: {0}", this.date);
        Console.WriteLine("Time: {0}", this.time);
        Console.WriteLine("Phone number: {0}", this.dialedPhone);
        Console.WriteLine("Duration in seconds: {0}", this.durationInSeconds);
    }
}