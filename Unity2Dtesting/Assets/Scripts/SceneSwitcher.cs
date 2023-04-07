using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;
    public string scene1;
    public string scene2;
    public string scene3;
    // Start is called before the first frame update
    void Start()
    {
        button1.onClick.AddListener(OnButton1Click);
        button2.onClick.AddListener(OnButton2Click);
        button3.onClick.AddListener(OnButton3Click);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnButton1Click(){
        SceneManager.LoadScene(scene1);
    }
    void OnButton2Click(){
        SceneManager.LoadScene(scene2);
    }
    void OnButton3Click(){
        SceneManager.LoadScene(scene3);
    }
    
}
