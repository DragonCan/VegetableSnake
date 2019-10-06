using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endit : MonoBehaviour
{


    public GameObject backto;
    public GameObject retry;

    // Start is called before the first frame update
    void Start()
    {
        print("oops");
        //this.transform.localPosition = new Vector3(cameral.transform.localPosition.x, cameral.transform.localPosition.y, 3);
        backto.transform.localPosition = new Vector3(this.transform.localPosition.x+3, this.transform.localPosition.y-2, 3);
        backto.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ending()
    {
        print("hahaha");
    }
}
