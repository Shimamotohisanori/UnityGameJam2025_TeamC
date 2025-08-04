using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField,Header("�ړ����x")]//��������邱�Ƃɂ����unity��ʂł����x�̕ҏW���\
    private float moveSpeed;//�ړ����x�����邽�߂̕ϐ�

    public GameObject ShellPrefab;//�e��Prefab�����邽�߂̕ϐ�

    public GameObject asteroid_mod_01_lowPrefab;//���f����Prefab�����邽�߂̕ϐ�
    Rigidbody rb;//Rigidbody�����邽�߂̕ϐ�
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();//Rigidbody���擾
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKey(KeyCode.W))//W�L�[�������Ă���ԏ�ɓ���
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S))//S�L�[�������Ă���ԉ��ɓ���
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A))//A�L�[�������Ă���Ԍ��ɓ���
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D))//D�L�[�������Ă���ԑO�ɓ���
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))//�X�y�[�X�L�[����������e���o��
        {
            GameObject shell = Instantiate(ShellPrefab, transform.position, Quaternion.identity);//�e��Prefab�𐶐�
            Rigidbody shellRb = shell.GetComponent<Rigidbody>();//�e��Rigidbody���擾
            shellRb.AddForce(transform.forward * 500);//�e�̈ړ����x
            Destroy(shell, 4);//4�b��ɒe���폜
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

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("asteroid_mod_01_low"))
        {
            Destroy(gameObject);//�v���C���[�����f���ɓ���������v���C���[���폜
        }
    }
}
