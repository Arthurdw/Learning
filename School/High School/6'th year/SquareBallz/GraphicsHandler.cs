using System.Drawing;
using System.Windows.Forms;

namespace Balletjes
{
    internal static class GraphicsHandler
    {
        public static Panel panel;
        public static Graphics graphic;

        public static void ReloadGraphics()
            => panel.Invalidate();
    }
}