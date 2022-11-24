using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class BrinkText : MonoBehaviour
{
    public float speed;
    private float time;
    private TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.GetComponent<TextMeshProUGUI>();
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Color color = text.color;
        time += Time.deltaTime * speed;
        // Mathf.Sin()ÇÕ-1Å`1Çï‘Ç∑
        // colorÇÕ0Å`1Ç≈éwíËÇ∑ÇÈ
        color.a = Mathf.Sin(time) * 0.5f + 0.5f;
        text.color = color;
    }
}
