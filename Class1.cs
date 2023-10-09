namespace Carvromvroom
{
    public class Car
    {

        public int Id { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public string LicensePlate { get; set; }



        public bool ValidateModel()
        {
            return !string.IsNullOrEmpty(Model) && Model.Length >= 4;
        }


        public bool ValidatePrice()
        {
            return Price > 0;
        }


        public bool ValidateLicensePlate()
        {
            int length = LicensePlate.Length;
            return length >= 2 && length <= 7;
        }


    }
}