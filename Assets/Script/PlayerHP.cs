using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    [SerializeField, Header("�v���C���[�̎c�@")]
    public int life = 5;//�v���C���[�̃��C�t�����邽�߂̕ϐ�

    public TextMeshProUGUI lifeText;//���C�t��\�����邽�߂�TextMeshProUGUI�R���|�[�l���g

    public GameObject asteroid_mod_01_lowPrefab;//���f����Prefab�����邽�߂̕ϐ�

    private AudioSource missaudioSource; // AudioSource�R���|�[�l���g�����邽�߂̕ϐ�
    public AudioClip missSound; // �@�̂�覐΂ɓ��������Ƃ��̉������邽�߂̕ϐ�
    // Start is called before the first frame update
    void Start()
    {
        missaudioSource = GetComponent<AudioSource>(); // AudioSource�R���|�[�l���g���擾
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Meteo"))
        {
            missaudioSource.PlayOneShot(missSound); // �@�̂�覐΂ɓ��������Ƃ��̉����Đ�
            life--;//���C�t��1���炷
            lifeText.text = "Life: " + life;//���C�t��\������
            if (life < 1)
            { 
                SceneManager.LoadScene("ResultScene");//���C�t��0�ȉ��ɂȂ����烊�U���g�V�[���Ɉړ�
                Destroy(gameObject);//�v���C���[�����f���ɓ���������v���C���[���폜
            }
        }
    }

}
