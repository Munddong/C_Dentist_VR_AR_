using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HospitalNarration : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip keyboard;
    public Text hospitalNarrationText;

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

    IEnumerator StartDialogue()
    {
        yield return new WaitForSeconds(2.0f);
        hospitalNarrationText.text = "";
        hospitalNarrationText.DOText(" #병   원# ", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        hospitalNarrationText.text = "";
        hospitalNarrationText.DOText("열과 몸살이 심해진 아지는 제튼 병원에 가게 된다.", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        yield return new WaitForSeconds(1.0f);
        hospitalNarrationText.text = "";
        hospitalNarrationText.DOText("과연 아지에게는 무슨 일이 생길까?", 3.0f);
        audioSource.clip = keyboard;
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();

        SceneManager.LoadScene("Hospital");
    }
}
