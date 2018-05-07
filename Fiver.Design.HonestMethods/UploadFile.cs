using System;
using System.Linq;

namespace Fiver.Design.HonestMethods
{
    public sealed class UploadFile
    {
        public UploadFile(string fileName, string fileExtension)
        {
            if (string.IsNullOrEmpty(fileName))
                throw new ArgumentException("file name empty");
            if (string.IsNullOrEmpty(fileExtension))
                throw new ArgumentException("file extension empty");
            if (!IsValidFormat(fileExtension))
                throw new ArgumentException("incorrect file format");

            FileName = fileName;
            FileExtension = fileExtension;
        }

        public string FileName { get; }
        public string FileExtension { get; }
        private bool IsValidFormat(string fileExtension)
            => (new[] { "pdf", "doc", "docx" }).Contains(fileExtension)
    }
}
