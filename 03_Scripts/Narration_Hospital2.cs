using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Narration_Hospital2 : MonoBehaviour
{
    private AudioSource audioSource; // 카세트

    public AudioClip keyboard; // 키보드 소리

    public GameObject narration;
    public GameObject hobbangFace;
    public GameObject aziFace;
    public GameObject ahriFace;
    public GameObject thermometer;
    public Text narrationText;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        StartCoroutine(Dialogue_Hospital2());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Dialogue_Hospital2() // 지하철 다이얼로그 함수
    {
        yield return new WaitForSeconds(1.0f);
        narrationText.text = "";
        narrationText.DOText("두분 모두 열을 재셨나요?", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        ahriFace.SetActive(false);
        hobbangFace.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("..... 저는 정상인데,,, 아지의 열이...", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        thermometer.SetActive(true);
        hobbangFace.SetActive(false);
        narration.SetActive(false);
        yield return new WaitForSeconds(5.0f);
        thermometer.SetActive(false);

        yield return new WaitForSeconds(1.0f);
        hobbangFace.SetActive(false);
        narration.SetActive(true);
        aziFace.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("콜록... 흐읍..... 숨 쉬기가 힘들어요...", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        aziFace.SetActive(false);
        ahriFace.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("열은 38.3°로 고열이에요, 코로나 바이러스의", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        narrationText.text = "";
        narrationText.DOText("초기 증상이 의심되며, 의료 기관을", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        narrationText.text = "";
        narrationText.DOText("방문하는 것 외에는 외출을 삼가해주세요.", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        ahriFace.SetActive(false);
        aziFace.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("알겠습니다... 콜록.. 콜록....", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        aziFace.SetActive(false);
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
