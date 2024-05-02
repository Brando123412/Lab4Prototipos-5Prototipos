using System;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]float time;
    bool pause = false;
    public static Action OnWin;
    public static Action OnLose;
    [SerializeField] UiManager uiManager;
    [SerializeField] PointSOController PSO;
    [SerializeField] HandlerHealtSO HHSO;

    void Awake()
    {
        Time.timeScale = 1;
        PSO.StartSOPointSO();
        HHSO.StartSOLifeSO();
    }
    private void Update()
    {
        UpdateTime();
    }
    void UpdateTime()
    {
        time = Time.time;
        uiManager.UpdateTime(time);
    }
    public void PauseGame()
    {
        if (!pause)
        {
            Time.timeScale = 0;
        }

    }
    public void Reintentar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void IrAMenu()
    {
        SceneManager.LoadScene(0);
    }
}
