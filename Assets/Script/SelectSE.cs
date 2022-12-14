using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SelectSE : MonoBehaviour
{
 
    private AudioSource SpaceAudio;
    private AudioSource ArrowAudio;
    public AudioClip SpaceSE;
    public AudioClip ArrowSE;
    private AudioSource BGMAudio;
    public AudioClip BGM;
    // Start is called before the first frame update
    void Start()
    {
        SpaceAudio = gameObject.AddComponent<AudioSource>();
        SpaceAudio.clip = SpaceSE;
        SpaceAudio.loop = false;
        ArrowAudio = gameObject.AddComponent<AudioSource>();
        ArrowAudio.clip = ArrowSE;
        ArrowAudio.loop = false;
        BGMAudio = gameObject.AddComponent<AudioSource>();
        BGMAudio.clip = BGM;
        BGMAudio.loop = true;
        BGMAudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        //�㉺���E�̖�󂪉����ꂽ��SE��炷
        if(Input.GetKeyDown(KeyCode.UpArrow) || 
           Input.GetKeyDown(KeyCode.DownArrow) ||
           Input.GetKeyDown(KeyCode.LeftArrow) ||
           Input.GetKeyDown(KeyCode.RightArrow))
        {
            ArrowAudio.Play();
        }
        //�X�y�[�X�L�[�������ꂽ��
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SpaceAudio.Play();
        }
    }
}
