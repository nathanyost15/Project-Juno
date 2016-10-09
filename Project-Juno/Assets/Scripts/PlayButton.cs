using UnityEngine;
using System.Collections;

public class PlayButton : MonoBehaviour
{
    private float moveSpeed;
	// Use this for initialization
	void Start ()
    {
        moveSpeed = .05f;
	}
	
	// Update is called once per frame
	void Update ()
    {
        // Move object towards mouse cursor // Issue: mousePosition is mapped to pixel coordinate plane, not world coordinates.
        Vector2 playButtonPosition = new Vector2(transform.position.x, transform.position.y),
            mousePosition = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        transform.position = Vector2.MoveTowards(playButtonPosition, mousePosition, moveSpeed);
	}
}
