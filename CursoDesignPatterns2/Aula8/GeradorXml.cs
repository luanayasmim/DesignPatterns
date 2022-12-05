using System.Xml.Serialization;

namespace CursoDesignPatterns2.Aula8
{
    public class GeradorXml
    {
        public string GeraXml(object o)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(o.GetType());

            StringWriter writer = new();
            xmlSerializer.Serialize(writer, o);

            return writer.ToString();
        }
    }
}
