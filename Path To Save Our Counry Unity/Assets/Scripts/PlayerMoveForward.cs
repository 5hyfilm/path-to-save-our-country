using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveForward : MonoBehaviour {
	public Animator anim;
	private float Step;
	public float Speed;
	private Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	void Update () {
		anim.SetBool("isMove",true);
		rb.AddForce(0,0,800f);
	}
}
