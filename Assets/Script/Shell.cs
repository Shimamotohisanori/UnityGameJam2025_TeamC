using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    public string shellName = "Shell"; // ’e‚Ì–¼‘O
    public string MeteoTag = "Meteo"; // ¬˜f¯‚Ìƒ^ƒO
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
        if (other.CompareTag(MeteoTag)) // ¬˜f¯‚ÉÕ“Ë‚µ‚½ê‡
        {
            Destroy(other.gameObject); // ¬˜f¯‚ğíœ
            Destroy(gameObject); // ’e‚ğíœ
        }
    }
}
