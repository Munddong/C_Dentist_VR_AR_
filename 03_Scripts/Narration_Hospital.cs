using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Narration_Hospital : MonoBehaviour
{
    private AudioSource audioSource; // 카세트

    public AudioClip keyboard; // 키보드 소리

    public GameObject narration;
    public GameObject hobbangFace;
    public GameObject aziFace;
    public GameObject ahriFace;
    public GameObject particle;
    public GameObject particle1;
    public GameObject goParticle;
    public GameObject practiceButton;
    public GameObject cursorGauge;

    public BoxCollider boxCollider;
    public BoxCollider boxCollider1;

    public Text narrationText;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        StartCoroutine(Dialogue_Hospital());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Dialogue_Hospital() // 병원 다이얼로그 함수
    {
        boxCollider.GetComponent<BoxCollider>().enabled = false;
        boxCollider1.GetComponent<BoxCollider>().enabled = false;
        yield return new WaitForSeconds(1.0f);
        narrationText.text = "";
        narration.SetActive(true);
        hobbangFace.SetActive(true);
        narrationText.DOText("아지야, 제튼 병원에 왔으니 진료를 받아보자", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        hobbangFace.SetActive(false);
        narrationText.text = "";
        narrationText.DOText("카운터 앞으로 가주세요!", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();
        goParticle.SetActive(true);
        yield return new WaitForSeconds(1.0f);
    }

    public IEnumerator SpeedZero()
    {
        cursorGauge.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("카운터에서 접수원을 3초간 바라봐 주세요!", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        goParticle.SetActive(false);
        yield return new WaitForSeconds(3.0f);
        boxCollider.GetComponent<BoxCollider>().enabled = true;
        boxCollider1.GetComponent<BoxCollider>().enabled = true;
        audioSource.Stop();
        yield return new WaitForSeconds(1.0f);
        particle.SetActive(true);
        particle1.SetActive(true);
        narration.SetActive(false);
        practiceButton.SetActive(true);
    }
}
