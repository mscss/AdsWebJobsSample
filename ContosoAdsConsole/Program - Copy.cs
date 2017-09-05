using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;

namespace ContosoAdsConsole
{
    class Program1
    {
        //static void Main(string[] args)
        //{
        //    //var StringToSign = VERB + "\n" +
        //    //                   Content-Encoding + "\n" +
        //    //                   Content-Language + "\n" +
        //    //                   Content-Length + "\n" +
        //    //                   Content-MD5 + "\n" +
        //    //                   Content-Type + "\n" +
        //    //                   Date + "\n" +
        //    //                   If-Modified-Since + "\n" +
        //    //                   If-Match + "\n" +
        //    //                   If-None-Match + "\n" +
        //    //                   If-Unmodified - Since + "\n" +
        //    //                   Range + "\n" +
        //    //                   CanonicalizedHeaders +
        //    //                   CanonicalizedResource;
        //    //Console.WriteLine("Please enter access key! /n");
        //    //var txt = Console.ReadLine();
        //    //Console.WriteLine(GetSharedBaseKey(txt, "StringToSign"));

        //    //Console.WriteLine(GenerateAuthorizationHeader("mscsssa", "images", "GET"));
        //    JobHost host = new JobHost();
        //    host.RunAndBlock();



        //    Console.ReadKey();
        //}


        static void Main1(string[] args)
        {
            JobHost host = new JobHost();
            host.RunAndBlock();
        }

        public static void CreateQueueMessages(
            [QueueTrigger("thumbnailrequest")] string queueMessage,
            [Queue("outputqueue")] ICollector<string> outputQueueMessage,
            TextWriter logger)
        {
            logger.WriteLine("Creating 2 messages in outputqueue");
            outputQueueMessage.Add(queueMessage + "1");
            outputQueueMessage.Add(queueMessage + "2");
        }


        //public static void GenerateThumbnail(
        //    [QueueTrigger("thumbnailrequest")] BlobInformation blobInfo,
        //    [Blob("images/{BlobName}", FileAccess.Read)] Stream input,
        //    [Blob("images/{BlobNameWithoutExtension}_thumbnail.jpg")] CloudBlockBlob outputBlob)
        //{
        //    using (Stream output = outputBlob.OpenWrite())
        //    {
        //        ConvertImageToThumbnailJPG(input, output);
        //        outputBlob.Properties.ContentType = "image/jpeg";
        //    }

        //    // Entity Framework context class is not thread-safe, so it must
        //    // be instantiated and disposed within the function.
        //    using (ContosoAdsContext db = new ContosoAdsContext())
        //    {
        //        var id = blobInfo.AdId;
        //        Ad ad = db.Ads.Find(id);
        //        if (ad == null)
        //        {
        //            throw new Exception(String.Format("AdId {0} not found, can't create thumbnail", id.ToString()));
        //        }
        //        ad.ThumbnailURL = outputBlob.Uri.ToString();
        //        db.SaveChanges();
        //    }
        //}

        //public static string GetSharedBaseKey(string secret,string message)
        //{

        //    secret = secret ?? "";
        //    var encoding = new System.Text.ASCIIEncoding();
        //    byte[] keyByte = encoding.GetBytes(secret);
        //    byte[] messageBytes = encoding.GetBytes(message);
        //    using (var hmacsha256 = new HMACSHA256(keyByte))
        //    {
        //        byte[] hashmessage = hmacsha256.ComputeHash(messageBytes);
        //        return Convert.ToBase64String(hashmessage);
        //    }
        //}

        //public static string GenerateAuthorizationHeader(string storageAccount,string containner,string requestMethod)
        //{
        //    var mxdate = DateTime.UtcNow.ToString("R");
        //    var storageKey = @"ea981RXkWh+kvvo5+KvWZfKlbJjOWqmsBDbbnwSwOGnJV/a6SYDcx/5DEAxrT3/+FHrVvA1hL6895yY23Zls+w==";
        //    //string canonicalizedResource = $"/{storageAccount}/Tables('{tablename}')";
        //    string canonicalizedResource = $"/{storageAccount}/{containner}";

        //    string contentType = "application/json";

        //    string stringToSign = $"{requestMethod}\n\n{contentType}\n{mxdate}\n{canonicalizedResource}";

        //    HMACSHA256 hmac = new HMACSHA256(Convert.FromBase64String(storageKey));

        //    string signature = Convert.ToBase64String(hmac.ComputeHash(Encoding.UTF8.GetBytes(stringToSign)));

        //    String authorization = String.Format("{0} {1}:{2}",
        //        "SharedKey",
        //        storageAccount,
        //        signature
        //    );

        //    return authorization;
        //}

    }
}
