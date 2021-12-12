using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdlePlay : MonoBehaviour {
	private Animator anim;
	
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		anim.SetBool("isMove",false);
	}

}
