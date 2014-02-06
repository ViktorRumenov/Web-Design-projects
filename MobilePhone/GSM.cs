using System;
using System.Collections.Generic;
using System.Text;

class GSM
{
    private string model;
    private string manufacturer;
    private int? price;
    private string owner;
    public Battery.BatteryType batteryType;
    public Battery batteryHaracteristics;
    public Display displayHaracteristics;
    private static GSM iPhone4S = new GSM("4S", "Apple");
    private List<Call> callHistory = new List<Call>();

    public GSM(string model, string manufacturer)
    {
        this.model = model;
        this.manufacturer = manufacturer;
        this.price = 0;
        this.owner = null;
        this.batteryHaracteristics = null;
        this.displayHaracteristics = null;
        this.batteryType = Battery.BatteryType.NoBattery;
    }

    public GSM(string model, string manufacturer, string owner)
        : this(model, manufacturer)
    {
        this.owner = owner;
    }

    public GSM(string model, string manufacturer, string owner, int price)
        : this(model, manufacturer, owner)
    {
        this.price = price;
    }

    public string Model
    {
        get { return model; }
        set { this.model = value; }
    }

    // The manufacturer can't be changed
    public string Manufacturer
    {
        get { return manufacturer; }
        //set { this.manufacturer = value; }
    }

    // Property for the price with ability to be rewritten
    public int? Price
    {
        get { return this.price; }
        set { price = value; }
    }

    // The owner can't be changed
    public string Owner
    {
        get { return this.owner; }
        //set { this.owner = value; }
    }

    public static GSM IPhone4S
    {
        get
        {
            return iPhone4S;
        }
    }

    public List<Call> CallHistory
    {
        get { return callHistory; }
        set { callHistory = value; }
    }

    // Clears the history
    public void ClearHistory()
    {
        callHistory.Clear();
    }

    // Deletes a call chosen by the user
    public void DeleteCall(int chosenCall)
    {
        callHistory.Remove(callHistory[chosenCall]);
    }

    // Add Call to the call history why? I have no fuckin' idea
    public void AddCall(DateTime date, string time, string dialedNumber, long timeInSeconds)
    {
        callHistory.Add(new Call(date, time, dialedNumber, timeInSeconds));
    }

    public override string ToString()
    {
        StringBuilder gsmInformation = new StringBuilder();

        gsmInformation.Append("Model of mobile device: " + model);
        gsmInformation.Append("\nType of battery: " + batteryType);

        if (batteryHaracteristics != null)
        {
            gsmInformation.Append("\nBattery model: " + batteryHaracteristics.Model);
            gsmInformation.Append("\nBattery hours of talk: " + batteryHaracteristics.HoursTalk);
            gsmInformation.Append("\nBattery hours of idle: " + batteryHaracteristics.HoursIdle);
        }

        if (displayHaracteristics != null)
        {
            gsmInformation.Append("\nDisplay colors: " + displayHaracteristics.NumberOfColors);
            gsmInformation.Append("\nDisplay resolution: " + displayHaracteristics.SizeOfDisplay);
        }

        gsmInformation.Append("\nManufacturer: " + manufacturer);
        gsmInformation.Append("\nPrice: " + price);

        if (owner != null)
        {
            gsmInformation.Append("\nOwner: " + owner);
        }

        return gsmInformation.ToString();
    }

    // Calculate price of all the call in the current device
    public decimal CalculatePriceOfCalls(decimal pricePerMinute)
    {
        decimal totalPrice = 0;
        decimal sumOfSecondsElapsed = 0;

        for (int i = 0; i < callHistory.Count; i++)
        {
            sumOfSecondsElapsed += callHistory[i].DurationInSeconds;
        }

        totalPrice = (sumOfSecondsElapsed / 60) * pricePerMinute;
        return totalPrice;
    }

    // Get maximal call length
    public int MaxCall()
    {
        long maxCall = 0;
        int indexOfMaxCall = 0;

        for (int i = 0; i < callHistory.Count; i++)
        {
            if (callHistory[i].DurationInSeconds > maxCall)
            {
                maxCall = callHistory[i].DurationInSeconds;
                indexOfMaxCall = i;
            }
        }

        return indexOfMaxCall;
    }
}