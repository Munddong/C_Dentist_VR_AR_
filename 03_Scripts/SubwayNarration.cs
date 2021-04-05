using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SubwayNarration : MonoBehaviour
{
    private AudioSource audioSource; // 카세트
    public AudioClip keyboard; // 키보드 소리
    public Text subwayNarrationText; // 나래이션 텍스트

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

    IEnumerator StartDialogue() // 지하철 씬 다이얼로그 함수
    {
        yield return new WaitForSeconds(2.0f);
        subwayNarrationText.text = "";
        subwayNarrationText.DOText(" #지하철# ", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        subwayNarrationText.text = "";
        subwayNarrationText.DOText("호빵이와 아지는 사람 많은 지하철에 오게 된다.", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        subwayNarrationText.text = "";
        subwayNarrationText.DOText("마스크를 쓰지 않고 지하철을 탄 아지는 어떻게 될까?", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        SceneManager.LoadScene("Subway");
    }
}
