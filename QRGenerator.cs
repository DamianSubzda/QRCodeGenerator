using QRCoder;

namespace QRGenerator
{
    internal class QRGenerator(string textToEncode)
    {
        private readonly string textToEncode = textToEncode;
        private Bitmap? qrcode;
        private readonly Setting setting = Setting.GetInstance();

        public Bitmap GenerateQrCode()
        {
            using (QRCodeGenerator qrGenerator = new())
            {
                QRCodeData qrCodeData = CreateQRCodeData(qrGenerator);

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

        private QRCodeData CreateQRCodeData(QRCodeGenerator qrGenerator)
        {
            QRCodeData qrCodeData = setting.eccLevel[0] switch
            {
                'L' => qrGenerator.CreateQrCode(textToEncode, QRCodeGenerator.ECCLevel.L),
                'M' => qrGenerator.CreateQrCode(textToEncode, QRCodeGenerator.ECCLevel.M),
                'Q' => qrGenerator.CreateQrCode(textToEncode, QRCodeGenerator.ECCLevel.Q),
                'H' => qrGenerator.CreateQrCode(textToEncode, QRCodeGenerator.ECCLevel.H),
                _ => qrGenerator.CreateQrCode(textToEncode, QRCodeGenerator.ECCLevel.Q),
            };

            return qrCodeData;
        }
    }
}
