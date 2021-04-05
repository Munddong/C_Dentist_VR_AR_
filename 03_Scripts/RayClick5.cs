using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RayClick5 : MonoBehaviour
{
    public Image cursorGauge;

    private float gaugeTimer = 0.0f;
    private float gazeTime = 3.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 1000;
        cursorGauge.fillAmount = gaugeTimer;
        Debug.DrawRay(transform.position, forward, Color.red);

        if (Physics.Raycast(transform.position, forward, out hit))
        {
            if (hit.transform.tag.Equals("Soap")) // == 보다 Equals가 계산량이 빠름
            {
                gaugeTimer += 1.0f / gazeTime * Time.deltaTime;

                if (gaugeTimer >= 1.0f)
                {
                    SceneManager.LoadScene("HousePractice");
                }
            }
        }
        else
        {
            gaugeTimer = 0.0f;
        }
    }
}
