using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void StartTheGame()=> SceneManager.LoadScene("lvl1");
 
    public void CloseGame() => Application.Quit();

}
