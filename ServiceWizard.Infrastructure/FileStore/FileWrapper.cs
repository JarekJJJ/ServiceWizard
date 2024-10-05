using ServiceWizard.Application.Interfaces.IFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWizard.Infrastructure.FileStore
{
    public class FileWrapper : IFileWrapper
    {
        public void WriteAllBytes(string outputFile, byte[] data)
        {
            File.WriteAllBytes(outputFile, data);

        }
    }
}
