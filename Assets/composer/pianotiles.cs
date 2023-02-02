using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pianotiles : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource audioSource1;
    public List<AudioClip> audios = new List<AudioClip>();
    public List<string> recordAudioname = new List<string>();
    public List<AudioClip> recordAudio = new List<AudioClip>();

    public Text recordText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void PlayAudio(int index)
    {
        audioSource.clip = audios[index];
        audioSource.Play();
        recordAudioname.Add(audios[index].name);
        recordAudio.Add(audios[index]);

        ShowRecordText();
    }

    IEnumerator PlayRecord()
    {
        
        for (int i = 0; i < recordAudio.Count; i++)
        {
            audioSource.clip = recordAudio[i];
            Debug.Log(audioSource.clip.name);
            audioSource.Play();
            yield return new WaitForSeconds(audioSource.clip.length);
        }
    }

    public void PlayRecordAudio() {
        StartCoroutine(PlayRecord());

    }

    void ShowRecordText()
    {
        recordText.text = "";
        for (int i = 0; i< recordAudioname.Count; i ++)
        {
            recordText.text = recordText.text + "   " + recordAudioname[i];
        }
    }

    public void DeleRecord()
    {
        recordAudioname.Remove(recordAudioname[recordAudioname.Count - 1]);
        recordAudio.Remove(recordAudio[recordAudio.Count - 1]);
        ShowRecordText();
    }
}
