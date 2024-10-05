namespace ServiceWizard.Application.Interfaces.IFile
{
    public interface IFileWrapper
    {
        void WriteAllBytes(string outputFile, byte[] data);
    }
}
