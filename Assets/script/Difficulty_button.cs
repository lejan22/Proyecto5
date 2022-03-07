using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Difficulty_button : MonoBehaviour
{
    public int difficulty;
    private Button button;
    private GameManager gameManagerScript;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);

        gameManagerScript = FindObjectOfType<GameManager>();
    }

    public void SetDifficulty()
    {
        //A�adir cosas para diferenciar la dificultad
        gameManagerScript.StartGame(difficulty);
    }
}
