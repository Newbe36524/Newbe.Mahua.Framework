﻿namespace Newbe.Mahua.ItemTemplateGenerator
{
    public interface IMahuaEventItemTemplateGenerator
    {
        /// <summary>
        /// 生成项模板，并返回生成的项模板zip文件物理路径
        /// </summary>
        /// <param name="mahuaEventInfo"></param>
        /// <returns></returns>
        string Generate(MahuaEventInfo mahuaEventInfo);
    }
}
