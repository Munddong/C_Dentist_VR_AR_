using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class CameraMove : MonoBehaviour
{
    private AudioSource audioSource;

    public AudioClip keyboard;

    public GameObject mainCam;
    public GameObject narration;
    public GameObject mask;
    public GameObject mask1;
    public GameObject mask2;
    public GameObject blackParticle;
    public GameObject x;
    public GameObject table;
    public GameObject demoHead;

    public Text narrationText;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        StartCoroutine(Move());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Move()
    {
        yield return new WaitForSeconds(1.0f);
        narration.SetActive(true);
        narrationText.DOText("마스크를 올바르게 쓰는 방법", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        mask.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("#1. 첫째, 마스크 착용시 코를 막지 않고 입만 막는 경우", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();
        yield return new WaitForSeconds(1.0f);
        x.SetActive(true);
        narration.SetActive(false);

        yield return new WaitForSeconds(2.5f);
        x.SetActive(false);
        mask.SetActive(false);
        yield return new WaitForSeconds(3.0f);
        narration.SetActive(true);
        mask1.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("#2. 둘째, 마스크를 턱에 내려 놓고 말을 하는 경우", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();
        yield return new WaitForSeconds(1.0f);
        x.SetActive(true);
        narration.SetActive(false);

        yield return new WaitForSeconds(2.5f);
        x.SetActive(false);
        mask1.SetActive(false);
        table.SetActive(true);
        mainCam.transform.position = new Vector3 (0.82f, 0.16f, 0.13f);
        mainCam.transform.Rotate(new Vector3(43.148f, 0f, 0f));
        demoHead.SetActive(false);
        yield return new WaitForSeconds(1.0f);
        narration.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("#3. 셋째, 착용하던 마스크를 식탁 위에 올려놓는 경우", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();
        yield return new WaitForSeconds(1.0f);
        x.SetActive(true);
        narration.SetActive(false);

        yield return new WaitForSeconds(2.5f);
        x.SetActive(false);
        table.SetActive(false);
        mask2.SetActive(true);
        demoHead.SetActive(true);
        mainCam.transform.position = new Vector3(0f, 0f, -0.08f);
        mainCam.transform.Rotate(new Vector3(-43.148f, 0f, 0f));
        blackParticle.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        narration.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("#4. 넷째, 마스크 앞부분을 맨손으로 만지는 경우", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();
        blackParticle.SetActive(false);
        yield return new WaitForSeconds(1.0f);
        x.SetActive(true);
        narration.SetActive(false);

        yield return new WaitForSeconds(2.5f);
        x.SetActive(false);
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
