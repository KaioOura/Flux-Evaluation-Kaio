using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

#if UNITY_EDITOR
public class ColorCreator : EditorWindow
{
    [SerializeField]
    List<Color> colors = new List<Color>();
    string[] strings;

    ColorPicker colorPicker;

    bool beginSelect;

    [MenuItem("Window/Tools/ColorCreator")]
    public static void ShowWindow()
    {
        ColorCreator window = (ColorCreator)GetWindow(typeof(ColorCreator));
        window.minSize = new Vector2(300, 200);
        window.maxSize = new Vector2(300, 600);
        window.Show();
    }

    private void OnGUI()
    {
        GUILayout.Label("Create new colors below!", EditorStyles.boldLabel);

        GUILayout.Space(20);

        GUILayout.BeginHorizontal();
        GUILayout.Label("Color Picker");
        colorPicker = (ColorPicker)EditorGUILayout.ObjectField(colorPicker, typeof(ColorPicker), false);
        GUILayout.EndHorizontal();

        GUILayout.Space(20);

         ScriptableObject target = this;
         SerializedObject so = new SerializedObject(target);
         SerializedProperty stringsProperty = so.FindProperty("colors");
 
         EditorGUILayout.PropertyField(stringsProperty, true);
         so.ApplyModifiedProperties();


        GUILayout.Space(20);

        if (GUILayout.Button("Get colors"))
        {
            if (colorPicker != null)
            {
                colors.Clear();

                foreach (var item in colorPicker.colors)
                {
                    colors.Add(item);
                }
            }
        }

        if (GUILayout.Button("Set colors"))
        {

            if (EditorUtility.DisplayDialog("Set new colors?","Are you sure you want to replace " + colorPicker.name + "?", "Yes, replace colors", "No"))
            {
                if (colorPicker != null)
                {

                colorPicker.colors.Clear();

                foreach (var item in colors)
                {
                    colorPicker.colors.Add(item);
                }
                }
            }
        
        }

    }
}
#endif
