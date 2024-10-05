using ServiceWizard.Application.Interfaces.IFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceWizard.Infrastructure.FileStore
{
    public class FileStore : IFileStore
    {
        private readonly IFileWrapper _fileWrapper;
        private readonly IDirectoryWrapper _directoryWrapper;
        public FileStore(IFileWrapper fileWrapper, IDirectoryWrapper directoryWrapper)
        {
            _fileWrapper = fileWrapper;
            _directoryWrapper = directoryWrapper;

        }
        public string SafeWriteFile(byte[] data, string sourceFileName, string path)
        {
            _directoryWrapper.CreateDirectory(path);
            var outputFile = Path.Combine(path, sourceFileName);
            _fileWrapper.WriteAllBytes(outputFile, data);

            return outputFile;
        }
    }
}
