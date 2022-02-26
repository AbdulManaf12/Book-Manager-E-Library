using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Final_Project
{
    [Serializable]
    public class Book
    {
        public String Name;
        public String Author;
        public String Edition;
        public int year;
        public String url;
        public String imagelocation = null;
        public String Description;
        public List<NoteData> Notes;
        public String LastAccessTime;

        public Book(){
            Notes = new List<NoteData>();
        }
    }
    [Serializable]
    public class NoteData
    {
        public String Title;
        public String Description;
        public String Time;

        public NoteData(String Title, String Description, String Time)
        {
            this.Title = Title;
            this.Description = Description;
            this.Time = Time;
        }
    }
    public class FilingClass
    {
        public static void WriteObjectIntoFile(Object o, String filename)
        {
            try
            {
                String path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                path += "\\AppData\\Local\\Book Manager\\";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                path += "\\" + filename;
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                FileStream fileStream;
                BinaryFormatter bf = new BinaryFormatter();
                fileStream = File.Create(path);
                bf.Serialize(fileStream, o);
                fileStream.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("File Not Write " + ex.Message, "Filing Error");
            }
        }
        public static object GetObjectIntoFile(String filename)
        {
            object o = null;
            try
            {
                String path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                path += "\\AppData\\Local\\Book Manager\\";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                path = path + "\\" + filename;
                if (File.Exists(path))
                {
                    FileStream fileStream;
                    BinaryFormatter bf = new BinaryFormatter();
                    fileStream = File.OpenRead(path);
                    o = bf.Deserialize(fileStream);
                    fileStream.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("File Not Read " + ex.Message, "Filing Error");
            }
            return o;
        }
    }
}
