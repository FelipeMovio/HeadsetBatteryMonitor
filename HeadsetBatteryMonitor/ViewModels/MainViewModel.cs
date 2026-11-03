using HeadsetBatteryMonitor.Service;

namespace HeadsetBatteryMonitor.ViewModels;

public class MainViewModel
{
    private readonly DispositivoHidService _dispositivoHidService;

    public string Status { get; private set; } = "Verificando headset...";
    public string HeadsetName { get; private set; } = string.Empty;
    public string DeviceDetails { get; private set; } = string.Empty;

    public MainViewModel()
    {
        _dispositivoHidService = new DispositivoHidService();
        DetectarHeadset();
    }

    private void DetectarHeadset()
    {
        var headset = _dispositivoHidService.GetHeadset();

        if (headset is null)
        {
            Status = "Headset não detectado";
            return;
        }

        Status = "Headset conectado";
        HeadsetName = headset.Name;
        DeviceDetails = $"VID: 0x{headset.VendorId:X4} | PID: 0x{headset.ProductId:X4}";
    }
}