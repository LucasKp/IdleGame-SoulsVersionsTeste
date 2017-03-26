using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class MainGameController : MonoBehaviour {

    public Canvas shop;

    void Start()
    {
        shop = shop.GetComponent<Canvas>();
        shop.enabled = false;
    }

    public void GoToShop()
    {
        shop.enabled = true;
        //SceneManager.LoadScene("ShopScene");
    }

    public void ExitShop()
    {
        shop.enabled = false;
    }
}
