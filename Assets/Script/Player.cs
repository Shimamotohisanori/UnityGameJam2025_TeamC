using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField,Header("�ړ����x")]//��������邱�Ƃɂ����unity��ʂł����x�̕ҏW���\
    private float moveSpeed;//�ړ����x�����邽�߂̕ϐ�

    public GameObject ShellPrefab;//�e��Prefab�����邽�߂̕ϐ�
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))//W�L�[�������Ă���ԏ�ɓ���
        {
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S))//S�L�[�������Ă���ԉ��ɓ���
        {
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A))//A�L�[�������Ă���Ԍ��ɓ���
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D))//D�L�[�������Ă���ԑO�ɓ���
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))//�X�y�[�X�L�[����������e���o��
        {
            GameObject shell = Instantiate(ShellPrefab, transform.position, Quaternion.identity);//�e��Prefab�𐶐�
            Rigidbody shellRb = shell.GetComponent<Rigidbody>();//�e��Rigidbody���擾
            shellRb.AddForce(transform.forward * 500);//�e�̈ړ����x
            Destroy(shell, 4);//4�b��ɒe���폜
        }
    }
}
