using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BackButtonScript : MonoBehaviour
{
    public Button button;
    public string NewScene;
    // Start is called before the first frame update
    private void Start()
    {
        button.onClick.AddListener(OnButtonClick);
    }
    private void OnButtonClick()
    {
        Debug.Log("Back Button Clicked");
        SceneManager.LoadScene(NewScene);
    }

}
