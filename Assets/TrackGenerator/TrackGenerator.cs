using System.Collections;
using System.Collections.Generic;
using Assets.Track;
using UnityEngine;

public class TrackGenerator : MonoBehaviour
{
    public Track Track;
	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddStraight()
    {
        Track.PlaceStraight();
    }

    public void AddCurveLeft()
    {
        Track.PlaceCurveLeft();
    }

    public void AddCurveRight()
    {
        Track.PlaceCurveRight();
    }

    public void AddWideCurveLeft()
    {
        Track.PlaceWideCurveLeft();
    }

    public void AddWideCurveRight()
    {
        Track.PlaceWideCurveRight();
    }

    public void RemoveLast()
    {
        Track.RemoveLast();
    }
}
