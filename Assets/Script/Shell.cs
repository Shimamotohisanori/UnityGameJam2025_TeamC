using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Shell : MonoBehaviour
{
    //public string shellName = "Shell"; // �e�̖��O
    public string MeteoTag = "Meteo"; // ���f���̃^�O

    public static int Score = 0; // �X�R�A��ێ�����ÓI�ϐ�

    public TextMeshProUGUI score;// �X�R�A��\�����邽�߂�TextMeshProUGUI�R���|�[�l���g

    [SerializeField, Header("1���̃X�R�A")]
    private int pulusScore = 100; // 1�̏��f����j�󂵂��Ƃ��ɉ��Z�����X�R�A

    private AudioSource conflictaudioSource; // AudioSource�R���|�[�l���g�����邽�߂̕ϐ�
    public AudioClip conflictSound; // ���f���ɏՓ˂����Ƃ��̉������邽�߂̕ϐ�
    // Start is called before the first frame update
    void Start()
    {
        conflictaudioSource = GetComponent<AudioSource>(); // AudioSource�R���|�[�l���g���擾
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + Score; // �X�R�A��\���X�V

        
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag(MeteoTag)) // ���f���ɏՓ˂����ꍇ
        {
            conflictaudioSource.PlayOneShot(conflictSound); // ���f���ɏՓ˂����Ƃ��̉����Đ�
            Score += pulusScore; // �X�R�A�����Z

            Destroy(other.gameObject); // ���f�����폜
            Destroy(gameObject,conflictSound.length); // �e���폜
        }
    }
}
