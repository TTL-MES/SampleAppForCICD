using System;

namespace SampleApplication
{
   public static class BusinessLayer
    {

        public static int Add(int a, int b)
        {
            try
            {
                return a + b;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
