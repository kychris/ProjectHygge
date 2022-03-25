using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventController : MonoBehaviour
{
    [Space(10)]
    public Material[] colors;
    public Light light;
    public int colorIndex = 0;

    [Header("Creatures")]
    public GameObject[] plants;
    public GameObject[] animals;
    private bool plantsEnabled = true;
    private bool animalsEnabled = true;

    [Header("Scale Objects")]
    public GameObject[] scaleObjects;
    public Vector3 scales;
    private bool xScaled = false;
    private bool yScaled = false;
    private bool zScaled = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    [ContextMenu("Change Color")]
    void ChangeColor()
    {
        colorIndex += 1;
        colorIndex = colorIndex % 3;
    }

    [ContextMenu("Show/Hide plants")]
    void ShowHidePlants()
    {
        for (int i = 0; i < plants.Length; i++)
        {
            plants[i].SetActive(!plantsEnabled);
            plantsEnabled = !plantsEnabled;
        }
    }

    [ContextMenu("Show/Hide animals")]
    void ShowHideAnimals()
    {
        for (int i = 0; i < animals.Length; i++)
        {
            animals[i].SetActive(!animalsEnabled);
            animalsEnabled = !animalsEnabled;
        }
    }

    [ContextMenu("Scale/Unscale x")]
    void ScaleUnscaleX()
    {
        for (int i = 0; i < scaleObjects.Length; i++)
        {
            Vector3 initialScale = scaleObjects[i].transform.localScale;

            if (!xScaled)
            {
                scaleObjects[i].transform.localScale = new Vector3(scales[0], initialScale.y, initialScale.z);
                xScaled = true;
            }
            else
            {
                scaleObjects[i].transform.localScale = new Vector3(1, initialScale.y, initialScale.z);
                xScaled = false;
            }
        }
    }

    [ContextMenu("Scale/Unscale y")]
    void ScaleUnscaleY()
    {
        for (int i = 0; i < scaleObjects.Length; i++)
        {
            Vector3 initialScale = scaleObjects[i].transform.localScale;

            if (!yScaled)
            {
                scaleObjects[i].transform.localScale = new Vector3(initialScale.x, scales[1], initialScale.z);
                yScaled = true;
            }
            else
            {
                scaleObjects[i].transform.localScale = new Vector3(initialScale.x, 1, initialScale.z);
                yScaled = false;
            }
        }
    }

    [ContextMenu("Scale/Unscale z")]
    void ScaleUnscaleZ()
    {
        for (int i = 0; i < scaleObjects.Length; i++)
        {
            Vector3 initialScale = scaleObjects[i].transform.localScale;

            if (!zScaled)
            {
                scaleObjects[i].transform.localScale = new Vector3(initialScale.x, initialScale.y, scales[2]);
                zScaled = true;
            }
            else
            {
                scaleObjects[i].transform.localScale = new Vector3(initialScale.x, initialScale.y, 1);
                zScaled = false;
            }
        }
    }


}
