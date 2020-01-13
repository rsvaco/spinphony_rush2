using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Podio : MonoBehaviour
{
    public Text textVictoria;
    Dictionary<string, int> ganadores = new Dictionary<string, int>();
    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < PlayerPrefs.GetInt("totalrondas"); i++)
        {
            ganadores[PlayerPrefs.GetString("ganador" + i)] = 0;
        }
        for (int i = 0; i < PlayerPrefs.GetInt("totalrondas"); i++) {
            ganadores[PlayerPrefs.GetString("ganador" + i)] = ganadores[PlayerPrefs.GetString("ganador" + i)] + 1;
        }

        int max = 0;
        string ganador = "";

        foreach (string s in ganadores.Keys) {
            if (ganadores[s] > max) {
                max = ganadores[s];
                ganador = s;
            }
        }

        textVictoria.text = ganador;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
