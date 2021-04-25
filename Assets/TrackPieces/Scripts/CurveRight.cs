using UnityEngine;

namespace Assets.TrackPieces
{
    public class CurveRight : TrackPiece
    {
        private static Vector3 curveRightOffset = new Vector3(0.5f, 0.5f, 0);
        private static Quaternion curveRightRotation = Quaternion.Euler(0, 0, -90);
        protected override Vector3 getOffset()
        {
            return curveRightOffset;
        }

        protected override Quaternion getRotation()
        {
            return curveRightRotation;
        }
        protected override Shape GetShape()
        {
            return Shape.RIGHT;
        }
    }
}
