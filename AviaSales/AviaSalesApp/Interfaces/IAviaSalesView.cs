using AviaSalesApp.Common;
using AviaSalesApp.Controllers;

namespace AviaSalesApp
{
    public interface IAviaSalesView
    {
        IAviaSalesView Parent { get; set; }
        IControlFactory Factory { get; }
        void Show();
        void Close();
        void Hide();
    }
}