/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OwlCommunity.Classes;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace OwlCommmunity.Classes
{
    public static class SFManager
    {
        // This class manages s serializable file object by reading from and writing to a file

        // Write the Person List to file as a serialized binary object
        public static bool writeToFile(OwlMemberList plist, string fn)
        {
            Stream thisFileStream;
            BinaryFormatter serializer = new BinaryFormatter();

            if (plist.Count() > 0)
            {
                try
                {
                    thisFileStream = File.Create(fn);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File open error: Owl Member List not written", "SFManager File Open");
                    MessageBox.Show(ex.ToString());
                    return false;
                }

                try
                {
                    serializer.Serialize(thisFileStream, plist);
                    MessageBox.Show("File write: Owl Member List was written to serializable file.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File write error: Owl Member List not written", "SFManager File Write");
                    MessageBox.Show(ex.ToString());
                    return false;
                }
                finally
                {
                    thisFileStream.Close();
                }
            }
            else
            {
                MessageBox.Show("No Owl Member in List");
            }

            return true;  

        } 


        // Read the Person List from file as a serialized binary object
        public static bool readFromFile(ref OwlMemberList plist, string fn)
        {
            Stream TestFileStream;
            BinaryFormatter deserializer = new BinaryFormatter();

            if (File.Exists(fn))
            {
                try
                {
                    TestFileStream = File.OpenRead(fn);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File open error: Open with new Owl Member List", "SFManager, File Open");
                    plist = new Classes.OwlMemberList();
                    return false;
                } 

                try
                {
                    plist = (OwlMemberList)deserializer.Deserialize(TestFileStream);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File read error: Open with new Owl Member List", "SFManager File Read");
                    plist = new Classes.OwlMemberList();
                    return false;
                }
                finally
                {
                    TestFileStream.Close();
                }  
            }  
            else
            {
                MessageBox.Show("File does not exist: Open with new Owl Member List", "SF Manager Exists ");
                plist = new Classes.OwlMemberList();
            }  

            return true;   // The file read succeeded

        }  

    }  
}  
*/