using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QRGenerator
{
    internal class Setting
    {
        private static Setting? _instance;

        public Color lightColor = Color.White;
        public Color darkColor = Color.Black;
        public Color iconBackground = Color.White;
        public int pixelPerModule = 20;
        public int iconSize = 15;
        public int iconBorderWidth = 1;
        public string eccLevel = "Q (25%)";
        public string measurmentToDisplay = "0mm";
        public bool drawQuietZones = false;
        public Bitmap? bitmap = null;

        public Setting() { }

        public static Setting GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Setting();
            }
            return _instance;
        }
    }
}
