using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Polyporphism.Models;

public abstract class Vehicle
{
    int _driveTime;
    // seconds
    float _drivePath;
    // meters

    public int DriveTime
    {
        get => this._driveTime;
        set
        {
            if (value < 0) value = 0;
            this._driveTime = value;
        }
    }
    public float DrivePath
    {
        get => this._drivePath;
        set
        {
            if (value < 0) value = 0;
            this._drivePath = value;
        }
    }
    public int AverageSpeed()
    {
        // * 3600 / 1000 = km per hour;
        return (Int32)((this.DrivePath / this.DriveTime) * 3.6);
        // average dont need to be accurate anyway so here go int
    }

    public override string ToString()
    {
        return "Meters drived: " + this.DrivePath + "\nSeconds it taked: " + this.DriveTime;
    }
}

internal record Engine : IEngine
{
    int _hoursePower, _tankSize;
    float _currentOil;
    string _fuelType;
    public int HorsePower
    {
        get => this._hoursePower;
        set
        {
            if (value < 0) value = 0;
            this._hoursePower = value;
        }
    }
    public int TankSize
    {
        get => this._tankSize;
        set
        {
            if (value < 0) value = 0;
            this._tankSize = value;
        }
    }
    public float CurrentOil
    {
        get => this._currentOil;
        set
        {
            if (value < 0) value = 0;
            this._currentOil = value;
        }
    }
    public string FuelType
    {
        get => this._fuelType;
        set
        {
            if (String.IsNullOrWhiteSpace(value)) value = "Basic";
            this._fuelType = value;
        }
    }

    public override string ToString()
    {
        string stats = "Horse power: " + this.HorsePower;
        stats += "\nTank size: " + this.TankSize;
        stats += "\nCurrent Oil: " + this.CurrentOil;
        stats += "\nFuel Type: " + this.FuelType;

        return stats;
    }
}
internal record Wheel : IWheel
{
    float _wheelThickness;
    public float WheelThickness
    {
        get => this._wheelThickness;
        set
        {
            if (value < 0) value = 0;
            this._wheelThickness = value;
        }
    }

    public override string ToString()
    {
        return "Wheel tickness: " + this.WheelThickness;
    }
}
internal record Transmission : ITransmission
{
    string _transmissionKind;
    public string TransmissionKind
    {
        get => _transmissionKind;
        set
        {
            if (String.IsNullOrWhiteSpace(value)) value = "Basic";
            this._transmissionKind = value;
        }
    }

    public override string ToString()
    {
        return "Tranmission kind: " + this.TransmissionKind;
    }
}

public class Car : Vehicle, IEngine, IWheel, ITransmission
{
    byte _doorCount;
    string _winCode;
    Engine _engine = new();
    Wheel _wheel = new();
    Transmission _transmission = new();

    public byte DoorCount
    {
        get => this._doorCount;
        set
        {
            if (value < 0) value = 0;
            this._doorCount = value;
        }
    }
    public string WinCode
    {
        get => _winCode;
        set
        {
            if (String.IsNullOrWhiteSpace(value)) value = "Basic";
            this._winCode = value;
        }
    }

    public int HorsePower { get => ((IEngine)_engine).HorsePower; set => ((IEngine)_engine).HorsePower = value; }
    public int TankSize { get => ((IEngine)_engine).TankSize; set => ((IEngine)_engine).TankSize = value; }
    public float CurrentOil { get => ((IEngine)_engine).CurrentOil; set => ((IEngine)_engine).CurrentOil = value; }
    public string FuelType { get => ((IEngine)_engine).FuelType; set => ((IEngine)_engine).FuelType = value; }
    public float WheelThickness { get => ((IWheel)_wheel).WheelThickness; set => ((IWheel)_wheel).WheelThickness = value; }
    public string TransmissionKind { get => ((ITransmission)_transmission).TransmissionKind; set => ((ITransmission)_transmission).TransmissionKind = value; }

    public override string ToString()
    {
        return "It is car.\nWin code: " + this.WinCode + "\nDoor count: " + this.DoorCount +
            "\n" + base.ToString() + "\n" + this._engine + "\n" + this._wheel + "\n" + this._transmission;
    }
}
public class Bicycle : Vehicle, IWheel, ITransmission
{
    string _pedalKind;
    Wheel _wheel = new();
    Transmission _transmission = new();

    public string PedalKind
    {
        get => _pedalKind;
        set
        {
            if (String.IsNullOrWhiteSpace(value)) value = "Basic";
            this._pedalKind = value;
        }
    }

    public float WheelThickness { get => ((IWheel)_wheel).WheelThickness; set => ((IWheel)_wheel).WheelThickness = value; }
    public string TransmissionKind { get => ((ITransmission)_transmission).TransmissionKind; set => ((ITransmission)_transmission).TransmissionKind = value; }

    public override string ToString()
    {
        return "It is bicycle.\nPedal kind: " + this.PedalKind +
            "\n" + base.ToString() + "\n" + this._wheel + "\n" + this._transmission;
    }
}
public class Plane : Vehicle, IEngine
{
    float _wingLength;
    Engine _engine = new();

    public float WingLength 
    { 
        get => this._wingLength;
        set
        {
            if (value < 0) value = 0;
            this._wingLength = value;
        }
    }

    public int HorsePower { get => ((IEngine)_engine).HorsePower; set => ((IEngine)_engine).HorsePower = value; }
    public int TankSize { get => ((IEngine)_engine).TankSize; set => ((IEngine)_engine).TankSize = value; }
    public float CurrentOil { get => ((IEngine)_engine).CurrentOil; set => ((IEngine)_engine).CurrentOil = value; }
    public string FuelType { get => ((IEngine)_engine).FuelType; set => ((IEngine)_engine).FuelType = value; }

    public override string ToString()
    {
        return "It is plane.\nWing length: " + this.WingLength + 
            "\n" + base.ToString() + "\n" + this._engine;
    }
}

