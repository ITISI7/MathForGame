using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Matrix4
    {
        public float m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14, m15, m16;

        public Matrix4()
        {
            m1 = 1; m2 = 0; m3 = 0; m4 = 0;
            m5 = 0; m6 = 1; m7 = 0; m8 = 0;
            m9 = 0; m10= 0; m11= 1; m12= 0;
            m13= 0; m14= 0; m15= 0; m16= 1;
        }
        public Matrix4(float m1, float m2, float m3, float m4, float m5, float m6, float m7, float m8, float m9, float m10, float m11, float m12, float m13, float m14, float m15, float m16)
        {
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
            this.m4 = m4;

            this.m5 = m5;
            this.m6 = m6;
            this.m7 = m7;
            this.m8 = m8;

            this.m9 = m9;
            this.m10 = m10;
            this.m11 = m11;
            this.m12 = m12;

            this.m13 = m13;
            this.m14 = m14;
            this.m15 = m15;
            this.m16 = m16;

        }

        public void Set(float m1, float m2, float m3, float m4, float m5, float m6, float m7, float m8, float m9, float m10, float m11, float m12, float m13, float m14, float m15, float m16)
        {
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
            this.m4 = m4;

            this.m5 = m5;
            this.m6 = m6;
            this.m7 = m7;
            this.m8 = m8;

            this.m9 = m9;
            this.m10 = m10;
            this.m11 = m11;
            this.m12 = m12;

            this.m13 = m13;
            this.m14 = m14;
            this.m15 = m15;
            this.m16 = m16;

        }

        public void Set(Matrix4 other)
        {
            m1 = other.m1;
            m2 = other.m2;
            m3 = other.m3;
            m4 = other.m4;

            m5 = other.m5;
            m6 = other.m6;
            m7 = other.m7;
            m8 = other.m8;

            m9 = other.m9;
            m10 = other.m10;
            m11 = other.m11;
            m12 = other.m12;

            m13 = other.m13;
            m14 = other.m14;
            m15 = other.m15;
            m16 = other.m16;
            

        }


        public static Matrix4 operator *(Matrix4 lhs, Matrix4 rhs)
        {
            Matrix4 retVal = new Matrix4();
            retVal.m1 = lhs.m1 * rhs.m1 + lhs.m5 * rhs.m2 + lhs.m9 * rhs.m3 + lhs.m13 * rhs.m4;
            retVal.m5 = lhs.m1 * rhs.m5 + lhs.m5 * rhs.m6 + lhs.m9 * rhs.m7 + lhs.m13 * rhs.m8;
            retVal.m9 = lhs.m1 * rhs.m9 + lhs.m5 * rhs.m10 + lhs.m9 * rhs.m11 + lhs.m13 * rhs.m12;
            retVal.m13 = lhs.m1 * rhs.m13 + lhs.m5 * rhs.m14 + lhs.m9 * rhs.m15 + lhs.m13 * rhs.m16;

            retVal.m2 = lhs.m2 * rhs.m1 + lhs.m6 * rhs.m2 + lhs.m10 * rhs.m3 + lhs.m14 * rhs.m4;
            retVal.m6 = lhs.m2 * rhs.m5 + lhs.m6 * rhs.m6 + lhs.m10 * rhs.m7 + lhs.m14 * rhs.m8;
            retVal.m10 = lhs.m2 * rhs.m9 + lhs.m6 * rhs.m10 + lhs.m10 * rhs.m11 + lhs.m14 * rhs.m12;
            retVal.m14 = lhs.m2 * rhs.m13 + lhs.m6 * rhs.m14 + lhs.m10 * rhs.m15 + lhs.m14 * rhs.m16;

            retVal.m3 = lhs.m3 * rhs.m1 + lhs.m7 * rhs.m2 + lhs.m11 * rhs.m3 + lhs.m15 * rhs.m4;
            retVal.m7 = lhs.m3 * rhs.m5 + lhs.m7 * rhs.m6 + lhs.m11 * rhs.m7 + lhs.m15 * rhs.m8;
            retVal.m11 = lhs.m3 * rhs.m9 + lhs.m7 * rhs.m10 + lhs.m11 * rhs.m11 + lhs.m15 * rhs.m12;
            retVal.m15 = lhs.m3 * rhs.m13 + lhs.m7 * rhs.m14 + lhs.m11 * rhs.m15 + lhs.m15 * rhs.m16;

            retVal.m4 = lhs.m4 * rhs.m1 + lhs.m8 * rhs.m2 + lhs.m12 * rhs.m3 + lhs.m16 * rhs.m4;
            retVal.m8 = lhs.m4 * rhs.m5 + lhs.m8 * rhs.m6 + lhs.m12 * rhs.m7 + lhs.m16 * rhs.m8;
            retVal.m12 = lhs.m4 * rhs.m9 + lhs.m8 * rhs.m10 + lhs.m12 * rhs.m11 + lhs.m16 * rhs.m12;
            retVal.m16 = lhs.m4 * rhs.m13 + lhs.m8 * rhs.m14 + lhs.m12 * rhs.m15 + lhs.m16 * rhs.m16;



            return retVal;


        }

        public void SetRotateX(float xRadians)
        {
            m1 = 1;
            m2 = 0;
            m3 = 0;

            m4 = 0;
            m5 = (float)Math.Cos(xRadians);
            m6 = (float)Math.Sin(xRadians);

            m7 = 0;
            m8 = (float)Math.Sin(xRadians);
            m9 = (float)Math.Cos(xRadians);

        }

        public void setRotateY(float yRadians)
        {
            m1 = (float)Math.Cos(yRadians);
            m2 = 0;
            m3 = (float)Math.Sin(yRadians);

            m4 = 0;
            m5 = 1;
            m6 = 0;

            m7 = (float)Math.Sin(yRadians);
            m8 = 0;
            m9 = (float)Math.Cos(yRadians);

        }
        public void setRotateZ(float zRadians)
        {
            m1 = (float)Math.Cos(zRadians);
            m2 = (float)Math.Sin(zRadians);
            m3 = 0;

            m4 = (float)Math.Sin(zRadians);
            m5 = (float)Math.Cos(zRadians);
            m6 = 0;

            m7 = 0;
            m8 = 0;
            m9 = 1;

        }



        public void rotateX(float xRadians)
        {
            Matrix3 rot = new Matrix3();
            rot.SetRotateX(xRadians);

            Set(this * rot);
        }
        public void rotateY(float yRadians)
        {
            Matrix3 rot = new Matrix3();
            rot.setRotateY(yRadians);

            Set(this * rot);
        }
        public void rotateZ(float zRadians)
        {
            Matrix3 rot = new Matrix3();
            rot.setRotateZ(zRadians);

            Set(this * rot);
        }
    }

}

