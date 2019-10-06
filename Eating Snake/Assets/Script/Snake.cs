using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{
    public float speed=3;
    public List<GameObject> Bodies = new List<GameObject>();
    public GameObject bodyobject;
    public GameObject boddy;
    public GameObject loseit;
    public GameObject cameral;
    //public GameObject uuse = new GameObject();
    public int stuck;
    public List<Vector3> positions = new List<Vector3>();
    private float a;
    private float b;
    public float a1;
    public float b1;
    private int c;
    private int d;
    public bool life = true;


    // Start is called before the first frame update
    void Start()
    {
        speed = 0.07f;
        positions.Clear();
        Bodies.Clear();
        positions.Insert(0, this.transform.localPosition);
        Grow();
        Grow();
        Grow();
        Grow();

        print("xyzxyz");



    }

    // Update is called once per frame
    void Update()
    {
        if (life)
        {
            //计算差值
            a = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0)).x - this.transform.localPosition.x;
            b = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0)).y - this.transform.localPosition.y;
            //print("start");
            if (a * a + b * b > 2.0)
            {
                a1 = speed * a / Mathf.Sqrt(a * a + b * b);
                b1 = speed * b / Mathf.Sqrt(a * a + b * b);
            }
            //this.transform.localPosition = Vector2.Lerp(this.transform.localPosition , Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0)), 0.2f);
            this.transform.localPosition = new Vector3(this.transform.localPosition.x + a1, this.transform.localPosition.y + b1);
            //print(this.transform.localPosition );
            if (Input.GetMouseButtonDown(0))
            {
                Grow();
                Grow();
                Grow();
                Grow();
                print("aaa");
            }
            positions.Insert(0, this.transform.localPosition);
            positions.RemoveAt(positions.Count - 1);
            //print(positions[0].x);
            //print(positions[0].y);

            c = 1;
            foreach (GameObject uuse in Bodies)
            {

                uuse.transform.localPosition = positions[5 * c];
                c += 1;
            }

            //d += 1;
            //if (d == 100)
            //{
            //    d = 0;
            //    Lower();
            //}
        }

        
    }

    void Grow()
    {
        //print(bodyobject);
        boddy = GameObject.Instantiate(bodyobject);
        boddy.transform.localPosition = this.transform.localPosition;
        Bodies.Add(boddy);

        positions.Add(positions[positions.Count - 1]);
        positions.Add(positions[positions.Count - 1]);
        positions.Add(positions[positions.Count - 1]);
        positions.Add(positions[positions.Count - 1]);
        positions.Add(positions[positions.Count - 1]);

    }

    void Lower()
    {
        if (Bodies.Count == 0)
        {
            dead();
        }
        else
        {
            boddy = Bodies[Bodies.Count - 1];
            Bodies.RemoveAt(Bodies.Count - 1);
            Destroy(boddy);
            positions.RemoveAt(positions.Count - 1);
            positions.RemoveAt(positions.Count - 1);
            positions.RemoveAt(positions.Count - 1);
            positions.RemoveAt(positions.Count - 1);
            positions.RemoveAt(positions.Count - 1);
        }
    }

    void dead()
    {
        print("awsl");
        life = false;
        a1 = b1 = 0;
        loseit.transform.localPosition = new Vector3(cameral.transform.localPosition.x, cameral.transform.localPosition.y, 3);
        loseit.SetActive(true);
        
    }
}