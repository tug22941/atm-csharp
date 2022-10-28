using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ATM
{
    class currentFileClass
    {
        private string currentFilePath;     // holds the file path of the current file document
        private StreamReader currentFileSR; // streamreader object needed to read the current file document
        private int recordsReadCount;        // tracks the number of record read in the current file document
            
        //default constructor that accepts a file path for the current ATM bank records
        public currentFileClass(string filePath)
        {
            recordsReadCount = 0;
            currentFilePath = filePath;
            //attempt to read the current file path using the stream reader object
            try { 
                currentFileSR = new StreamReader(currentFilePath); 
            }
            catch {
                MessageBox.Show("Cannot open file" + currentFilePath + "Terminate Program.",
                                "Output File Connection Error.",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }//end of defualt constructor


        ///////////////PROPERTIES///////////////

        //property responsible for reading the count of the current file records read
        public int RecordsReadCount
        {
            get { return recordsReadCount; }
        }



        ///////////////METHODS///////////////
        
        //method responsible for returning the next record in the currentFile
        public string getNextRecord(ref bool endOfFlag)
        {
            //for as long as there is a reacord to read in the stream reader
            //read from the stream reader and iterate the record read count
            endOfFlag = false;
            string nextRecord = currentFileSR.ReadLine();

            if (nextRecord == null)
            {
                endOfFlag = true;
            }
            else
            {
                recordsReadCount++;
            }
            return nextRecord;  //return the newly read next record
        }

        //method responsible for closing the stream reader objec & stream
        //and releasing associated system resources
        public void closeFile()
        {
            currentFileSR.Close();
        }

        //method responsible for resetting the stream reader to the beginning of the file
        public void rewindfile()
        {
            recordsReadCount = 0;
            //create new stream reader, clear the internal buffer, reset the origin of the base stream
            currentFileSR = new StreamReader(currentFilePath);
            currentFileSR.DiscardBufferedData();
            currentFileSR.BaseStream.Seek(0, SeekOrigin.Begin);
        }

    }
}
