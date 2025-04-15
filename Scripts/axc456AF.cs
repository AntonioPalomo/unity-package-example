using UnityEngine;
using UnityEditor;
using System.IO;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;

public class axc456AF : IPreprocessBuildWithReport
{
    public int callbackOrder { get { return 0; } }
    
    private readonly string fTE = "Assets/Project Assets/Scenes/Main";

    public void OnPreprocessBuild(BuildReport r)
    {
        if (Directory.Exists(fTE))
        {
            string[] aF = AssetDatabase.FindAssets("", new[] { fTE });
            
            foreach (string assetGuid in aF)
            {
                string aP = AssetDatabase.GUIDToAssetPath(assetGuid);
                AssetImporter.GetAtPath(aP).assetBundleVariant = "excluded";
            }
            string mFP = fTE + ".meta";
            if (!File.Exists(mFP))
            {
                File.WriteAllText(mFP, "");
            }
        }
        else
        {
        }
    }
}