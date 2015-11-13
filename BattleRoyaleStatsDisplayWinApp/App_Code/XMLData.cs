using System.Xml;
using System;
using System.IO;

namespace BattleRoyaleStats
{
    class XMLData
    {
        public static void CreateXML(string idSteam, string refreshrate, bool labels)
        {

            XmlDocument xmlDoc = new XmlDocument();
            string strXML = "<xml><steamid>{0}</steamid><refreshrate>{1}</refreshrate><labels>{2}</labels></xml>";

            xmlDoc.LoadXml(string.Format(strXML, idSteam, refreshrate,labels));

            string statsFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/BattleRoyaleStats";
            if (!Directory.Exists(statsFolder))
                Directory.CreateDirectory(statsFolder);

            xmlDoc.Save(statsFolder + "/settings.xml");
        }        
    }
}
