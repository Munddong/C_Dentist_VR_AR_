using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navi : MonoBehaviour
{

    NavMeshAgent agent; // 네비매쉬
    Animator animator; // 에니메이터
    [SerializeField] private Transform tf_Destination; // 목적지

    public GameObject azi;
    public GameObject azi2;
    public GameObject collider3;

    public float speed;

    Narration_Subway narration_SubwayScript_Navi; // Narration_Subway 스크립트 에서 변수 및 함수 등을 쓸 수 있게 함

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();

        agent.isStopped = false;

        speed = 3.0f;

        narration_SubwayScript_Navi = GameObject.Find("Hobbang").GetComponent<Narration_Subway>(); // 호빵이 인스펙터 값을 가져옴
    }

    // Update is called once per frame
    void Update()
    {
        Patrol();

        if (agent.speed == 0f)
        {
            animator.enabled = false;

            StartCoroutine(objectRotate(azi, Quaternion.Euler(0f, 90.0f, 0)));

            StartCoroutine(AziMove());
        }
    }

    private void Patrol() // 목적지까지 움직이게 하는 함수
    {
        agent.SetDestination(tf_Destination.position);

        if (Vector3.Distance(transform.position, tf_Destination.position) < 13.5f)
        {
            agent.speed = 0f;
        }
    }

    private void OnTriggerEnter(Collider other) // 충돌 했을 시 시작되는 함수
    {
        if (other.transform.tag.Equals("Collider3"))
        {
            azi.SetActive(false);
            azi2.SetActive(true);
            collider3.SetActive(false);
        }
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

    IEnumerator AziMove() // 아지의 움직임 함수
    {
        if (narration_SubwayScript_Navi.speed == 1.0f)
        {
            azi.transform.Translate((Vector3.forward) * Time.deltaTime * speed);
            animator.enabled = true;
        }
        yield return null;
    }
}
