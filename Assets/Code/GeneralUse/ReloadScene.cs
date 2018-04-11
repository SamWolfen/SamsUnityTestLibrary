using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReloadScene : MonoBehaviour {

    public Button button;

    // Use this for initialization
    void Start () {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }

    void TaskOnClick ()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(sceneName: scene.name);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
