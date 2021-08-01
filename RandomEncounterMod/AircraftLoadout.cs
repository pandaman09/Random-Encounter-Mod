﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AircraftLoadout
{
    public string aircraftName;
    public string[] hardpoints;

    public AircraftLoadout(string aircraftName)
    {
        this.aircraftName = aircraftName;
        this.hardpoints = new string[0];
    }

    public AircraftLoadout(string aircraftName, string[] hardpoints) {
        this.aircraftName = aircraftName;
        this.hardpoints = hardpoints;
    }
}
