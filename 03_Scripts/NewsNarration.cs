using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;


public class NewsNarration : MonoBehaviour
{
    private AudioSource audioSource; // 카세트

    public AudioClip keyboard; // 키보드 소리

    public GameObject narration; // 나래이션 이미지
    public GameObject example; // 팁
    public GameObject newsBackground;
    public GameObject viruses;

    public Text narrationText; // 나래이션 텍스트

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(StartDialogue());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator StartDialogue() // 뉴스 다이얼로그 함수
    {
        yield return new WaitForSeconds(2.0f);
        narrationText.text = "";
        narrationText.DOText("‘우한 폐렴’ 국내 첫 확진 환자 발생", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        narrationText.text = "";
        narrationText.DOText("추가 확진 2명···국내 첫 ‘사람 간 감염’ 확인", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        narrationText.text = "";
        narrationText.DOText("국내 4번 째 신종코로나 확진 환자 발생", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        narrationText.text = "";
        narrationText.DOText("확진자 2명 추가···첫 2차 감염 발생", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        narrationText.text = "";
        narrationText.DOText("‘접촉자’ 172명···네 번째 환자 이동 경로는?", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        narrationText.text = "";
        narrationText.DOText("中사망 636명·확진 3만 천 명↑···“정점 진단 시기 상조”", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        narration.SetActive(false);
        yield return new WaitForSeconds(1.0f);
        newsBackground.SetActive(false);
        example.SetActive(true);
        viruses.SetActive(true);
    }
}
