using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace CSharpInterviewPrograms
{
    public class ClassToSerialize
    {
        public int age = 100;
        public string name = "bipin";
    }
    public class SerialTest
    {
        //public void SerializeNow()
        //{
        //    ClassToSerialize c = new ClassToSerialize();
        //    FileStream f = File.Open("temp.dat",FileMode.OpenOrCreate);
        //    BinaryFormatter b = new BinaryFormatter();
        //    b.Serialize(f, c);
        //    f.Close();
        //}
        //public void DeSerializeNow()
        //{
        //    ClassToSerialize c = new ClassToSerialize();
        //    FileStream f = File.Open("temp.dat",FileMode.OpenOrCreate);
        //    BinaryFormatter b = new BinaryFormatter();
        //    c = (ClassToSerialize)b.Deserialize(f);
        //    Console.WriteLine(c.name);
        //    f.Close();
        //}
       
    }
}
