using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ChangeFileDateLib
{
    public class FileDateChanger
    {
        private FileInfo fileInfo;

        public DateTime CreationTime { get; set; }
        public DateTime LastAccessTime { get; set; }
        public DateTime LastWriteTime { get; set; }

        public FileDateChanger(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
        }

        public void ChangeTimes()
        {
            ChangeCreationTime(CreationTime);
            ChangeLastAccessTime(LastAccessTime);
            ChangeLastWriteTime(LastWriteTime);
        }

        private void ChangeCreationTime(DateTime timeToSet)
        {
            fileInfo.CreationTime = timeToSet;
        }

        private void ChangeLastAccessTime(DateTime timeToSet)
        {
            fileInfo.LastAccessTime = timeToSet;
        }

        private void ChangeLastWriteTime(DateTime timeToSet)
        {
            fileInfo.LastWriteTime = timeToSet;
        }
    }
}