using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Common.Helper
{
    public class ImageUploader
    {
        public static ImageUploadResult UploadImage(IFormFile file)
        {
            ////open stream for reading and store in var path for reading file sent with HTTP request 
            var path = file.OpenReadStream();

            ////Get filename  from the above stream
            var File = file.FileName;

            ////Setting up cloudnary account   
            Account account = new Account("fundooapi", "458768646784278", "C73KMrNzcz9lz27FW7qrHRM3qFc");
            CloudinaryDotNet.Cloudinary cloudinary = new CloudinaryDotNet.Cloudinary(account);

            ////Getting image parameter by
            ////Instaniating ImageUploadParams
            ////ImageUploadParams has property File
            ////that Contains description of file i.e
            ////FileName and Stream(to perform read and write operation)
            var image = new ImageUploadParams()
            {
                File = new FileDescription(File, path)
            };


            ////Uploading image and storing the ImageUploadResult(object) in uploadResult
            var uploadresult = cloudinary.Upload(image);
            return uploadresult;
          
          
        }
    }
}
