using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace City_Traffic_Simulation_Application
{
   public class SerializeData
    {
        
       
        // the construcor
        public SerializeData()
        {
            
        }

        //methods to serialize
        public void SerialiseObjects( string filename, object objectToSerialize)
        {
            Stream stream = File.Open(filename, FileMode.Create, FileAccess.Write);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(stream, objectToSerialize);
            stream.Close();
        }
        //methods to deserialize
        public object DeSerialiseObjects(String filename)
        {
            object objectToSerialize;
            Stream stream = File.Open(filename, FileMode.Open);
            BinaryFormatter bFormatter = new BinaryFormatter();
            objectToSerialize = bFormatter.Deserialize(stream);
            stream.Close();
            return objectToSerialize;
        }
    }

}
