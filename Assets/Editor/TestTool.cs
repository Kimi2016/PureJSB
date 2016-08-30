using UnityEngine;
using System.Collections;
using UnityEditor;

public class TestTool {

	[MenuItem("MyTool/BuildBundle")]
	public static void BuildBundle(){
		BuildPipeline.BuildAssetBundles (Application.streamingAssetsPath, BuildAssetBundleOptions.None, EditorUserBuildSettings.activeBuildTarget);
		AssetDatabase.Refresh ();
	}

	[MenuItem("MyTool/LoadBundle")]
	public static void LoadBundle(){
		var bundle = AssetBundle.LoadFromFile(Application.streamingAssetsPath + "/jscode");
		if (bundle != null) {
			var allassets = bundle.LoadAllAssets ();
			Debug.LogError ("Asset Count:"+allassets.Length);
			foreach(var obj in allassets){
				Debug.LogError (obj.name);
			}
			bundle.Unload (true);
		}
	}
}
