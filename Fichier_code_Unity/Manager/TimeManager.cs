using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

public class TimeManager : MonoBehaviour
{
    public event Action<float> OnTimeChanged;
    public float MinTime { get; private set; }
    public float MaxTime { get; private set; }
    public float CurrentTime { get; private set; }
    private bool isPaused;

    void Start()
    {
        MinTime = 0;
        MaxTime = 240; // Par exemple, 4 heures en minutes
        CurrentTime = MinTime;
        isPaused = false;
    }

    public void Play()
    {
        isPaused = false;
    }

    public void Pause()
    {
        isPaused = true;
    }

    void Update()
    {
        if (!isPaused)
        {
            float deltaTime = Time.deltaTime * 60; // Conversion en minutes
            CurrentTime += deltaTime;
            CurrentTime = Mathf.Clamp(CurrentTime, MinTime, MaxTime);
            OnTimeChanged?.Invoke(CurrentTime);
        }
    }
}
