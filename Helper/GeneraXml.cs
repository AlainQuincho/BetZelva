using System.Xml.Serialization;

namespace Helper
{
    public static class GeneraXml
    {
        public static string Xml(this object obj)
        {
            var stringwriter = new System.IO.StringWriter();
            var serializer = new XmlSerializer(obj.GetType());
            serializer.Serialize(stringwriter, obj);
            return stringwriter.ToString();
        }
    }
}
