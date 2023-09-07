namespace Domain
{ 
    public class WeighIn
    {
        public int Id { get; set; }
        public DateOnly Date { get; set; }
        public decimal Weight { get; set; }
        public decimal Bmi { get; set; }
        public decimal BodyFatPercent { get; set; }
        public decimal MusclePercent { get; set; }
        public int RestingMetabolismCalories { get; set; }
        public int BodyAge { get; set; }
        public int VisceralFat { get; set; }
    }
}
