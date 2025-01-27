using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a_SoundManager : MonoBehaviour
{
    public string targetTag = "TargetTag"; // 対象のタグを設定する
    public AudioClip collisionSound; // 効果音を設定する
    private AudioSource audioSource;
    private bool hasPlayedSound = false; // 効果音が再生されたかを追跡するフラグ

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = collisionSound;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (!hasPlayedSound && collision.gameObject.CompareTag(targetTag))
        {
            audioSource.Play();
            hasPlayedSound = true; // 効果音を一度だけ再生するようにフラグを設定する
        }
    }
}
