using UnityEngine;

namespace Assets.TrackPieces
{
    public class WideCurveLeft : TrackPiece
    {
        private const float cos30minus1 = -0.13397459621556135323627682924706f;
        private static Vector3 wideCurveLeftOffset = new Vector3(cos30minus1, 0.5f, 0);
        private static Quaternion wideCurveLeftRotation = Quaternion.Euler(0, 0, 30);


        protected override Vector3 getOffset()
        {
            return wideCurveLeftOffset;
        }

        protected override Quaternion getRotation()
        {
            return wideCurveLeftRotation;
        }

        protected override Shape GetShape()
        {
            return Shape.WIDELEFT;
        }
    }
}
