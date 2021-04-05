using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RayClick6 : MonoBehaviour
{
    private AudioSource audioSource; // 카세트

    public AudioClip keyboard; // 키보드 소리

    public Image cursorGauge;
    
    public GameObject narration;
    public GameObject hands;
    public GameObject hands1;
    public GameObject hands2;
    public GameObject hands3;
    public GameObject hands4;
    public GameObject hands5;
    public GameObject image;

    public Text narrationText;

    private float gaugeTimer = 0.0f;
    private float gazeTime = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        StartCoroutine(Dialogue_HousePractice());
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
                    image.SetActive(false);
                    StartCoroutine(Dialogue_HousePractice_1());
                }
            }
        }
        else
        {
            gaugeTimer = 0.0f;
        }
    }

    IEnumerator Dialogue_HousePractice()
    {
        yield return new WaitForSeconds(2.0f);
        narrationText.text = "";
        narrationText.DOText("올바른 손씻기 6단계 방법", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        image.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("손씻기를 3초간 바라봐주세요!", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();
    }

    IEnumerator Dialogue_HousePractice_1()
    {
        yield return new WaitForSeconds(2.0f);
        narrationText.text = "";
        narrationText.DOText("1. 손바닥과 손바닥을 마주대고 문질러 주세요.", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        hands.SetActive(true);

        yield return new WaitForSeconds(5.0f);
        narration.SetActive(false);
        hands.SetActive(false);

        yield return new WaitForSeconds(2.0f);
        narration.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("2. 손등과 손바닥을 마주대고 문질러 주세요.", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        hands1.SetActive(true);

        yield return new WaitForSeconds(5.0f);
        narration.SetActive(false);
        hands1.SetActive(false);

        yield return new WaitForSeconds(2.0f);
        narration.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("3. 손바닥을 마주대고 손깍지를 끼고 문질러 주세요.", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        hands2.SetActive(true);

        yield return new WaitForSeconds(5.0f);
        narration.SetActive(false);
        hands2.SetActive(false);

        yield return new WaitForSeconds(2.0f);
        narration.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("4. 손바닥을 마주잡고 문질러 주세요.", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        hands3.SetActive(true);

        yield return new WaitForSeconds(5.0f);
        narration.SetActive(false);
        hands3.SetActive(false);

        yield return new WaitForSeconds(2.0f);
        narration.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("5. 엄지손가락을 다른 편 손가락으로 돌려주며 문질러 주세요.", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        hands4.SetActive(true);

        yield return new WaitForSeconds(5.0f);
        narration.SetActive(false);
        hands4.SetActive(false);

        yield return new WaitForSeconds(2.0f);
        narration.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("6. 손가락을 반대편 손바닥에 놓고,", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(2.0f);
        narration.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("문지르며 손톱 밑을 깨끗이 씻어주세요.", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        hands5.SetActive(true);

        yield return new WaitForSeconds(5.0f);
        narration.SetActive(false);
        hands5.SetActive(false);

        yield return new WaitForSeconds(1.0f);
        narration.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("5초 뒤에 선택화면으로 돌아갑니다.", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(5.0f);
        SceneManager.LoadScene("SelectVR");
    }
}
