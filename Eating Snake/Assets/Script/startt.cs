using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startt : MonoBehaviour
{

    private SpriteRenderer render;
    public Sprite startbottom1;
    public Sprite startbottom2;
    public Sprite startbottom3;
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
        render.sprite = startbottom3;
        SceneManager.LoadScene("m1");
    }

    private void OnMouseEnter()
    {
        print("in");
        render.sprite = startbottom2;
    }

    private void OnMouseExit()
    {
        print("out");
        render.sprite = startbottom1;
    }
}
