
using HidSharp;

namespace HeadsetBatteryMonitor.Service;

public class DispositivoHidService
{
    public IEnumerable<HidDevice> GetConnectedDevices()
    {
        return DeviceList.Local
            .GetHidDevices()
            .ToList();
    }
}
