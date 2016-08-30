using System;
using UnityEngine;
using System.Collections;
using System.IO;


/*
 * JSFileLoader
 * All js files are loaded by this class.
 */
public static class JSFileLoader
{
	private static AssetBundle _jsCodeBundle;

	public static void StartLoading(){
		if (!JSEngine.inst.loadBundle)
			return;
		_jsCodeBundle = AssetBundle.LoadFromFile (Application.streamingAssetsPath + "/jscode");
	}

	public static void EndLoading(){
		if (!JSEngine.inst.loadBundle)
			return;

		_jsCodeBundle.Unload (false);
		_jsCodeBundle = null;
	}

    public static byte[] LoadJSSync(string scriptName)
    {
        string filePath = GetJsScriptPath(scriptName);
        try
        {
			if(JSEngine.inst.loadBundle){
				if(_jsCodeBundle != null){
					var asset = _jsCodeBundle.LoadAsset(filePath) as TextAsset;
					return asset.bytes;
				}
				else
					throw new Exception("_jsCodeBundle is null");
			}else{
            	return File.ReadAllBytes(filePath);
			}
        }
        catch (Exception e)
        {
            Debug.LogError(e.Message);
            return null;
        }
    }

    /// <summary>
    /// Gets the full name of the javascript file.
    /// </summary>
    /// <param name="jsScriptName">The short name.</param>
    /// <returns></returns>
    public static string GetJsScriptPath(string jsScriptName)
    {
		if (JSEngine.inst.loadBundle)
			return Path.GetFileNameWithoutExtension (jsScriptName);
		
        if (jsScriptName.EndsWith(".json"))
            return jsScriptName;

        string minPath = JSPathSettings.jsDir + "/" + jsScriptName + ".min" + JSPathSettings.jsExtension;
        if (File.Exists(minPath))
        {
            return minPath;
        }
        return JSPathSettings.jsDir + "/" + jsScriptName + JSPathSettings.jsExtension;
    }
}
