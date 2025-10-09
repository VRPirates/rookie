using System;
using System.IO;
using SharpCompress.Archives;
using SharpCompress.Readers;

namespace Backend.Wrappers
{
    public sealed class Archiver
    {
        public IProgress<double> Progress { get; } = new Progress<double>();

        public Result ExtractArchive(string pathToArchive, string extractTo, string password = null)
        {
            try
            {
                using (var archive = ArchiveFactory.Open(pathToArchive, new ReaderOptions() { Password = password }))
                {
                    var diskInfo = new DriveInfo(Path.GetPathRoot(extractTo));

                    if (diskInfo != null && archive.TotalUncompressSize > diskInfo.AvailableFreeSpace)
                    {
                        return new Result(ResultEnum.NotEnoughSpace, $"{(int)(archive.TotalUncompressSize / 1000 / 1000)}MBs");
                    }

                    archive.ExtractToDirectory(
                        extractTo,
                        Progress.Report
                        );
                }
            }
            catch (Exception ex)
            {
                return new Result(ResultEnum.GeneralFailure, ex);
            }

            return new Result(ResultEnum.Success);
        }
    }
}