using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FightConfiguration : MonoBehaviour
{
    public Button backButton, startButton;
    public InputField rondas;

    // Start is called before the first frame update
    void Start()
    {
        backButton.onClick.AddListener(OnClickBack);
        startButton.onClick.AddListener(OnClickStart);
    }

    private void OnClickStart()
    {
        int numrondas = int.Parse(rondas.text);
        PlayerPrefs.SetInt("totalrondas", numrondas);
        PlayerPrefs.SetInt("rondas", numrondas);
        SceneManager.LoadScene("Map Selection");
    }

    private void OnClickBack()
    {
        this.gameObject.SetActive(false);
    }


}
