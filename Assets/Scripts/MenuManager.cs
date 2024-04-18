using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    private enum sceneNames
    {
        Main_Menu = 2,
        Menu_Settings = 3,
        Credits = 4,
        World_Select = 5,
        Plains = 6,
        A_New_Beginning = 7,
        On_Your_Way = 8,
        Ramping_Up = 9,
        Grass_Eater = 10,
        Deep_Forest = 11,
        Into_The_Woods = 12,
        Downhill_Doozy = 13,
        Ancient_Temple = 14,
        MUUSHROOM = 15,
        Sandy_Dunes = 16,
        Getting_Warm = 17,
        Quick_Quicksand = 18,
        Secret_Civilization = 19,
        Senor_Cactus = 20,
        Clouds = 21,
        Windy_Way = 22,
        Rainy_Day = 23,
        Stormy_Night = 24,
        Thunder_Triplets = 25,
        Lava = 26,
        Watch_Your_Step = 27,
        Treacherous_Trap = 28,
        Into_The_Castle = 29,
        King_Kane = 30,
        Paused_Settings = 31
    }

    public void Main_Menu()
    {
        SceneManager.LoadSceneAsync((int)sceneNames.Main_Menu);
    }

    public void Menu_Settings()
    {
        SceneManager.LoadSceneAsync((int)sceneNames.Menu_Settings);
    }

    public void Credits()
    {
        SceneManager.LoadSceneAsync((int)sceneNames.Credits);
    }

    public void World_Select()
    {
        SceneManager.LoadSceneAsync((int)sceneNames.World_Select);
    }

    public void Plains()
    {
        SceneManager.LoadSceneAsync((int)sceneNames.Plains);
    }

    public void A_New_Beginning()
    {
        SceneManager.LoadSceneAsync((int)sceneNames.A_New_Beginning);
    }

    public void On_Your_Way()
    {
        SceneManager.LoadSceneAsync((int)sceneNames.On_Your_Way);
    }

    public void Ramping_Up()
    {
        SceneManager.LoadSceneAsync((int)sceneNames.Ramping_Up);
    }

    public void Grass_Eater()
    {
        SceneManager.LoadSceneAsync((int)sceneNames.Grass_Eater);
    }

    public void Deep_Forest()
    {
        SceneManager.LoadSceneAsync((int)sceneNames.Deep_Forest);
    }

    public void Into_The_Woods()
    {
        SceneManager.LoadSceneAsync((int)sceneNames.Into_The_Woods);
    }

    public void Downhill_Doozy()
    {
        SceneManager.LoadSceneAsync((int)sceneNames.Downhill_Doozy);
    }

    public void Ancient_Temple()
    {
        SceneManager.LoadSceneAsync((int)sceneNames.Ancient_Temple);
    }

    public void MUUSHROOM()
    {
        SceneManager.LoadSceneAsync((int)sceneNames.MUUSHROOM);
    }

    public void Sandy_Dunes()
    {
        SceneManager.LoadSceneAsync((int)sceneNames.Sandy_Dunes);
    }

    public void Getting_Warm()
    {
        SceneManager.LoadSceneAsync((int)sceneNames.Getting_Warm);
    }

    public void Quick_Quicksand()
    {
        SceneManager.LoadSceneAsync((int)sceneNames.Quick_Quicksand);
    }

    public void Secret_Civilization()
    {
        SceneManager.LoadSceneAsync((int)sceneNames.Secret_Civilization);
    }

    public void Senor_Cactus()
    {
        SceneManager.LoadSceneAsync((int)sceneNames.Senor_Cactus);
    }

    public void Clouds()
    {
        SceneManager.LoadSceneAsync((int)sceneNames.Clouds);
    }

    public void Windy_Way()
    {
        SceneManager.LoadSceneAsync((int)sceneNames.Windy_Way);
    }

    public void Rainy_Day()
    {
        SceneManager.LoadSceneAsync((int)sceneNames.Rainy_Day);
    }

    public void Stormy_Night()
    {
        SceneManager.LoadSceneAsync((int)sceneNames.Stormy_Night);
    }

    public void Thunder_Triplets()
    {
        SceneManager.LoadSceneAsync((int)sceneNames.Thunder_Triplets);
    }

    public void Lava()
    {
        Debug.Log("Lava");
        SceneManager.LoadSceneAsync((int)sceneNames.Lava);
    }

    public void Watch_Your_Step()
    {
        SceneManager.LoadSceneAsync((int)sceneNames.Watch_Your_Step);
    }

    public void Treacherous_Trap()
    {
        SceneManager.LoadSceneAsync((int)sceneNames.Treacherous_Trap);
    }

    public void Into_The_Castle()
    {
        SceneManager.LoadSceneAsync((int)sceneNames.Into_The_Castle);
    }

    public void King_Kane()
    {
        SceneManager.LoadSceneAsync((int)sceneNames.King_Kane);
    }

    public void Paused_Settings()
    {
        SceneManager.LoadSceneAsync((int)sceneNames.Paused_Settings);
    }
}
