#nullable disable
using System;

namespace B4_7_MDI_QuanLyDaCuaSo
{
    /// <summary>
    /// Interface for MDI child forms to send status messages to parent.
    /// </summary>
    public interface IStatusReporter
    {
        event EventHandler<string> StatusChanged;
    }
}
