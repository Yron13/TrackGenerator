using UnityEngine;

namespace Assets.TrackPieces
{
    public class Straight : TrackPiece
    {     
        private static Vector3 straightOffset = new Vector3(0, 1, 0);
        private static Quaternion straightRotation = Quaternion.identity;
        protected override Vector3 getOffset()
        {
            return straightOffset;
        }

        protected override Quaternion getRotation()
        {
            return straightRotation;
        }

        protected override Shape GetShape()
        {
            return Shape.STRAIGHT;
        }
    }
}
