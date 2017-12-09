using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour {

    int numBlocks = 0;
	// Use this for initialization
	void Start () {
        numBlocks++;
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        BlockUpdate();
    }

    void BlockUpdate()
    {
        //destroy block
        Destroy(gameObject);

        //if all blocks have been hit load new level
        numBlocks--;
        if (numBlocks == 0)
        {
            Debug.Log("YOU WIN!!!");
        }
    }
}
