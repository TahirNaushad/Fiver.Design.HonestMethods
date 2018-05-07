namespace Fiver.Design.HonestMethods
{
    public sealed class UploadImageResult
    {
        private UploadImageResult(bool hasUploaded, string failureMessage)
        {
            HasUploaded = hasUploaded;
            FailureMessage = failureMessage;
        }
  
        public bool HasUploaded { get; }

        public string FailureMessage { get; }

        public static UploadImageResult Success()
            => new UploadImageResult(true, "");

        public static UploadImageResult Fail(string failureMessage)
            => new UploadImageResult(false, failureMessage);
    }
}