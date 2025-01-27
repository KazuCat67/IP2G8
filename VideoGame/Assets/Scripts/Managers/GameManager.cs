using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("Gem References")]
    public int gemCount = 0;
    public TextMeshProUGUI gemCountText;

    void Start()
    {
        gemCountText.text = gemCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddGems(int amount)
    {
        gemCount += amount;
        UpdateGemCountText();
    }

    private void UpdateGemCountText()
    {
        gemCountText.text = gemCount.ToString();
    }
}
