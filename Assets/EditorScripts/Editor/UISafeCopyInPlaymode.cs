using UnityEngine;
using System.Collections;
using UnityEditor;
using UnityEngine.UI;

[CustomEditor(typeof(Canvas))]
public class UISafeCopyInPlaymode : Editor 
{
    //Note this script will override the prefab if it exists already.
    string uiPath = "Assets/";
    string cloneName = "will be set automaticaly";

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector ();

        if(GUILayout.Button("Save UI during Playmode!")){
            cloneTheUI();
        }
    }

    void cloneTheUI(){
        Canvas myTarget = (Canvas)target;
        cloneName = myTarget.transform.name+".prefab";
        PrefabUtility.SaveAsPrefabAsset(myTarget.gameObject, uiPath + cloneName);
        Debug.Log("Saved here: " + uiPath+cloneName);
    }
}