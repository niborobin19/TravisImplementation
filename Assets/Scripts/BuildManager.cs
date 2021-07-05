using UnityEditor;
using UnityEngine;

namespace BuildManager
{
    public class BuildManager
    {
        public static void MyBuild()
        {
            try
            {
                //BuildServer();
                BuildClient();

                Debug.Log($"<color=orange>Your Builds Client and Server are Ready ! </color>");
            }
            catch (System.Exception)
            {
                Debug.Log($"Build Failed !!!");
                throw;
            }
        }

        private static void BuildClient()
        {
            BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
            buildPlayerOptions.scenes = new[] { "Assets/Scenes/Travis.unity" };
            buildPlayerOptions.locationPathName = "Builds/Travis.exe";
            buildPlayerOptions.target = BuildTarget.StandaloneWindows;
            buildPlayerOptions.options = BuildOptions.None;

            BuildPipeline.BuildPlayer(buildPlayerOptions);
        }

        private static void BuildServer()
        {
            BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
            buildPlayerOptions.scenes = new[] { "Assets/Scenes/Server.unity" };
            buildPlayerOptions.locationPathName = "Builds/Server/Server.exe";
            buildPlayerOptions.target = BuildTarget.StandaloneWindows;
            buildPlayerOptions.options = BuildOptions.EnableHeadlessMode;

            BuildPipeline.BuildPlayer(buildPlayerOptions);
        }
    }
}