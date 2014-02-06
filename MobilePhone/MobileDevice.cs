using System;
using System.Collections.Generic;
using System.Text;

class MobileDevice
{
    static void Main()
    {
        List<GSM> phones = new List<GSM>();

        GSM lgOptimus = new GSM("lg optimus", "dingi", "sulio");
        lgOptimus.Price = 700;
        lgOptimus.batteryHaracteristics = new Battery("shittymodel", 3000, 3000);
        lgOptimus.batteryType = Battery.BatteryType.LiIon;
        lgOptimus.displayHaracteristics = new Display("300x400px.", 1024);
        phones.Add(lgOptimus);

        // Display phones haracteristicst
        foreach (var phone in phones)
        {
            Console.WriteLine(phone.Model.ToUpper());
            Console.WriteLine(phone.ToString());
            Console.WriteLine();
        }

        Console.WriteLine("CALL HISTORY:\n");
        Call newCall = new Call(new DateTime(2012, 12, 12), "12:12:43", "0887431223", 123);
        lgOptimus.CallHistory.Add(newCall);
        Call newCall2 = new Call(new DateTime(2012, 12, 12), "12:12:43", "0887436223", 1234);
        lgOptimus.CallHistory.Add(newCall2);

        lgOptimus.AddCall(new DateTime(2011, 3, 4), "12:24:12", "08893243", 321);

        foreach (var item in lgOptimus.CallHistory)
        {
           item.PrintCall();
           Console.WriteLine();
        }

        // Calculate the price
        decimal price = lgOptimus.CalculatePriceOfCalls(0.37M);
        Console.WriteLine("Price: {0:0.00}", price);

        // Get the longest call       
        long maxLength = lgOptimus.MaxCall();
        Console.WriteLine("Max length: {0}", maxLength);

        lgOptimus.DeleteCall(lgOptimus.MaxCall()); // Delete the call with maximal length

        foreach (var item in lgOptimus.CallHistory)
        {
            item.PrintCall();
            Console.WriteLine();
        }

        lgOptimus.ClearHistory(); // Clears the history for the current device

        
    }
}