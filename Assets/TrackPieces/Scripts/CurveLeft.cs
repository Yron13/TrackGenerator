using UnityEngine;

namespace Assets.TrackPieces
{
    public class CurveLeft : TrackPiece
    {
        private static Vector3 curveLeftOffset = new Vector3(-0.5f, 0.5f, 0);
        private static Quaternion curveLeftRotation = Quaternion.Euler(0, 0, 90);
        protected override Vector3 getOffset()
        {
            return curveLeftOffset;
        }

        protected override Quaternion getRotation()
        {
            return curveLeftRotation;
        }

        protected override Shape GetShape()
        {
            return Shape.LEFT;
        }
    }
}
