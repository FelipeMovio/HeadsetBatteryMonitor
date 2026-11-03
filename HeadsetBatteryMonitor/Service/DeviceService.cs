using HeadsetBatteryMonitor.Model;
using HidSharp;

namespace HeadsetBatteryMonitor.Service;

public class DispositivoHidService
{
    private const int VendorId = 0x0D8C;
    private const int ProductId = 0x0147;

    public HeadsetDevice? GetHeadset()
    {
        var device = DeviceList.Local
            .GetHidDevices(VendorId, ProductId)
            .FirstOrDefault();

        if (device is null)
            return null;

        return new HeadsetDevice
        {
            Name = device.GetProductName() ?? "Captain 700 Pro",
            VendorId = device.VendorID,
            ProductId = device.ProductID,
            DevicePath = device.DevicePath
        };
    }
}