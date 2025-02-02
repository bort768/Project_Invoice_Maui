﻿//using System;
//using System.Threading.Tasks;
//using System.IO;
//using UIKit;
//using QuickLook;
//using Microsoft.Maui.Controls;
//using Project_Invoice_MAUI.SaveFileHelper;

//[assembly: Dependency(typeof(SaveIOS))]

//class SaveIOS : ISave
//{
//    public async Task SaveAndView(string filename, string contentType, MemoryStream stream)
//    {
//        string exception = string.Empty;
//        string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
//        string filePath = Path.Combine(path, filename);
//        try
//        {
//            FileStream fileStream = File.Open(filePath, FileMode.Create);
//            stream.Position = 0;
//            stream.CopyTo(fileStream);
//            fileStream.Flush();
//            fileStream.Close();
//        }
//        catch (Exception e)
//        {
//            exception = e.ToString();
//        }
//        if (contentType == "application/html" || exception != string.Empty)
//            return;

//        UIViewController currentController = UIApplication.SharedApplication.KeyWindow.RootViewController;
//        while (currentController.PresentedViewController != null)
//            currentController = currentController.PresentedViewController;
//        UIView currentView = currentController.View;

//        QLPreviewController qlPreview = new QLPreviewController();
//        QLPreviewItem item = new QLPreviewItemBundle(filename, filePath);
//        qlPreview.DataSource = new ControllerDS(item);
//        currentController.PresentViewController((UIViewController)qlPreview, true, (Action)null);
//    }

//    private string GetMimeType(string filename)
//    {
//        if (string.IsNullOrEmpty(filename))
//        {
//            return null;
//        }

//        var extension = Path.GetExtension(filename.ToLowerInvariant());

//        switch (extension)
//        {
//            case "png":
//                return "image/png";
//            case "doc":
//                return "application/msword";
//            case "pdf":
//                return "application/pdf";
//            case "jpeg":
//            case "jpg":
//                return "image/jpeg";
//            case "zip":
//            case "docx":
//            case "xlsx":
//            case "pptx":
//                return "application/zip";
//            case "htm":
//            case "html":
//                return "text/html";
//        }

//        return "application/octet-stream";
//    }

//}