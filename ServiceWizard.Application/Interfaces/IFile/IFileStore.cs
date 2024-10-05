namespace ServiceWizard.Application.Interfaces.IFile
{
    public interface IFileStore
    {
        string SafeWriteFile(byte[] data, string sourceFileName, string path);
    }
}
