using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

namespace SparseMatrices
{
    /// <remarks>
    /// Contains methods for dynamically creating functions, calculating polynomials, their derivatives etc.
    /// </remarks>
    class PolynomialFactory
    {
        public static Func<double, double> getPolynomialFunction(double[] coeffs) //Dynamically creates a polynomial function with coeffs coefficients. (ex.: coeffs = {5, -3, 0, 2} -> f(x) := 2*x^3 - 3*x + 5)
        {
            Type[] methodArgs = { typeof(double) };

            DynamicMethod polyFunc = new DynamicMethod("PolynomialFunction",
                                                        typeof(double),
                                                        methodArgs);
           
            ILGenerator il = polyFunc.GetILGenerator();


            il.Emit(OpCodes.Ldc_R8, 0.0); //Push 0 to stack (result will be calculated here)

            if (coeffs.Length > 0)
            {
                for (int i = 1; i < (coeffs.Length); i++) //Sum every term, except the last one (with 0 power)
                {
                    if (coeffs[i] != 0)  //Omit all terms with coefficients 0 (n + 0 = n)
                        emitPolyTerm(il, coeffs[i], i);
                }

                il.Emit(OpCodes.Ldc_R8, coeffs[0]); //Add last term (with 0 power)
                il.Emit(OpCodes.Add); 
            }
            il.Emit(OpCodes.Ret);

            Func<double, double> result;
            try
            {
                result = (Func<double, double>)polyFunc.CreateDelegate(typeof(Func<double, double>));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                throw ex;
            }
                
            
            return result;
        }

        public static Func<double, double> getPolynomialDerivative(double[] coeffs)
        {
            coeffs = getDerivativeCoeffs(coeffs);
            return getPolynomialFunction(coeffs);
        }

        public static double[] getDerivativeCoeffs(double[] coeffs)
        {
            double[] newCoeffs = new double[coeffs.Length - 1];
            for(int i = 1; i < coeffs.Length; i++)
                newCoeffs[i - 1] = coeffs[i] * i;
            return newCoeffs;
        }

        //Adds a calculation of one polynomial term (coeff * x^power) code to a method.
        //Result variable should be on the top of the stack (current result will be added to the result variable)
        private static void emitPolyTerm(ILGenerator il, double coeff, double power)                                                                            
        {
            il.Emit(OpCodes.Ldc_R8, coeff); //Push coefficient to the stack (power result will be multiplied by the coeff) (ex.: 3x^2 -> coeff := 3, power := 2)

            il.Emit(OpCodes.Ldarg_0); //Push x
            il.Emit(OpCodes.Conv_R8); //Convert to double

            for (int i = 0; i < (power - 1); i++)  //Duplicate x value (power - 1) times (one instance of x already exists, so in overall there is "power" copies of x). Used to calculate pow(x, power)
                il.Emit(OpCodes.Dup);

            for (int i = 0; i < power; i++) //Multiplies the top of the stack "power" times. (power - 1) time calculates pow(x, power), the last one multiples x^power by the coefficient (coeff)
                il.Emit(OpCodes.Mul);

            il.Emit(OpCodes.Add); //Finally add coeff*x^power to the result variable
        }
    }
}
