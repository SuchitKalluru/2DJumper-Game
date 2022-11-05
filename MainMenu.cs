using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject menu;

    public void PlayGame(){
        SceneManager.LoadScene("Gameplay");

    }
}
