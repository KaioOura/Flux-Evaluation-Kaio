using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

#if UNITY_EDITOR
public class ColorCreator : EditorWindow
{
    List<Color> colors = new List<Color>();

    ColorPicker colorPicker;

    bool beginSelect;

    [MenuItem("Window/Tools/ColorCreator")]
    public static void ShowWindow()
    {
        GetWindow<ColorCreator>("Color Creator Tool");
    }

    private void OnGUI()
    {
        GUILayout.Label("Create new colors below!", EditorStyles.boldLabel);

        GUILayout.Space(20);

        Object[] selection = Selection.GetFiltered(typeof(ColorPicker), SelectionMode.Assets);
        Object[] colorSelection = Selection.GetFiltered(typeof(Color), SelectionMode.Assets);


        //if (selection.Length > 0)
        //{
        //    colors.Clear();

        //    ColorPicker cp = selection[0] as ColorPicker;
        //    foreach (var item in cp.colors)
        //    {
        //        colors.Add(item);
        //    }

        //    if (colors.Count > 0)
        //    {
        //        for (int i = 0; i < colors.Count; i++)
        //        {
        //            colors[i] = EditorGUILayout.ColorField("Color", colors[i]);

        //        }
        //    }

        //}
        //else
        {
            // colors.Clear();

            if (colors.Count > 0)
            {
                for (int i = 0; i < colors.Count; i++)
                {
                    colors[i] = EditorGUILayout.ColorField("Color", colors[i]);

                }
            }
        }


        if (GUILayout.Button("Add new color"))
        {
            colors.Add(new Color());

            //if (selection.Length > 0)
            //{
            //    ColorPicker cp = selection[0] as ColorPicker;

            //    cp.colors.Add(new Color());

            //    foreach (var item in cp.colors)
            //    {
            //        colors.Add(item);
            //    }
            //}

        }

        if (GUILayout.Button("Remove color"))
        {
            colors.Remove(colors[colors.Count - 1]);
            //if (selection.Length > 0)
            //{
            //    ColorPicker cp = selection[0] as ColorPicker;

            //    cp.colors.Remove(cp.colors[cp.colors.Count - 1]);

            //    foreach (var item in cp.colors)
            //    {
            //        colors.Add(item);
            //    }
            //}

        }

        if (GUILayout.Button("Send colors"))
        {
            //colors.Add(new Color());
            if (selection.Length > 0)
            {
                ColorPicker cp = selection[0] as ColorPicker;

                cp.colors.Clear();

                foreach (var item in colors)
                {
                    cp.colors.Add(item);
                }
            }

        }

    }
}
#endif
