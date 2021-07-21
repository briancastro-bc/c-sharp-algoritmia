using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym
{
    class Calculate
    {

        private double[] set;
        private double sum;
        private double mean;
        private double variance;
        private double deviation;

        public Calculate()
        {
            this.set = Array.Empty<double>();
            this.sum = 0;
            this.mean = 0;
            this.variance = 0;
        }

        public void SetMean(double[] set)
        {
            try
            {
                this.set = set;
                for (int i = 0; i < this.set.Length; i++) this.sum += this.set[i];
                this.mean = sum / this.set.Length;
            } catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }
        }

        public string GetMean()
        {
            foreach(double i in this.set)
            {
                Console.WriteLine(i);
            }
            return $"Media: {mean}";
        }

        public void SetVariance(double[] set)
        {
            try
            {
                this.set = set;
                for(int i = 0; i < this.set.Length; i++)
                {
                    double operation = this.set[i] - mean;
                    double result = Math.Pow(operation, 2);
                    this.sum += result;
                }
                this.variance = this.sum / (this.set.Length - 1);
            } catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }
        }

        public string GetVariance()
        {
            return $"Varianza: {this.variance}";
        }

        public string GetDeviation()
        {
            this.deviation = Math.Sqrt(variance);
            return $"Desviación estándar = {deviation}";
        }

    }
}
