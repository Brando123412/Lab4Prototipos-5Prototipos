using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiManager : MonoBehaviour
{
    [SerializeField] TMP_Text coins;
    [SerializeField] TMP_Text life;
    [SerializeField] TMP_Text time; 
    [SerializeField] TMP_Text timeFinal;
    [SerializeField] GameObject winPanel;
    [SerializeField] GameObject losePanel;
    [SerializeField] GameObject[] paneles;
    float timeFinalFloat;
    private void Awake()
    {
        HealthSystem.UpdateHealth += UpdateLife;
        PointSystem.UpdatePoints += UpdateCoins;
        GameManager.OnWin += ActivateWin;
        GameManager.OnLose += ActivateLose;
    }
    void UpdateCoins(int value)
    {
        coins.text = "Coins: "+value.ToString();
    }
    void UpdateLife(int value)
    {
        life.text = "Life: "+value.ToString();
    }
    public void UpdateTime(float value)
    {
        value = Mathf.Round(value);
        timeFinalFloat = value;
        time.text = "Time: " + value.ToString();
    }
    void ActivateWin()
    {
        winPanel.SetActive(true);
        paneles[0].SetActive(true);
        paneles[1].SetActive(true);
    }
    void ActivateLose()
    {
        timeFinal.text="Tiempo: " + timeFinalFloat.ToString();
        losePanel.SetActive(true);
        paneles[0].SetActive(true);
        paneles[1].SetActive(true);
    }
}
