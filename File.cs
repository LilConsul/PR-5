using System.IO;
using System.Xml.Serialization;

namespace PR_5 {
    public class File {
        private string fileIn;
        private string fileOut;

        private XmlSerializer _serializer = new XmlSerializer(typeof(ListStudents));
        
        public File(string fileIn = "in.xml", string fileOut = "out.xml") {
            this.fileIn = fileIn;
            this.fileOut = fileOut;
        }

        public void Write(ref ListStudents list) {
            using (var fs = new FileStream(fileOut, FileMode.Create, FileAccess.Write, FileShare.None)) {
                _serializer.Serialize(fs, list);
            }
        }

        public void Read(ref ListStudents list) {
            using ( var fs = new FileStream(fileIn, FileMode.Open, FileAccess.Read, FileShare.None)) {
                list = _serializer.Deserialize(fs) as ListStudents;
            }
        }
    }
}