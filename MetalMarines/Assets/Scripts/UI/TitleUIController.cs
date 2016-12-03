using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleUIController : MonoBehaviour {


    public GameObject countdownScreen;
    public Text timer;

    float startTime;

    

    void Update()
    {
        timer.text = Mathf.Round(Time.time - startTime).ToString();
    }


    public void ClickStart()
    {
        startTime = Time.time;
        countdownScreen.SetActive(true);
        Invoke("__StartGame", 3f);
    }

    void __StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void __Quit()
    {
        Application.Quit();

    }


}
