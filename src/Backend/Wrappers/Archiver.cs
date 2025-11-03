using System;
using System.IO;
using System.Threading.Tasks;
using SharpCompress.Archives;
using SharpCompress.Readers;

namespace Backend.Wrappers
{
    /// <summary>
    /// Class for working with archives.
    /// </summary>
    public sealed class Archiver
    {
        /// <summary>
        /// Unpacking progress.
        /// </summary>
        public IProgress<double> Progress { get; } = new Progress<double>();

        /// <summary>
        /// Extract archive to folder.
        /// </summary>
        /// <param name="pathToArchive">The archive to extract.</param>
        /// <param name="extractTo">The folder to extract into.</param>
        /// <param name="password">Archive password (optional).</param>
        /// <returns>Operation result.
        /// <br/>
        /// If <see cref="Result.Status"/> is <see cref="ResultEnum.NotEnoughSpace"/>, <see cref="Result.Message"/> contains required free space.</returns>
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

        /// <inheritdoc cref="ExtractArchive"/>
        public async Task<Result> ExtractArchiveAsync(string pathToArchive, string extractTo, string password = null)
        {
            try
            {
                var unpackResult = await Task.Run(() => 
                { 
                    return ExtractArchive(pathToArchive, extractTo, password);
                });

                return unpackResult;
            }
            catch (Exception ex)
            {
                return new Result(ResultEnum.GeneralFailure, ex);
            }
        }
    }
}