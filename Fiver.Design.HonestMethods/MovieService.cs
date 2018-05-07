using System;

namespace Fiver.Design.HonestMethods
{
    public class MovieService
    {
        public bool UploadDocument(string fileName, string fileExtension)
        {
            if (string.IsNullOrEmpty(fileName))
                throw new ArgumentException("file name empty");
            if (string.IsNullOrEmpty(fileExtension))
                throw new ArgumentException("file extension empty");

            if (fileExtension == "pdf" || fileExtension == "doc" || fileExtension == "docx")
            {
                // upload

                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class MovieServiceHonest
    {
        public UploadImageResult UploadDocument(UploadFile file)
        {
            // upload

            // if failure when uploading
            //    UploadImageResult.Fail("<message>");

            return UploadImageResult.Success();
        }
    }
}
