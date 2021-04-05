using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cough : MonoBehaviour
{
    private AudioSource audioSource; // 카세트
    public AudioClip coughSound; // 기침 소리

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(GiraCough());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator GiraCough() // 반복된 시간마다 기침 소리를 내는 함수
    {
        while (true)
        {
            audioSource.clip = coughSound;
            audioSource.Play();
            yield return new WaitForSeconds(6.5f);
        }
    }
}
