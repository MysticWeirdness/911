using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject PauseMenu;
    [SerializeField] private TextMeshProUGUI currencyText;
    public int enemiesReached = 0;
    private int currency = 200;
    public void EnemyReachedTheEnd()
    {
        enemiesReached++;
        if(enemiesReached >= 3)
        {
            Restart();
        }
    }

    public void ChangeCurrency(int amt)
    {
        currency += amt;
        UpdateUI();
    }
    private void Restart()
    {

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }

    private void UpdateUI()
    {
        currencyText.text = "$" + currency.ToString();
    }

    private void Pause()
    {
        Time.timeScale = 0;
        PauseMenu.SetActive(true);
    }

    public void Unpause()
    {
        Time.timeScale = 1;
        PauseMenu.SetActive(false);
    }

    public int GetCurrency()
    {
        return currency;
    }
}