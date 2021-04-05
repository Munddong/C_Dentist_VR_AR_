using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tip : MonoBehaviour
{
    public GameObject tip_Background;
    public GameObject coronaTip;
    public GameObject coronaTip1;
    public GameObject coronaTip2;
    public GameObject coronaTip3;
    public GameObject coronaTip4;
    public GameObject coronaTip5;
    public GameObject coronaTip6;
    public GameObject coronaTip7;
    public GameObject coronaTip8;
    public GameObject newsBackground;
    public float timer; // 시간

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(tip_()); // Tip코루틴

        timer += Time.deltaTime; // 시간++
    }

    IEnumerator tip_() // 팁 함수
    {
        if (timer >= 0f)
        {
            coronaTip.SetActive(true);
        }

        if (timer >= 3.0f)
        {
            coronaTip.SetActive(false);
            coronaTip1.SetActive(true);
        }

        if (timer >= 6.0f)
        {
            coronaTip1.SetActive(false);
            coronaTip2.SetActive(true);
        }

        if (timer >= 9.0f)
        {
            coronaTip2.SetActive(false);
            coronaTip3.SetActive(true);
        }

        if (timer >= 12.0f)
        {
            coronaTip3.SetActive(false);
            coronaTip4.SetActive(true);
        }

        if (timer >= 15.0f)
        {
            coronaTip4.SetActive(false);
            coronaTip5.SetActive(true);
        }

        if (timer >= 18.0f)
        {
            coronaTip5.SetActive(false);
            coronaTip6.SetActive(true);
        }

        if (timer >= 21.0f)
        {
            coronaTip6.SetActive(false);
            coronaTip7.SetActive(true);
        }

        if (timer >= 24.0f)
        {
            coronaTip7.SetActive(false);
            coronaTip8.SetActive(true);
        }

        if (timer >= 28.5f)
        {
            coronaTip8.SetActive(false);
            tip_Background.SetActive(false);
            newsBackground.SetActive(true);
        }
        yield return null;
    }
}
