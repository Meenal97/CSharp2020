using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CSharpBasic.TryCatch
{
    public class TryCatchFinally
    {
        
        public void ReaderFromFile()
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"C:\Users\Meenal\Documents\sample\Hello.txt");
                Console.WriteLine(streamReader.ReadToEnd());
              
            }
            catch (FileNotFoundException expection)
            {
                Console.WriteLine(expection.Message);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(expection.StackTrace);
                Console.WriteLine();
                Console.WriteLine(expection.FileName + " not found");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine();
            }
            finally
            {
                if(streamReader != null)
                {
                    streamReader.Close();
                }
               
            }
        }


    }
}
