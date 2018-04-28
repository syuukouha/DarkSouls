using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class KeyboardInput : UserInput
{
    [Header("Key Settings")]
    public string KeyRun;
	// Update is called once per frame
	void Update () {
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");
        Vector2 temp = SquareToCircle(new Vector2(Horizontal, Vertical));
        Magnitude = Mathf.Sqrt((temp.x * temp.x) + (temp.y * temp.y));
        Direction = Horizontal * transform.right + Vertical * transform.forward;
        Run = Input.GetKey(KeyRun);
    }
}
