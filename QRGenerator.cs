using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QRCoder;

namespace QRGenerator
{
    internal class QRGenerator
    {
        private string textToEncode;
        private Bitmap qrcode;
        private Setting setting;
        public QRGenerator(string textToEncode)
        {
            this.setting = Setting.GetInstance();
            this.textToEncode = textToEncode;
        }

        public Bitmap GenerateQrCode()
        {
            using (QRCodeGenerator qrGenerator = new())
            {
                QRCodeData qrCodeData;
                switch (setting.eccLevel[0])
                {
                    case 'L':
                        qrCodeData = qrGenerator.CreateQrCode(textToEncode, QRCodeGenerator.ECCLevel.L);
                        break;
                    case 'M':
                        qrCodeData = qrGenerator.CreateQrCode(textToEncode, QRCodeGenerator.ECCLevel.M);
                        break;
                    case 'Q':
                        qrCodeData = qrGenerator.CreateQrCode(textToEncode, QRCodeGenerator.ECCLevel.Q);
                        break;
                    case 'H':
                        qrCodeData = qrGenerator.CreateQrCode(textToEncode, QRCodeGenerator.ECCLevel.H);
                        break;
                    default:
                        qrCodeData = qrGenerator.CreateQrCode(textToEncode, QRCodeGenerator.ECCLevel.Q);
                        break;

                }

                using (QRCode qrCode = new(qrCodeData))
                {
                    if (setting.bitmap != null)
                    {
                        qrcode = qrCode.GetGraphic(setting.pixelPerModule, setting.darkColor, setting.lightColor, setting.bitmap, setting.iconSize, setting.iconBorderWidth, setting.drawQuietZones, setting.iconBackground);
                    }
                    else
                    {
                        qrcode = qrCode.GetGraphic(setting.pixelPerModule, setting.darkColor, setting.lightColor, setting.drawQuietZones);
                    }
                    
                    return qrcode;

                }
            }
        }
    }
}
