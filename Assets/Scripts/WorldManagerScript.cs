using System;
using UnityEngine;

public class WorldManagerScript : MonoBehaviour
{
    public static WorldManagerScript Instance;

    public float worldState = 0f; // De -1 (distòpic) a +1 (utòpic)
    public event Action<float> OnWorldStateChanged;

    void Awake()
    {
        Instance = this;
    }

    public void ModifyWorldState(float amount)
    {
        worldState = Mathf.Clamp(worldState + amount, -1f, 1f);
        Debug.Log("WorldStatus: " + worldState);
        OnWorldStateChanged?.Invoke(worldState);
    }
}