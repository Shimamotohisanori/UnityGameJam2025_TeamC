using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    public string shellName = "Shell"; // �e�̖��O
    public string MeteoTag = "Meteo"; // ���f���̃^�O
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(MeteoTag)) // ���f���ɏՓ˂����ꍇ
        {
            Destroy(other.gameObject); // ���f�����폜
            Destroy(gameObject); // �e���폜
        }
    }
}
