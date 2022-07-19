using Microsoft.Extensions.Caching.Memory;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System;
using System.IO;
//using System.Drawing;
using System.Windows.Media.Imaging;

namespace DynamicTestingWPF
{
    public class ImageCacher
    {
        IMemoryCache _memoryCache;
        private ImageModel? _imageModel;

        public ImageCacher(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
            _imageModel = null;
        }

        public BitmapImage ConvertByteArrayToImage(byte[] imageBytes)
        {
            BitmapImage bitmapImage = new BitmapImage();

            bitmapImage.BeginInit();
            bitmapImage.StreamSource = new MemoryStream(imageBytes);
            bitmapImage.DecodePixelWidth = 535;
            bitmapImage.EndInit();

            return bitmapImage;
        }

        public ImageModel GetImageFromCache(string filePath)
        {
            ImageModel imageModel;
            string fileName = Path.GetFileName(filePath);

            try
            {
                _memoryCache.TryGetValue(fileName, out imageModel);
            }
            catch
            {
                return null;
            }

            return imageModel;
        }

        public void CacheImage(string filePath)
        {
            ImageModel imageModel;

            //read timestamp
            DateTime fileLastEditDate = File.GetLastWriteTime(filePath);
            fileLastEditDate = fileLastEditDate.AddMilliseconds(-fileLastEditDate.Millisecond);

            //open file and read its contents into byte array
            byte[] imageByteArray = File.ReadAllBytes(filePath);
            imageModel = new ImageModel(filePath, "image/jpeg", imageByteArray, fileLastEditDate);

            //set cache options. Objects in memory cache will expire after 120 seconds
            var memoryCacheEntryOptions = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(120));

            //cache image using set. There's also Create, but we haven't tested that. The key is the imagePath
            _memoryCache.Set(Path.GetFileName(filePath), imageModel, memoryCacheEntryOptions);
        }

        public string GetImage(string imagePath)
        {
            string message = string.Empty;

            if(File.Exists(imagePath))
            {
                _memoryCache.TryGetValue(imagePath, out _imageModel);    //trying to get the specified image from the cache

                if(_imageModel == null)    //if it can't find the specified image in the cache, it chaches that image
                {
                    //read timestamp
                    DateTime fileLastEditDate = File.GetLastWriteTime(imagePath);
                    fileLastEditDate = fileLastEditDate.AddMilliseconds(-fileLastEditDate.Millisecond);

                    //open file and read its contents into byte array
                    byte[] imageByteArray = File.ReadAllBytes(imagePath);
                    _imageModel = new ImageModel(imagePath, "image/jpeg", imageByteArray, fileLastEditDate);

                    //set cache options. Objects in memory cache will expire after 120 seconds
                    var memoryCacheEntryOptions = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(120));

                    //cache image using set. There's also Create, but we haven't tested that. The key is the imagePath
                    _memoryCache.Set(imagePath, _imageModel, memoryCacheEntryOptions);

                    message = "Loading image from local drive";
                }
                else
                {
                    message = "Loading image from cache";
                }
            }
            else
            {
                throw new FileNotFoundException();
            }

            return message;
        }
    }
}
