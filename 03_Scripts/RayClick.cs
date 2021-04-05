using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RayClick : MonoBehaviour
{
    private AudioSource audioSource; // 카세트

    public AudioClip keyboard; // 키보드 소리

    public Image cursorGauge;

    public GameObject ui_Canvas;
    public GameObject particle;
    public GameObject particle1;
    public GameObject disinfectants;

    public BoxCollider boxCollider;
    public BoxCollider boxCollider1;
    public BoxCollider DisinfectantBoxCollider;
    public BoxCollider Disinfectant1BoxCollider;
    public BoxCollider Disinfectant2BoxCollider;
    public GameObject disinfectantParticle;
    public GameObject disinfectant1Particle;
    public GameObject disinfectant2Particle;

    private float gaugeTimer = 0.0f;
    private float gazeTime = 3.0f;

    Narration_Hospital narration_HospitalScript_RayClick;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        narration_HospitalScript_RayClick = GameObject.Find("Hobbang").GetComponent<Narration_Hospital>();
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
            if (hit.transform.tag.Equals("Objects")) // == 보다 Equals가 계산량이 빠름
            {
                gaugeTimer += 1.0f / gazeTime * Time.deltaTime;

                if (gaugeTimer >= 1.0f)
                {
                    ui_Canvas.SetActive(true);
                    narration_HospitalScript_RayClick.narration.SetActive(true);
                    DisinfectantBoxCollider.GetComponent<BoxCollider>().enabled = false;
                    Disinfectant1BoxCollider.GetComponent<BoxCollider>().enabled = false;
                    Disinfectant2BoxCollider.GetComponent<BoxCollider>().enabled = false;
                }
            }

            else if (hit.transform.tag.Equals("Counter")) // == 보다 Equals가 계산량이 빠름
            {
                gaugeTimer += 1.0f / gazeTime * Time.deltaTime;

                if (gaugeTimer >= 1.0f)
                {
                    StartCoroutine(Ahri());
                    disinfectantParticle.SetActive(true);
                    disinfectant1Particle.SetActive(true);
                    disinfectant2Particle.SetActive(true);
                } 
            }

            else if (hit.transform.tag.Equals("Practice")) // == 보다 Equals가 계산량이 빠름
            {
                gaugeTimer += 1.0f / gazeTime * Time.deltaTime;

                if (gaugeTimer >= 1.0f)
                {
                    SceneManager.LoadScene("HospitalPractice");
                }
            }

            else
            {
                gaugeTimer = 0.0f;
            }
        }
    }

    IEnumerator Ahri()
    {
        particle.SetActive(false);
        particle1.SetActive(false);
        boxCollider.GetComponent<BoxCollider>().enabled = false;
        boxCollider1.GetComponent<BoxCollider>().enabled = false;
        narration_HospitalScript_RayClick.ahriFace.SetActive(true);
        narration_HospitalScript_RayClick.narration.SetActive(true);
        narration_HospitalScript_RayClick.narrationText.text = "";
        narration_HospitalScript_RayClick.narrationText.DOText("어떤 일로 찾아오셨나요?", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        narration_HospitalScript_RayClick.ahriFace.SetActive(false);
        narration_HospitalScript_RayClick.hobbangFace.SetActive(true);
        narration_HospitalScript_RayClick.narrationText.text = "";
        narration_HospitalScript_RayClick.narrationText.DOText("제 친구 아지가 코로나 바이러스 증상이 의심되서요.", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        narration_HospitalScript_RayClick.hobbangFace.SetActive(false);
        narration_HospitalScript_RayClick.aziFace.SetActive(true);
        narration_HospitalScript_RayClick.narrationText.text = "";
        narration_HospitalScript_RayClick.narrationText.DOText("콜록.. 콜록......", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        narration_HospitalScript_RayClick.aziFace.SetActive(false);
        narration_HospitalScript_RayClick.ahriFace.SetActive(true);
        narration_HospitalScript_RayClick.narrationText.text = "";
        narration_HospitalScript_RayClick.narrationText.DOText("일단 두분 모두 손 소독제로 손을 소독해 주세요.", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        narration_HospitalScript_RayClick.cursorGauge.SetActive(true);
        narration_HospitalScript_RayClick.ahriFace.SetActive(false);
        narration_HospitalScript_RayClick.narrationText.text = "";
        narration_HospitalScript_RayClick.narrationText.DOText("소독제를 3초간 바라봐주세요.", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        narration_HospitalScript_RayClick.narration.SetActive(false);
        disinfectants.SetActive(true);
        disinfectantParticle.SetActive(true);
        disinfectant1Particle.SetActive(true);
        disinfectant2Particle.SetActive(true);
        narration_HospitalScript_RayClick.narrationText.text = "손 소독하기를 3초간 바라봐주세요!";
    }
}