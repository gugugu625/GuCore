using System;
using System.Windows;
using System.Drawing;

namespace GuCore
{
    public interface IGuguguInterface
    {
        Window MainWindow();
        string Name();
        string Version();
        Bitmap Icon();
    }
}
