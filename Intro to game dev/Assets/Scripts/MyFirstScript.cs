using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MyFirstScript : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;
    public string NewScene1;
    public string NewScene2;
    public string NewScene3;

    // Start is called before the first frame update
    private void Start()
    {
        button1.onClick.AddListener(OnButtonClick1);
        button2.onClick.AddListener(OnButtonClick2);
        button3.onClick.AddListener(OnButtonClick3);
    }
    private void OnButtonClick1()
    {
        Debug.Log("Button 1 Clicked");
        SceneManager.LoadScene(NewScene1);
    }
    private void OnButtonClick2()
    {
        Debug.Log("Button 1 Clicked");
        SceneManager.LoadScene(NewScene2);
    }
    private void OnButtonClick3()
    {
        Debug.Log("Button 1 Clicked");
        SceneManager.LoadScene(NewScene3);
    }

}
