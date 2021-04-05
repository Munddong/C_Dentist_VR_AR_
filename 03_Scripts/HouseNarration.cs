using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HouseNarration : MonoBehaviour
{
    private AudioSource audioSource; // 카세트
    public AudioClip keyboard; // 키보드 소리
    public Text houseNarrationText; // 나래이션 텍스트

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

    IEnumerator StartDialogue() // 집 씬 다이얼로그 함수
    {
        yield return new WaitForSeconds(2.0f);
        houseNarrationText.text = "";
        houseNarrationText.DOText(" # 집 # ", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        houseNarrationText.text = "";
        houseNarrationText.DOText("병원에 갔다온 아지는 양성판정(확진)을 받게 되고,", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        houseNarrationText.text = "";
        houseNarrationText.DOText("아지는 38° 고열과 기침을 계속 하게 된다.", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(4.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        houseNarrationText.text = "";
        houseNarrationText.DOText("확진이 된 아지는 어떻게 행동해야 하는지 알아보자.", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene("House");
    }
}
