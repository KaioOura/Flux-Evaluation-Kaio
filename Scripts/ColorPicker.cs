using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "ColorPicker", menuName = "ScriptableObjects/ColorPickerScriptableObject", order = 1)]
public class ColorPicker : ScriptableObject
{
    public List<Color> colors = new List<Color>();
}
