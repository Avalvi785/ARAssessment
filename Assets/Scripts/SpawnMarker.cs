using UnityEngine;
using Mapbox.Utils;
using Mapbox.Unity.Map;
using Mapbox.Unity.MeshGeneration.Factories;
using Mapbox.Unity.Utilities;
using System.Collections.Generic;

public class SpawnMarker : MonoBehaviour
{
    [SerializeField]
    AbstractMap _map;

    [SerializeField]
    [Geocode]
    string _locationStrings;

    [SerializeField]
    float _spawnScale = 100f;

    [SerializeField]
    public GameObject MarkerPrefab;
    public GameObject MarkerCopy;

    public Vector2d Location;
    void Start()
    {
        Location = Conversions.StringToLatLon(_locationStrings);
        MarkerCopy = Instantiate(MarkerPrefab);
        MarkerCopy.transform.localPosition = _map.GeoToWorldPosition(Location, true);
        MarkerCopy.transform.localScale = new Vector3(_spawnScale, _spawnScale, _spawnScale);
    }

    private void Update()
    {
        MarkerCopy.transform.localPosition = _map.GeoToWorldPosition(Location, true);
        MarkerCopy.transform.localScale = new Vector3(_spawnScale, _spawnScale, _spawnScale);

    }
}