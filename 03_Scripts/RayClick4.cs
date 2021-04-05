using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RayClick4 : MonoBehaviour
{
    private AudioSource audioSource; // 카세트

    public AudioClip keyboard; // 키보드 소리

    public Image cursorGauge;

    public GameObject thermometer;
    public GameObject narration;
    public GameObject image;

    private float gaugeTimer = 0.0f;
    private float gazeTime = 3.0f;

    public Text narrationText;

    public BoxCollider boxcollider;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        StartCoroutine(Dialogue_HospitalPractice1());
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
            if (hit.transform.tag.Equals("Thermometer")) // == 보다 Equals가 계산량이 빠름
            {
                gaugeTimer += 1.0f / gazeTime * Time.deltaTime;

                if (gaugeTimer >= 1.0f)
                {
                    image.SetActive(false);
                    boxcollider.GetComponent<BoxCollider>().enabled = false;
                    thermometer.SetActive(true);
                    thermometer.GetComponent<Animator>().enabled = true;
                    StartCoroutine(Dialogue_HospitalPractice1_1());
                }
            }
        }
        else
        {
            gaugeTimer = 0.0f;
        }
    }

    IEnumerator Dialogue_HospitalPractice1()
    {
        yield return new WaitForSeconds(2.0f);
        narrationText.text = "";
        narrationText.DOText("체온계를 올바르게 쓰는 방법", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        image.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("체온계를 3초간 바라봐주세요!", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();
    }

    IEnumerator Dialogue_HospitalPractice1_1()
    {
        yield return new WaitForSeconds(1.0f);
        narrationText.text = "";
        narrationText.DOText("귀를 살짝 잡아당기고 측정부를 귓 속에 넣어주세요!", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        narrationText.text = "";
        narrationText.DOText("1 ~ 2초 후 측정버튼을 누르고", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        narrationText.text = "";
        narrationText.DOText("알람소리가 나면 측정이 완료됩니다.", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        narrationText.text = "";
        narrationText.DOText("양쪽 귀 모두를 측정해 높은 체온 측정 결과를 선택합니다.", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        narrationText.text = "";
        narrationText.DOText("5초 뒤에 병원으로 돌아갑니다.", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();
        yield return new WaitForSeconds(5.0f);
        SceneManager.LoadScene("Hospital2");
    }
}