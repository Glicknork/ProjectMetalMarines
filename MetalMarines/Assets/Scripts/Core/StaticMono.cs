using UnityEngine;
using System.Collections;

public abstract class StaticMono : MonoBehaviour {

    public static StaticMono instance;

	
	void Awake () {

        instance = this;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
