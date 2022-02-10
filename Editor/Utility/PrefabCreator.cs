namespace Tilia.SDK.SteamVR.Utility
{
    using System.IO;
    using UnityEditor;
    using Zinnia.Utility;

    public class PrefabCreator : BasePrefabCreator
    {
        private const string group = "Tilia/";
        private const string menuItemRoot = topLevelMenuLocation + group + subLevelMenuLocation;

        private const string package = "io.extendreality.tilia.sdk.steamvr.unity";
        private const string baseDirectory = "Runtime";
        private const string prefabDirectory = "Prefabs";
        private const string prefabSuffix = ".prefab";

        private const string prefabCameraRigsSteamVR = "CameraRigs.SteamVR";

        [MenuItem(menuItemRoot + "CameraRigs/" + prefabCameraRigsSteamVR, false, priority)]
        private static void AddCameraRigsSteamVR()
        {
            string prefab = prefabCameraRigsSteamVR + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, prefab);
            CreatePrefab(packageLocation);
        }
    }
}