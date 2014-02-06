using System;
using System.Collections.Generic;

class Battery
{
    private string model;
    private int? hoursIdle;
    private int? hoursTalk;
    private BatteryType batteryType;

    // Set enumeration for the types of the battery
    public enum BatteryType
    {
        LiIon,
        NiMH,
        NiCd,
        NoBattery
    };

    public Battery() : this (null, 0, 0)
    {
    }

    public string Model
    {
        get { return model; }
        set { this.model = value; }
    }

    public Battery(string model, int hoursIdle, int hoursTalk)
    {
        this.model = model;
        this.hoursIdle = hoursIdle;
        this.hoursTalk = hoursTalk;
    }

    public Battery(string model, int hoursTalk)
    {
        this.model = model;
        this.hoursTalk = hoursTalk;
    }

    public int? HoursIdle
    {
        get { return hoursIdle; }
        set { this.hoursIdle = value; }
    }

    public int? HoursTalk
    {
        get { return hoursTalk; }
        set { this.hoursTalk = value; }
    }

    public BatteryType TypeOfBattery
    {
        get { return this.batteryType; }
        set { batteryType = value; }
    }
}
