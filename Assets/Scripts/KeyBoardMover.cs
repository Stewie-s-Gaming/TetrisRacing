using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class KeyBoardMover : MonoBehaviour
    {
    [SerializeField]
    [Tooltip("Step size")]
    float step_size;
    float step_init = 0.1f;
    Vector3 startPosition;
    float acceleration = 0.2f;
    float borderLimit = 8.8f;

    // Start is called before the first frame update
    void Start()
    {
        step_size = step_init;
    }

    // Update is called once per frame
    void Update()
    {
        if ((!Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow)) || (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.RightArrow)))
        {
            step_size = step_init;
        }
        if (!Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.RightArrow) && transform.position.x <= borderLimit)
        {
            step_size += acceleration;
            transform.position += new Vector3(step_size * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -borderLimit && !Input.GetKey(KeyCode.RightArrow))
        {
            step_size += acceleration;
            transform.position += new Vector3(-step_size * Time.deltaTime, 0, 0);
        }
    }
}

