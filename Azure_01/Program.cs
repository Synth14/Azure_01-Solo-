using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azure_01
{
    class Program// ajouter des nuget storage azure
    {
        static void Main(string[] args)
        {
            CloudStorageAccount storageAcount = new CloudStorageAccount // on veut acceder a azure
           (new StorageCredentials("Gtm", "clé"),// la on a besoin des codes pour acceder on va les mettre entre (information qu'on recupere sur le compte azure)
            true);// on met ces deux parametres 
            CloudBlobClient blobClient = storageAcount.CreateCloudBlobClient(); //creer un compte client 
            CloudBlobContainer container = blobClient.GetContainerReference("image");

            CloudBlockBlob blockBlob = container.GetBlockBlobReference("blob1");
            using (var filestream = System.IO.File.OpenRead("s:\ali.jpg"));// des qu'on sort du system ,jessy detruit ce fichier la ,pour liberer de la place
                }
    }
}