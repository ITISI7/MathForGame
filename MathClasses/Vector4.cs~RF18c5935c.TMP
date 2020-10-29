using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Vector4
    {
        public float x, y, z, w;

        public Vector4()
        {
            x = 0;
            y = 0;
            z = 0;
            w = 0;
        }

        public Vector4(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public static Vector4 VectorTranslate(Vector4 point, Vector4 vec)
        {
            Vector4 retVal = new Vector4();
            retVal.x = point.x + vec.x;
            retVal.y = point.y + vec.y;
            retVal.z = point.z + vec.z;
            retVal.w = point.w + vec.w;
            return retVal;
        }

        public static Vector4 PointDiffrence(Vector4 lhs, Vector4 rhs)
        {
            Vector4 retVal = new Vector4();
            retVal.x = lhs.x - rhs.x;
            retVal.y = lhs.y - rhs.y;
            retVal.z = lhs.z - rhs.z;
            retVal.w = lhs.w - rhs.w;
            return retVal;
        }

        public static Vector4 operator +(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        }

        public static Vector4 operator -(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - lhs.w);
        }
        public static Vector4 Scaling (Vector4 vec, float scale)
        {
            Vector4 retval = new Vector4();
            retval.x = vec.x * scale;
            retval.y = vec.y * scale;
            retval.z = vec.z * scale;
            retval.w = vec.w * scale;
            return retval;
        }
        public static Vector4 PreScaling(float scale, Vector4 vec)
        {
            Vector4 retval = new Vector4();
            retval.x = scale * vec.x;
            retval.y = scale * vec.y;
            retval.z = scale * vec.z;
            retval.w = scale * vec.w;
            return retval;

        }
        public static float Magnitude(Vector4 vec)
        {
            return (float)Math.Sqrt(vec.x * vec.x + vec.y * vec.y + vec.z * vec.z + vec.w * vec.w);



        }
        public static Vector4 Normalise(Vector4 vec)
        {
            Vector4 retVal = new Vector4();
            retVal.x = vec.x / vec.x;
            retVal.y = vec.y / vec.y;
            retVal.y = vec.z / vec.z;
            retVal.w = vec.w / vec.w;
            return retVal;

        }

        public static Vector4 Cross(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4(
            lhs.z * rhs.w - lhs.w * rhs.z,
            lhs.w * rhs.y - lhs.y * rhs.w,
            lhs.x * rhs.z - lhs.z * rhs.x,
            lhs.y * rhs.x - lhs.x * rhs.y);



        }

        public static float Dot(Vector4 lhs, Vector4 rhs)
        {
            return lhs.x * rhs.x + lhs.y * rhs.y + lhs.z * rhs.z + lhs.w * lhs.w;

        }

    }
}
