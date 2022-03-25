using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Rendering;

using UnityEngine;
using UnityEngine.SceneManagement;

public class EventController : MonoBehaviour
{
    [Header("----------------------------------------")]
    public Material[] colors;
    public Light light;
    public int colorIndex = 0;

    [Header("----------------------------------------")]
    public GameObject[] plants;
    public GameObject[] animals;
    public GameObject[] furnitures;
    private bool plantsEnabled = true;
    private bool animalsEnabled = true;
    private bool furnituresEnabled = true;

    [Header("----------------------------------------")]
    public GameObject[] rooms;
    public int roomIndex;

    [Header("----------------------------------------")]
    public GameObject[] materialObjects;
    public Material[] materials;
    public int materialIndex = 0;

    // [Header("----------------------------------------")]


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

    [ContextMenu("Show/Hide furnitures")]
    void ShowHideFurnitures()
    {
        for (int i = 0; i < furnitures.Length; i++)
        {
            furnitures[i].SetActive(!furnituresEnabled);
            furnituresEnabled = !furnituresEnabled;
        }
    }

    [ContextMenu("Change room")]
    void ChangeRoom()
    {
        for (int i = 0; i < rooms.Length; i++)
        {
            rooms[i].SetActive(false);
        }
        roomIndex += 1;
        roomIndex = roomIndex % rooms.Length;
        rooms[roomIndex].SetActive(true);
    }

    [ContextMenu("Change Material")]
    void ChangeMaterial()
    {
        for (int i = 0; i < materialObjects.Length; i++)
        {
            materialObjects[i].GetComponent<MeshRenderer>().material = materials[materialIndex];
        }
        materialIndex += 1;
        materialIndex = materialIndex % 3;
    }

    [ContextMenu("Reset")]
    void ResetScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
