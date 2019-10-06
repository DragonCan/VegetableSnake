using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    private float a;
    private float b;
    public GameObject ss;
    private int c;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        a = this.transform.localPosition.x - ss.transform.localPosition.x;
        b = this.transform.localPosition.y - ss.transform.localPosition.y;
        c = ss.GetComponent<Snake>().stuck;
        //print(c);
        //计算差值
        //print("start");
        if (a * a + b * b > 2.0) {
            if (c == 0)
            {
                this.transform.localPosition = new Vector3(this.transform.localPosition.x + ss.GetComponent<Snake>().a1, this.transform.localPosition.y + ss.GetComponent<Snake>().b1, -10);
            }
            else
            {
                if (c == 1)
                {
                    this.transform.localPosition = new Vector3(this.transform.localPosition.x + ss.GetComponent<Snake>().a1, this.transform.localPosition.y, -10);
                }
                else
                {
                    this.transform.localPosition = new Vector3(this.transform.localPosition.x, this.transform.localPosition.y + ss.GetComponent<Snake>().b1, -10);
                }
            }
        }
    }
    
        
    
}
