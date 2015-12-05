﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class single_multi : MonoBehaviour
{
    public Canvas quitMenu;
    public Button PlaySingle;
    public Button exitText;
    public Button PlayMulti;
    public GameObject SinglePlayer;
    public GameObject Multi;
    public GameObject Quit;


    void Start()
    {
        quitMenu = quitMenu.GetComponent<Canvas>();
        exitText = exitText.GetComponent<Button>();
        PlaySingle = PlaySingle.GetComponent<Button>();
        PlayMulti = PlayMulti.GetComponent<Button>();
        quitMenu.enabled = false;

    }
    public void exitPress()
    {
        quitMenu.enabled = true;
        exitText.enabled = false;
        PlaySingle.enabled = false;
        PlayMulti.enabled = false;
        SinglePlayer.SetActive(false);
        Multi.SetActive(false);
        Quit.SetActive(false);
    }

    public void NoPress()
    {
        quitMenu.enabled = false;
        exitText.enabled = true;
        PlaySingle.enabled = true;
        PlayMulti.enabled = true;
        SinglePlayer.SetActive(true);
        Multi.SetActive(true);
        Quit.SetActive(true);
    }
    public void SinglePress()
    {
        Application.LoadLevel("Calibration");
    }
    public void MultiPress()
    {
        Application.LoadLevel("Calibration");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
