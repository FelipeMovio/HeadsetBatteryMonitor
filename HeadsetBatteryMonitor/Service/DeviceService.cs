
using HidSharp;

namespace HeadsetBatteryMonitor.Service;

public class DeviceService
{
    public IEnumerable<HidDevice> GetConnectedDevices()
    {
        return DeviceList.Local
            .GetHidDevices()
            .ToList();
    }
}
