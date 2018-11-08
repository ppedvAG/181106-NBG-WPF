using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMTextEditor.Models
{
    class FileService
    {
        public string OpenTextFile()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Textdatei | *.txt";

            if(dlg.ShowDialog() == true)
                return File.ReadAllText(dlg.FileName);
            throw new InvalidOperationException("Vorgang wurde abgebrochen");
        }

        public void SaveTextFile(string content)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Textdatei | *.txt";

            if (dlg.ShowDialog() == true)
                File.WriteAllText(dlg.FileName,content);
            else
                throw new InvalidOperationException("Vorgang wurde abgebrochen");
        }
    }
}
