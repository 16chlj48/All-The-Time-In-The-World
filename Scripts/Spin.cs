using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 75 * Time.deltaTime, 0);
    }
}
