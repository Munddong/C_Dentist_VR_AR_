using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Narration_House : MonoBehaviour
{
    private AudioSource audioSource; // 카세트

    public AudioClip keyboard; // 키보드 소리

    public GameObject narration;
    public GameObject hobbangFace;
    public GameObject aziFace;
    public GameObject sangaFace;
    public GameObject backGround;
    public GameObject CursorGauge;
    public GameObject walking;
    public GameObject city;
    public GameObject x;
    public GameObject iphone;
    public GameObject aziSpeechBox;
    public GameObject sangaImage;
    public GameObject sangaSpeechBox;
    public GameObject sangaSpeechBox1;
    public GameObject sangaSpeechBox2;
    public GameObject houseImage;
    public GameObject washHandImage;
    public GameObject disinfectantImage;
    public GameObject do_not_TouchImage;
    public GameObject cleanImage;
    public GameObject disposableGlovesImage;
    public GameObject maskImage;

    public Text narrationText;

    HobbangMove hobbangMoveScript_PlayerCtrl;

    // Start is called before the first frame update
    void Start()
    {
        hobbangMoveScript_PlayerCtrl = GameObject.Find("Hobbang").GetComponent<HobbangMove>();

        audioSource = GetComponent<AudioSource>();

        StartCoroutine(Dialogue_House());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Dialogue_House() // 지하철 다이얼로그 함수
    {
        hobbangMoveScript_PlayerCtrl.player.GetComponent<CharacterController>().enabled = false;
        yield return new WaitForSeconds(1.0f);
        narrationText.text = "";
        narrationText.DOText("아지는 상아 의사 선생님과 했던 이야기를 떠올린다.", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        backGround.SetActive(true);
        narration.SetActive(false);
        yield return new WaitForSeconds(5.0f);
        narration.SetActive(true);
        sangaFace.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("아지군, 지금부터 제가 하는 말을 잘 들으세요.", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        narrationText.text = "";
        narrationText.DOText("코로나 확산 방지를 위해 감염자가 취할 수 있는 조치를 알려드릴게요.", 4.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(4.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        walking.SetActive(true);
        city.SetActive(true);
        x.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("1. 의료 기관을 방문하는 것 외에는 외출을 삼가하세요.", 5.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(5.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        aziFace.SetActive(true);
        sangaFace.SetActive(false);
        walking.SetActive(false);
        city.SetActive(false);
        x.SetActive(false);
        narrationText.text = "";
        narrationText.DOText("상아쌤~   궁금한게 있어요!", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        aziFace.SetActive(false);
        sangaFace.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("네, 궁금한 것이 무엇 인가요??", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        iphone.SetActive(true);
        sangaFace.SetActive(false);
        narration.SetActive(false);

        yield return new WaitForSeconds(1.0f);
        aziSpeechBox.SetActive(true);

        yield return new WaitForSeconds(3.0f);
        sangaImage.SetActive(true);
        sangaSpeechBox.SetActive(true);

        yield return new WaitForSeconds(3.0f);
        sangaSpeechBox1.SetActive(true);

        yield return new WaitForSeconds(3.0f);
        sangaSpeechBox2.SetActive(true);

        yield return new WaitForSeconds(3.0f);
        iphone.SetActive(false);
        sangaFace.SetActive(true);
        narration.SetActive(true);
        houseImage.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("2. 다른 사람들로부터 자가 격리하세요.", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        narrationText.text = "";
        narrationText.DOText("되도록 정해진 한 군데 방에서 머물러주세요.", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(3.0f);
        houseImage.SetActive(false);
        washHandImage.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("3. 손을 자주 씻으세요.", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        narrationText.text = "";
        narrationText.DOText("자주 비누와 물로 20초 이상 손을 씻어야 해요.", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(2.0f);
        disinfectantImage.SetActive(true);

        yield return new WaitForSeconds(1.0f);
        narrationText.text = "";
        narrationText.DOText("손 소독제를 사용해도 되고,", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        washHandImage.SetActive(false);
        disinfectantImage.SetActive(false);
        do_not_TouchImage.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("씻지 않은 손으로 눈, 코, 입을 만지지 마세요.", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(2.0f);
        aziFace.SetActive(true);
        sangaFace.SetActive(false);
        do_not_TouchImage.SetActive(false);
        narrationText.text = "";
        narrationText.DOText("알겠습니다! 이 외에는 더 없나요?", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        aziFace.SetActive(false);
        sangaFace.SetActive(true);
        cleanImage.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("마지막으로 자주 접촉하는 표면을 모두 청소하세요.", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        narrationText.text = "";
        narrationText.DOText("자주 닿는 물건의 표면을 청소 및 소독하세요.", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        cleanImage.SetActive(false);
        disposableGlovesImage.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("간병인 또는 다른 사람이 청소하고 소독해야 하는 경우,", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        maskImage.SetActive(true);

        yield return new WaitForSeconds(1.0f);
        narrationText.text = "";
        narrationText.DOText("오랜시간이 지난 후 꼭 마스크와 일회용 장갑을 끼고 청소해야합니다.", 4.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(4.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(2.0f);
        disposableGlovesImage.SetActive(false);
        maskImage.SetActive(false);
        backGround.SetActive(false);
        sangaFace.SetActive(false);
        narration.SetActive(false);
        hobbangMoveScript_PlayerCtrl.player.GetComponent<CharacterController>().enabled = true;

        yield return new WaitForSeconds(1.0f);
        narration.SetActive(true);
        hobbangFace.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("아지야 몸은 좀 괜찮아? 무슨생각을 그렇게 하는거야!", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        hobbangFace.SetActive(false);
        aziFace.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("지금은 괜찮아, 의사쌤이랑 이야기한 거 생각하고 있었어.", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        hobbangFace.SetActive(true);
        aziFace.SetActive(false);
        narrationText.text = "";
        narrationText.DOText("그나저나 외출하고 집에 왔으니 손부터 얼른 씻자!", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        hobbangFace.SetActive(false);
        aziFace.SetActive(false);
        CursorGauge.SetActive(true);
        narrationText.text = "";
        narrationText.DOText("비누를 3초간 바라봐주세요!", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();
    }
}
