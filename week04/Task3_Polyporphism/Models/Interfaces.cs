using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Polyporphism.Models;

public interface IEngine
{
    public int HorsePower { get; set; }
    public int TankSize { get; set; }
    public float CurrentOil { get; set; }
    public string FuelType { get; set; }
    public float RemainOilAmount()
    {
        return (float)this.TankSize - this.CurrentOil;
    }
}
public interface IWheel
{
    public float WheelThickness { get; set; }
}
public interface ITransmission
{
    public string TransmissionKind { get; set; }
}

