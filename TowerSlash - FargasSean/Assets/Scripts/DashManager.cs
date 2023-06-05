using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DashManager : MonoBehaviour
{
    public Image dashGauge;
    public float dashAmount = 100f;

    void Start()
    {
        dashAmount = 0f;
    }

    void Update()
    {
        
    }
    
    public void AddDashPoints(float points)
    {
        dashAmount += points;
        dashGauge.fillAmount = dashAmount / 100f;
    }
}
