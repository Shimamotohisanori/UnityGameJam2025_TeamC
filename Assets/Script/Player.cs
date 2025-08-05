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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

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

        if (Input.GetKeyDown(KeyCode.Space))//�X�y�[�X�L�[����������e���o��
        {       
                GameObject shell = Instantiate(ShellPrefab, transform.position, Quaternion.identity);//�e��Prefab�𐶐�
                Rigidbody shellRb = shell.GetComponent<Rigidbody>();//�e��Rigidbody���擾
                shellRb.AddForce(transform.forward * shellSpeed);//�e�̈ړ����x
                Destroy(shell, shellDestroyTime);//3�b��ɒe���폜
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
