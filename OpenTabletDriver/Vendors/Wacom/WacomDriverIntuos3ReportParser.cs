using OpenTabletDriver.Plugin.Tablet;

namespace OpenTabletDriver.Vendors.Wacom
{
    public class WacomDriverIntuos3ReportParser : Intuos3ReportParser
    {
        public override IDeviceReport Parse(byte[] data)
        {
            return base.Parse(data[1..^0]);
        }
    }
}