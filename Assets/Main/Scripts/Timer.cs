using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {
    float _time_limit = 60;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        _time_limit -= Time.deltaTime;
        if (_time_limit <= 0) {
            SceneChanger.sceneChange("Result");
        }
	}

    public void addTime(float time) {
        _time_limit += time;
    }
}
