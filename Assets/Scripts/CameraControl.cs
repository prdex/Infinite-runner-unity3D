using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    private Transform lookAt;
    private Vector3 offset;
    private Vector3 contraint;
	// Use this for initialization
	void Start () {
        lookAt = GameObject.FindGameObjectWithTag("Player").transform;
        offset = transform.position - lookAt.position;
    }
	
	// Update is called once per frame
	void Update () {
        contraint = lookAt.position + offset;
        contraint.x = 0;
        contraint.y = Mathf.Clamp(contraint.y, 7, 9);
        transform.position = contraint;
	}
}
