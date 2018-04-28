using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorController : MonoBehaviour {
    [SerializeField]
    private GameObject avatar;
    private Animator animator;
    private UserInput userInput;
    private Rigidbody rigid;
    [SerializeField]
    private float walkSpeed = 1.5f;
    private float runSpeed = 3.0f;

    private Vector3 movingVelocity;
    // Use this for initialization
    void Awake()
    {
        animator = avatar.GetComponent<Animator>();
        userInput = GetComponent<UserInput>();
        rigid = GetComponent<Rigidbody>();
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        animator.SetFloat("forward", userInput.Magnitude * Mathf.Lerp(animator.GetFloat("forward"), (userInput.Run ? 2.0f : 1.0f), 0.5f));
        if (userInput.Magnitude > 0.1f)
            avatar.transform.forward = Vector3.Slerp(avatar.transform.forward, userInput.Direction, 0.25f);

        movingVelocity = userInput.Magnitude * avatar.transform.forward * walkSpeed * (userInput.Run ? runSpeed : 1.0f);
	}
    private void FixedUpdate()
    {
        rigid.velocity = new Vector3(movingVelocity.x, rigid.velocity.y, movingVelocity.z);
    }
}
