using Assets.TrackPieces;
using UnityEngine;
using System.Collections.Generic;
using System;

namespace Assets.Track
{
    public class Track : MonoBehaviour {

        public Straight  Straight;
        public CurveLeft CurveLeft;
        public CurveRight CurveRight;
        public WideCurveLeft WideCurveLeft;
        public WideCurveRight WideCurveRight;

        internal void Start()
        {
            endOfTrack = this.gameObject.transform;
            endOfTrack.position = new Vector3(0, 0, 0);
            endOfTrack.rotation = Quaternion.identity;

            inventory = new Inventory(
                new Dictionary<Shape, int>
                {
                    { Shape.STRAIGHT, 5 },
                    { Shape.RIGHT, 5 },
                    { Shape.LEFT, 5 },
                    { Shape.WIDERIGHT, 5 },
                    { Shape.WIDELEFT, 5 },
                }
            );

            TrackPieces = new Stack<TrackPiece>();            
        }

        internal void PlaceStraight()
        {
            var straightClone = Instantiate(Straight);
            straightClone.Place(this.gameObject.transform);
            TrackPieces.Push(straightClone);
        }

        internal void PlaceCurveLeft()
        {
            var curveLeftClone = Instantiate(CurveLeft);
            curveLeftClone.Place(endOfTrack);
            TrackPieces.Push(curveLeftClone);
        }

        internal void PlaceCurveRight()
        {
            var curveRightClone = Instantiate(CurveRight);
            curveRightClone.Place(endOfTrack); // The Instantiate command takes a GameObject, a Vector3 for position and a Quaternion for rotation.
            TrackPieces.Push(curveRightClone);
        }

        internal void PlaceWideCurveLeft()
        {
            var wideCurveLeftClone = Instantiate(WideCurveLeft);
            wideCurveLeftClone.Place(endOfTrack); // The Instantiate command takes a GameObject, a Vector3 for position and a Quaternion for rotation.
            TrackPieces.Push(wideCurveLeftClone);
        }

        internal void PlaceWideCurveRight()
        {
            var wideCurveRightClone = Instantiate(WideCurveRight);
            wideCurveRightClone.Place(endOfTrack); // The Instantiate command takes a GameObject, a Vector3 for position and a Quaternion for rotation.
            TrackPieces.Push(wideCurveRightClone);
        }

        internal void RemoveLast()
        {
            TrackPiece last = TrackPieces.Pop();
            endOfTrack.position = last.gameObject.transform.position;
            endOfTrack.rotation = last.gameObject.transform.rotation;
            Destroy(last.gameObject);
            Destroy(last);
        }

        private Stack<TrackPiece> TrackPieces;
        private Inventory inventory;
        
        private Transform endOfTrack;
    }
}
