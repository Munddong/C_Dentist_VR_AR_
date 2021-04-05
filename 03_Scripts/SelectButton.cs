using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadDevice("none", true));
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Subway()
    {
        SceneManager.LoadScene("SubwayNarration");
    }

    public void Hospital()
    {
        SceneManager.LoadScene("HospitalNarration");
    }

    public void House()
    {
        SceneManager.LoadScene("HouseNarration");
    }

    public void Tip()
    {
        SceneManager.LoadScene("Intro");
    }

    IEnumerator LoadDevice(string newDevice, bool enable)
    {
        UnityEngine.XR.XRSettings.LoadDeviceByName(newDevice);
        yield return null;
        UnityEngine.XR.XRSettings.enabled = enable;
    }
}
