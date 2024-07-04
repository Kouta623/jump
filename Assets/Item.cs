using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Item : MonoBehaviour
{
    Animator _anim;
    AudioSource _audioSource;

    void Start()
    {
        _anim = GetComponent<Animator>();
        _audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.V))
        //{
        //    _anim.Play("Idle");
        //}

        //if (Input.GetKeyDown(KeyCode.C))
        //{
        //    _anim.Play("Get");
        //}
    }

    /// <summary>
    /// �l���A�j���[�V�����̍Đ����I�������Ă�
    /// �I�u�W�F�N�g��j������
    /// </summary>
    void OnGetAnimationFinished()
    {
        Debug.Log("�A�C�e����j�����܂�");
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        //Destroy(gameObject);
        Debug.Log(other.gameObject.name + " ���ڐG����");
        // _anim.Play("Get");
        _anim.SetBool("get", true);
        _audioSource.Play();
        //GetComponent<AudioSource>().Play();
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.gameObject.name + " �����ꂽ");
    }
}