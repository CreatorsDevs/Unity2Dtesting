using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestoreScene : MonoBehaviour
{
    public Button button;
    public string scene;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(OnButtonClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnButtonClick(){
        SceneManager.LoadScene(scene);
    }
}
