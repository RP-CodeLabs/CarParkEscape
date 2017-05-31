using System;
using System.Collections.Generic;

namespace CarPark
{
    public class CarParkEscape
    {
        public string[] Escape(int[,] carpark)
        {
            var result = new List<string>();
            var carParkFloor = new CarParkFloor();
            var stairCaseCount = 1;
            
            for (var i = 0; i < carpark.GetLength(0); i++)
            {
                SetCarParkFloor(carParkFloor);
                GetCarParkFloorDetails(carpark, i, carParkFloor);
                if (CanExitCarPark(carParkFloor, result)) break;
                MoveCarToStairCaseOrExit(carParkFloor, result);
                if (!carParkFloor.HasStairCase) continue;
                MoveCarToStairCaseOrExitBasedOnPrevoiusStairCasePosition(carParkFloor, result);
                stairCaseCount = MoveDownCarParkLevel(result, carParkFloor, stairCaseCount);
            }
            return result.ToArray();
        }

        private void SetCarParkFloor(CarParkFloor carParkFloor)
        {
            carParkFloor.PreviousFloorStairCasePosition = carParkFloor.StairCasePosition;
            carParkFloor.HasStairCase = false;
            carParkFloor.IsCarInThisFloor = false;
            carParkFloor.CanExitCarPark = false;
        }

        private bool CanExitCarPark(CarParkFloor carParkFloor, List<string> result)
        {
            if (!carParkFloor.CanExitCarPark || carParkFloor.HasStairCase) return false;
            var exit = carParkFloor.ExitPosition - carParkFloor.StairCasePosition;
            if (exit != 0)
                result.Add((exit < 0) ? $"L{Math.Abs(exit)}" : $"R{Math.Abs(exit)}");
            return true;
        }

        private void MoveCarToStairCaseOrExitBasedOnPrevoiusStairCasePosition(CarParkFloor carParkFloor, ICollection<string> result)
        {
            var move = carParkFloor.StairCasePosition - carParkFloor.PreviousFloorStairCasePosition;
            if (move != 0 && !carParkFloor.IsCarInThisFloor)
            {
                result.Add((move < 0) ? $"L{Math.Abs(move)}" : $"R{Math.Abs(move)}");
            }
        }

        private int MoveDownCarParkLevel(IList<string> result, CarParkFloor carParkFloor, int stairCaseCount)
        {
            var val = result.Count > 0 ? result[result.Count - 1] : null;
            if (!string.IsNullOrEmpty(val) && val.Contains("D") && (carParkFloor.StairCasePosition - carParkFloor.PreviousFloorStairCasePosition) == 0)
            {
                stairCaseCount++;
                result.RemoveAt(result.Count - 1);
                result.Add($"D{stairCaseCount}");
            }
            else
            {
                result.Add("D1");
            }
            return stairCaseCount;
        }

        private void MoveCarToStairCaseOrExit(CarParkFloor carParkFloor, ICollection<string> result)
        {
            if (!carParkFloor.IsCarInThisFloor || (!carParkFloor.CanExitCarPark && !carParkFloor.HasStairCase)) return;
            var moveNumberOfSpaces = carParkFloor.StairCasePosition - carParkFloor.CarPosition;
            result.Add((moveNumberOfSpaces < 0) ? $"L{Math.Abs(moveNumberOfSpaces)}" : $"R{Math.Abs(moveNumberOfSpaces)}");
        }

        private void GetCarParkFloorDetails(int[,] carpark, int i, CarParkFloor carParkFloor)
        {
            for (var j = 0; j < carpark.GetLength(1); j++)
            {
                if (CarPark.StairCase == (CarPark)Enum.Parse(typeof(CarPark), carpark[i, j].ToString()))
                {
                    carParkFloor.HasStairCase = true;
                    carParkFloor.StairCasePosition = j;
                }
                if (CarPark.Position == (CarPark)Enum.Parse(typeof(CarPark), carpark[i, j].ToString()))
                {
                    carParkFloor.CarPosition = j;
                    carParkFloor.IsCarInThisFloor = true;
                }
                if (j != carpark.GetLength(1) - 1 || CarPark.FreeSpace != (CarPark)Enum.Parse(typeof(CarPark), carpark[i, j].ToString())) continue;
                carParkFloor.CanExitCarPark = true;
                carParkFloor.ExitPosition = j;
            }
        }
    }
}
