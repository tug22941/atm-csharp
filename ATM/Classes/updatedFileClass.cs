using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ATM
{
    class updatedFileClass
    {
        
        private string updatedFilePath;     //holds the file path of the updated file document
        private StreamWriter updatedFileSW; //streamwriter object neede to write to the update file
        private int recordsWrittenCount;    //tracks the number of record written to the updated file

        //default constructor that accepts a file path for the updated ATM bank records
        public updatedFileClass(string filePath)
        {
            recordsWrittenCount = 0;
            updatedFilePath = filePath;
            try
            {
                updatedFileSW = new StreamWriter(filePath, true);
            }
            catch
            {
                MessageBox.Show("Cannot open file" + updatedFilePath + " \n Terminate Program.",
                            "Output File Connection Error.",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }//end of default constructor

        ///////////////PROPERTIES///////////////
        
        //property responsible for reading the the count of records written to the updated file
        public int RecordsWrittenCount
        {
            get { return recordsWrittenCount; }
        }

        ///////////////METHODS///////////////
        
        //method responsible for writing the next record from the current file to the updated file
        public void writeNextRecord(string nextRecord)
        {
            //write record line using the streamreader, iterate records written count
            updatedFileSW.WriteLine(nextRecord);
            recordsWrittenCount++;
        }

        //method responsible for closing the updated file stream writer object and stream
        //and releasing the associated system resources
        public void closeFile()
        {
            updatedFileSW.Close();
        }

        //method responsible for resetting the updated file stream writer to the beginning of the file
        public void rewindFile()
        {
            recordsWrittenCount = 0;
            //create new stream writer, release buffered data in stream writer, reset the origin of the base stream
            updatedFileSW = new StreamWriter(updatedFilePath);
            updatedFileSW.Dispose();
            updatedFileSW.BaseStream.Seek(0, SeekOrigin.Begin);
        }

        public void dipsoseFile()
        {
            updatedFileSW.Dispose();
        }
    }
}
