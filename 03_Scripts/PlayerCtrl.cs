using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public float speed;

    public GameObject mainCam;
    public GameObject player;

    private Transform cam;
    private CharacterController cc;

    Narration_Hospital narration_HospitalScript_PlayerCtrl;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0.6f;
        narration_HospitalScript_PlayerCtrl = GameObject.Find("Hobbang").GetComponent<Narration_Hospital>();
        cam = Camera.main.GetComponent<Transform>();
        cc = player.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButton(0))
        //{
        //    transform.Translate(mainCam.transform.TransformDirection(Vector3.forward) * speed * Time.deltaTime);
        //}

        if (cam.eulerAngles.x >= 25.0f && cam.transform.eulerAngles.x < 300)
        {
            speed = 0.6f;
        }

        else
        {
            speed = 0f;
        }
        cc.SimpleMove(cam.forward * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag.Equals("Collider"))
        {
            player.GetComponent<CharacterController>().enabled = false;
            StartCoroutine(narration_HospitalScript_PlayerCtrl.SpeedZero());
        }
    }
}

