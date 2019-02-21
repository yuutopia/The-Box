using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamaManager : MonoBehaviour {

    public const int WALL_FRONT = 1;
    public const int WALL_RIGHT = 2;
    public const int WALL_BACK = 3;
    public const int WALL_LEFT = 4;

    public GameObject panelWalls;

    private int wallNo;

    // Use this for initialization
    void Start () {
        wallNo = WALL_FRONT;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
