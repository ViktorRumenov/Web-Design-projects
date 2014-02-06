using System;
using System.Collections.Generic;

class Display
{
    private string sizeOfDisplay;
    private int? numberOfColors;

    // If constructor is empty set default values
    public Display() : this (null, 0)
    { 
    }

    public Display(string sizeOfDisplay)
    {
        this.sizeOfDisplay = sizeOfDisplay;
    }

    public Display(string sizeOfDisplay, int numberOfColors)
    {
        this.numberOfColors = numberOfColors;
        this.sizeOfDisplay = sizeOfDisplay;
    }

    public Display(int numberOfColors)
    {
        this.numberOfColors = numberOfColors;
    }

    public string SizeOfDisplay
    {
        get { return sizeOfDisplay; }
        set { this.sizeOfDisplay = value; }
    }

    public int? NumberOfColors
    {
        get { return numberOfColors; }
        set { this.numberOfColors = value; }
    }
}