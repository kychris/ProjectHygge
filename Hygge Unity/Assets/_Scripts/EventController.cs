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


}
