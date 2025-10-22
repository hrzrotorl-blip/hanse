using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController_ : MonoBehaviour
{
    float Speed = 0;
    Vector3 startPos;
    Vector3 endPos;
    float length;
    AudioSource myAudio;
    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //Speed = 0.2f;
            startPos = Input.mousePosition;
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            endPos = Input.mousePosition;
            length = endPos.x - startPos.x;
            Speed = length / 500f;
            myAudio.Play();
        }
        transform.Translate( new Vector3( Speed, 0, 0 )  * 300.0f * Time.deltaTime  );
        Speed = Speed * 0.98f;
    }
}
