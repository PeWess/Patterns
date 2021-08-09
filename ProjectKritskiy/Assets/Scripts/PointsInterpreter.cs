namespace ProjectKritskiy
{
    internal sealed class PointsInterpreter
    {
        public string CalculatePoints(long points)
        {
            if (points < 1) return string.Empty;
            if (points / 1000000 > 0) return $"{points / 1000000} + M";
            if (points / 1000 > 0) return $"{points / 1000} + K";
            return $"{points}";
        }
    }
}