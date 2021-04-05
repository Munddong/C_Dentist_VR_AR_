using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HobbangMove : MonoBehaviour
{
    public GameObject mainCam;
    public GameObject player;

    private Transform cam;
    private CharacterController cc;

    public float speed; // 호빵이 스피드

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main.GetComponent<Transform>();

        cc = player.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cam.eulerAngles.x >= 25.0f && cam.transform.eulerAngles.x < 300)
        {
            speed = 6.5f;
        }

        else
        {
            speed = 0f;
        }
        cc.SimpleMove(cam.forward * speed);
    }
}

