namespace Airline
{
    public class Passenger
    {
        public bool IsValidPassenger(string name)
        {
            if (name.Trim().Equals(""))
            {
                return false;
            }

            return true;
        }
    }
}