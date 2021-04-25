using UnityEngine;

namespace Assets.TrackPieces
{
    public class WideCurveRight : TrackPiece
    {
        private const float cos150plus1 = 0.13397459621556135323627682924706f;
        private static Vector3 wideCurveRightOffset = new Vector3(cos150plus1, 0.5f, 0);
        private static Quaternion wideCurveRightRotation = Quaternion.Euler(0, 0, -30);


        protected override Vector3 getOffset()
        {
            return wideCurveRightOffset;
        }

        protected override Quaternion getRotation()
        {
            return wideCurveRightRotation;
        }

        protected override Shape GetShape()
        {
            return Shape.WIDERIGHT;
        }
    }
}
