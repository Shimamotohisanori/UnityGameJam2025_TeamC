using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Result : MonoBehaviour
{
   public Shell shell; // Shell�N���X�̃C���X�^���X���Q�Ƃ��邽�߂̕ϐ�

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Shell.Score = 0; // �X�R�A�����Z�b�g
            SceneManager.LoadScene("TetileScene");//���U���g�V�[����Enter�L�[�܂��̓}�E�X�̍��N���b�N����������^�C�g���V�[���Ɉړ�
        }
    }
}
