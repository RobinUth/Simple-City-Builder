using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City : MonoBehaviour {

    
    public int Cash { get; set; }
    public int Day { get; set; }
    public float PopulationCurrent { get; set; }
    public float PopulationCeiling { get; set; }
    public int JobsCurrent { get; set; }
    public int JobsCeiling { get; set; }
    public float Food { get; set; }

    public int[] buildingCounts = new int[3];


    private void Start()
    {
        Cash = 10000;
        Food = 6;
        JobsCeiling = 10;
    }

    public void EndTurn()
    {
        Day++;
        CalculateJobs();
        CalculateFood();
        CalculateCash();
        Debug.Log("day ended");
    }

    void CalculateJobs()
    {
        JobsCeiling = buildingCounts[2] * 10;
        JobsCurrent = Mathf.Min((int)PopulationCurrent, JobsCeiling);
    }

    void CalculateCash()
    {
        Cash += JobsCurrent * 2;
    }

    void CalculateFood()
    {
        Food += buildingCounts[1] * 4f;
    }

    void CalculatePopulation()
    {
        PopulationCeiling = buildingCounts[0] * 5;
    }




}
