using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Narration_Hospital1 : MonoBehaviour
{
    private AudioSource audioSource; // 카세트

    public AudioClip keyboard; // 키보드 소리

    public GameObject narration;
    public GameObject hobbangFace;
    public GameObject aziFace;
    public GameObject ahriFace;
    public GameObject ui_Canvas;
    public GameObject cursorGauge;

    public Text narrationText;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        StartCoroutine(Dialogue_Hospital1());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Dialogue_Hospital1() // 병원1 다이얼로그 함수
    {
        yield return new WaitForSeconds(1.0f);
        narrationText.text = "";
        narrationText.DOText("두분 모두 손 소독은 다 하셨나요?", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        ahriFace.SetActive(false);
        hobbangFace.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("넵! 구석구석 마를때까지 싹싹 닦았어요!", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        hobbangFace.SetActive(false);
        aziFace.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("콜록... 콜록.....", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        aziFace.SetActive(false);
        ahriFace.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("마지막으로 체온을 재고 저에게 이야기 해주세요.", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();
        narration.SetActive(false);
        ahriFace.SetActive(false);

        yield return new WaitForSeconds(1.0f);
        cursorGauge.SetActive(true);
        narration.SetActive(true);
        narrationText.text = "체온 재기를 3초간 바라봐주세요!";
        ui_Canvas.SetActive(true);
        
    }
}
