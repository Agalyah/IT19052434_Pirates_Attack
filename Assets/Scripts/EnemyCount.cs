using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCount : MonoBehaviour
{
    Text text;

    public static int enemyAmount;

    private void Start()
    {
        text = GetComponent<Text>();
    }

    private void Update()
    {
        text.text = enemyAmount.ToString();
    }
}
