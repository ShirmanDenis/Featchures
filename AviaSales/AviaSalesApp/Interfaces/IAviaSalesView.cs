using AviaSalesApp.Common;
using AviaSalesApp.Controllers;

namespace AviaSalesApp
{
    public interface IAviaSalesView
    {
        IControlFactory Factory { get; }
    }
}