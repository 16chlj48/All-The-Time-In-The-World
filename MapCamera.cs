using UnityEngine;
using System.Collections;

public class MapCamera : MonoBehaviour {

    public Transform target;
    public float smootheTime = 0.3f;
    private Vector3 velocity = Vector3.zero;
    

    void FixedUpdate() {
        Vector3 goalPos = target.position;
        goalPos.y = transform.position.y;
        transform.position = Vector3.SmoothDamp(transform.position, goalPos, ref velocity, smootheTime);
    }
}
