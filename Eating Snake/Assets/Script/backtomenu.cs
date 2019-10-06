using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backtomenu : MonoBehaviour
{

	private SpriteRenderer render;
	public Sprite backbottom1;
	public Sprite backbottom2;
	public Sprite backbottom3;
	// Start is called before the first frame update
	void Start()
	{
		render = GetComponent<SpriteRenderer>();
	}

	// Update is called once per frame
	void Update()
	{
		//render.sprite = startbottom2;
	}

	private void OnMouseDown()
	{

		print("aaa");
		render.sprite = backbottom3;
		SceneManager.LoadScene("Start");
	}

	private void OnMouseEnter()
	{
		print("in");
		render.sprite = backbottom2;
	}

	private void OnMouseExit()
	{
		print("out");
		render.sprite = backbottom1;
	}
}