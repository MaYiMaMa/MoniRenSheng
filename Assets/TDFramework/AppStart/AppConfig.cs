

namespace TDFramework
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class AppConfig
    {
        //应用开启，读取的配置文件
        public static string ApplicatioinConfigFileName = "ApplicationConfig.ini";
        //本地version.json文件相对路径
        public static string VersionFilePath = "Config/Version/version.json";
        //远程version.json下载地址
        public static string RemoteVersionFileUrl = "http://192.168.0.111:3333/" + VersionFilePath;
        //下载version.json的超时时间设置
        public static int DownloadVersionFileTimeout = 10;
        //下载version.json的最多次数
        public static int DownloadVersionFileFailedTryCount = 3;
        
    }
}