public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        var cars =
            position
                .Select((p, index) => new { Position = p,
                                            Time = (double)(target - p) / speed[index] })
                .OrderByDescending(car => car.Position)
                .ToList();

        Stack<double> carFleet = new Stack<double>();

        foreach (var car in cars) {
            double time = car.Time;
            if(carFleet.Count == 0){
                carFleet.Push(time);
                continue;
            }
            if(carFleet.Peek() < time){
                carFleet.Push(time);
            }
        }
        return carFleet.Count;
    }
}
