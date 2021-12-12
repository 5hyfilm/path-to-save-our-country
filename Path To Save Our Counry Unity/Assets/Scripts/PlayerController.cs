using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Cameras;

public class PlayerController : MonoBehaviour
{
    public PauseMenu Menucontroller;
	public FreeLookCam CamControl;
	private Rigidbody rb;
    private AudioSource JumpStep;
    private float Step;
	private bool IsJump;
	private float JumpStart = 0.0f;
	private Animator anim;
	private int score;
	public float TurnAngle;
	public float Speed;
	public Text ScoreText;
    public bool isMove;
    public float Mapheight;
	public GameObject Gate;
    private bool dead;
	public GameObject Waste;
	public GameObject WasteDemo;
	void Start ()
	{
		score = (int)PlayerPrefs.GetFloat("Score");
		if (PlayerPrefs.GetInt("Demo") == 0)
		{
			Waste.SetActive(true);
			WasteDemo.SetActive(false);
		}
		else if (PlayerPrefs.GetInt("Demo") == 1)
		{
			Waste.SetActive(false);
			WasteDemo.SetActive(true);
		}

		Gate.SetActive(false);
        dead = false;
		score = 0;
		anim = GetComponent<Animator>();
		rb = GetComponent<Rigidbody>();
        JumpStep = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update ()
	{
		if (GameObject.FindWithTag("Wet") == null && GameObject.FindWithTag("Danger") == null &&
		    GameObject.FindWithTag("General") == null && GameObject.FindWithTag("Wet") == null)
		{
			Gate.SetActive(true);
		}
        if (rb.transform.position.y < Mapheight)
        {//ปิดหรือไม่ปิดก็ได้
	        Debug.Log("Dead");
            Menucontroller.Dead();
            dead = true;
        }
        anim.SetBool("isMove",isMove);
		Step = Speed * Time.deltaTime;
		transform.position = transform.position + transform.forward * Step;
        if ((!Menucontroller.Pausedbool()) && !dead)
        {
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.Rotate(0, -TurnAngle, 0);
            }
            else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.Rotate(0, TurnAngle, 0);
            }
            if (Input.GetKeyDown(KeyCode.Space) && !IsJump)
            {
                JumpStep.Play();
                IsJump = true;
                JumpStart = Time.time;
                rb.useGravity = false;
            }
            if (IsJump)
            {
                float intervalTime = Time.time - JumpStart;
                Vector3 pos = transform.position;
                if (intervalTime < 0.4f)
                {
                    pos.y += 0.2f;
                    transform.position = pos;
                }
                else if (intervalTime < 1.0f)
                {
                    pos.y -= 0.2f;
                    transform.position = pos;
                }
                else
                {
                    IsJump = false;
                    rb.useGravity = true;
                }
            }
        }
		else
		{
			CamControl.OnDisable();
		}
	}

	public void AddScore(int getscore)
	{
		score += getscore;
		PlayerPrefs.SetFloat("Score",score);
		ScoreText.text =  PlayerPrefs.GetFloat("Score").ToString();
	}
}

