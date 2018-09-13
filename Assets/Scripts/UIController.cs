using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIController : MonoBehaviour {

    [SerializeField]
    private Text dayText;
    [SerializeField]
    private Text cityText;
    private City city;

    private void Start()
    {
        city = GetComponent<City>();


    }

    public void UpdateCityData()
    {
        cityText.text =  string.Format("Jobs {0}/{1}\n Cash:${2} (+${6})\n Population {3} / {4}\n food: {5}", city.JobsCurrent, city.JobsCeiling, city.Cash, (int)city.PopulationCurrent, (int)city.PopulationCeiling, city.Food, city.JobsCurrent * 2);
    }

    public void UpdateDayCount()
    {
        dayText.text = string.Format("Day {0}", city.Day);
    }

}
