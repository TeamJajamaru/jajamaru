using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTimer : Item {
    [SerializeField] Timer _timer = null;
    const float TIME_INCREMENT = 5.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GameObject test = GameObject.Find("Time");
        _timer = test.GetComponent<Timer>();
	}

    void OnDestroy(){
        _timer.addTime(TIME_INCREMENT);
    }
}
