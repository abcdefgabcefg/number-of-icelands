using System;

namespace NumberOfIcelands
{
    public class Place : IEquatable<Place>
    {
        public int Type { get; }

        public Guid Id { get; }

        public Place(int type)
        {
            Type = type;
            Id = Guid.NewGuid();
        }

        public bool Equals(Place other)
        {
            if (other.Id == Id)
            {
                return true;
            }

            return false;
        }
    }
}
