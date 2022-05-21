using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ResourcesLoad : MonoBehaviour
{

    [SerializeField] private GameObject prefab;

    void Awake()
    {
        string prefabURL = Application.streamingAssetsPath + $"/bundlebuilds/prefabs/enviroment";
        AssetBundle prefabAB = AssetBundle.LoadFromFile(prefabURL);
        prefab = prefabAB.LoadAsset<GameObject>("Environment_Prefab");

        Instantiate(prefab, transform);
    }
}