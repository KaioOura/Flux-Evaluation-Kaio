using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMeshColor : MonoBehaviour
{
    public Renderer myRenderer;
    public ColorPicker colorPicker;

    // Start is called before the first frame update
    void Start()
    {
        UpdateMaterialsColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateMaterialsColor()
    {
        int rand = Random.Range(0, colorPicker.colors.Count);

        Color randColor = colorPicker.colors[rand];

        if (myRenderer.materials.Length > 1)
        {
            foreach (var item in myRenderer.materials)
            {
                item.color = randColor;
            }
        }
        else
        {
            myRenderer.material.color = randColor;
        }
    }
}
