
using HidSharp;

namespace HeadsetBatteryMonitor.Service;

public class DispositivoHidService
{
    public IEnumerable<HidDevice> ObterDispositivosConectados()
    {
        return DeviceList.Local.GetHidDevices().ToList();
    }
}
