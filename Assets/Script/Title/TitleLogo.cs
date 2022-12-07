using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TitleLogo : MonoBehaviour
{
    public float fadetime = 1f;
    private float timer;
    private TextMeshProUGUI title;

    private AudioSource SpaceAudio;
    private AudioSource BGMAudio;
    public AudioClip SpaceSE;
    public AudioClip BGMSE;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<TextMeshProUGUI>().alpha = 0;

        SpaceAudio = gameObject.AddComponent<AudioSource>();
        SpaceAudio.clip = SpaceSE;
        SpaceAudio.loop = false;
        BGMAudio = gameObject.AddComponent<AudioSource>();
        BGMAudio.clip = BGMSE;
        BGMAudio.loop = true;

        BGMAudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        this.gameObject.GetComponent<TextMeshProUGUI>().alpha = timer/fadetime;

        //スペースキーが押されたら
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpaceAudio.Play();
        }
    }
}
