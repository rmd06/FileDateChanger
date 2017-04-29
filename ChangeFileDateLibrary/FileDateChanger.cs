using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ChangeFileDateLib
{
    public class FileDateChanger
    {
        private FileInfo _fileInfo;

        public DateTime CreationTime { get; set; }
        public DateTime LastAccessTime { get; set; }
        public DateTime LastWriteTime { get; set; }

        public FileDateChanger(string filePath)
        {
            this._fileInfo = new FileInfo(filePath);
        }

        public void ChangeTimes()
        {
            ChangeCreationTime(CreationTime);
            ChangeLastAccessTime(LastAccessTime);
            ChangeLastWriteTime(LastWriteTime);
        }

        private void ChangeCreationTime(DateTime timeToSet)
        {
            _fileInfo.CreationTime = timeToSet;
        }

        private void ChangeLastAccessTime(DateTime timeToSet)
        {
            _fileInfo.LastAccessTime = timeToSet;
        }

        private void ChangeLastWriteTime(DateTime timeToSet)
        {
            _fileInfo.LastWriteTime = timeToSet;
        }
    }
}