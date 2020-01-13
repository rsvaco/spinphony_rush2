using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameRules : MonoBehaviour
{
    //private PhonySelector selector = PhonySelector.Instance;
    private int players;
    public int numRondas;
    public DataObject Data;

    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;

    public GameObject hud1;
    public GameObject hud2;
    public GameObject hud3;
    public GameObject hud4;

    public Text textoVictoria;
    public GameObject menuVictoria;
    public Button siguienteBoton;

    // Start is called before the first frame update
    void Start()
    {
        players = PlayerPrefs.GetInt("numJugadores");
        numRondas = PlayerPrefs.GetInt("rondas");
        print("numero de rondas restantes " + numRondas);
        if (numRondas > 0)
        {
            player1.SetActive(true);
            hud1.SetActive(true);

            if (players >= 2)
            {
                player2.SetActive(true);
                hud2.SetActive(true);
                //player2.GetComponentInChildren<PhonyPlayerController>().setKeys(DataObject.player2Keyboard);
            }
            if (players >= 3)
            {
                player3.SetActive(true);
                hud3.SetActive(true);
                //player3.GetComponentInChildren<PhonyPlayerController>().setKeys(DataObject.player3Keyboard);
            }
            if (players == 4)
            {
                player4.SetActive(true);
                hud4.SetActive(true);
                //player4.GetComponentInChildren<PhonyPlayerController>().setKeys(DataObject.player4Keyboard);
            }

            siguienteBoton.onClick.AddListener(siguienteRonda);
        }
        else {
            SceneManager.LoadScene("Podio");
        }

    }

    void siguienteRonda() {
        if (PlayerPrefs.GetInt("rondas") > 0)
        {
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.UnloadSceneAsync(currentScene);
            SceneManager.LoadScene("Map Selection");
        }
        else {
            SceneManager.LoadScene("Podio");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Phony").Length == 1) {
            menuVictoria.SetActive(true);
            textoVictoria.text = "Ha ganado la peonza " + GameObject.FindGameObjectWithTag("Phony").name;
            PlayerPrefs.SetInt("rondas", numRondas - 1);
            PlayerPrefs.SetString("ganador" + PlayerPrefs.GetInt("rondas"), GameObject.FindGameObjectWithTag("Phony").name);
        }

        if (GameObject.FindGameObjectsWithTag("Phony").Length == 0)
        {
            menuVictoria.SetActive(true);
            textoVictoria.text = "Empate";
            PlayerPrefs.SetInt("rondas", PlayerPrefs.GetInt("rondas") - 1);
            PlayerPrefs.SetString("ganador" + PlayerPrefs.GetInt("rondas"), "empate");
        }
    }
    


}
