using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Polyporphism.Models;

public abstract class Vehicle
{
    int _driveTime;
    double _drivePath;

    public int DriveTime
    {
        get => this._driveTime;
        set
        {
            if (value < 0) value = 0;
            this._driveTime = value;
        }
    }
    public double DrivePath
    {
        get => this._drivePath;
        set
        {
            if (value < 0) value = 0;
            this._drivePath = value;
        }
    }
    public double AverageSpeed()
    {
        return this.DrivePath / (double)this.DriveTime;
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
}

public class Car : Vehicle, IEngine, IWheel, ITransmission
{
    Engine _engine = new();
    Wheel _wheel = new();
    Transmission _transmission = new();

    public int HorsePower { get => ((IEngine)_engine).HorsePower; set => ((IEngine)_engine).HorsePower = value; }
    public int TankSize { get => ((IEngine)_engine).TankSize; set => ((IEngine)_engine).TankSize = value; }
    public float CurrentOil { get => ((IEngine)_engine).CurrentOil; set => ((IEngine)_engine).CurrentOil = value; }
    public string FuelType { get => ((IEngine)_engine).FuelType; set => ((IEngine)_engine).FuelType = value; }
    public float WheelThickness { get => ((IWheel)_wheel).WheelThickness; set => ((IWheel)_wheel).WheelThickness = value; }
    public string TransmissionKind { get => ((ITransmission)_transmission).TransmissionKind; set => ((ITransmission)_transmission).TransmissionKind = value; }

    public override string ToString()
    {
        return "It is car.";
    }
}
public class Bicycle : Vehicle, IWheel, ITransmission
{
    Wheel _wheel = new();
    Transmission _transmission = new();

    public float WheelThickness { get => ((IWheel)_wheel).WheelThickness; set => ((IWheel)_wheel).WheelThickness = value; }
    public string TransmissionKind { get => ((ITransmission)_transmission).TransmissionKind; set => ((ITransmission)_transmission).TransmissionKind = value; }

    public override string ToString()
    {
        return "It is bicycle.";
    }
}
public class Plane : Vehicle, IEngine
{
    Engine _engine = new();

    public int HorsePower { get => ((IEngine)_engine).HorsePower; set => ((IEngine)_engine).HorsePower = value; }
    public int TankSize { get => ((IEngine)_engine).TankSize; set => ((IEngine)_engine).TankSize = value; }
    public float CurrentOil { get => ((IEngine)_engine).CurrentOil; set => ((IEngine)_engine).CurrentOil = value; }
    public string FuelType { get => ((IEngine)_engine).FuelType; set => ((IEngine)_engine).FuelType = value; }

    public override string ToString()
    {
        return "It is plane.";
    }
}

