using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField,Header("�ړ����x")]//��������邱�Ƃɂ����unity��ʂł����x�̕ҏW���\
    private float moveSpeed;//�ړ����x�����邽�߂̕ϐ�

    public GameObject ShellPrefab;//�e��Prefab�����邽�߂̕ϐ�

    [SerializeField, Header("�e�̈ړ����x")]
    private float shellSpeed = 700f; // �e�̈ړ����x�����邽�߂̕ϐ�

    [SerializeField, Header("�e�̍폜����")]
    private float shellDestroyTime = 3f; // �e�̍폜���Ԃ����邽�߂̕ϐ�

    private float time = 0; // ���Ԃ��J�E���g���邽�߂̕ϐ�

    [SerializeField,Header("�A�ˊԊu")]
    private float timeinterval = 0.5f; // �A�ˊԊu�����邽�߂̕ϐ�

    private AudioSource audioSource; // AudioSource�R���|�[�l���g�����邽�߂̕ϐ�
    public AudioClip shotSound; // �e���������Ƃ��̉������邽�߂̕ϐ�
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // AudioSource�R���|�[�l���g���擾
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime; // ���Ԃ��J�E���g

        if (Input.GetKey(KeyCode.UpArrow))//����L�[�������Ă���ԏ�ɓ���
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))//�����L�[�������Ă���ԉ��ɓ���
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))//�����L�[�������Ă���Ԍ��ɓ���
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))//�E���L�[�������Ă���ԑO�ɓ���
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
        //if (Input.GetKey(KeyCode.W))//W�L�[�������Ă���ԏ�ɓ���
        //{
        //    transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        //}
        //if(Input.GetKey(KeyCode.S))//S�L�[�������Ă���ԉ��ɓ���
        //{
        //    transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        //}
        //if(Input.GetKey(KeyCode.A))//A�L�[�������Ă���Ԍ��ɓ���
        //{
        //    transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        //}
        //if(Input.GetKey(KeyCode.D))//D�L�[�������Ă���ԑO�ɓ���
        //{
        //    transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        //}

        if (time > timeinterval)
        {
            if (Input.GetKey(KeyCode.Space))//�X�y�[�X�L�[����������e���o��
            {
                audioSource.PlayOneShot(shotSound); // �e���������Ƃ��̉����Đ�
                time = 0; // ���Ԃ����Z�b�g
                GameObject shell = Instantiate(ShellPrefab, transform.position, Quaternion.identity);//�e��Prefab�𐶐�
                Rigidbody shellRb = shell.GetComponent<Rigidbody>();//�e��Rigidbody���擾
                shellRb.AddForce(transform.forward * shellSpeed);//�e�̈ړ����x
                Destroy(shell, shellDestroyTime);//3�b��ɒe���폜
            }
        }

        if(transform.position.y < -14)//�v���C���[�����ɗ�������
        {
            transform.position = new Vector3(0, 0, 10);//�v���C���[�̈ʒu�����Z�b�g
        }
        if(transform.position.y > 14)//�v���C���[����ɍs����������
        {
            transform.position = new Vector3(0, 0, 10);//�v���C���[�̈ʒu�����Z�b�g
        }
        if (transform.position.x < -26)//�v���C���[�����ɍs����������
        {
            transform.position = new Vector3(0, 0, 10);//�v���C���[�̈ʒu�����Z�b�g
        }
        if (transform.position.x > 26)//�v���C���[���E�ɍs����������
        {
            transform.position = new Vector3(0, 0, 10);//�v���C���[�̈ʒu�����Z�b�g
        }

        
    }

   
}
