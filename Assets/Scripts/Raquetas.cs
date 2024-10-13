using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float y;
    public int speed = 10;
    public string eje = "Vertical";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        y = Input.GetAxisRaw(eje);
        GetComponent<Rigidbody2D>().velocity =
            new Vector2(0, y) * speed;
    }
}
