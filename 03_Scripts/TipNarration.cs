using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TipNarration : MonoBehaviour
{
    private AudioSource audioSource; // 카세트
    public AudioClip keyboard; // 키보드 소리
    public Text tipNarrationText;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(TipDialogue());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator TipDialogue() // 팁 다이얼로그 함수
    {
        tipNarrationText.text = "";
        tipNarrationText.DOText("바이러스는 주로 사람 간에 전파되는 것으로 여겨집니다.", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        tipNarrationText.text = "";
        tipNarrationText.DOText("· 밀접 접촉자들 간 전파(약 6피트 이내)됩니다.", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        tipNarrationText.text = "";
        tipNarrationText.DOText("· 감염자의 기침, 재채기 및 대화할 때 나오는 호흡기 비말을 통해 전파됩니다.", 5.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(5.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        tipNarrationText.text = "";
        tipNarrationText.DOText("· 침이 근처에 있는 사람의 입, 코에 닿거나, 호흡기를 통해 흡입 가능합니다.", 6.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(6.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        tipNarrationText.text = "";
        tipNarrationText.DOText("· COVID-19는 무증상자를 통해서도 전파 가능합니다.", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        tipNarrationText.text = "";
        tipNarrationText.DOText("5초 뒤 메인메뉴로 돌아갑니다.", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(5.0f);
        audioSource.Stop();
        SceneManager.LoadScene("SelectVR");
    }
}
