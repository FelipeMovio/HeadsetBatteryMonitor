namespace HeadsetBatteryMonitor.Model;

public class HeadsetDevice
{
    public string Name { get; set; } = string.Empty;
    public int VendorId { get; set; }
    public int ProductId { get; set; }
    public string DevicePath { get; set; } = string.Empty;
}