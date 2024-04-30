using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class UFOGenerator : MonoBehaviour
{
    [SerializeField] private GameObject UFO;

    private async void Start()
    {
        await Timer();
    }

    private async Task Timer()
    {
        await Task.Delay(500);
        Instantiate(UFO);
        //await Timer();
    }

}
