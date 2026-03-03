using UnityEngine;
using System;

public class AppBootstrapper : MonoBehaviour
{
    public SolarSystemConfig config;
    public PlanetView[] planets;
    public TimeController timeController;

    TimeModel timeModel;
    PlanetSystemController controller;

    void Start()
    {
        Debug.Log("[BOOT] Initializing application");

        timeModel = new TimeModel();
        var ephemeris = new PlanetEphemerisService();

        controller = new PlanetSystemController(timeModel, ephemeris, planets);

        // v1.2: time flow
        timeController.Init(timeModel);
    }
}