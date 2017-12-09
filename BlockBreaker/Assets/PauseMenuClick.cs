using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuClick : MonoBehaviour {

    public Transform canvas;

	public void continueGame()
    {
        canvas.gameObject.SetActive(false);
    }
}
