using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame() 
    { 
        SceneManager.LoadScene("Game"); 
        Debug.Log("Created by Valentino Herdyan Permadi - BDI08");
    }

    public void OpenCredit() 
    {
        SceneManager.LoadScene("Credit");
        Debug.Log("Created by Valentino Herdyan Permadi - BDI08");
    } 

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
