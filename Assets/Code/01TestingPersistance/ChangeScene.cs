using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{
    public Button button;
    public Text counterText;
    int sceneCounter = 0;


    // Use this for initialization
    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Scene scene = SceneManager.GetActiveScene();


        if (scene.name == "01TestingPersistanceScene1")
        {
            SceneManager.LoadScene(sceneName: "01TestingPersistanceScene2");
            sceneCounter++;
        }

        if (scene.name == "01TestingPersistanceScene2")
        {
            SceneManager.LoadScene(sceneName: "01TestingPersistanceScene1");
            sceneCounter++;
        }

        
        counterText.text = ("Counter: " + sceneCounter);



    }

    // Update is called once per frame
    void Update()
    {

    }


}