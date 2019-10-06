using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		this.transform.localPosition = new Vector3(Random.Range(-26.5f,26.5f), Random.Range(-26.5f,26.5f), 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("find!");
        if (collision.collider.tag == "main")
        {
            print("hahaha");
            collision.gameObject.SendMessage("Grow");
            

        }
        this.transform.localPosition = new Vector3(Random.Range(-26.5f, 26.5f), Random.Range(-26.5f, 26.5f), 1);

    }
}
