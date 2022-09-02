using System;

// https://docs.microsoft.com/en-US/windows/win32/cimwin32prov/win32-computersystem

namespace Hardware.Info
{
    /// <summary>
    /// WMI class: Win32_ComputerSystem
    /// </summary>
    public class ComputerSystem
    {
        /// <summary>
        /// Name of the organization responsible for producing the physical element.
        /// </summary>
        public string Manufacturer { get; set; } = string.Empty;

        /// <summary>
        /// Computer system model defined by the manufacturer.
        /// </summary>
        public string Model { get; set; } = string.Empty;


        public override string ToString()
        {
            return
                "Manufacturer: " + Manufacturer + Environment.NewLine +
                "Model: " + Model + Environment.NewLine;
        }
    }
}
