using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallrandom : MonoBehaviour
{

    public GameObject w1;
    public GameObject w3;
    public GameObject w5;
    public GameObject w7;
    public GameObject w9;
    public GameObject w3x;
    public GameObject w5x;
    public GameObject w7x;
    public GameObject w9x;
    private GameObject usse;

    // Start is called before the first frame update
    void Start()
    {
        create();
        create();
        create();
        create();
        create();
        create();
        create();
        create(); 
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void create()
    {
        usse = Instantiate(w1);
        usse.transform.localPosition = new Vector3(Random.Range(0f, 26.75f) * ((Random.Range(0,2) == 0) ? 1 : -1), Random.Range(0f, 26.75f) * ((Random.Range(0, 2) == 0) ? 1 : -1), 1);
        usse = Instantiate(w3);
        usse.transform.localPosition = new Vector3(Random.Range(0f, 26.75f) * ((Random.Range(0,2) == 0) ? 1 : -1), Random.Range(0f, 26.25f) * ((Random.Range(0, 2) == 0) ? 1 : -1), 1);
        usse = Instantiate(w5);
        usse.transform.localPosition = new Vector3(Random.Range(0f, 26.75f) * ((Random.Range(0,2) == 0) ? 1 : -1), Random.Range(0f, 25.75f) * ((Random.Range(0, 2) == 0) ? 1 : -1), 1);
        usse = Instantiate(w7);
        usse.transform.localPosition = new Vector3(Random.Range(0f, 26.75f) * ((Random.Range(0,2) == 0) ? 1 : -1), Random.Range(0f, 24.25f) * ((Random.Range(0, 2) == 0) ? 1 : -1), 1);
        usse = Instantiate(w9);
        usse.transform.localPosition = new Vector3(Random.Range(0f, 26.75f) * ((Random.Range(0,2) == 0) ? 1 : -1), Random.Range(0f, 24.75f) * ((Random.Range(0, 2) == 0) ? 1 : -1), 1);
        
        usse = Instantiate(w1);
        usse.transform.localPosition = new Vector3(Random.Range(0f, 26.75f) * ((Random.Range(0, 2) == 0) ? 1 : -1), Random.Range(0f, 26.75f) * ((Random.Range(0, 2) == 0) ? 1 : -1), 1);
        usse = Instantiate(w3x);
        usse.transform.localPosition = new Vector3(Random.Range(0f, 26.25f) * ((Random.Range(0, 2) == 0) ? 1 : -1), Random.Range(0f, 26.75f) * ((Random.Range(0, 2) == 0) ? 1 : -1), 1);
        usse = Instantiate(w5x);
        usse.transform.localPosition = new Vector3(Random.Range(0f, 25.75f) * ((Random.Range(0, 2) == 0) ? 1 : -1), Random.Range(0f, 26.75f) * ((Random.Range(0, 2) == 0) ? 1 : -1), 1);
        usse = Instantiate(w7x);
        usse.transform.localPosition = new Vector3(Random.Range(0f, 25.25f) * ((Random.Range(0, 2) == 0) ? 1 : -1), Random.Range(0f, 26.75f) * ((Random.Range(0, 2) == 0) ? 1 : -1), 1);
        usse = Instantiate(w9x);
        usse.transform.localPosition = new Vector3(Random.Range(0f, 25.75f) * ((Random.Range(0, 2) == 0) ? 1 : -1), Random.Range(0f, 26.75f) * ((Random.Range(0, 2) == 0) ? 1 : -1), 1);

    }
}
