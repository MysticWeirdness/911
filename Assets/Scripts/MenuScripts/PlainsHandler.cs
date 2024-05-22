using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlainsHandler : MonoBehaviour
{
    [SerializeField] private List<Button> levels = new List<Button>();

    private void Start()
    {
        if (PlayerPrefs.GetInt("L1") == 1)
        {
            levels[1].interactable = true;
        }
        if (PlayerPrefs.GetInt("L2") == 1)
        {
            levels[2].interactable = true;
        }
        if (PlayerPrefs.GetInt("L3") == 1)
        {
            levels[3].interactable = true;
        }
    }
}
