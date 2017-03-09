using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR.WSA.WebCam;

public class ArrowGenerator : MonoBehaviour
{
    private GameObject arrowPrefab;
    private float span = 1.0f;
    private float delta = 0;

	// Update is called once per frame
	void Update ()
	{
	    this.delta += Time.deltaTime;
	    if (this.delta > this.span)
	    {
	        this.delta = 0;
	        GameObject go = Instantiate(arrowPrefab) as GameObject;
	        int px = Random(-6, 7);
	        go.transform.position = new Vector3(px, 7, 0);
	    }
	}
}
