using System;
using System.Xml;
using BattleRoyaleStatsApp.Validators;

namespace BattleRoyaleStatsApp.Data
{
    public static class XmlData
    {
        public static void CreateXml(string idSteam, string refreshrate, bool labels)
        {
            var xmlDoc = new XmlDocument();
            const string strXml = "<xml><steamid>{0}</steamid><refreshrate>{1}</refreshrate><labels>{2}</labels></xml>";

            xmlDoc.LoadXml(string.Format(strXml, idSteam, refreshrate, labels));

            var statsFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/BattleRoyaleStats";
            DirectoryValidator.ValidateDirectoryExists(statsFolder);

            xmlDoc.Save(statsFolder + "/settings.xml");
        }
    }
}
