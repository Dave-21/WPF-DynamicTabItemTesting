using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicTestingWPF
{
    public class ImageModel
    {
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
        public DateTime SubmitDate { get; set; }

        public ImageModel(string fileName, string contentType, byte[] imageContent, DateTime submitDate)
        {
            FileName = fileName;
            ContentType = contentType;
            Content = imageContent;
            SubmitDate = new DateTime(submitDate.Year, submitDate.Month, submitDate.Day, submitDate.Hour, submitDate.Minute, submitDate.Second, 0, DateTimeKind.Utc);
        }
    }
}
