namespace CarPark
{
    public class CarParkFloor
    {
        public int CarPosition { get; set; }
        public int ExitPosition { get; set; }
        public int StairCasePosition { get; set; }
        public int PreviousFloorStairCasePosition { get; set; }

        public bool HasStairCase { get; set; }
        public bool IsCarInThisFloor { get; set; }
        public bool CanExitCarPark { get; set; }
        
    }
}
