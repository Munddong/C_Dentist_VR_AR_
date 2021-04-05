using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Narration_Subway : MonoBehaviour
{
    private AudioSource audioSource; // 카세트

    public AudioClip keyboard; // 키보드 소리
    public AudioClip doorOpen; // 문 열리는 소리
    public AudioClip doorClose; // 문 닫히는 소리

    public GameObject narration;
    public GameObject hobbangFace;
    public GameObject aziFace;
    public GameObject aziMask;
    public GameObject collider; // 충돌체크
    public GameObject collider1;
    public GameObject collider2;
    public GameObject door;
    public GameObject door1;
    public GameObject door2;
    public GameObject door3;
    public GameObject location1; //
    public GameObject gira;

    public float speed;

    public Text narrationText;

    HobbangMove hobbangMoveScript_Narration_Subway; // HobbangMove스크립트 에서 변수 및 함수 등을 쓸 수 있게 함

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        hobbangMoveScript_Narration_Subway = GameObject.Find("Hobbang").GetComponent<HobbangMove>(); // 호빵이 인스펙터 값을 가져옴

        StartCoroutine(Dialogue_Subway());

        speed = 0f;
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Dialogue_Subway() // 지하철 다이얼로그 함수
    {
        narration.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("아지를 향해 따라가 보세요!", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();
        narration.SetActive(false);
    }

    private void OnTriggerEnter(Collider other) // 충돌 했을 시 시작되는 함수
    {
        if (other.transform.tag.Equals("Collider"))
        {
            hobbangMoveScript_Narration_Subway.player.GetComponent<CharacterController>().enabled = false;
            narration.SetActive(true);
            StartCoroutine(Dialogue_Collider());
            collider.SetActive(false);
        }

        else if (other.transform.tag.Equals("Collider1"))
        {
            hobbangMoveScript_Narration_Subway.player.GetComponent<CharacterController>().enabled = false;
            narration.SetActive(true);
            StartCoroutine(Dialogue_Collider1());
            collider1.SetActive(false);
        }

        else if (other.transform.tag.Equals("Collider2"))
        {
            location1.SetActive(false);
            collider2.SetActive(false);
            hobbangMoveScript_Narration_Subway.player.GetComponent<CharacterController>().enabled = false;
            StartCoroutine(DoorOpen());
        }
    }

    IEnumerator Dialogue_Collider() // 충돌했을 시 나오는 다이얼로그 함수
    {
        narrationText.text = "";
        narrationText.DOText("밑쪽을 바라봐주세요!", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(3.0f);
        narrationText.text = "";
        narrationText.DOText("외출하거나 사람이 많은 곳은 적정한 거리를 두어야합니다.", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        narrationText.text = "";
        narrationText.DOText("다른 사람과의 간격을  2m 정도로 유지하세요!", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();
        yield return new WaitForSeconds(1.0f);
        narration.SetActive(false);
        hobbangMoveScript_Narration_Subway.player.GetComponent<CharacterController>().enabled = true;
    }

    IEnumerator Dialogue_Collider1()
    {
        narrationText.text = "";
        narrationText.DOText("아지와 함께 지하철을 타세요!", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();
        narration.SetActive(false);
        location1.SetActive(true);
        hobbangMoveScript_Narration_Subway.player.GetComponent<CharacterController>().enabled = true;
    }

    IEnumerator objectRotate(GameObject move, Quaternion dir) // 회전
    {
        yield return new WaitForSeconds(1.0f);
        while (true)
        {
            move.transform.rotation = Quaternion.Lerp(move.transform.rotation, dir, 1.0f * Time.deltaTime);
            yield return null;
        }
    }

    IEnumerator DoorOpen() // 문 관련 함수
    {
        hobbangMoveScript_Narration_Subway.speed = 0f;
        narration.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("전철 안으로 들어가주세요!", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();
        yield return new WaitForSeconds(1.0f);
        audioSource.PlayOneShot(doorOpen);
        yield return new WaitForSeconds(1.0f);
        hobbangMoveScript_Narration_Subway.player.GetComponent<CharacterController>().enabled = true;
        narration.SetActive(false);
        door.SetActive(false);
        door1.SetActive(false);
        door2.SetActive(false);
        door3.SetActive(false);
        speed = 1.0f;
        yield return new WaitForSeconds(5.0f);
        collider2.SetActive(false);
        audioSource.PlayOneShot(doorClose);
        yield return new WaitForSeconds(3.0f);
        StartCoroutine(Stop());
        yield return new WaitForSeconds(5.0f);

        narration.SetActive(true);
        hobbangFace.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("아지야, 감기몸살은 괜찮아? 요즘 코로나 바이러스가 유행이래...", 4.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(4.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        hobbangFace.SetActive(false);
        aziFace.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("아직 감기몸살 기운이 있는 것 같아.. 옆에 저 사람은 계속 기침을 하네?", 4.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(4.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        aziFace.SetActive(false);
        hobbangFace.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("!? 아지야, 그러고 보니 너 마스크를 안꼈잖아...", 3.5f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.5f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        hobbangFace.SetActive(false);
        aziFace.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("마스크? 마스크는 너무 답답하고 땀차고 귀찮아. 하기 싫은데?", 4.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(4.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        aziFace.SetActive(false);
        hobbangFace.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("큰일 날 소리를 하네... 마스크를 안 끼고 다니면 코로나에 걸린다구!", 4.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(4.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        narrationText.text = "";
        narrationText.DOText("전염으로 쉽게 걸리는 병이기 때문에 꼭 쓰고 다녀야 해!", 4.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(4.0f);

        yield return new WaitForSeconds(1.0f);
        narrationText.text = "";
        narrationText.DOText("또 너가 다른 사람들에게 피해를 줄 수 있잖아...", 3.5f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.5f);

        yield return new WaitForSeconds(1.0f);
        hobbangFace.SetActive(false);
        aziFace.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("알겠어.. 다음 부터 외출할 때 꼭 마스크를 낄게,, 콜록 콜록", 4.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(4.0f);
        audioSource.Stop();
        aziMask.SetActive(true);

        yield return new WaitForSeconds(1.0f);
        aziFace.SetActive(false);
        hobbangFace.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("한 가지 더! 마스크는 꼭 입과 코 모두 다 막게 써야해, 그래야 확실하다구!", 4.5f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(4.5f);
        audioSource.Stop();

        yield return new WaitForSeconds(3.0f);

        SceneManager.LoadScene("SubwayPractice");
    }

    IEnumerator Stop() // 호빵이의 속도 및 기침소리 함수
    {
        hobbangMoveScript_Narration_Subway.player.GetComponent<CharacterController>().enabled = false;
        door.SetActive(true);
        door1.SetActive(true);
        door2.SetActive(true);
        door3.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        gira.GetComponent<Cough>().enabled = true;
    }
}
