using System.Collections;
using System.Collections.Generic;
//using UnityEditor.EditorTools;
//using UnityEditor.Rendering;
using UnityEngine.XR.Interaction.Toolkit;

using UnityEngine;
using UnityEngine.SceneManagement;

public class EventController : MonoBehaviour
{
    [Header("----------------------------------------")]
    public Material[] colors;
    public Light[] lights;
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
    public int roomIndex = 3;

    [Header("----------------------------------------")]
    public GameObject[] materialObjects;
    public Material[] materials;
    public int materialIndex = 0;

    [Header("----------------------------------------")]
    public GameObject[] noWindowWalls;
    public GameObject[] windowWalls;
    private bool noWindowWallsEnabled = false;
    private bool windowWallsEnabled = true;

    public void Start() 
    {
        roomIndex = rooms.Length - 1;
        ChangeRoom();
        TogglePlants();
        ToggleFurnitures();
        ChangeRoom();
        ToggleWindowWalls();
        ToggleNoWindowWalls();
    }

    [SerializeField] GameObject room;
    [SerializeField] GameObject canvas;
    [SerializeField] GameObject hand;

    [ContextMenu("Toggle Room/Canvas")]
    void startRoomActivity()
    {
        room.SetActive(true);
        canvas.GetComponent<Canvas>().enabled = false;
        hand.GetComponent<XRInteractorLineVisual>().enabled = false;
    }

    [ContextMenu("Change Color")]
    void ChangeColor()
    {
        for (int i = 0; i < lights.Length; i++) 
        {
            lights[i].color = colors[colorIndex].color;
        }
        colorIndex += 1;
        colorIndex = colorIndex % 3;
    }

    [ContextMenu("Show/Hide plants")]
    void TogglePlants()
    {
        for (int i = 0; i < plants.Length; i++)
        {
            plants[i].SetActive(!plantsEnabled);
        }
        plantsEnabled = !plantsEnabled;
    }

    [ContextMenu("Show/Hide animals")]
    void ToggleAnimals()
    {
        for (int i = 0; i < animals.Length; i++)
        {
            animals[i].SetActive(!animalsEnabled);
        }
        animalsEnabled = !animalsEnabled;
    }

    [ContextMenu("Show/Hide furnitures")]
    void ToggleFurnitures()
    {
        for (int i = 0; i < furnitures.Length; i++)
        {
            furnitures[i].SetActive(!furnituresEnabled);
        }
        furnituresEnabled = !furnituresEnabled;
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

    [ContextMenu("Toggle no window walls")]
    void ToggleNoWindowWalls()
    {
        for (int i = 0; i < noWindowWalls.Length; i++)
        {
            noWindowWalls[i].SetActive(!noWindowWallsEnabled);
        }
        noWindowWallsEnabled = !noWindowWallsEnabled;
    }

    [ContextMenu("Toggle window walls")]
    void ToggleWindowWalls()
    {
        for (int i = 0; i < windowWalls.Length; i++)
        {
            windowWalls[i].SetActive(!windowWallsEnabled);
        }
        windowWallsEnabled = !windowWallsEnabled;

    }
}


