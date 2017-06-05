﻿using System.IO;
using System.Linq;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using Newbe.Mahua.Msbuild.Packers;
using NuGet;

namespace Newbe.Mahua.Msbuild
{
    /// <summary>
    /// Mahua插件打包任务
    /// </summary>
    public class MahuaPackTask : Task
    {
        /// <summary>
        /// 项目文件夹
        /// </summary>
        [Required]
        public string ProjectDirectory { get; set; }

        /// <summary>
        /// 生成配置
        /// </summary>
        [Required]
        public string Configuration { get; set; }

        /// <summary>
        /// 插件名称
        /// </summary>
        [Required]
        public string NewbePluginName { get; set; }

        /// <summary>
        /// Package文件夹
        /// </summary>
        [Required]
        public string PackageDirectory { get; set; }

        /// <summary>
        /// 需要打包的插件列表
        /// </summary>
        [Required]
        public MahuaPlatform[] MahuaPlatforms { get; set; }

        public override bool Execute()
        {
            var context = new MahuaPluginPackContext
            {
                NewbePluginName = NewbePluginName,
                PackageDirectory = PackageDirectory,
                ProjectDirectory = ProjectDirectory,
                Configuration = Configuration
            };
            IMahuaPluginPackerFactory factory = new MahuaPluginPackerFactory();
            return MahuaPlatforms
                .Select(mahuaPlatform => factory.Create(mahuaPlatform))
                .Select(mahuaPluginPacker => mahuaPluginPacker.Pack(context))
                .All(packResult => packResult);
        }
    }
}