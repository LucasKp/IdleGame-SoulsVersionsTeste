using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenuController : MonoBehaviour
{
    public void GoToGamePlay()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void GoToShop()
    {
        SceneManager.LoadScene("ShopScene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
