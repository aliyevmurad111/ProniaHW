using Microsoft.AspNetCore.Http;
using Pronia.Buisness.Exceptions;
using Pronia.Buisness.Services.Interfaces;
using Pronia.Buisness.Utilities;
using Pronia.Core.Entities;

namespace Pronia.Buisness.Services.Implementations;

public class FileService : IFileService
{
    public void RemoveFile(string root, string filePath)
    {
        string fileroot = Path.Combine(root,filePath);
        if (File.Exists(fileroot))
        {
            File.Delete(fileroot);
        }
    }

    public async Task<string> UploadFile(IFormFile file, string root, int kb,params string[] folders)
    {
        if (!file.CheckFileSize(kb))
        {
            throw new FileSizeException("File Size must be less than 300kb");
        }
        if (!file.CheckFileType("image"))
        {
            {
                throw new FileTypeException("Choose an image type");  
            }
        }
        string folderRoot = string.Empty;
        foreach (var folder in folders)
        {
            folderRoot = Path.Combine(folderRoot, folder);
        }
        string filename = await file.UploadFile(root,folderRoot); 
        return filename;
    }
}
