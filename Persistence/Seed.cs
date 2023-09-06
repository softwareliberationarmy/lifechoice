using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (!context.WeighIns.Any())
            {
                var weighIns = new[]
                {
                    new WeighIn
                    {
                        Date = DateOnly.Parse("05/01/2023"), Weight = 223.6M, Bmi = 33M, BodyFatPercent = 30.9M,
                        MusclePercent = 32.3M, RestingMetabolismCalories = 2019, BodyAge = 69, VisceralFat = 16
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("05/02/2023"), Weight = 224M, Bmi = 33.1M, BodyFatPercent = 31.4M,
                        MusclePercent = 32.1M, RestingMetabolismCalories = 2021, BodyAge = 69, VisceralFat = 16
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("05/03/2023"), Weight = 222.8M, Bmi = 32.9M, BodyFatPercent = 31.2M,
                        MusclePercent = 32.2M, RestingMetabolismCalories = 2014, BodyAge = 69, VisceralFat = 16
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("05/04/2023"), Weight = 223.4M, Bmi = 33M, BodyFatPercent = 32.4M,
                        MusclePercent = 31.5M, RestingMetabolismCalories = 2015, BodyAge = 69, VisceralFat = 16
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("05/05/2023"), Weight = 220.8M, Bmi = 32.6M, BodyFatPercent = 31.3M,
                        MusclePercent = 32.1M, RestingMetabolismCalories = 2002, BodyAge = 68, VisceralFat = 16
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("05/06/2023"), Weight = 224.4M, Bmi = 33.1M, BodyFatPercent = 31.8M,
                        MusclePercent = 31.8M, RestingMetabolismCalories = 2023, BodyAge = 69, VisceralFat = 17
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("05/08/2023"), Weight = 227.8M, Bmi = 33.6M, BodyFatPercent = 30.4M,
                        MusclePercent = 32.6M, RestingMetabolismCalories = 2044, BodyAge = 70, VisceralFat = 17
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("05/09/2023"), Weight = 226.6M, Bmi = 33.5M, BodyFatPercent = 31.2M,
                        MusclePercent = 32.2M, RestingMetabolismCalories = 2036, BodyAge = 70, VisceralFat = 17
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("05/10/2023"), Weight = 228.8M, Bmi = 33.8M, BodyFatPercent = 31.8M,
                        MusclePercent = 31.8M, RestingMetabolismCalories = 2049, BodyAge = 70, VisceralFat = 17
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("05/11/2023"), Weight = 228M, Bmi = 33.6M, BodyFatPercent = 31.5M,
                        MusclePercent = 32M, RestingMetabolismCalories = 2044, BodyAge = 70, VisceralFat = 17
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("05/12/2023"), Weight = 224.8M, Bmi = 33.2M, BodyFatPercent = 32M,
                        MusclePercent = 31.7M, RestingMetabolismCalories = 2025, BodyAge = 69, VisceralFat = 17
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("05/13/2023"), Weight = 225.8M, Bmi = 33.3M, BodyFatPercent = 30.2M,
                        MusclePercent = 32.7M, RestingMetabolismCalories = 2032, BodyAge = 69, VisceralFat = 17
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("05/15/2023"), Weight = 226.8M, Bmi = 33.5M, BodyFatPercent = 31.4M,
                        MusclePercent = 32M, RestingMetabolismCalories = 2037, BodyAge = 70, VisceralFat = 17
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("05/16/2023"), Weight = 224.4M, Bmi = 33.1M, BodyFatPercent = 30M,
                        MusclePercent = 32.8M, RestingMetabolismCalories = 2025, BodyAge = 69, VisceralFat = 16
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("05/17/2023"), Weight = 222.4M, Bmi = 32.8M, BodyFatPercent = 31M,
                        MusclePercent = 32.3M, RestingMetabolismCalories = 2012, BodyAge = 68, VisceralFat = 16
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("05/18/2023"), Weight = 222M, Bmi = 32.8M, BodyFatPercent = 29.9M,
                        MusclePercent = 32.8M, RestingMetabolismCalories = 2010, BodyAge = 68, VisceralFat = 16
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("05/19/2023"), Weight = 222.6M, Bmi = 32.9M, BodyFatPercent = 31M,
                        MusclePercent = 32.3M, RestingMetabolismCalories = 2013, BodyAge = 68, VisceralFat = 16
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("05/22/2023"), Weight = 223.4M, Bmi = 33M, BodyFatPercent = 29.4M,
                        MusclePercent = 33.1M, RestingMetabolismCalories = 2018, BodyAge = 68, VisceralFat = 16
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("05/23/2023"), Weight = 222.2M, Bmi = 32.8M, BodyFatPercent = 29.7M,
                        MusclePercent = 33M, RestingMetabolismCalories = 2011, BodyAge = 68, VisceralFat = 16
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("05/24/2023"), Weight = 223M, Bmi = 32.9M, BodyFatPercent = 30.3M,
                        MusclePercent = 32.6M, RestingMetabolismCalories = 2016, BodyAge = 68, VisceralFat = 16
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("05/25/2023"), Weight = 224M, Bmi = 33.1M, BodyFatPercent = 29.9M,
                        MusclePercent = 32.9M, RestingMetabolismCalories = 2022, BodyAge = 69, VisceralFat = 16
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("05/26/2023"), Weight = 221.8M, Bmi = 32.7M, BodyFatPercent = 30.8M,
                        MusclePercent = 32.4M, RestingMetabolismCalories = 2007, BodyAge = 68, VisceralFat = 16
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("05/27/2023"), Weight = 225.4M, Bmi = 33.3M, BodyFatPercent = 31.4M,
                        MusclePercent = 32.1M, RestingMetabolismCalories = 2029, BodyAge = 69, VisceralFat = 17
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("05/30/2023"), Weight = 223.8M, Bmi = 33M, BodyFatPercent = 28.1M,
                        MusclePercent = 33.8M, RestingMetabolismCalories = 2021, BodyAge = 69, VisceralFat = 16
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("05/31/2023"), Weight = 221.6M, Bmi = 32.7M, BodyFatPercent = 28M,
                        MusclePercent = 33.9M, RestingMetabolismCalories = 2009, BodyAge = 68, VisceralFat = 16
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("06/01/2023"), Weight = 221.2M, Bmi = 32.6M, BodyFatPercent = 28.6M,
                        MusclePercent = 33.6M, RestingMetabolismCalories = 2006, BodyAge = 68, VisceralFat = 16
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("06/02/2023"), Weight = 220.4M, Bmi = 32.5M, BodyFatPercent = 29.2M,
                        MusclePercent = 33.2M, RestingMetabolismCalories = 2002, BodyAge = 67, VisceralFat = 16
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("06/03/2023"), Weight = 218M, Bmi = 32.2M, BodyFatPercent = 29.4M,
                        MusclePercent = 33.1M, RestingMetabolismCalories = 1987, BodyAge = 67, VisceralFat = 16
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("06/05/2023"), Weight = 219M, Bmi = 32.3M, BodyFatPercent = 28.7M,
                        MusclePercent = 33.5M, RestingMetabolismCalories = 1993, BodyAge = 67, VisceralFat = 16
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("06/06/2023"), Weight = 217.8M, Bmi = 32.2M, BodyFatPercent = 29M,
                        MusclePercent = 33.4M, RestingMetabolismCalories = 1986, BodyAge = 67, VisceralFat = 15
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("06/07/2023"), Weight = 216.6M, Bmi = 32M, BodyFatPercent = 29M,
                        MusclePercent = 33.4M, RestingMetabolismCalories = 1978, BodyAge = 66, VisceralFat = 15
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("06/08/2023"), Weight = 218.4M, Bmi = 32.2M, BodyFatPercent = 29.4M,
                        MusclePercent = 33.2M, RestingMetabolismCalories = 1990, BodyAge = 67, VisceralFat = 16
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("06/09/2023"), Weight = 217.4M, Bmi = 32.1M, BodyFatPercent = 29.2M,
                        MusclePercent = 33.3M, RestingMetabolismCalories = 1984, BodyAge = 66, VisceralFat = 15
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("06/10/2023"), Weight = 218.8M, Bmi = 32.3M, BodyFatPercent = 28.7M,
                        MusclePercent = 33.5M, RestingMetabolismCalories = 1992, BodyAge = 67, VisceralFat = 16
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("06/12/2023"), Weight = 215.2M, Bmi = 31.8M, BodyFatPercent = 29.1M,
                        MusclePercent = 33.3M, RestingMetabolismCalories = 1971, BodyAge = 66, VisceralFat = 15
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("06/13/2023"), Weight = 215.6M, Bmi = 31.8M, BodyFatPercent = 30M,
                        MusclePercent = 32.8M, RestingMetabolismCalories = 1972, BodyAge = 66, VisceralFat = 15
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("06/15/2023"), Weight = 216.8M, Bmi = 32M, BodyFatPercent = 29.7M,
                        MusclePercent = 33M, RestingMetabolismCalories = 1979, BodyAge = 66, VisceralFat = 15
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("06/19/2023"), Weight = 217.6M, Bmi = 32.1M, BodyFatPercent = 28.3M,
                        MusclePercent = 33.8M, RestingMetabolismCalories = 1986, BodyAge = 66, VisceralFat = 15
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("06/20/2023"), Weight = 216.2M, Bmi = 31.9M, BodyFatPercent = 28.2M,
                        MusclePercent = 33.8M, RestingMetabolismCalories = 1978, BodyAge = 66, VisceralFat = 15
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("06/21/2023"), Weight = 215.8M, Bmi = 31.9M, BodyFatPercent = 29M,
                        MusclePercent = 33.4M, RestingMetabolismCalories = 1975, BodyAge = 66, VisceralFat = 15
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("06/22/2023"), Weight = 216M, Bmi = 31.9M, BodyFatPercent = 27.7M,
                        MusclePercent = 34.1M, RestingMetabolismCalories = 1977, BodyAge = 66, VisceralFat = 15
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("06/23/2023"), Weight = 212M, Bmi = 31.3M, BodyFatPercent = 26.7M,
                        MusclePercent = 34.6M, RestingMetabolismCalories = 1954, BodyAge = 64, VisceralFat = 15
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("06/24/2023"), Weight = 214.8M, Bmi = 31.7M, BodyFatPercent = 26.7M,
                        MusclePercent = 34.6M, RestingMetabolismCalories = 1969, BodyAge = 65, VisceralFat = 15
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("06/26/2023"), Weight = 215.8M, Bmi = 31.9M, BodyFatPercent = 29.2M,
                        MusclePercent = 33.3M, RestingMetabolismCalories = 1974, BodyAge = 66, VisceralFat = 15
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("06/27/2023"), Weight = 214.8M, Bmi = 31.7M, BodyFatPercent = 29.2M,
                        MusclePercent = 33.3M, RestingMetabolismCalories = 1967, BodyAge = 65, VisceralFat = 15
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("06/28/2023"), Weight = 214.8M, Bmi = 31.7M, BodyFatPercent = 29.3M,
                        MusclePercent = 33.2M, RestingMetabolismCalories = 1967, BodyAge = 65, VisceralFat = 15
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("06/29/2023"), Weight = 213M, Bmi = 31.4M, BodyFatPercent = 28.6M,
                        MusclePercent = 33.6M, RestingMetabolismCalories = 1958, BodyAge = 65, VisceralFat = 15
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("06/30/2023"), Weight = 214.4M, Bmi = 31.7M, BodyFatPercent = 28.5M,
                        MusclePercent = 33.6M, RestingMetabolismCalories = 1968, BodyAge = 65, VisceralFat = 15
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("07/01/2023"), Weight = 216.6M, Bmi = 32M, BodyFatPercent = 27.8M,
                        MusclePercent = 34M, RestingMetabolismCalories = 1980, BodyAge = 66, VisceralFat = 15
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("07/03/2023"), Weight = 214.4M, Bmi = 31.7M, BodyFatPercent = 26.8M,
                        MusclePercent = 34.6M, RestingMetabolismCalories = 1969, BodyAge = 65, VisceralFat = 15
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("07/04/2023"), Weight = 211.8M, Bmi = 31.3M, BodyFatPercent = 25.8M,
                        MusclePercent = 35.1M, RestingMetabolismCalories = 1954, BodyAge = 64, VisceralFat = 14
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("07/05/2023"), Weight = 214M, Bmi = 31.6M, BodyFatPercent = 27.6M,
                        MusclePercent = 34.1M, RestingMetabolismCalories = 1965, BodyAge = 65, VisceralFat = 15
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("07/06/2023"), Weight = 212.8M, Bmi = 31.4M, BodyFatPercent = 26.3M,
                        MusclePercent = 34.8M, RestingMetabolismCalories = 1959, BodyAge = 64, VisceralFat = 14
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("07/07/2023"), Weight = 213.8M, Bmi = 31.6M, BodyFatPercent = 26.6M,
                        MusclePercent = 34.7M, RestingMetabolismCalories = 1965, BodyAge = 65, VisceralFat = 15
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("07/08/2023"), Weight = 213.4M, Bmi = 31.5M, BodyFatPercent = 27.2M,
                        MusclePercent = 34.4M, RestingMetabolismCalories = 1962, BodyAge = 65, VisceralFat = 15
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("07/10/2023"), Weight = 212.6M, Bmi = 31.4M, BodyFatPercent = 27.4M,
                        MusclePercent = 34.3M, RestingMetabolismCalories = 1957, BodyAge = 64, VisceralFat = 15
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("07/11/2023"), Weight = 214M, Bmi = 31.6M, BodyFatPercent = 29M,
                        MusclePercent = 33.4M, RestingMetabolismCalories = 1964, BodyAge = 65, VisceralFat = 15
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("07/12/2023"), Weight = 213M, Bmi = 31.4M, BodyFatPercent = 28.2M,
                        MusclePercent = 33.8M, RestingMetabolismCalories = 1958, BodyAge = 65, VisceralFat = 15
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("07/13/2023"), Weight = 213M, Bmi = 31.4M, BodyFatPercent = 28.2M,
                        MusclePercent = 33.8M, RestingMetabolismCalories = 1958, BodyAge = 65, VisceralFat = 15
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("07/14/2023"), Weight = 215.2M, Bmi = 31.8M, BodyFatPercent = 27.9M,
                        MusclePercent = 34M, RestingMetabolismCalories = 1972, BodyAge = 65, VisceralFat = 15
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("07/17/2023"), Weight = 213.2M, Bmi = 31.5M, BodyFatPercent = 27.7M,
                        MusclePercent = 34.1M, RestingMetabolismCalories = 1960, BodyAge = 65, VisceralFat = 15
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("07/18/2023"), Weight = 212.4M, Bmi = 31.3M, BodyFatPercent = 28M,
                        MusclePercent = 33.9M, RestingMetabolismCalories = 1954, BodyAge = 64, VisceralFat = 15
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("07/19/2023"), Weight = 211.6M, Bmi = 31.2M, BodyFatPercent = 28M,
                        MusclePercent = 33.9M, RestingMetabolismCalories = 1951, BodyAge = 64, VisceralFat = 15
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("07/20/2023"), Weight = 212.6M, Bmi = 31.4M, BodyFatPercent = 26.8M,
                        MusclePercent = 34.6M, RestingMetabolismCalories = 1957, BodyAge = 64, VisceralFat = 15
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("07/21/2023"), Weight = 211M, Bmi = 31.1M, BodyFatPercent = 26.4M,
                        MusclePercent = 34.8M, RestingMetabolismCalories = 1948, BodyAge = 64, VisceralFat = 14
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("07/25/2023"), Weight = 213M, Bmi = 31.4M, BodyFatPercent = 27.7M,
                        MusclePercent = 34.1M, RestingMetabolismCalories = 1958, BodyAge = 65, VisceralFat = 15
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("07/26/2023"), Weight = 210.6M, Bmi = 31.1M, BodyFatPercent = 27.5M,
                        MusclePercent = 34.2M, RestingMetabolismCalories = 1944, BodyAge = 64, VisceralFat = 14
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("07/27/2023"), Weight = 209.8M, Bmi = 31M, BodyFatPercent = 27.7M,
                        MusclePercent = 34.1M, RestingMetabolismCalories = 1940, BodyAge = 63, VisceralFat = 14
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("07/28/2023"), Weight = 210.8M, Bmi = 31.1M, BodyFatPercent = 27.4M,
                        MusclePercent = 34.3M, RestingMetabolismCalories = 1946, BodyAge = 64, VisceralFat = 14
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("07/30/2023"), Weight = 210.2M, Bmi = 31M, BodyFatPercent = 26.7M,
                        MusclePercent = 34.7M, RestingMetabolismCalories = 1943, BodyAge = 63, VisceralFat = 14
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("07/31/2023"), Weight = 211.4M, Bmi = 31.2M, BodyFatPercent = 27.4M,
                        MusclePercent = 34.3M, RestingMetabolismCalories = 1950, BodyAge = 64, VisceralFat = 14
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("08/01/2023"), Weight = 209M, Bmi = 30.8M, BodyFatPercent = 27.5M,
                        MusclePercent = 34.2M, RestingMetabolismCalories = 1935, BodyAge = 63, VisceralFat = 14
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("08/02/2023"), Weight = 211.8M, Bmi = 31.3M, BodyFatPercent = 27.5M,
                        MusclePercent = 34.2M, RestingMetabolismCalories = 1953, BodyAge = 64, VisceralFat = 14
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("08/03/2023"), Weight = 207.4M, Bmi = 30.6M, BodyFatPercent = 27.7M,
                        MusclePercent = 34.1M, RestingMetabolismCalories = 1926, BodyAge = 63, VisceralFat = 14
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("08/04/2023"), Weight = 207.6M, Bmi = 30.7M, BodyFatPercent = 28.3M,
                        MusclePercent = 33.8M, RestingMetabolismCalories = 1926, BodyAge = 63, VisceralFat = 14
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("08/05/2023"), Weight = 209.2M, Bmi = 30.9M, BodyFatPercent = 26.9M,
                        MusclePercent = 34.5M, RestingMetabolismCalories = 1937, BodyAge = 63, VisceralFat = 14
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("08/07/2023"), Weight = 210.6M, Bmi = 31.1M, BodyFatPercent = 26.4M,
                        MusclePercent = 34.8M, RestingMetabolismCalories = 1945, BodyAge = 64, VisceralFat = 14
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("08/08/2023"), Weight = 209.8M, Bmi = 31M, BodyFatPercent = 28.6M,
                        MusclePercent = 33.6M, RestingMetabolismCalories = 1939, BodyAge = 64, VisceralFat = 14
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("08/09/2023"), Weight = 207.8M, Bmi = 30.7M, BodyFatPercent = 26.1M,
                        MusclePercent = 35M, RestingMetabolismCalories = 1929, BodyAge = 63, VisceralFat = 14
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("08/10/2023"), Weight = 206.6M, Bmi = 30.5M, BodyFatPercent = 26.2M,
                        MusclePercent = 34.9M, RestingMetabolismCalories = 1922, BodyAge = 62, VisceralFat = 14
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("08/11/2023"), Weight = 209M, Bmi = 30.8M, BodyFatPercent = 26.6M,
                        MusclePercent = 34.7M, RestingMetabolismCalories = 1936, BodyAge = 63, VisceralFat = 14
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("08/12/2023"), Weight = 206M, Bmi = 30.4M, BodyFatPercent = 26.7M,
                        MusclePercent = 34.7M, RestingMetabolismCalories = 1917, BodyAge = 62, VisceralFat = 14
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("08/14/2023"), Weight = 208.4M, Bmi = 30.8M, BodyFatPercent = 25.8M,
                        MusclePercent = 35.1M, RestingMetabolismCalories = 1932, BodyAge = 63, VisceralFat = 14
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("08/15/2023"), Weight = 212M, Bmi = 31.3M, BodyFatPercent = 26.8M,
                        MusclePercent = 34.6M, RestingMetabolismCalories = 1954, BodyAge = 64, VisceralFat = 15
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("08/16/2023"), Weight = 209M, Bmi = 30.8M, BodyFatPercent = 26.5M,
                        MusclePercent = 34.8M, RestingMetabolismCalories = 1936, BodyAge = 63, VisceralFat = 14
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("08/17/2023"), Weight = 208.8M, Bmi = 30.8M, BodyFatPercent = 25.6M,
                        MusclePercent = 35.3M, RestingMetabolismCalories = 1936, BodyAge = 63, VisceralFat = 14
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("08/18/2023"), Weight = 208M, Bmi = 30.7M, BodyFatPercent = 25.5M,
                        MusclePercent = 35.3M, RestingMetabolismCalories = 1930, BodyAge = 62, VisceralFat = 14
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("08/21/2023"), Weight = 209.4M, Bmi = 30.9M, BodyFatPercent = 25.5M,
                        MusclePercent = 35.3M, RestingMetabolismCalories = 1940, BodyAge = 63, VisceralFat = 14
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("08/22/2023"), Weight = 207.6M, Bmi = 30.7M, BodyFatPercent = 26.5M,
                        MusclePercent = 34.8M, RestingMetabolismCalories = 1928, BodyAge = 62, VisceralFat = 14
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("08/23/2023"), Weight = 207.4M, Bmi = 30.6M, BodyFatPercent = 27.2M,
                        MusclePercent = 34.4M, RestingMetabolismCalories = 1926, BodyAge = 63, VisceralFat = 14
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("08/24/2023"), Weight = 203.8M, Bmi = 30.1M, BodyFatPercent = 26.2M,
                        MusclePercent = 34.9M, RestingMetabolismCalories = 1904, BodyAge = 61, VisceralFat = 13
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("08/25/2023"), Weight = 206.6M, Bmi = 30.5M, BodyFatPercent = 26.3M,
                        MusclePercent = 34.9M, RestingMetabolismCalories = 1922, BodyAge = 62, VisceralFat = 14
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("08/26/2023"), Weight = 204.2M, Bmi = 30.1M, BodyFatPercent = 24.9M,
                        MusclePercent = 35.7M, RestingMetabolismCalories = 1909, BodyAge = 61, VisceralFat = 13
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("08/28/2023"), Weight = 209.4M, Bmi = 30.9M, BodyFatPercent = 24.6M,
                        MusclePercent = 35.8M, RestingMetabolismCalories = 1940, BodyAge = 63, VisceralFat = 14
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("08/29/2023"), Weight = 206.2M, Bmi = 30.4M, BodyFatPercent = 25.7M,
                        MusclePercent = 35.2M, RestingMetabolismCalories = 1920, BodyAge = 62, VisceralFat = 14
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("08/30/2023"), Weight = 204M, Bmi = 30.1M, BodyFatPercent = 26.2M,
                        MusclePercent = 34.9M, RestingMetabolismCalories = 1906, BodyAge = 61, VisceralFat = 13
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("08/31/2023"), Weight = 207.6M, Bmi = 30.7M, BodyFatPercent = 25.6M,
                        MusclePercent = 35.3M, RestingMetabolismCalories = 1929, BodyAge = 62, VisceralFat = 14
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("09/01/2023"), Weight = 210.6M, Bmi = 31.1M, BodyFatPercent = 26.7M,
                        MusclePercent = 34.6M, RestingMetabolismCalories = 1945, BodyAge = 64, VisceralFat = 14
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("09/02/2023"), Weight = 207.2M, Bmi = 30.6M, BodyFatPercent = 25.1M,
                        MusclePercent = 35.5M, RestingMetabolismCalories = 1926, BodyAge = 62, VisceralFat = 14
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("09/04/2023"), Weight = 209.6M, Bmi = 30.9M, BodyFatPercent = 25.4M,
                        MusclePercent = 35.3M, RestingMetabolismCalories = 1941, BodyAge = 63, VisceralFat = 14
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("09/05/2023"), Weight = 205.4M, Bmi = 30.3M, BodyFatPercent = 24.6M,
                        MusclePercent = 35.8M, RestingMetabolismCalories = 1917, BodyAge = 61, VisceralFat = 13
                    },
                    new WeighIn
                    {
                        Date = DateOnly.Parse("09/06/2023"), Weight = 205.4M, Bmi = 30.3M, BodyFatPercent = 24.2M,
                        MusclePercent = 36M, RestingMetabolismCalories = 1917, BodyAge = 61, VisceralFat = 13
                    }
                };
                await context.WeighIns.AddRangeAsync(weighIns);
                await context.SaveChangesAsync();
            }
        }
    }
}
