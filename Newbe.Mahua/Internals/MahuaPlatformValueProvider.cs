using System;
using System.IO;
using System.Linq;

namespace Newbe.Mahua.Internals
{
    /// <summary>
    /// ��ǰ���ƽ̨��Ϣ��ȡ
    /// </summary>
    internal static class MahuaPlatformValueProvider
    {
        internal static readonly Lazy<MahuaPlatform> CurrentPlatform =
            new Lazy<MahuaPlatform>(() =>
            {
                var mahuaPlatform = new IPlatformResolver[]
                        {new CqpPlatformResolver(), new MpqPlatformResolver(), new AmandaPlatformResolver()}
                    .FirstOrDefault(x => x.IsThis())?.MahuaPlatform;
                if (mahuaPlatform == null)
                {
                    throw new NotSupportMahuaPlatformExpcetion();
                }
                return mahuaPlatform.Value;
            });

        private static string GetCurrentDir() => Environment.CurrentDirectory;

        #region IPlatformResolver

        internal interface IPlatformResolver
        {
            MahuaPlatform MahuaPlatform { get; }
            bool IsThis();
        }

        class CqpPlatformResolver : IPlatformResolver
        {
            public MahuaPlatform MahuaPlatform { get; } = MahuaPlatform.Cqp;

            public bool IsThis()
            {
                var currentDir = GetCurrentDir();
                return File.Exists(Path.Combine(currentDir, "CQA.exe")) ||
                       File.Exists(Path.Combine(currentDir, "CQP.exe"));
            }
        }

        class MpqPlatformResolver : IPlatformResolver
        {
            public MahuaPlatform MahuaPlatform { get; } = MahuaPlatform.Mpq;

            public bool IsThis()
            {
                var currentDir = GetCurrentDir();
                return File.Exists(Path.Combine(currentDir, "Core.exe"));
            }
        }

        class AmandaPlatformResolver : IPlatformResolver
        {
            public MahuaPlatform MahuaPlatform { get; } = MahuaPlatform.Amanda;

            public bool IsThis()
            {
                var currentDir = GetCurrentDir();
                return File.Exists(Path.Combine(currentDir, "Amanda.exe"));
            }
        }

        #endregion
    }
}