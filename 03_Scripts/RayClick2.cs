using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RayClick2 : MonoBehaviour
{
    private AudioSource audioSource; // 카세트

    public AudioClip keyboard; // 키보드 소리

    public Image cursorGauge;

    public GameObject top;
    public GameObject liquid;
    public GameObject rightHand;
    public GameObject virus;
    public GameObject virus1;
    public GameObject virus2;
    public GameObject virus3;
    public GameObject narration;
    public GameObject image;
    public Text narrationText;

    private float gaugeTimer = 0.0f;
    private float gazeTime = 3.0f;

    bool hand = false;

    public BoxCollider boxcollider;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        StartCoroutine(Dialogue_HospitalPractice());
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
            if (hit.transform.tag.Equals("Disinfectant")) // == 보다 Equals가 계산량이 빠름
            {
                gaugeTimer += 1.0f / gazeTime * Time.deltaTime;

                if (gaugeTimer >= 1.0f)
                {
                    image.SetActive(false);
                    boxcollider.GetComponent<BoxCollider>().enabled = false;
                    top.GetComponent<Animator>().enabled = true;
                    liquid.SetActive(true);
                    StartCoroutine(Wash());
                    StartCoroutine(Dialogue_HospitalPractice_1());
                }
            }
        }
        else
        {
            gaugeTimer = 0.0f;
        }
    }

    IEnumerator Wash()
    {
        yield return new WaitForSeconds(3.0f);
        rightHand.SetActive(true);
        hand = true;

        if (hand == true)
        {
            StartCoroutine(Virus());
        }
    }

    IEnumerator Virus() // 팁 함수
    {
        yield return new WaitForSeconds(2.3f);
        liquid.SetActive(false);
        virus.SetActive(false);

        yield return new WaitForSeconds(2.3f);
        virus1.SetActive(false);

        yield return new WaitForSeconds(2.3f);
        virus2.SetActive(false);

        yield return new WaitForSeconds(2.3f);
        virus3.SetActive(false);
    }

    IEnumerator Dialogue_HospitalPractice()
    {
        yield return new WaitForSeconds(2.0f);
        narrationText.text = "";
        narrationText.DOText("소독제를 올바르게 쓰는 방법", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        image.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("소독제를 3초간 바라봐주세요!", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();
    }

    IEnumerator Dialogue_HospitalPractice_1()
    {
        yield return new WaitForSeconds(1.0f);
        narrationText.text = "";
        narrationText.DOText("물로 손을 씻을 수 없을 때는 손소독제를", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        narrationText.text = "";
        narrationText.DOText("사용하면 손쉽게 위생을 챙길 수 있습니다.", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        narrationText.text = "";
        narrationText.DOText("물로 씻을 때와 같은 동작으로 손의 모든 부위에 신경써 발라주고,", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        narrationText.text = "";
        narrationText.DOText("소독제가 *모두 마를 때까지* 두 손을 잘 문질러주세요.", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        narrationText.text = "";
        narrationText.DOText("소독제는 상처가 없는 피부에 사용해야 하며,", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        narrationText.text = "";
        narrationText.DOText("주의해야할 것은 눈, 구강, 점막 등과 같은 부위에는", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        narrationText.text = "";
        narrationText.DOText("자극을 주기 때문에 사용하지 않아야 합니다.", 3.0f);
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
        SceneManager.LoadScene("Hospital1");
    }
}