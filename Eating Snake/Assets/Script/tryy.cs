using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class tryy : MonoBehaviour
{

	private SpriteRenderer render;
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
		//render.sprite = startbottom3;
		SceneManager.LoadScene("start");
	}

	private void OnMouseEnter()
	{
		print("in");
		//render.sprite = startbottom2;
	}

	private void OnMouseExit()
	{
		print("out");
		//render.sprite = startbottom1;
	}
}