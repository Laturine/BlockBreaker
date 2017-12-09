using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeKeyMenu : MonoBehaviour {

    public Transform canvas;
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            //SceneManager.LoadScene(2);
            if(canvas.gameObject.activeInHierarchy == false)
            {
                canvas.gameObject.SetActive(true);
            }
            else
            {
                canvas.gameObject.SetActive(false);
            }
        }
	}
}
