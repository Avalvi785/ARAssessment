using Mapbox.Examples;
using Mapbox.Unity.Location;
using Mapbox.Unity.Utilities;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerLocationChecker : MonoBehaviour
{
    // Start is called before the first frame update
    public DeviceLocationProviderAndroidNative LocationProvider;
    [SerializeField] SpawnMarker _markerSpawner;
    public Text Distance;
    Location _playerLocation;
    public GameObject PromptPanel;
    bool promptpanelActivated = false;

    // Update is called once per frames
    void Update()
    {
        var distance = GetMarkerDistanceFromPlayer();
        Distance.text = "Remaining Distance:"+distance.ToString();
        if (distance <= 5)
        {
            if (!promptpanelActivated)
            {
                promptpanelActivated = true;
                PromptPanel.SetActive(true);
            }
        }
    }

    private double GetMarkerDistanceFromPlayer()
    {
        _playerLocation = LocationProvider.CurrentLocation;
        var loc = new GeoCoordinatePortable.GeoCoordinate(_playerLocation.LatitudeLongitude.x, _playerLocation.LatitudeLongitude.y);
        var markerLocation = new GeoCoordinatePortable.GeoCoordinate(_markerSpawner.Location.x, _markerSpawner.Location.y);
        var distance = loc.GetDistanceTo(markerLocation);
        return distance;
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(1);
    }
}
