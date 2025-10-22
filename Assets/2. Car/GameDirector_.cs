using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector_ : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;
    float length;
    Text distance_output;
    // Start is called before the first frame update
    void Start()
    {
        car = GameObject.Find("car");
        flag = GameObject.Find("flag");
        distance = GameObject.Find("Distance");
        distance_output = distance.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        length = flag.transform.position.x - car.transform.position.x;
        distance_output.text = "목표지점까지 " + length.ToString("F2") + "m";
    }
}
