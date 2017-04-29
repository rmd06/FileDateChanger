using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ChangeFileDateLib
{
    public class FileDateChanger
    {
        private FileInfo fileInfo;

        public FileDateChanger(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
        }
        public void ChangeCreationTime(DateTime timeToSet)
        {
            fileInfo.CreationTime = timeToSet;
        }

        public void ChangeLastAccessTime(DateTime timeToSet)
        {
            fileInfo.LastAccessTime = timeToSet;
        }

        public void ChangeLastWriteTime(DateTime timeToSet)
        {
            fileInfo.LastWriteTime = timeToSet;
        }
    }
}